using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using analytics_backend.Models;

namespace analytics_backend.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {

    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<ApiKey> ApiKeys { get; set; }

    public virtual DbSet<ApiKeyClaim> ApiKeyClaims { get; set; }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<ArticlesBarcode> ArticlesBarcodes { get; set; }

    public virtual DbSet<ArticlesCategoriesLang> ArticlesCategoriesLangs { get; set; }

    public virtual DbSet<ArticlesCategoriesLink> ArticlesCategoriesLinks { get; set; }

    public virtual DbSet<ArticlesCategory> ArticlesCategories { get; set; }

    public virtual DbSet<ArticlesKioskDataLang> ArticlesKioskDataLangs { get; set; }

    public virtual DbSet<ArticlesKioskDatum> ArticlesKioskData { get; set; }

    public virtual DbSet<ArticlesLang> ArticlesLangs { get; set; }

    public virtual DbSet<ArticlesLangView> ArticlesLangViews { get; set; }

    public virtual DbSet<ArticlesLink> ArticlesLinks { get; set; }

    public virtual DbSet<ArticlesLinksView> ArticlesLinksViews { get; set; }

    public virtual DbSet<ArticlesMeasUnitsConversionFactor> ArticlesMeasUnitsConversionFactors { get; set; }

    public virtual DbSet<ArticlesNutritional> ArticlesNutritionals { get; set; }

    public virtual DbSet<ArticlesNutritionalStaging> ArticlesNutritionalStagings { get; set; }

    public virtual DbSet<ArticlesNutritionalView> ArticlesNutritionalViews { get; set; }

    public virtual DbSet<ArticlesStaging> ArticlesStagings { get; set; }

    public virtual DbSet<ArticlesView> ArticlesViews { get; set; }

    public virtual DbSet<ArticlesWarehouseDataLang> ArticlesWarehouseDataLangs { get; set; }

    public virtual DbSet<ArticlesWarehouseDatum> ArticlesWarehouseData { get; set; }

    public virtual DbSet<BackofficeRole> BackofficeRoles { get; set; }

    public virtual DbSet<BackofficeRoleClaim> BackofficeRoleClaims { get; set; }

    public virtual DbSet<BackofficeUser> BackofficeUsers { get; set; }

    public virtual DbSet<BackofficeUserClaim> BackofficeUserClaims { get; set; }

    public virtual DbSet<BackofficeUserLogin> BackofficeUserLogins { get; set; }

    public virtual DbSet<BackofficeUserSession> BackofficeUserSessions { get; set; }

    public virtual DbSet<BackofficeUserToken> BackofficeUserTokens { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<CausalControl> CausalControls { get; set; }

    public virtual DbSet<CausalLink> CausalLinks { get; set; }

    public virtual DbSet<CausalOperation> CausalOperations { get; set; }

    public virtual DbSet<CausalTotal> CausalTotals { get; set; }

    public virtual DbSet<CausalWorkflow> CausalWorkflows { get; set; }

    public virtual DbSet<CompaniesFiscal> CompaniesFiscals { get; set; }

    public virtual DbSet<CompaniesFiscalDataStaging> CompaniesFiscalDataStagings { get; set; }

    public virtual DbSet<CompaniesStaging> CompaniesStagings { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<ConfigOverridesView> ConfigOverridesViews { get; set; }

    public virtual DbSet<ConfigsView> ConfigsViews { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Coupon> Coupons { get; set; }

    public virtual DbSet<CouponSegmentationRule> CouponSegmentationRules { get; set; }

    public virtual DbSet<CouponTemplate> CouponTemplates { get; set; }

    public virtual DbSet<CouponTemplatesLang> CouponTemplatesLangs { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerCard> CustomerCards { get; set; }

    public virtual DbSet<CustomerCardType> CustomerCardTypes { get; set; }

    public virtual DbSet<CustomerCardTypesStaging> CustomerCardTypesStagings { get; set; }

    public virtual DbSet<CustomerConsentsHistory> CustomerConsentsHistories { get; set; }

    public virtual DbSet<CustomerFiscal> CustomerFiscals { get; set; }

    public virtual DbSet<CustomerPoint> CustomerPoints { get; set; }

    public virtual DbSet<CustomerPointsCollection> CustomerPointsCollections { get; set; }

    public virtual DbSet<CustomerPointsCollectionsStaging> CustomerPointsCollectionsStagings { get; set; }

    public virtual DbSet<CustomerPointsStaging> CustomerPointsStagings { get; set; }

    public virtual DbSet<CustomerPointsTransaction> CustomerPointsTransactions { get; set; }

    public virtual DbSet<CustomerPointsTransactionsStaging> CustomerPointsTransactionsStagings { get; set; }

    public virtual DbSet<CustomersGroup> CustomersGroups { get; set; }

    public virtual DbSet<CustomersStaging> CustomersStagings { get; set; }

    public virtual DbSet<DailyStockValue> DailyStockValues { get; set; }

    public virtual DbSet<DateMinimumDurability> DateMinimumDurabilities { get; set; }

    public virtual DbSet<DocumentCausal> DocumentCausals { get; set; }

    public virtual DbSet<DocumentCode> DocumentCodes { get; set; }

    public virtual DbSet<DocumentControl> DocumentControls { get; set; }

    public virtual DbSet<DocumentCounter> DocumentCounters { get; set; }

    public virtual DbSet<DocumentExpense> DocumentExpenses { get; set; }

    public virtual DbSet<DocumentExpenseItem> DocumentExpenseItems { get; set; }

    public virtual DbSet<DocumentHeading> DocumentHeadings { get; set; }

    public virtual DbSet<DocumentLink> DocumentLinks { get; set; }

    public virtual DbSet<DocumentRecent> DocumentRecents { get; set; }

    public virtual DbSet<DocumentRow> DocumentRows { get; set; }

    public virtual DbSet<DocumentState> DocumentStates { get; set; }

    public virtual DbSet<DocumentTotal> DocumentTotals { get; set; }

    public virtual DbSet<DocumentTotalsAmount> DocumentTotalsAmounts { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<DocumentWorkflow> DocumentWorkflows { get; set; }

    public virtual DbSet<EntityDynamicImportStaging> EntityDynamicImportStagings { get; set; }

    public virtual DbSet<FidelityConfig> FidelityConfigs { get; set; }

    public virtual DbSet<FidelityEvent> FidelityEvents { get; set; }

    public virtual DbSet<FidelityMarketingContent> FidelityMarketingContents { get; set; }

    public virtual DbSet<FidelityMarketingContentsLang> FidelityMarketingContentsLangs { get; set; }

    public virtual DbSet<FidelitySurvey> FidelitySurveys { get; set; }

    public virtual DbSet<FidelitySurveyQuestion> FidelitySurveyQuestions { get; set; }

    public virtual DbSet<FidelitySurveyQuestionsLang> FidelitySurveyQuestionsLangs { get; set; }

    public virtual DbSet<FidelitySurveyResponse> FidelitySurveyResponses { get; set; }

    public virtual DbSet<FidelitySurveysLang> FidelitySurveysLangs { get; set; }

    public virtual DbSet<FidelityUser> FidelityUsers { get; set; }

    public virtual DbSet<FidelityUserClaim> FidelityUserClaims { get; set; }

    public virtual DbSet<FidelityUserLogin> FidelityUserLogins { get; set; }

    public virtual DbSet<FidelityUserSession> FidelityUserSessions { get; set; }

    public virtual DbSet<FidelityUserToken> FidelityUserTokens { get; set; }

    public virtual DbSet<KioskConfig> KioskConfigs { get; set; }

    public virtual DbSet<KioskConfigOverride> KioskConfigOverrides { get; set; }

    public virtual DbSet<KioskLanguage> KioskLanguages { get; set; }

    public virtual DbSet<KioskLayout> KioskLayouts { get; set; }

    public virtual DbSet<KioskLayoutSchedule> KioskLayoutSchedules { get; set; }

    public virtual DbSet<KioskLayoutScheduleDetail> KioskLayoutScheduleDetails { get; set; }

    public virtual DbSet<KioskMediaSchedule> KioskMediaSchedules { get; set; }

    public virtual DbSet<KioskMediaScheduleDetail> KioskMediaScheduleDetails { get; set; }

    public virtual DbSet<KioskPayment> KioskPayments { get; set; }

    public virtual DbSet<KioskServiceType> KioskServiceTypes { get; set; }

    public virtual DbSet<KioskUiGroup> KioskUiGroups { get; set; }

    public virtual DbSet<KioskUiGroupDetail> KioskUiGroupDetails { get; set; }

    public virtual DbSet<KioskUiGroupLang> KioskUiGroupLangs { get; set; }

    public virtual DbSet<KioskUiGroupLayoutsLink> KioskUiGroupLayoutsLinks { get; set; }

    public virtual DbSet<KioskUiTileTemplate> KioskUiTileTemplates { get; set; }

    public virtual DbSet<KiosksView> KiosksViews { get; set; }

    public virtual DbSet<LanguagesView> LanguagesViews { get; set; }

    public virtual DbSet<LayoutScheduleDetailsView> LayoutScheduleDetailsViews { get; set; }

    public virtual DbSet<LayoutSchedulesView> LayoutSchedulesViews { get; set; }

    public virtual DbSet<LayoutsView> LayoutsViews { get; set; }

    public virtual DbSet<LegalDocument> LegalDocuments { get; set; }

    public virtual DbSet<LegalDocumentsLang> LegalDocumentsLangs { get; set; }

    public virtual DbSet<MeasUnit> MeasUnits { get; set; }

    public virtual DbSet<MeasUnitsConversion> MeasUnitsConversions { get; set; }

    public virtual DbSet<MeasUnitsStaging> MeasUnitsStagings { get; set; }

    public virtual DbSet<MediaScheduleDetailsView> MediaScheduleDetailsViews { get; set; }

    public virtual DbSet<MediaSchedulesView> MediaSchedulesViews { get; set; }

    public virtual DbSet<MediaView> MediaViews { get; set; }

    public virtual DbSet<Medium> Media { get; set; }

    public virtual DbSet<OutOfStock> OutOfStocks { get; set; }

    public virtual DbSet<OutOfStockView> OutOfStockViews { get; set; }

    public virtual DbSet<PaymentsView> PaymentsViews { get; set; }

    public virtual DbSet<Po> Pos { get; set; }

    public virtual DbSet<PosKiosk> PosKiosks { get; set; }

    public virtual DbSet<PosStaging> PosStagings { get; set; }

    public virtual DbSet<PurchasePriceList> PurchasePriceLists { get; set; }

    public virtual DbSet<PurchasePriceListDetail> PurchasePriceListDetails { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipeCategory> RecipeCategories { get; set; }

    public virtual DbSet<RecipeClass> RecipeClasses { get; set; }

    public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }

    public virtual DbSet<RecipeIngredientsFlat> RecipeIngredientsFlats { get; set; }

    public virtual DbSet<RecipeProvenance> RecipeProvenances { get; set; }

    public virtual DbSet<RecipeSeason> RecipeSeasons { get; set; }

    public virtual DbSet<RecipeType> RecipeTypes { get; set; }

    public virtual DbSet<SaleArticleLink> SaleArticleLinks { get; set; }

    public virtual DbSet<SaleArticleLinksHistory> SaleArticleLinksHistories { get; set; }

    public virtual DbSet<SaleHeading> SaleHeadings { get; set; }

    public virtual DbSet<SalePriceList> SalePriceLists { get; set; }

    public virtual DbSet<SalePriceListDetail> SalePriceListDetails { get; set; }

    public virtual DbSet<SalePriceListDetailsView> SalePriceListDetailsViews { get; set; }

    public virtual DbSet<SalePriceListLink> SalePriceListLinks { get; set; }

    public virtual DbSet<SalePriceListLinksStaging> SalePriceListLinksStagings { get; set; }

    public virtual DbSet<SalePriceListLinksView> SalePriceListLinksViews { get; set; }

    public virtual DbSet<SalePriceListsStaging> SalePriceListsStagings { get; set; }

    public virtual DbSet<SalePriceListsView> SalePriceListsViews { get; set; }

    public virtual DbSet<SaleRow> SaleRows { get; set; }

    public virtual DbSet<SaleTransaction> SaleTransactions { get; set; }

    public virtual DbSet<ServiceTypesView> ServiceTypesViews { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Shop> Shops { get; set; }

    public virtual DbSet<ShopGroup> ShopGroups { get; set; }

    public virtual DbSet<ShopStaging> ShopStagings { get; set; }

    public virtual DbSet<ShopType> ShopTypes { get; set; }

    public virtual DbSet<ShopWarehouse> ShopWarehouses { get; set; }

    public virtual DbSet<ShopsFidelityDatum> ShopsFidelityData { get; set; }

    public virtual DbSet<ShopsFiscal> ShopsFiscals { get; set; }

    public virtual DbSet<ShopsView> ShopsViews { get; set; }

    public virtual DbSet<SsvDocumentsHeadingsReport> SsvDocumentsHeadingsReports { get; set; }

    public virtual DbSet<SsvSaleCategory> SsvSaleCategories { get; set; }

    public virtual DbSet<SsvSalePayment> SsvSalePayments { get; set; }

    public virtual DbSet<SsvSaleReportsRound> SsvSaleReportsRounds { get; set; }

    public virtual DbSet<StagingLog> StagingLogs { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<StockField> StockFields { get; set; }

    public virtual DbSet<StockValue> StockValues { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SuppliersGroup> SuppliersGroups { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TagsLang> TagsLangs { get; set; }

    public virtual DbSet<TagsLangView> TagsLangViews { get; set; }

    public virtual DbSet<TagsView> TagsViews { get; set; }

    public virtual DbSet<UiGroupDetailsView> UiGroupDetailsViews { get; set; }

    public virtual DbSet<UiGroupLangView> UiGroupLangViews { get; set; }

    public virtual DbSet<UiGroupLayoutsLinksView> UiGroupLayoutsLinksViews { get; set; }

    public virtual DbSet<UiGroupsView> UiGroupsViews { get; set; }

    public virtual DbSet<UiTileTemplatesView> UiTileTemplatesViews { get; set; }

    public virtual DbSet<Upload> Uploads { get; set; }

    public virtual DbSet<UpsellSet> UpsellSets { get; set; }

    public virtual DbSet<UpsellSetDetail> UpsellSetDetails { get; set; }

    public virtual DbSet<UpsellSetDetailsView> UpsellSetDetailsViews { get; set; }

    public virtual DbSet<UpsellSetLink> UpsellSetLinks { get; set; }

    public virtual DbSet<UpsellSetLinksView> UpsellSetLinksViews { get; set; }

    public virtual DbSet<UpsellSetsView> UpsellSetsViews { get; set; }

    public virtual DbSet<Vat> Vats { get; set; }

    public virtual DbSet<VatsExemptionKind> VatsExemptionKinds { get; set; }

    public virtual DbSet<VatsFiscal> VatsFiscals { get; set; }

    public virtual DbSet<VatsFiscalDataStaging> VatsFiscalDataStagings { get; set; }

    public virtual DbSet<VatsStaging> VatsStagings { get; set; }

    public virtual DbSet<WarehouseTransaction> WarehouseTransactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5431;Database=postgres;Username=postgres;Password=password");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("btree_gist");

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("addresses");

            entity.HasIndex(e => e.CountryId, "IX_addresses_country_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Pec)
                .HasMaxLength(50)
                .HasColumnName("pec");
            entity.Property(e => e.PhoneNumberA)
                .HasMaxLength(20)
                .HasColumnName("phone_number_a");
            entity.Property(e => e.PhoneNumberB)
                .HasMaxLength(20)
                .HasColumnName("phone_number_b");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .HasColumnName("postal_code");
            entity.Property(e => e.Province)
                .HasMaxLength(20)
                .HasColumnName("province");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .HasColumnName("street");
            entity.Property(e => e.Website)
                .HasMaxLength(100)
                .HasColumnName("website");

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<ApiKey>(entity =>
        {
            entity.ToTable("api_keys");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Deleter).HasColumnName("deleter");
            entity.Property(e => e.DeletionTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deletion_time");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsEnabled)
                .HasDefaultValue(true)
                .HasColumnName("is_enabled");
            entity.Property(e => e.Key)
                .HasMaxLength(64)
                .HasColumnName("key");
            entity.Property(e => e.KeyPreview)
                .HasMaxLength(50)
                .HasColumnName("key_preview");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ApiKeyClaim>(entity =>
        {
            entity.ToTable("api_key_claims");

            entity.HasIndex(e => e.ApiKeyId, "IX_api_key_claims_api_key_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApiKeyId).HasColumnName("api_key_id");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(100)
                .HasColumnName("claim_type");
            entity.Property(e => e.ClaimValue)
                .HasMaxLength(20)
                .HasColumnName("claim_value");

            entity.HasOne(d => d.ApiKey).WithMany(p => p.ApiKeyClaims).HasForeignKey(d => d.ApiKeyId);
        });

        modelBuilder.Entity<Article>(entity =>
        {
            entity.ToTable("articles");

            entity.HasIndex(e => e.Code, "IX_articles_code").IsUnique();

            entity.HasIndex(e => e.MeasUnitId, "IX_articles_meas_unit_id");

            entity.HasIndex(e => e.MediaId, "IX_articles_media_id");

            entity.HasIndex(e => e.VatId, "IX_articles_vat_id");

            entity.HasIndex(e => e.WeightMeasUnitId, "IX_articles_weight_meas_unit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleSubtype).HasColumnName("article_subtype");
            entity.Property(e => e.ArticleType).HasColumnName("article_type");
            entity.Property(e => e.BillDescription)
                .HasMaxLength(40)
                .HasColumnName("bill_description");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.LongDescription)
                .HasMaxLength(1000)
                .HasColumnName("long_description");
            entity.Property(e => e.MeasUnitId).HasColumnName("meas_unit_id");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PublicName)
                .HasMaxLength(50)
                .HasColumnName("public_name");
            entity.Property(e => e.ReferencePrice)
                .HasPrecision(15, 5)
                .HasColumnName("reference_price");
            entity.Property(e => e.ScalesPriceLookUp).HasColumnName("scales_price_look_up");
            entity.Property(e => e.Tare).HasColumnName("tare");
            entity.Property(e => e.VatId).HasColumnName("vat_id");
            entity.Property(e => e.Weight).HasColumnName("weight");
            entity.Property(e => e.WeightMeasUnitId).HasColumnName("weight_meas_unit_id");

            entity.HasOne(d => d.MeasUnit).WithMany(p => p.ArticleMeasUnits)
                .HasForeignKey(d => d.MeasUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Media).WithMany(p => p.Articles).HasForeignKey(d => d.MediaId);

            entity.HasOne(d => d.Vat).WithMany(p => p.Articles)
                .HasForeignKey(d => d.VatId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.WeightMeasUnit).WithMany(p => p.ArticleWeightMeasUnits).HasForeignKey(d => d.WeightMeasUnitId);
        });

        modelBuilder.Entity<ArticlesBarcode>(entity =>
        {
            entity.ToTable("articles_barcodes");

            entity.HasIndex(e => new { e.ArticleId, e.Barcode }, "IX_articles_barcodes_article_id_barcode").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .HasColumnName("barcode");
            entity.Property(e => e.Quantity)
                .HasPrecision(15, 5)
                .HasColumnName("quantity");

            entity.HasOne(d => d.Article).WithMany(p => p.ArticlesBarcodes).HasForeignKey(d => d.ArticleId);
        });

        modelBuilder.Entity<ArticlesCategoriesLang>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LanguageCode });

            entity.ToTable("articles_categories_lang");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.LanguageCode).HasColumnName("language_code");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.Category).WithMany(p => p.ArticlesCategoriesLangs).HasForeignKey(d => d.CategoryId);
        });

        modelBuilder.Entity<ArticlesCategoriesLink>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.AssignedCategoryRootId });

            entity.ToTable("articles_categories_links");

            entity.HasIndex(e => e.ArticleId, "IX_articles_categories_links_article_id");

            entity.HasIndex(e => e.AssignedCategoryId, "IX_articles_categories_links_assigned_category_id");

            entity.HasIndex(e => e.AssignedCategoryRootId, "IX_articles_categories_links_assigned_category_root_id");

            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.AssignedCategoryRootId).HasColumnName("assigned_category_root_id");
            entity.Property(e => e.AssignedCategoryId).HasColumnName("assigned_category_id");

            entity.HasOne(d => d.Article).WithMany(p => p.ArticlesCategoriesLinks).HasForeignKey(d => d.ArticleId);

            entity.HasOne(d => d.AssignedCategory).WithMany(p => p.ArticlesCategoriesLinkAssignedCategories)
                .HasForeignKey(d => d.AssignedCategoryId)
                .HasConstraintName("FK_articles_categories_links_articles_categories_assigned_cate~");

            entity.HasOne(d => d.AssignedCategoryRoot).WithMany(p => p.ArticlesCategoriesLinkAssignedCategoryRoots)
                .HasForeignKey(d => d.AssignedCategoryRootId)
                .HasConstraintName("FK_articles_categories_links_articles_categories_assigned_cat~1");
        });

        modelBuilder.Entity<ArticlesCategory>(entity =>
        {
            entity.ToTable("articles_categories");

            entity.HasIndex(e => new { e.CategoryType, e.IsMainCategory }, "IX_articles_categories_category_type_is_main_category")
                .IsUnique()
                .HasFilter("(is_main_category = true)");

            entity.HasIndex(e => e.Code, "IX_articles_categories_code").IsUnique();

            entity.HasIndex(e => e.ParentCategoryId, "IX_articles_categories_parent_category_id");

            entity.HasIndex(e => e.PathFromRoot, "IX_articles_categories_path_from_root");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryType).HasColumnName("category_type");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.IsMainCategory).HasColumnName("is_main_category");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.ParentCategoryId).HasColumnName("parent_category_id");
            entity.Property(e => e.PathFromRoot).HasColumnName("path_from_root");

            entity.HasOne(d => d.ParentCategory).WithMany(p => p.InverseParentCategory).HasForeignKey(d => d.ParentCategoryId);
        });

        modelBuilder.Entity<ArticlesKioskDataLang>(entity =>
        {
            entity.HasKey(e => new { e.ArticleKioskDataId, e.LanguageCode });

            entity.ToTable("articles_kiosk_data_lang");

            entity.HasIndex(e => e.TileMediaId, "IX_articles_kiosk_data_lang_tile_media_id");

            entity.Property(e => e.ArticleKioskDataId).HasColumnName("article_kiosk_data_id");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.PageDescription)
                .HasMaxLength(2000)
                .HasColumnName("page_description");
            entity.Property(e => e.TileDescription)
                .HasMaxLength(500)
                .HasColumnName("tile_description");
            entity.Property(e => e.TileMediaId).HasColumnName("tile_media_id");

            entity.HasOne(d => d.ArticleKioskData).WithMany(p => p.ArticlesKioskDataLangs)
                .HasForeignKey(d => d.ArticleKioskDataId)
                .HasConstraintName("FK_articles_kiosk_data_lang_articles_kiosk_data_article_kiosk_~");

            entity.HasOne(d => d.TileMedia).WithMany(p => p.ArticlesKioskDataLangs).HasForeignKey(d => d.TileMediaId);
        });

        modelBuilder.Entity<ArticlesKioskDatum>(entity =>
        {
            entity.HasKey(e => e.ArticleId);

            entity.ToTable("articles_kiosk_data");

            entity.HasIndex(e => e.ArticlePageTileTemplateId, "IX_articles_kiosk_data_article_page_tile_template_id");

            entity.HasIndex(e => e.GroupByTagId, "IX_articles_kiosk_data_group_by_tag_id");

            entity.HasIndex(e => e.MediaId, "IX_articles_kiosk_data_media_id").IsUnique();

            entity.HasIndex(e => e.TileMediaId, "IX_articles_kiosk_data_tile_media_id").IsUnique();

            entity.HasIndex(e => e.TileTemplateId, "IX_articles_kiosk_data_tile_template_id");

            entity.Property(e => e.ArticleId)
                .ValueGeneratedNever()
                .HasColumnName("article_id");
            entity.Property(e => e.ArticlePageTileTemplateId).HasColumnName("article_page_tile_template_id");
            entity.Property(e => e.GroupByTagId).HasColumnName("group_by_tag_id");
            entity.Property(e => e.Max).HasColumnName("max");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Min).HasColumnName("min");
            entity.Property(e => e.PageDescription)
                .HasMaxLength(2000)
                .HasColumnName("page_description");
            entity.Property(e => e.TileDescription)
                .HasMaxLength(500)
                .HasColumnName("tile_description");
            entity.Property(e => e.TileMediaId).HasColumnName("tile_media_id");
            entity.Property(e => e.TileTemplateId).HasColumnName("tile_template_id");

            entity.HasOne(d => d.Article).WithOne(p => p.ArticlesKioskDatum).HasForeignKey<ArticlesKioskDatum>(d => d.ArticleId);

            entity.HasOne(d => d.ArticlePageTileTemplate).WithMany(p => p.ArticlesKioskDatumArticlePageTileTemplates)
                .HasForeignKey(d => d.ArticlePageTileTemplateId)
                .HasConstraintName("FK_articles_kiosk_data_kiosk_ui_tile_templates_article_page_ti~");

            entity.HasOne(d => d.GroupByTag).WithMany(p => p.ArticlesKioskData).HasForeignKey(d => d.GroupByTagId);

            entity.HasOne(d => d.Media).WithOne(p => p.ArticlesKioskDatumMedia).HasForeignKey<ArticlesKioskDatum>(d => d.MediaId);

            entity.HasOne(d => d.TileMedia).WithOne(p => p.ArticlesKioskDatumTileMedia).HasForeignKey<ArticlesKioskDatum>(d => d.TileMediaId);

            entity.HasOne(d => d.TileTemplate).WithMany(p => p.ArticlesKioskDatumTileTemplates).HasForeignKey(d => d.TileTemplateId);
        });

        modelBuilder.Entity<ArticlesLang>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.LanguageCode });

            entity.ToTable("articles_lang");

            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.BillDescription)
                .HasMaxLength(40)
                .HasColumnName("bill_description");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Ingredients)
                .HasMaxLength(1000)
                .HasColumnName("ingredients");
            entity.Property(e => e.LongDescription)
                .HasMaxLength(1000)
                .HasColumnName("long_description");
            entity.Property(e => e.PublicName)
                .HasMaxLength(50)
                .HasColumnName("public_name");

            entity.HasOne(d => d.Article).WithMany(p => p.ArticlesLangs).HasForeignKey(d => d.ArticleId);
        });

        modelBuilder.Entity<ArticlesLangView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("articles_lang_view", "kiosk");

            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.BillDescription)
                .HasMaxLength(40)
                .HasColumnName("bill_description");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Ingredients)
                .HasMaxLength(1000)
                .HasColumnName("ingredients");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.LongDescription)
                .HasMaxLength(1000)
                .HasColumnName("long_description");
            entity.Property(e => e.PageDescription)
                .HasMaxLength(2000)
                .HasColumnName("page_description");
            entity.Property(e => e.PublicName)
                .HasMaxLength(50)
                .HasColumnName("public_name");
            entity.Property(e => e.TileDescription)
                .HasMaxLength(500)
                .HasColumnName("tile_description");
            entity.Property(e => e.TileMediaId).HasColumnName("tile_media_id");
        });

        modelBuilder.Entity<ArticlesLink>(entity =>
        {
            entity.HasKey(e => new { e.ParentId, e.ChildId });

            entity.ToTable("articles_links");

            entity.HasIndex(e => e.ChildId, "IX_articles_links_child_id");

            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.ChildId).HasColumnName("child_id");
            entity.Property(e => e.MaxQuantity).HasColumnName("max_quantity");
            entity.Property(e => e.MinQuantity).HasColumnName("min_quantity");
            entity.Property(e => e.SortOrder)
                .HasDefaultValue(0)
                .HasColumnName("sort_order");

            entity.HasOne(d => d.Child).WithMany(p => p.ArticlesLinkChildren)
                .HasForeignKey(d => d.ChildId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Parent).WithMany(p => p.ArticlesLinkParents)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ArticlesLinksView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("articles_links_view", "kiosk");

            entity.Property(e => e.ChildId).HasColumnName("child_id");
            entity.Property(e => e.MaxQuantity).HasColumnName("max_quantity");
            entity.Property(e => e.MinQuantity).HasColumnName("min_quantity");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.SortOrder).HasColumnName("sort_order");
        });

        modelBuilder.Entity<ArticlesMeasUnitsConversionFactor>(entity =>
        {
            entity.ToTable("articles_meas_units_conversion_factors");

            entity.HasIndex(e => new { e.ArticleId, e.MeasUnitId, e.Value }, "IX_articles_meas_units_conversion_factors_article_id_meas_unit~").IsUnique();

            entity.HasIndex(e => e.MeasUnitId, "IX_articles_meas_units_conversion_factors_meas_unit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.MeasUnitId).HasColumnName("meas_unit_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .HasColumnName("notes");
            entity.Property(e => e.Value)
                .HasPrecision(15, 5)
                .HasColumnName("value");

            entity.HasOne(d => d.Article).WithMany(p => p.ArticlesMeasUnitsConversionFactors).HasForeignKey(d => d.ArticleId);

            entity.HasOne(d => d.MeasUnit).WithMany(p => p.ArticlesMeasUnitsConversionFactors)
                .HasForeignKey(d => d.MeasUnitId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_articles_meas_units_conversion_factors_meas_units_meas_unit~");
        });

        modelBuilder.Entity<ArticlesNutritional>(entity =>
        {
            entity.HasKey(e => e.ArticleId);

            entity.ToTable("articles_nutritional");

            entity.Property(e => e.ArticleId)
                .ValueGeneratedNever()
                .HasColumnName("article_id");
            entity.Property(e => e.Allergens).HasColumnName("allergens");
            entity.Property(e => e.Carbohydrates).HasColumnName("carbohydrates");
            entity.Property(e => e.Fats).HasColumnName("fats");
            entity.Property(e => e.FoodTypes).HasColumnName("food_types");
            entity.Property(e => e.Ingredients)
                .HasMaxLength(1000)
                .HasColumnName("ingredients");
            entity.Property(e => e.Kcal).HasColumnName("kcal");
            entity.Property(e => e.Proteins).HasColumnName("proteins");
            entity.Property(e => e.SaturatedFats).HasColumnName("saturated_fats");
            entity.Property(e => e.Sodium).HasColumnName("sodium");
            entity.Property(e => e.Sugars).HasColumnName("sugars");

            entity.HasOne(d => d.Article).WithOne(p => p.ArticlesNutritional).HasForeignKey<ArticlesNutritional>(d => d.ArticleId);
        });

        modelBuilder.Entity<ArticlesNutritionalStaging>(entity =>
        {
            entity.ToTable("articles_nutritional_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allergens).HasColumnName("allergens");
            entity.Property(e => e.ArticleCode).HasColumnName("article_code");
            entity.Property(e => e.Carbohydrates).HasColumnName("carbohydrates");
            entity.Property(e => e.Fats).HasColumnName("fats");
            entity.Property(e => e.FoodTypes).HasColumnName("food_types");
            entity.Property(e => e.Ingredients).HasColumnName("ingredients");
            entity.Property(e => e.Kcal).HasColumnName("kcal");
            entity.Property(e => e.Proteins).HasColumnName("proteins");
            entity.Property(e => e.SaturatedFats).HasColumnName("saturated_fats");
            entity.Property(e => e.Sodium).HasColumnName("sodium");
            entity.Property(e => e.Sugars).HasColumnName("sugars");
        });

        modelBuilder.Entity<ArticlesNutritionalView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("articles_nutritional_view", "kiosk");

            entity.Property(e => e.Allergens).HasColumnName("allergens");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.Carbohydrates).HasColumnName("carbohydrates");
            entity.Property(e => e.Fats).HasColumnName("fats");
            entity.Property(e => e.FoodTypes).HasColumnName("food_types");
            entity.Property(e => e.Ingredients)
                .HasMaxLength(1000)
                .HasColumnName("ingredients");
            entity.Property(e => e.Kcal).HasColumnName("kcal");
            entity.Property(e => e.Proteins).HasColumnName("proteins");
            entity.Property(e => e.SaturatedFats).HasColumnName("saturated_fats");
            entity.Property(e => e.Sodium).HasColumnName("sodium");
            entity.Property(e => e.Sugars).HasColumnName("sugars");
        });

        modelBuilder.Entity<ArticlesStaging>(entity =>
        {
            entity.ToTable("articles_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleSubtype).HasColumnName("article_subtype");
            entity.Property(e => e.ArticleType).HasColumnName("article_type");
            entity.Property(e => e.BillDescription).HasColumnName("bill_description");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsValid).HasColumnName("is_valid");
            entity.Property(e => e.LongDescription).HasColumnName("long_description");
            entity.Property(e => e.MeasUnitCode).HasColumnName("meas_unit_code");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PublicName).HasColumnName("public_name");
            entity.Property(e => e.ReferencePrice).HasColumnName("reference_price");
            entity.Property(e => e.ScalesPriceLookUp).HasColumnName("scales_price_look_up");
            entity.Property(e => e.Tare).HasColumnName("tare");
            entity.Property(e => e.VatCode).HasColumnName("vat_code");
            entity.Property(e => e.WarehouseLongDescription).HasColumnName("warehouse_long_description");
            entity.Property(e => e.WarehouseReferenceCost).HasColumnName("warehouse_reference_cost");
            entity.Property(e => e.Weight).HasColumnName("weight");
            entity.Property(e => e.WeightMeasUnitCode).HasColumnName("weight_meas_unit_code");
        });

        modelBuilder.Entity<ArticlesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("articles_view", "kiosk");

            entity.Property(e => e.ArticlePageTileTemplateId).HasColumnName("article_page_tile_template_id");
            entity.Property(e => e.ArticleSubtype).HasColumnName("article_subtype");
            entity.Property(e => e.BillDescription)
                .HasMaxLength(40)
                .HasColumnName("bill_description");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.GroupByTagId).HasColumnName("group_by_tag_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LongDescription)
                .HasMaxLength(1000)
                .HasColumnName("long_description");
            entity.Property(e => e.Max).HasColumnName("max");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Min).HasColumnName("min");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PageDescription)
                .HasMaxLength(2000)
                .HasColumnName("page_description");
            entity.Property(e => e.PublicName)
                .HasMaxLength(50)
                .HasColumnName("public_name");
            entity.Property(e => e.ReferencePrice)
                .HasPrecision(15, 5)
                .HasColumnName("reference_price");
            entity.Property(e => e.TileDescription)
                .HasColumnType("character varying")
                .HasColumnName("tile_description");
            entity.Property(e => e.TileMediaId).HasColumnName("tile_media_id");
            entity.Property(e => e.TileTemplateId).HasColumnName("tile_template_id");
        });

        modelBuilder.Entity<ArticlesWarehouseDataLang>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.LanguageCode });

            entity.ToTable("articles_warehouse_data_lang");

            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.LanguageCode).HasColumnName("language_code");
            entity.Property(e => e.LongDescription)
                .HasMaxLength(1000)
                .HasColumnName("long_description");
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(100)
                .HasColumnName("warehouse_name");

            entity.HasOne(d => d.Article).WithMany(p => p.ArticlesWarehouseDataLangs)
                .HasForeignKey(d => d.ArticleId)
                .HasConstraintName("FK_articles_warehouse_data_lang_articles_warehouse_data_articl~");
        });

        modelBuilder.Entity<ArticlesWarehouseDatum>(entity =>
        {
            entity.HasKey(e => e.ArticleId);

            entity.ToTable("articles_warehouse_data");

            entity.Property(e => e.ArticleId)
                .ValueGeneratedNever()
                .HasColumnName("article_id");
            entity.Property(e => e.LongDescription)
                .HasMaxLength(1000)
                .HasColumnName("long_description");
            entity.Property(e => e.ReferenceCost)
                .HasPrecision(15, 5)
                .HasColumnName("reference_cost");
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(100)
                .HasColumnName("warehouse_name");

            entity.HasOne(d => d.Article).WithOne(p => p.ArticlesWarehouseDatum).HasForeignKey<ArticlesWarehouseDatum>(d => d.ArticleId);
        });

        modelBuilder.Entity<BackofficeRole>(entity =>
        {
            entity.ToTable("backoffice_roles");

            entity.HasIndex(e => e.Code, "IX_backoffice_roles_code").IsUnique();

            entity.HasIndex(e => e.NormalizedName, "backoffice_role_name_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.ConcurrencyStamp).HasColumnName("concurrency_stamp");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasColumnName("normalized_name");
            entity.Property(e => e.VisibilityLevel)
                .HasDefaultValue(9)
                .HasColumnName("visibility_level");
        });

        modelBuilder.Entity<BackofficeRoleClaim>(entity =>
        {
            entity.ToTable("backoffice_role_claims");

            entity.HasIndex(e => e.RoleId, "IX_backoffice_role_claims_role_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClaimType).HasColumnName("claim_type");
            entity.Property(e => e.ClaimValue).HasColumnName("claim_value");
            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Role).WithMany(p => p.BackofficeRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<BackofficeUser>(entity =>
        {
            entity.ToTable("backoffice_users");

            entity.HasIndex(e => e.Code, "IX_backoffice_users_code").IsUnique();

            entity.HasIndex(e => e.NormalizedEmail, "backoffice_email_index");

            entity.HasIndex(e => e.NormalizedUserName, "backoffice_user_name_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessEndDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("access_end_date");
            entity.Property(e => e.AccessFailedCount).HasColumnName("access_failed_count");
            entity.Property(e => e.AccessStartDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("access_start_date");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.ConcurrencyStamp).HasColumnName("concurrency_stamp");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_of_birth");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .HasColumnName("email");
            entity.Property(e => e.EmailConfirmed).HasColumnName("email_confirmed");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.LockoutEnabled).HasColumnName("lockout_enabled");
            entity.Property(e => e.LockoutEnd).HasColumnName("lockout_end");
            entity.Property(e => e.NormalizedEmail)
                .HasMaxLength(256)
                .HasColumnName("normalized_email");
            entity.Property(e => e.NormalizedUserName)
                .HasMaxLength(256)
                .HasColumnName("normalized_user_name");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.PhoneNumberConfirmed).HasColumnName("phone_number_confirmed");
            entity.Property(e => e.SecurityStamp).HasColumnName("security_stamp");
            entity.Property(e => e.TwoFactorEnabled).HasColumnName("two_factor_enabled");
            entity.Property(e => e.Username)
                .HasMaxLength(256)
                .HasColumnName("username");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "BackofficeUserRole",
                    r => r.HasOne<BackofficeRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<BackofficeUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("backoffice_user_roles");
                        j.HasIndex(new[] { "RoleId" }, "IX_backoffice_user_roles_role_id");
                        j.IndexerProperty<string>("UserId").HasColumnName("user_id");
                        j.IndexerProperty<string>("RoleId").HasColumnName("role_id");
                    });

            entity.HasMany(d => d.Shops).WithMany(p => p.Accounts)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountShopLink",
                    r => r.HasOne<Shop>().WithMany().HasForeignKey("ShopId"),
                    l => l.HasOne<BackofficeUser>().WithMany().HasForeignKey("AccountId"),
                    j =>
                    {
                        j.HasKey("AccountId", "ShopId");
                        j.ToTable("account_shop_links");
                        j.HasIndex(new[] { "ShopId" }, "IX_account_shop_links_shop_id");
                        j.IndexerProperty<string>("AccountId").HasColumnName("account_id");
                        j.IndexerProperty<int>("ShopId").HasColumnName("shop_id");
                    });
        });

        modelBuilder.Entity<BackofficeUserClaim>(entity =>
        {
            entity.ToTable("backoffice_user_claims");

            entity.HasIndex(e => e.UserId, "IX_backoffice_user_claims_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClaimType).HasColumnName("claim_type");
            entity.Property(e => e.ClaimValue).HasColumnName("claim_value");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.BackofficeUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<BackofficeUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("backoffice_user_logins");

            entity.HasIndex(e => e.UserId, "IX_backoffice_user_logins_user_id");

            entity.Property(e => e.LoginProvider)
                .HasMaxLength(128)
                .HasColumnName("login_provider");
            entity.Property(e => e.ProviderKey)
                .HasMaxLength(128)
                .HasColumnName("provider_key");
            entity.Property(e => e.ProviderDisplayName).HasColumnName("provider_display_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.BackofficeUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<BackofficeUserSession>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.ToTable("backoffice_user_sessions");

            entity.HasIndex(e => e.UserId, "IX_backoffice_user_sessions_user_id");

            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("expires_at");
            entity.Property(e => e.RefreshToken).HasColumnName("refresh_token");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.BackofficeUserSessions).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<BackofficeUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("backoffice_user_tokens");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.LoginProvider)
                .HasMaxLength(128)
                .HasColumnName("login_provider");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.User).WithMany(p => p.BackofficeUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("brands");

            entity.HasIndex(e => e.Code, "IX_brands_code").IsUnique();

            entity.HasIndex(e => e.LogoId, "IX_brands_logo_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FacebookUrl)
                .HasMaxLength(2048)
                .HasColumnName("facebook_url");
            entity.Property(e => e.InstagramUrl)
                .HasMaxLength(2048)
                .HasColumnName("instagram_url");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.LinkedinUrl)
                .HasMaxLength(2048)
                .HasColumnName("linkedin_url");
            entity.Property(e => e.LogoId).HasColumnName("logo_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");
            entity.Property(e => e.WebsiteUrl)
                .HasMaxLength(2048)
                .HasColumnName("website_url");
            entity.Property(e => e.XUrl)
                .HasMaxLength(2048)
                .HasColumnName("x_url");

            entity.HasOne(d => d.Logo).WithMany(p => p.Brands).HasForeignKey(d => d.LogoId);
        });

        modelBuilder.Entity<CausalControl>(entity =>
        {
            entity.ToTable("causal_controls");

            entity.HasIndex(e => e.CausalId, "IX_causal_controls_causal_id");

            entity.HasIndex(e => e.DocumentControlId, "IX_causal_controls_document_control_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CausalId).HasColumnName("causal_id");
            entity.Property(e => e.ControlLevel).HasColumnName("control_level");
            entity.Property(e => e.DocumentControlId).HasColumnName("document_control_id");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");

            entity.HasOne(d => d.Causal).WithMany(p => p.CausalControls).HasForeignKey(d => d.CausalId);

            entity.HasOne(d => d.DocumentControl).WithMany(p => p.CausalControls)
                .HasForeignKey(d => d.DocumentControlId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CausalLink>(entity =>
        {
            entity.ToTable("causal_links");

            entity.HasIndex(e => e.CausalId, "IX_causal_links_causal_id");

            entity.HasIndex(e => e.LinkedCausalId, "IX_causal_links_linked_causal_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CausalId).HasColumnName("causal_id");
            entity.Property(e => e.ConcludeAutomatically).HasColumnName("conclude_automatically");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");
            entity.Property(e => e.LinkedCausalId).HasColumnName("linked_causal_id");
            entity.Property(e => e.SqlStatement)
                .HasMaxLength(2000)
                .HasColumnName("sql_statement");

            entity.HasOne(d => d.Causal).WithMany(p => p.CausalLinkCausals)
                .HasForeignKey(d => d.CausalId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.LinkedCausal).WithMany(p => p.CausalLinkLinkedCausals)
                .HasForeignKey(d => d.LinkedCausalId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CausalOperation>(entity =>
        {
            entity.ToTable("causal_operations");

            entity.HasIndex(e => e.CausalWorkflowId, "IX_causal_operations_causal_workflow_id");

            entity.HasIndex(e => e.StockFieldId, "IX_causal_operations_stock_field_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CausalWorkflowId).HasColumnName("causal_workflow_id");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.StockFieldId).HasColumnName("stock_field_id");
            entity.Property(e => e.Task).HasColumnName("task");

            entity.HasOne(d => d.CausalWorkflow).WithMany(p => p.CausalOperations).HasForeignKey(d => d.CausalWorkflowId);

            entity.HasOne(d => d.StockField).WithMany(p => p.CausalOperations)
                .HasForeignKey(d => d.StockFieldId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CausalTotal>(entity =>
        {
            entity.ToTable("causal_totals");

            entity.HasIndex(e => new { e.CausalId, e.TotalId }, "IX_causal_totals_causal_id_total_id");

            entity.HasIndex(e => e.TotalId, "IX_causal_totals_total_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CausalId).HasColumnName("causal_id");
            entity.Property(e => e.TotalId).HasColumnName("total_id");
            entity.Property(e => e.VisibilityLevel).HasColumnName("visibility_level");

            entity.HasOne(d => d.Causal).WithMany(p => p.CausalTotals)
                .HasForeignKey(d => d.CausalId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Total).WithMany(p => p.CausalTotals)
                .HasForeignKey(d => d.TotalId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CausalWorkflow>(entity =>
        {
            entity.ToTable("causal_workflows");

            entity.HasIndex(e => new { e.CausalId, e.ToStateId }, "IX_causal_workflows_causal_id_to_state_id");

            entity.HasIndex(e => e.FromStateId, "IX_causal_workflows_from_state_id");

            entity.HasIndex(e => e.ToStateId, "IX_causal_workflows_to_state_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CausalId).HasColumnName("causal_id");
            entity.Property(e => e.FromStateId).HasColumnName("from_state_id");
            entity.Property(e => e.ToStateId).HasColumnName("to_state_id");

            entity.HasOne(d => d.Causal).WithMany(p => p.CausalWorkflows).HasForeignKey(d => d.CausalId);

            entity.HasOne(d => d.FromState).WithMany(p => p.CausalWorkflowFromStates)
                .HasForeignKey(d => d.FromStateId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ToState).WithMany(p => p.CausalWorkflowToStates)
                .HasForeignKey(d => d.ToStateId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CompaniesFiscal>(entity =>
        {
            entity.HasKey(e => e.CompanyId);

            entity.ToTable("companies_fiscal");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("company_id");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(100)
                .HasColumnName("business_name");
            entity.Property(e => e.FiscalCode)
                .HasMaxLength(20)
                .HasColumnName("fiscal_code");
            entity.Property(e => e.Sdi)
                .HasMaxLength(10)
                .HasColumnName("sdi");
            entity.Property(e => e.VatNumber)
                .HasMaxLength(20)
                .HasColumnName("vat_number");

            entity.HasOne(d => d.Company).WithOne(p => p.CompaniesFiscal).HasForeignKey<CompaniesFiscal>(d => d.CompanyId);
        });

        modelBuilder.Entity<CompaniesFiscalDataStaging>(entity =>
        {
            entity.ToTable("companies_fiscal_data_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyCode).HasColumnName("company_code");
            entity.Property(e => e.FiscalCode).HasColumnName("fiscal_code");
            entity.Property(e => e.Sdi).HasColumnName("sdi");
            entity.Property(e => e.VatNumber).HasColumnName("vat_number");
        });

        modelBuilder.Entity<CompaniesStaging>(entity =>
        {
            entity.ToTable("companies_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressName).HasColumnName("address_name");
            entity.Property(e => e.AddressType).HasColumnName("address_type");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CompanyCode).HasColumnName("company_code");
            entity.Property(e => e.CountryCode).HasColumnName("country_code");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Pec).HasColumnName("pec");
            entity.Property(e => e.PhoneNumberA).HasColumnName("phone_number_a");
            entity.Property(e => e.PhoneNumberB).HasColumnName("phone_number_b");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.Province).HasColumnName("province");
            entity.Property(e => e.Street).HasColumnName("street");
            entity.Property(e => e.Website).HasColumnName("website");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("companies");

            entity.HasIndex(e => e.AddressId, "IX_companies_address_id").IsUnique();

            entity.HasIndex(e => e.Code, "IX_companies_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.Address).WithOne(p => p.Company).HasForeignKey<Company>(d => d.AddressId);

            entity.HasMany(d => d.Addresses).WithMany(p => p.Companies)
                .UsingEntity<Dictionary<string, object>>(
                    "CompanyDestination",
                    r => r.HasOne<Address>().WithMany().HasForeignKey("AddressId"),
                    l => l.HasOne<Company>().WithMany().HasForeignKey("CompanyId"),
                    j =>
                    {
                        j.HasKey("CompanyId", "AddressId");
                        j.ToTable("company_destinations");
                        j.HasIndex(new[] { "AddressId" }, "IX_company_destinations_address_id");
                        j.IndexerProperty<int>("CompanyId").HasColumnName("company_id");
                        j.IndexerProperty<int>("AddressId").HasColumnName("address_id");
                    });
        });

        modelBuilder.Entity<ConfigOverridesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("config_overrides_view", "kiosk");

            entity.Property(e => e.ConfigId).HasColumnName("config_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KioskId).HasColumnName("kiosk_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<ConfigsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("configs_view", "kiosk");

            entity.Property(e => e.DefaultValue).HasColumnName("default_value");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Key).HasColumnName("key");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("countries");

            entity.HasIndex(e => e.Code, "IX_countries_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alpha2)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("alpha2");
            entity.Property(e => e.Alpha3)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("alpha3");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.ToTable("coupons");

            entity.HasIndex(e => e.Code, "IX_coupons_code").IsUnique();

            entity.HasIndex(e => e.CustomerId, "IX_coupons_customer_id");

            entity.HasIndex(e => e.LastUsageShopId, "IX_coupons_last_usage_shop_id");

            entity.HasIndex(e => e.TemplateId, "IX_coupons_template_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Deleter).HasColumnName("deleter");
            entity.Property(e => e.DeletionTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deletion_time");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");
            entity.Property(e => e.FixedValue)
                .HasPrecision(15, 5)
                .HasColumnName("fixed_value");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.LastUsageDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_usage_date");
            entity.Property(e => e.LastUsageShopId).HasColumnName("last_usage_shop_id");
            entity.Property(e => e.LockedBy).HasColumnName("locked_by");
            entity.Property(e => e.LockedUntil)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("locked_until");
            entity.Property(e => e.MaxUsage).HasColumnName("max_usage");
            entity.Property(e => e.PromotionCode).HasColumnName("promotion_code");
            entity.Property(e => e.TemplateId).HasColumnName("template_id");
            entity.Property(e => e.UsageCount).HasColumnName("usage_count");
            entity.Property(e => e.ValidFrom)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("valid_from");
            entity.Property(e => e.ValidTo)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("valid_to");

            entity.HasOne(d => d.Customer).WithMany(p => p.Coupons)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.LastUsageShop).WithMany(p => p.Coupons)
                .HasForeignKey(d => d.LastUsageShopId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Template).WithMany(p => p.Coupons)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CouponSegmentationRule>(entity =>
        {
            entity.ToTable("coupon_segmentation_rules");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Query)
                .HasMaxLength(2000)
                .HasColumnName("query");
        });

        modelBuilder.Entity<CouponTemplate>(entity =>
        {
            entity.ToTable("coupon_templates");

            entity.HasIndex(e => new { e.BrandId, e.TriggerEvent, e.IsActive }, "IX_coupon_templates_brand_id_trigger_event_is_active")
                .IsUnique()
                .HasFilter("((trigger_event <> 0) AND (is_active = true))");

            entity.HasIndex(e => e.Code, "IX_coupon_templates_code").IsUnique();

            entity.HasIndex(e => e.CustomerGroupId, "IX_coupon_templates_customer_group_id");

            entity.HasIndex(e => e.MediaId, "IX_coupon_templates_media_id");

            entity.HasIndex(e => e.SegmentationRuleId, "IX_coupon_templates_segmentation_rule_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CodeGenerationType).HasColumnName("code_generation_type");
            entity.Property(e => e.CouponType).HasColumnName("coupon_type");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.FixedCode)
                .HasMaxLength(30)
                .HasColumnName("fixed_code");
            entity.Property(e => e.FixedValue)
                .HasPrecision(15, 5)
                .HasColumnName("fixed_value");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.IsPublic).HasColumnName("is_public");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.MaxTotalUsage).HasColumnName("max_total_usage");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PromotionCode)
                .HasMaxLength(50)
                .HasColumnName("promotion_code");
            entity.Property(e => e.PublicName)
                .HasMaxLength(150)
                .HasColumnName("public_name");
            entity.Property(e => e.RandomCodeLength).HasColumnName("random_code_length");
            entity.Property(e => e.RandomCodePrefix)
                .HasMaxLength(10)
                .HasColumnName("random_code_prefix");
            entity.Property(e => e.RandomCodeSuffix)
                .HasMaxLength(10)
                .HasColumnName("random_code_suffix");
            entity.Property(e => e.RecurrenceType).HasColumnName("recurrence_type");
            entity.Property(e => e.SegmentationRuleId).HasColumnName("segmentation_rule_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.System).HasColumnName("system");
            entity.Property(e => e.TermsAndConditions)
                .HasMaxLength(500)
                .HasColumnName("terms_and_conditions");
            entity.Property(e => e.TriggerEvent).HasColumnName("trigger_event");
            entity.Property(e => e.UsageTimeLimitMinutes).HasColumnName("usage_time_limit_minutes");
            entity.Property(e => e.ValidFrom)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("valid_from");
            entity.Property(e => e.ValidTo)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("valid_to");
            entity.Property(e => e.ValidityDays).HasColumnName("validity_days");
            entity.Property(e => e.ValidityPeriodType).HasColumnName("validity_period_type");
            entity.Property(e => e.Weekdays)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("weekdays");

            entity.HasOne(d => d.Brand).WithMany(p => p.CouponTemplates).HasForeignKey(d => d.BrandId);

            entity.HasOne(d => d.CustomerGroup).WithMany(p => p.CouponTemplates)
                .HasForeignKey(d => d.CustomerGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Media).WithMany(p => p.CouponTemplates)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.SegmentationRule).WithMany(p => p.CouponTemplates)
                .HasForeignKey(d => d.SegmentationRuleId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_coupon_templates_coupon_segmentation_rules_segmentation_rul~");
        });

        modelBuilder.Entity<CouponTemplatesLang>(entity =>
        {
            entity.HasKey(e => new { e.CouponTemplateId, e.LanguageCode });

            entity.ToTable("coupon_templates_lang");

            entity.HasIndex(e => e.MediaId, "IX_coupon_templates_lang_media_id");

            entity.Property(e => e.CouponTemplateId).HasColumnName("coupon_template_id");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.PublicName)
                .HasMaxLength(150)
                .HasColumnName("public_name");
            entity.Property(e => e.TermsAndConditions)
                .HasMaxLength(500)
                .HasColumnName("terms_and_conditions");

            entity.HasOne(d => d.CouponTemplate).WithMany(p => p.CouponTemplatesLangs).HasForeignKey(d => d.CouponTemplateId);

            entity.HasOne(d => d.Media).WithMany(p => p.CouponTemplatesLangs)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.ToTable("currencies");

            entity.HasIndex(e => e.Code, "IX_currencies_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("customers");

            entity.HasIndex(e => e.Code, "IX_customers_code").IsUnique();

            entity.HasIndex(e => e.FidelityUserId, "IX_customers_fidelity_user_id").IsUnique();

            entity.HasIndex(e => e.MainAddressId, "IX_customers_main_address_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.ConsentMarketing).HasColumnName("consent_marketing");
            entity.Property(e => e.ConsentProfiling).HasColumnName("consent_profiling");
            entity.Property(e => e.ConsentTermsAndPrivacy).HasColumnName("consent_terms_and_privacy");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .HasColumnName("contact_email");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.FidelityUserId).HasColumnName("fidelity_user_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.MainAddressId).HasColumnName("main_address_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Origin).HasColumnName("origin");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");

            entity.HasOne(d => d.FidelityUser).WithOne(p => p.Customer)
                .HasForeignKey<Customer>(d => d.FidelityUserId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.MainAddress).WithOne(p => p.Customer).HasForeignKey<Customer>(d => d.MainAddressId);

            entity.HasMany(d => d.CustomerGroups).WithMany(p => p.Customers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerGroupLink",
                    r => r.HasOne<CustomersGroup>().WithMany().HasForeignKey("CustomerGroupId"),
                    l => l.HasOne<Customer>().WithMany().HasForeignKey("CustomerId"),
                    j =>
                    {
                        j.HasKey("CustomerId", "CustomerGroupId");
                        j.ToTable("customer_group_links");
                        j.HasIndex(new[] { "CustomerGroupId" }, "IX_customer_group_links_customer_group_id");
                        j.IndexerProperty<int>("CustomerId").HasColumnName("customer_id");
                        j.IndexerProperty<int>("CustomerGroupId").HasColumnName("customer_group_id");
                    });
        });

        modelBuilder.Entity<CustomerCard>(entity =>
        {
            entity.ToTable("customer_cards");

            entity.HasIndex(e => e.CardNumber, "IX_customer_cards_card_number").IsUnique();

            entity.HasIndex(e => e.CardTypeId, "IX_customer_cards_card_type_id");

            entity.HasIndex(e => e.CustomerId, "IX_customer_cards_customer_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CardNumber)
                .HasMaxLength(30)
                .HasColumnName("card_number");
            entity.Property(e => e.CardTypeId).HasColumnName("card_type_id");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Deleter).HasColumnName("deleter");
            entity.Property(e => e.DeletionTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deletion_time");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");
            entity.Property(e => e.ExpirationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("expiration_date");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IssueDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("issue_date");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");

            entity.HasOne(d => d.CardType).WithMany(p => p.CustomerCards)
                .HasForeignKey(d => d.CardTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerCards)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CustomerCardType>(entity =>
        {
            entity.ToTable("customer_card_types");

            entity.HasIndex(e => e.Code, "IX_customer_card_types_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.GenerationRule)
                .HasMaxLength(50)
                .HasColumnName("generation_rule");
            entity.Property(e => e.IdentificationRule)
                .HasMaxLength(50)
                .HasColumnName("identification_rule");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<CustomerCardTypesStaging>(entity =>
        {
            entity.ToTable("customer_card_types_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.GenerationRule).HasColumnName("generation_rule");
            entity.Property(e => e.IdentificationRule).HasColumnName("identification_rule");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<CustomerConsentsHistory>(entity =>
        {
            entity.ToTable("customer_consents_history");

            entity.HasIndex(e => e.CustomerId, "IX_customer_consents_history_customer_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accepted).HasColumnName("accepted");
            entity.Property(e => e.ConsentType).HasColumnName("consent_type");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerConsentsHistories).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<CustomerFiscal>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.ToTable("customer_fiscal");

            entity.HasIndex(e => e.ReferenceCustomerId, "IX_customer_fiscal_reference_customer_id");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("customer_id");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(100)
                .HasColumnName("business_name");
            entity.Property(e => e.FiscalCode)
                .HasMaxLength(20)
                .HasColumnName("fiscal_code");
            entity.Property(e => e.IsGovernment).HasColumnName("is_government");
            entity.Property(e => e.PecAddress)
                .HasMaxLength(50)
                .HasColumnName("pec_address");
            entity.Property(e => e.ReferenceCustomerId).HasColumnName("reference_customer_id");
            entity.Property(e => e.SdiCode)
                .HasMaxLength(10)
                .HasColumnName("sdi_code");
            entity.Property(e => e.UseSplitPayment).HasColumnName("use_split_payment");
            entity.Property(e => e.VatNumber)
                .HasMaxLength(20)
                .HasColumnName("vat_number");

            entity.HasOne(d => d.Customer).WithOne(p => p.CustomerFiscalCustomer)
                .HasForeignKey<CustomerFiscal>(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ReferenceCustomer).WithMany(p => p.CustomerFiscalReferenceCustomers)
                .HasForeignKey(d => d.ReferenceCustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CustomerPoint>(entity =>
        {
            entity.ToTable("customer_points");

            entity.HasIndex(e => e.CollectionId, "IX_customer_points_collection_id");

            entity.HasIndex(e => new { e.CustomerId, e.CollectionId }, "IX_customer_points_customer_id_collection_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Deleter).HasColumnName("deleter");
            entity.Property(e => e.DeletionTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deletion_time");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_update_date");
            entity.Property(e => e.PointsAmount)
                .HasPrecision(15, 5)
                .HasColumnName("points_amount");

            entity.HasOne(d => d.Collection).WithMany(p => p.CustomerPoints).HasForeignKey(d => d.CollectionId);

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerPoints).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<CustomerPointsCollection>(entity =>
        {
            entity.ToTable("customer_points_collections");

            entity.HasIndex(e => e.BrandId, "IX_customer_points_collections_brand_id");

            entity.HasIndex(e => e.Code, "IX_customer_points_collections_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.Brand).WithMany(p => p.CustomerPointsCollections)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<CustomerPointsCollectionsStaging>(entity =>
        {
            entity.ToTable("customer_points_collections_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandCode).HasColumnName("brand_code");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsValid).HasColumnName("is_valid");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<CustomerPointsStaging>(entity =>
        {
            entity.ToTable("customer_points_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CollectionCode).HasColumnName("collection_code");
            entity.Property(e => e.CustomerCode).HasColumnName("customer_code");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_update_date");
            entity.Property(e => e.PointsAmount).HasColumnName("points_amount");
        });

        modelBuilder.Entity<CustomerPointsTransaction>(entity =>
        {
            entity.ToTable("customer_points_transactions");

            entity.HasIndex(e => e.CollectionId, "IX_customer_points_transactions_collection_id");

            entity.HasIndex(e => e.CustomerId, "IX_customer_points_transactions_customer_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CollectionId).HasColumnName("collection_id");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Deleter).HasColumnName("deleter");
            entity.Property(e => e.DeletionTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deletion_time");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.Operation).HasColumnName("operation");
            entity.Property(e => e.Points)
                .HasPrecision(15, 5)
                .HasColumnName("points");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("transaction_date");

            entity.HasOne(d => d.Collection).WithMany(p => p.CustomerPointsTransactions)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("FK_customer_points_transactions_customer_points_collections_co~");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerPointsTransactions).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<CustomerPointsTransactionsStaging>(entity =>
        {
            entity.ToTable("customer_points_transactions_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CollectionCode).HasColumnName("collection_code");
            entity.Property(e => e.CustomerCode).HasColumnName("customer_code");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Operation).HasColumnName("operation");
            entity.Property(e => e.Points).HasColumnName("points");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("transaction_date");
        });

        modelBuilder.Entity<CustomersGroup>(entity =>
        {
            entity.ToTable("customers_groups");

            entity.HasIndex(e => e.Code, "IX_customers_groups_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<CustomersStaging>(entity =>
        {
            entity.ToTable("customers_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.CardNumber).HasColumnName("card_number");
            entity.Property(e => e.CardTypeCode).HasColumnName("card_type_code");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.ConsentMarketing).HasColumnName("consent_marketing");
            entity.Property(e => e.ConsentProfiling).HasColumnName("consent_profiling");
            entity.Property(e => e.ConsentTermsAndPrivacy).HasColumnName("consent_terms_and_privacy");
            entity.Property(e => e.ContactEmail).HasColumnName("contact_email");
            entity.Property(e => e.CountryCode).HasColumnName("country_code");
            entity.Property(e => e.CustomerCode).HasColumnName("customer_code");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.ExpirationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("expiration_date");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IsValid).HasColumnName("is_valid");
            entity.Property(e => e.IssueDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("issue_date");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Origin).HasColumnName("origin");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.Province).HasColumnName("province");
            entity.Property(e => e.Street).HasColumnName("street");
        });

        modelBuilder.Entity<DailyStockValue>(entity =>
        {
            entity.ToTable("daily_stock_values");

            entity.HasIndex(e => e.StockDate, "IX_daily_stock_values_stock_date");

            entity.HasIndex(e => e.StockFieldId, "IX_daily_stock_values_stock_field_id");

            entity.HasIndex(e => new { e.StockId, e.StockFieldId, e.StockDate }, "IX_daily_stock_values_stock_id_stock_field_id_stock_date").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OperationsCount).HasColumnName("operations_count");
            entity.Property(e => e.StockDate).HasColumnName("stock_date");
            entity.Property(e => e.StockFieldId).HasColumnName("stock_field_id");
            entity.Property(e => e.StockId).HasColumnName("stock_id");
            entity.Property(e => e.Value)
                .HasPrecision(15, 5)
                .HasColumnName("value");

            entity.HasOne(d => d.StockField).WithMany(p => p.DailyStockValues)
                .HasForeignKey(d => d.StockFieldId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Stock).WithMany(p => p.DailyStockValues).HasForeignKey(d => d.StockId);
        });

        modelBuilder.Entity<DateMinimumDurability>(entity =>
        {
            entity.ToTable("date_minimum_durabilities");

            entity.HasIndex(e => e.Code, "IX_date_minimum_durabilities_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<DocumentCausal>(entity =>
        {
            entity.ToTable("document_causals");

            entity.HasIndex(e => e.Code, "IX_document_causals_code").IsUnique();

            entity.HasIndex(e => e.DocumentTypeId, "IX_document_causals_document_type_id");

            entity.HasIndex(e => e.OppositeCausalId, "IX_document_causals_opposite_causal_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllowDirectCreation).HasColumnName("allow_direct_creation");
            entity.Property(e => e.CausalType).HasColumnName("causal_type");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Columns)
                .HasColumnType("jsonb")
                .HasColumnName("columns");
            entity.Property(e => e.Context).HasColumnName("context");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.OppositeCausalId).HasColumnName("opposite_causal_id");
            entity.Property(e => e.ShowInvalidArticles).HasColumnName("show_invalid_articles");
            entity.Property(e => e.Template).HasColumnName("template");
            entity.Property(e => e.VisibilityLevel).HasColumnName("visibility_level");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.DocumentCausals)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.OppositeCausal).WithMany(p => p.InverseOppositeCausal)
                .HasForeignKey(d => d.OppositeCausalId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(d => d.ShopGroups).WithMany(p => p.DocumentCausals)
                .UsingEntity<Dictionary<string, object>>(
                    "DocumentCausalShopGroupLink",
                    r => r.HasOne<ShopGroup>().WithMany()
                        .HasForeignKey("ShopGroupId")
                        .OnDelete(DeleteBehavior.Restrict),
                    l => l.HasOne<DocumentCausal>().WithMany()
                        .HasForeignKey("DocumentCausalId")
                        .HasConstraintName("FK_document_causal_shop_group_links_document_causals_document_~"),
                    j =>
                    {
                        j.HasKey("DocumentCausalId", "ShopGroupId");
                        j.ToTable("document_causal_shop_group_links");
                        j.HasIndex(new[] { "ShopGroupId" }, "IX_document_causal_shop_group_links_shop_group_id");
                        j.IndexerProperty<int>("DocumentCausalId").HasColumnName("document_causal_id");
                        j.IndexerProperty<int>("ShopGroupId").HasColumnName("shop_group_id");
                    });
        });

        modelBuilder.Entity<DocumentCode>(entity =>
        {
            entity.ToTable("document_codes");

            entity.HasIndex(e => new { e.DocumentTypeId, e.ShopId, e.Year }, "IX_document_codes_document_type_id_shop_id_year").IsUnique();

            entity.HasIndex(e => e.ShopId, "IX_document_codes_shop_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrentCode).HasColumnName("current_code");
            entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.DocumentCodes).HasForeignKey(d => d.DocumentTypeId);

            entity.HasOne(d => d.Shop).WithMany(p => p.DocumentCodes).HasForeignKey(d => d.ShopId);
        });

        modelBuilder.Entity<DocumentControl>(entity =>
        {
            entity.ToTable("document_controls");

            entity.HasIndex(e => e.Code, "IX_document_controls_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.IsRowControl).HasColumnName("is_row_control");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Statement)
                .HasMaxLength(2000)
                .HasColumnName("statement");
        });

        modelBuilder.Entity<DocumentCounter>(entity =>
        {
            entity.ToTable("document_counters");

            entity.HasIndex(e => e.Code, "IX_document_counters_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.EnumerationType).HasColumnName("enumeration_type");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ResetRule).HasColumnName("reset_rule");
            entity.Property(e => e.YearPrefix).HasColumnName("year_prefix");
        });

        modelBuilder.Entity<DocumentExpense>(entity =>
        {
            entity.ToTable("document_expenses");

            entity.HasIndex(e => e.DocumentHeadingId, "IX_document_expenses_document_heading_id");

            entity.HasIndex(e => e.ExpenseItemId, "IX_document_expenses_expense_item_id");

            entity.HasIndex(e => e.VatId, "IX_document_expenses_vat_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocumentHeadingId).HasColumnName("document_heading_id");
            entity.Property(e => e.ExpenseItemId).HasColumnName("expense_item_id");
            entity.Property(e => e.GrossAmount)
                .HasPrecision(15, 5)
                .HasColumnName("gross_amount");
            entity.Property(e => e.NetAmount)
                .HasPrecision(15, 5)
                .HasColumnName("net_amount");
            entity.Property(e => e.VatAmount)
                .HasPrecision(15, 5)
                .HasColumnName("vat_amount");
            entity.Property(e => e.VatId).HasColumnName("vat_id");

            entity.HasOne(d => d.DocumentHeading).WithMany(p => p.DocumentExpenses).HasForeignKey(d => d.DocumentHeadingId);

            entity.HasOne(d => d.ExpenseItem).WithMany(p => p.DocumentExpenses)
                .HasForeignKey(d => d.ExpenseItemId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Vat).WithMany(p => p.DocumentExpenses)
                .HasForeignKey(d => d.VatId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DocumentExpenseItem>(entity =>
        {
            entity.ToTable("document_expense_items");

            entity.HasIndex(e => e.Code, "IX_document_expense_items_code").IsUnique();

            entity.HasIndex(e => e.VatId, "IX_document_expense_items_vat_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.ExpenseType)
                .HasDefaultValue(1)
                .HasColumnName("expense_type");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.VatId).HasColumnName("vat_id");

            entity.HasOne(d => d.Vat).WithMany(p => p.DocumentExpenseItems)
                .HasForeignKey(d => d.VatId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DocumentHeading>(entity =>
        {
            entity.ToTable("document_headings");

            entity.HasIndex(e => e.CausalId, "IX_document_headings_causal_id");

            entity.HasIndex(e => e.CurrencyId, "IX_document_headings_currency_id");

            entity.HasIndex(e => e.CustomerId, "IX_document_headings_customer_id");

            entity.HasIndex(e => e.FromWarehouseId, "IX_document_headings_from_warehouse_id");

            entity.HasIndex(e => e.PosId, "IX_document_headings_pos_id");

            entity.HasIndex(e => e.PriceListId, "IX_document_headings_price_list_id");

            entity.HasIndex(e => e.StateId, "IX_document_headings_state_id");

            entity.HasIndex(e => e.SupplierId, "IX_document_headings_supplier_id");

            entity.HasIndex(e => e.ToWarehouseId, "IX_document_headings_to_warehouse_id");

            entity.HasIndex(e => e.TypeId, "IX_document_headings_type_id");

            entity.HasIndex(e => new { e.ShopId, e.TypeId, e.Code, e.Year }, "ix_documents_headings_shop_type_code_year").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CausalId).HasColumnName("causal_id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Concluded).HasColumnName("concluded");
            entity.Property(e => e.ConclusionDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("conclusion_date");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Deleter).HasColumnName("deleter");
            entity.Property(e => e.DeletionTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deletion_time");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("delivery_date");
            entity.Property(e => e.ExternalCode)
                .HasMaxLength(20)
                .HasColumnName("external_code");
            entity.Property(e => e.FromWarehouseId).HasColumnName("from_warehouse_id");
            entity.Property(e => e.IntegrationGuid)
                .HasMaxLength(36)
                .HasColumnName("integration_guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.NumberOfRows).HasColumnName("number_of_rows");
            entity.Property(e => e.OperationsNotes)
                .HasMaxLength(255)
                .HasColumnName("operations_notes");
            entity.Property(e => e.PaymentConditionId).HasColumnName("payment_condition_id");
            entity.Property(e => e.PercentualADiscount)
                .HasPrecision(15, 5)
                .HasColumnName("percentual_a_discount");
            entity.Property(e => e.PercentualBDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("percentual_b_discount");
            entity.Property(e => e.PercentualCDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("percentual_c_discount");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.PriceListId).HasColumnName("price_list_id");
            entity.Property(e => e.RegistrationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("registration_date");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.ToWarehouseId).HasColumnName("to_warehouse_id");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.UseSplitPayment).HasColumnName("use_split_payment");
            entity.Property(e => e.ValueDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("value_discount");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Causal).WithMany(p => p.DocumentHeadings)
                .HasForeignKey(d => d.CausalId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Currency).WithMany(p => p.DocumentHeadings)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Customer).WithMany(p => p.DocumentHeadings)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.FromWarehouse).WithMany(p => p.DocumentHeadingFromWarehouses)
                .HasForeignKey(d => d.FromWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Pos).WithMany(p => p.DocumentHeadings).HasForeignKey(d => d.PosId);

            entity.HasOne(d => d.PriceList).WithMany(p => p.DocumentHeadings)
                .HasForeignKey(d => d.PriceListId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Shop).WithMany(p => p.DocumentHeadings)
                .HasForeignKey(d => d.ShopId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.State).WithMany(p => p.DocumentHeadings)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Supplier).WithMany(p => p.DocumentHeadings)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ToWarehouse).WithMany(p => p.DocumentHeadingToWarehouses)
                .HasForeignKey(d => d.ToWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Type).WithMany(p => p.DocumentHeadings)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DocumentLink>(entity =>
        {
            entity.ToTable("document_links");

            entity.HasIndex(e => e.ChildHeadingId, "IX_document_links_child_heading_id");

            entity.HasIndex(e => new { e.ParentHeadingId, e.ChildHeadingId }, "IX_document_links_parent_heading_id_child_heading_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChildHeadingId).HasColumnName("child_heading_id");
            entity.Property(e => e.ParentHeadingId).HasColumnName("parent_heading_id");

            entity.HasOne(d => d.ChildHeading).WithMany(p => p.DocumentLinkChildHeadings)
                .HasForeignKey(d => d.ChildHeadingId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ParentHeading).WithMany(p => p.DocumentLinkParentHeadings)
                .HasForeignKey(d => d.ParentHeadingId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DocumentRecent>(entity =>
        {
            entity.HasKey(e => new { e.OperatorId, e.DocumentId });

            entity.ToTable("document_recents");

            entity.HasIndex(e => e.DocumentId, "IX_document_recents_document_id");

            entity.Property(e => e.OperatorId).HasColumnName("operator_id");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp");

            entity.HasOne(d => d.Document).WithMany(p => p.DocumentRecents).HasForeignKey(d => d.DocumentId);

            entity.HasOne(d => d.Operator).WithMany(p => p.DocumentRecents).HasForeignKey(d => d.OperatorId);
        });

        modelBuilder.Entity<DocumentRow>(entity =>
        {
            entity.ToTable("document_rows");

            entity.HasIndex(e => e.ArticleId, "IX_document_rows_article_id");

            entity.HasIndex(e => e.CausalId, "IX_document_rows_causal_id");

            entity.HasIndex(e => e.HeadingId, "IX_document_rows_heading_id");

            entity.HasIndex(e => e.MeasUnitId, "IX_document_rows_meas_unit_id");

            entity.HasIndex(e => e.PurchasePriceListId, "IX_document_rows_purchase_price_list_id");

            entity.HasIndex(e => e.SalePriceListId, "IX_document_rows_sale_price_list_id");

            entity.HasIndex(e => e.ShopId, "IX_document_rows_shop_id");

            entity.HasIndex(e => e.SourceDetailId, "IX_document_rows_source_detail_id");

            entity.HasIndex(e => e.SourceHeadingId, "IX_document_rows_source_heading_id");

            entity.HasIndex(e => e.VatId, "IX_document_rows_vat_id");

            entity.HasIndex(e => e.WarehouseId, "IX_document_rows_warehouse_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(15, 5)
                .HasColumnName("amount");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .HasColumnName("barcode");
            entity.Property(e => e.CausalId).HasColumnName("causal_id");
            entity.Property(e => e.Concluded).HasColumnName("concluded");
            entity.Property(e => e.ConfirmedQuantity)
                .HasPrecision(15, 5)
                .HasColumnName("confirmed_quantity");
            entity.Property(e => e.ConversionFactor)
                .HasPrecision(15, 5)
                .HasDefaultValue(1.0m)
                .HasColumnName("conversion_factor");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Deleter).HasColumnName("deleter");
            entity.Property(e => e.DeletionTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deletion_time");
            entity.Property(e => e.DiffQuantity)
                .HasPrecision(15, 5)
                .HasColumnName("diff_quantity");
            entity.Property(e => e.GrossTotalAmount)
                .HasPrecision(15, 5)
                .HasColumnName("gross_total_amount");
            entity.Property(e => e.HeadingId).HasColumnName("heading_id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.MeasUnitId).HasColumnName("meas_unit_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.OperationsNotes)
                .HasMaxLength(255)
                .HasColumnName("operations_notes");
            entity.Property(e => e.PercentDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("percent_discount");
            entity.Property(e => e.PriceListAmount)
                .HasPrecision(15, 5)
                .HasColumnName("price_list_amount");
            entity.Property(e => e.PurchasePriceListId).HasColumnName("purchase_price_list_id");
            entity.Property(e => e.Quantity)
                .HasPrecision(15, 5)
                .HasColumnName("quantity");
            entity.Property(e => e.RowTotalAmount)
                .HasPrecision(15, 5)
                .HasColumnName("row_total_amount");
            entity.Property(e => e.SalePriceListId).HasColumnName("sale_price_list_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.SourceDetailId).HasColumnName("source_detail_id");
            entity.Property(e => e.SourceHeadingId).HasColumnName("source_heading_id");
            entity.Property(e => e.StockQuantity)
                .HasPrecision(15, 5)
                .HasColumnName("stock_quantity");
            entity.Property(e => e.SuppArticleCode)
                .HasMaxLength(20)
                .HasColumnName("supp_article_code");
            entity.Property(e => e.SuppArticleDescription)
                .HasMaxLength(100)
                .HasColumnName("supp_article_description");
            entity.Property(e => e.ValueDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("value_discount");
            entity.Property(e => e.VatId).HasColumnName("vat_id");
            entity.Property(e => e.VatTotalAmount)
                .HasPrecision(15, 5)
                .HasColumnName("vat_total_amount");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

            entity.HasOne(d => d.Article).WithMany(p => p.DocumentRows)
                .HasForeignKey(d => d.ArticleId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Causal).WithMany(p => p.DocumentRows)
                .HasForeignKey(d => d.CausalId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Heading).WithMany(p => p.DocumentRowHeadings).HasForeignKey(d => d.HeadingId);

            entity.HasOne(d => d.MeasUnit).WithMany(p => p.DocumentRows)
                .HasForeignKey(d => d.MeasUnitId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.PurchasePriceList).WithMany(p => p.DocumentRows)
                .HasForeignKey(d => d.PurchasePriceListId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.SalePriceList).WithMany(p => p.DocumentRows)
                .HasForeignKey(d => d.SalePriceListId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Shop).WithMany(p => p.DocumentRows)
                .HasForeignKey(d => d.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.SourceDetail).WithMany(p => p.InverseSourceDetail)
                .HasForeignKey(d => d.SourceDetailId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.SourceHeading).WithMany(p => p.DocumentRowSourceHeadings)
                .HasForeignKey(d => d.SourceHeadingId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Vat).WithMany(p => p.DocumentRows)
                .HasForeignKey(d => d.VatId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Warehouse).WithMany(p => p.DocumentRows)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DocumentState>(entity =>
        {
            entity.ToTable("document_states");

            entity.HasIndex(e => e.Code, "IX_document_states_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.VisibilityLevel).HasColumnName("visibility_level");
        });

        modelBuilder.Entity<DocumentTotal>(entity =>
        {
            entity.ToTable("document_totals");

            entity.HasIndex(e => e.Code, "IX_document_totals_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplyDiscounts).HasColumnName("apply_discounts");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.FixedLabel)
                .HasMaxLength(50)
                .HasColumnName("fixed_label");
            entity.Property(e => e.LabelStatement)
                .HasMaxLength(255)
                .HasColumnName("label_statement");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.TotalType).HasColumnName("total_type");
            entity.Property(e => e.ValueStatement)
                .HasMaxLength(2000)
                .HasColumnName("value_statement");
        });

        modelBuilder.Entity<DocumentTotalsAmount>(entity =>
        {
            entity.ToTable("document_totals_amount");

            entity.HasIndex(e => e.DocumentHeadingId, "IX_document_totals_amount_document_heading_id");

            entity.HasIndex(e => e.TotalId, "IX_document_totals_amount_total_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocumentHeadingId).HasColumnName("document_heading_id");
            entity.Property(e => e.GrossAmount)
                .HasPrecision(15, 5)
                .HasColumnName("gross_amount");
            entity.Property(e => e.LabelResult)
                .HasMaxLength(255)
                .HasColumnName("label_result");
            entity.Property(e => e.LabelStatementConditionId).HasColumnName("label_statement_condition_id");
            entity.Property(e => e.NetAmount)
                .HasPrecision(15, 5)
                .HasColumnName("net_amount");
            entity.Property(e => e.TotalId).HasColumnName("total_id");
            entity.Property(e => e.VatAmount)
                .HasPrecision(15, 5)
                .HasColumnName("vat_amount");
            entity.Property(e => e.VatPercent)
                .HasPrecision(15, 5)
                .HasColumnName("vat_percent");

            entity.HasOne(d => d.DocumentHeading).WithMany(p => p.DocumentTotalsAmounts).HasForeignKey(d => d.DocumentHeadingId);

            entity.HasOne(d => d.Total).WithMany(p => p.DocumentTotalsAmounts)
                .HasForeignKey(d => d.TotalId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.ToTable("document_types");

            entity.HasIndex(e => e.Code, "IX_document_types_code").IsUnique();

            entity.HasIndex(e => e.DocumentCounterId, "IX_document_types_document_counter_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Context)
                .HasDefaultValue(1)
                .HasColumnName("context");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.DocumentCounterId).HasColumnName("document_counter_id");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.DocumentCounter).WithMany(p => p.DocumentTypes)
                .HasForeignKey(d => d.DocumentCounterId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DocumentWorkflow>(entity =>
        {
            entity.ToTable("document_workflows");

            entity.HasIndex(e => new { e.HeadingId, e.StateId, e.Timestamp }, "IX_document_workflows_heading_id_state_id_timestamp");

            entity.HasIndex(e => e.StateId, "IX_document_workflows_state_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HeadingId).HasColumnName("heading_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.Operator)
                .HasMaxLength(100)
                .HasColumnName("operator");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp");

            entity.HasOne(d => d.Heading).WithMany(p => p.DocumentWorkflows).HasForeignKey(d => d.HeadingId);

            entity.HasOne(d => d.State).WithMany(p => p.DocumentWorkflows)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<EntityDynamicImportStaging>(entity =>
        {
            entity.ToTable("entity_dynamic_import_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EntityType).HasColumnName("entity_type");
            entity.Property(e => e.ImportData)
                .HasColumnType("jsonb")
                .HasColumnName("import_data");
        });

        modelBuilder.Entity<FidelityConfig>(entity =>
        {
            entity.ToTable("fidelity_configs");

            entity.HasIndex(e => new { e.BrandId, e.Key }, "IX_fidelity_configs_brand_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.DefaultValue).HasColumnName("default_value");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.Brand).WithMany(p => p.FidelityConfigs).HasForeignKey(d => d.BrandId);
        });

        modelBuilder.Entity<FidelityEvent>(entity =>
        {
            entity.ToTable("fidelity_events");

            entity.HasIndex(e => new { e.BrandId, e.Type }, "IX_fidelity_events_brand_id_type").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CouponOffsetDays).HasColumnName("coupon_offset_days");
            entity.Property(e => e.EmailTemplateId).HasColumnName("email_template_id");
            entity.Property(e => e.GenerateCoupon).HasColumnName("generate_coupon");
            entity.Property(e => e.SendEmail).HasColumnName("send_email");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.Brand).WithMany(p => p.FidelityEvents).HasForeignKey(d => d.BrandId);
        });

        modelBuilder.Entity<FidelityMarketingContent>(entity =>
        {
            entity.ToTable("fidelity_marketing_contents");

            entity.HasIndex(e => e.BrandId, "IX_fidelity_marketing_contents_brand_id");

            entity.HasIndex(e => e.Code, "IX_fidelity_marketing_contents_code").IsUnique();

            entity.HasIndex(e => e.ImageMediaId, "IX_fidelity_marketing_contents_image_media_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EndTime)
                .HasDefaultValueSql("'23:59:59'::time without time zone")
                .HasColumnName("end_time");
            entity.Property(e => e.ImageMediaId).HasColumnName("image_media_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.LinkUrl)
                .HasMaxLength(2048)
                .HasColumnName("link_url");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime)
                .HasDefaultValueSql("'00:00:00'::time without time zone")
                .HasColumnName("start_time");
            entity.Property(e => e.TextSection)
                .HasMaxLength(1000)
                .HasColumnName("text_section");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.Weekdays)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("weekdays");

            entity.HasOne(d => d.Brand).WithMany(p => p.FidelityMarketingContents)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ImageMedia).WithMany(p => p.FidelityMarketingContents)
                .HasForeignKey(d => d.ImageMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<FidelityMarketingContentsLang>(entity =>
        {
            entity.HasKey(e => new { e.MarketingContentId, e.LanguageCode });

            entity.ToTable("fidelity_marketing_contents_lang");

            entity.HasIndex(e => e.ImageMediaId, "IX_fidelity_marketing_contents_lang_image_media_id");

            entity.Property(e => e.MarketingContentId).HasColumnName("marketing_content_id");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.ImageMediaId).HasColumnName("image_media_id");
            entity.Property(e => e.TextSection)
                .HasMaxLength(1000)
                .HasColumnName("text_section");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");

            entity.HasOne(d => d.ImageMedia).WithMany(p => p.FidelityMarketingContentsLangs).HasForeignKey(d => d.ImageMediaId);

            entity.HasOne(d => d.MarketingContent).WithMany(p => p.FidelityMarketingContentsLangs)
                .HasForeignKey(d => d.MarketingContentId)
                .HasConstraintName("FK_fidelity_marketing_contents_lang_fidelity_marketing_content~");
        });

        modelBuilder.Entity<FidelitySurvey>(entity =>
        {
            entity.ToTable("fidelity_surveys");

            entity.HasIndex(e => e.BrandId, "IX_fidelity_surveys_brand_id");

            entity.HasIndex(e => e.Code, "IX_fidelity_surveys_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.EmailTemplateId).HasColumnName("email_template_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PublicDescription)
                .HasMaxLength(2000)
                .HasColumnName("public_description");
            entity.Property(e => e.SubmitAction).HasColumnName("submit_action");
            entity.Property(e => e.SubmittedMessage)
                .HasMaxLength(2000)
                .HasColumnName("submitted_message");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.UniqueTransactionCodePrivateKey)
                .HasMaxLength(64)
                .HasColumnName("unique_transaction_code_private_key");

            entity.HasOne(d => d.Brand).WithMany(p => p.FidelitySurveys)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<FidelitySurveyQuestion>(entity =>
        {
            entity.ToTable("fidelity_survey_questions");

            entity.HasIndex(e => e.SurveyId, "IX_fidelity_survey_questions_survey_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdditionalData)
                .HasMaxLength(10000)
                .HasColumnName("additional_data");
            entity.Property(e => e.IsRequired)
                .HasDefaultValue(true)
                .HasColumnName("is_required");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PublicDescription)
                .HasMaxLength(2000)
                .HasColumnName("public_description");
            entity.Property(e => e.QuestionType).HasColumnName("question_type");
            entity.Property(e => e.SemanticValue).HasColumnName("semantic_value");
            entity.Property(e => e.SurveyId).HasColumnName("survey_id");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");

            entity.HasOne(d => d.Survey).WithMany(p => p.FidelitySurveyQuestions).HasForeignKey(d => d.SurveyId);
        });

        modelBuilder.Entity<FidelitySurveyQuestionsLang>(entity =>
        {
            entity.HasKey(e => new { e.SurveyQuestionId, e.LanguageCode });

            entity.ToTable("fidelity_survey_questions_lang");

            entity.Property(e => e.SurveyQuestionId).HasColumnName("survey_question_id");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.AdditionalData)
                .HasMaxLength(10000)
                .HasColumnName("additional_data");
            entity.Property(e => e.PublicDescription)
                .HasMaxLength(2000)
                .HasColumnName("public_description");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");

            entity.HasOne(d => d.SurveyQuestion).WithMany(p => p.FidelitySurveyQuestionsLangs)
                .HasForeignKey(d => d.SurveyQuestionId)
                .HasConstraintName("FK_fidelity_survey_questions_lang_fidelity_survey_questions_su~");
        });

        modelBuilder.Entity<FidelitySurveyResponse>(entity =>
        {
            entity.ToTable("fidelity_survey_responses");

            entity.HasIndex(e => e.SurveyId, "IX_fidelity_survey_responses_survey_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnswerCode).HasColumnName("answer_code");
            entity.Property(e => e.AnswersJson).HasColumnName("answers_json");
            entity.Property(e => e.DateSubmitted)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_submitted");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.SurveyId).HasColumnName("survey_id");

            entity.HasOne(d => d.Survey).WithMany(p => p.FidelitySurveyResponses).HasForeignKey(d => d.SurveyId);
        });

        modelBuilder.Entity<FidelitySurveysLang>(entity =>
        {
            entity.HasKey(e => new { e.SurveyId, e.LanguageCode });

            entity.ToTable("fidelity_surveys_lang");

            entity.Property(e => e.SurveyId).HasColumnName("survey_id");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.PublicDescription)
                .HasMaxLength(2000)
                .HasColumnName("public_description");
            entity.Property(e => e.SubmittedMessage)
                .HasMaxLength(2000)
                .HasColumnName("submitted_message");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");

            entity.HasOne(d => d.Survey).WithMany(p => p.FidelitySurveysLangs).HasForeignKey(d => d.SurveyId);
        });

        modelBuilder.Entity<FidelityUser>(entity =>
        {
            entity.ToTable("fidelity_users");

            entity.HasIndex(e => e.NormalizedEmail, "fidelity_email_index");

            entity.HasIndex(e => e.NormalizedUserName, "fidelity_user_name_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessFailedCount).HasColumnName("access_failed_count");
            entity.Property(e => e.ConcurrencyStamp).HasColumnName("concurrency_stamp");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .HasColumnName("email");
            entity.Property(e => e.EmailConfirmed).HasColumnName("email_confirmed");
            entity.Property(e => e.LockoutEnabled).HasColumnName("lockout_enabled");
            entity.Property(e => e.LockoutEnd).HasColumnName("lockout_end");
            entity.Property(e => e.NormalizedEmail)
                .HasMaxLength(256)
                .HasColumnName("normalized_email");
            entity.Property(e => e.NormalizedUserName)
                .HasMaxLength(256)
                .HasColumnName("normalized_user_name");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.PhoneNumberConfirmed).HasColumnName("phone_number_confirmed");
            entity.Property(e => e.SecurityStamp).HasColumnName("security_stamp");
            entity.Property(e => e.TwoFactorEnabled).HasColumnName("two_factor_enabled");
            entity.Property(e => e.Username)
                .HasMaxLength(256)
                .HasColumnName("username");
        });

        modelBuilder.Entity<FidelityUserClaim>(entity =>
        {
            entity.ToTable("fidelity_user_claims");

            entity.HasIndex(e => e.UserId, "IX_fidelity_user_claims_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClaimType).HasColumnName("claim_type");
            entity.Property(e => e.ClaimValue).HasColumnName("claim_value");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.FidelityUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<FidelityUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("fidelity_user_logins");

            entity.HasIndex(e => e.UserId, "IX_fidelity_user_logins_user_id");

            entity.Property(e => e.LoginProvider)
                .HasMaxLength(128)
                .HasColumnName("login_provider");
            entity.Property(e => e.ProviderKey)
                .HasMaxLength(128)
                .HasColumnName("provider_key");
            entity.Property(e => e.ProviderDisplayName).HasColumnName("provider_display_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.FidelityUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<FidelityUserSession>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.ToTable("fidelity_user_sessions");

            entity.HasIndex(e => e.UserId, "IX_fidelity_user_sessions_user_id");

            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("expires_at");
            entity.Property(e => e.RefreshToken).HasColumnName("refresh_token");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.FidelityUserSessions).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<FidelityUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("fidelity_user_tokens");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.LoginProvider)
                .HasMaxLength(128)
                .HasColumnName("login_provider");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.User).WithMany(p => p.FidelityUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<KioskConfig>(entity =>
        {
            entity.ToTable("kiosk_configs");

            entity.HasIndex(e => e.Key, "IX_kiosk_configs_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DefaultValue).HasColumnName("default_value");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("''::text")
                .HasColumnName("type");
        });

        modelBuilder.Entity<KioskConfigOverride>(entity =>
        {
            entity.ToTable("kiosk_config_overrides");

            entity.HasIndex(e => e.ConfigId, "IX_kiosk_config_overrides_config_id");

            entity.HasIndex(e => e.KioskId, "IX_kiosk_config_overrides_kiosk_id");

            entity.HasIndex(e => e.ShopId, "IX_kiosk_config_overrides_shop_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConfigId).HasColumnName("config_id");
            entity.Property(e => e.KioskId).HasColumnName("kiosk_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Config).WithMany(p => p.KioskConfigOverrides).HasForeignKey(d => d.ConfigId);

            entity.HasOne(d => d.Kiosk).WithMany(p => p.KioskConfigOverrides).HasForeignKey(d => d.KioskId);

            entity.HasOne(d => d.Shop).WithMany(p => p.KioskConfigOverrides).HasForeignKey(d => d.ShopId);
        });

        modelBuilder.Entity<KioskLanguage>(entity =>
        {
            entity.ToTable("kiosk_languages");

            entity.HasIndex(e => e.Code, "IX_kiosk_languages_code").IsUnique();

            entity.HasIndex(e => e.MediaId, "IX_kiosk_languages_media_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.Media).WithOne(p => p.KioskLanguage).HasForeignKey<KioskLanguage>(d => d.MediaId);
        });

        modelBuilder.Entity<KioskLayout>(entity =>
        {
            entity.ToTable("kiosk_layouts");

            entity.HasIndex(e => e.Code, "IX_kiosk_layouts_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<KioskLayoutSchedule>(entity =>
        {
            entity.ToTable("kiosk_layout_schedules");

            entity.HasIndex(e => e.Code, "IX_kiosk_layout_schedules_code").IsUnique();

            entity.HasIndex(e => e.DefaultLayoutId, "IX_kiosk_layout_schedules_default_layout_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.DefaultLayoutId).HasColumnName("default_layout_id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.DefaultLayout).WithMany(p => p.KioskLayoutSchedules).HasForeignKey(d => d.DefaultLayoutId);
        });

        modelBuilder.Entity<KioskLayoutScheduleDetail>(entity =>
        {
            entity.ToTable("kiosk_layout_schedule_details");

            entity.HasIndex(e => e.LayoutId, "IX_kiosk_layout_schedule_details_layout_id");

            entity.HasIndex(e => e.LayoutScheduleId, "IX_kiosk_layout_schedule_details_layout_schedule_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EndTime)
                .HasDefaultValueSql("'23:59:59'::time without time zone")
                .HasColumnName("end_time");
            entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            entity.Property(e => e.LayoutScheduleId).HasColumnName("layout_schedule_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime)
                .HasDefaultValueSql("'00:00:00'::time without time zone")
                .HasColumnName("start_time");
            entity.Property(e => e.Weekdays).HasColumnName("weekdays");

            entity.HasOne(d => d.Layout).WithMany(p => p.KioskLayoutScheduleDetails).HasForeignKey(d => d.LayoutId);

            entity.HasOne(d => d.LayoutSchedule).WithMany(p => p.KioskLayoutScheduleDetails)
                .HasForeignKey(d => d.LayoutScheduleId)
                .HasConstraintName("FK_kiosk_layout_schedule_details_kiosk_layout_schedules_layout~");
        });

        modelBuilder.Entity<KioskMediaSchedule>(entity =>
        {
            entity.ToTable("kiosk_media_schedules");

            entity.HasIndex(e => e.Code, "IX_kiosk_media_schedules_code").IsUnique();

            entity.HasIndex(e => e.TopBannerMediaId, "IX_kiosk_media_schedules_top_banner_media_id");

            entity.HasIndex(e => e.WelcomeMediaId, "IX_kiosk_media_schedules_welcome_media_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.TopBannerMediaId).HasColumnName("top_banner_media_id");
            entity.Property(e => e.WelcomeMediaId).HasColumnName("welcome_media_id");

            entity.HasOne(d => d.TopBannerMedia).WithMany(p => p.KioskMediaScheduleTopBannerMedia).HasForeignKey(d => d.TopBannerMediaId);

            entity.HasOne(d => d.WelcomeMedia).WithMany(p => p.KioskMediaScheduleWelcomeMedia).HasForeignKey(d => d.WelcomeMediaId);
        });

        modelBuilder.Entity<KioskMediaScheduleDetail>(entity =>
        {
            entity.ToTable("kiosk_media_schedule_details");

            entity.HasIndex(e => e.MediaScheduleId, "IX_kiosk_media_schedule_details_media_schedule_id");

            entity.HasIndex(e => e.TopBannerMediaId, "IX_kiosk_media_schedule_details_top_banner_media_id");

            entity.HasIndex(e => e.WelcomeMediaId, "IX_kiosk_media_schedule_details_welcome_media_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EndTime)
                .HasDefaultValueSql("'23:59:59'::time without time zone")
                .HasColumnName("end_time");
            entity.Property(e => e.MediaScheduleId).HasColumnName("media_schedule_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime)
                .HasDefaultValueSql("'00:00:00'::time without time zone")
                .HasColumnName("start_time");
            entity.Property(e => e.TopBannerMediaId).HasColumnName("top_banner_media_id");
            entity.Property(e => e.Weekdays)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("weekdays");
            entity.Property(e => e.WelcomeMediaId).HasColumnName("welcome_media_id");

            entity.HasOne(d => d.MediaSchedule).WithMany(p => p.KioskMediaScheduleDetails)
                .HasForeignKey(d => d.MediaScheduleId)
                .HasConstraintName("FK_kiosk_media_schedule_details_kiosk_media_schedules_media_sc~");

            entity.HasOne(d => d.TopBannerMedia).WithMany(p => p.KioskMediaScheduleDetailTopBannerMedia).HasForeignKey(d => d.TopBannerMediaId);

            entity.HasOne(d => d.WelcomeMedia).WithMany(p => p.KioskMediaScheduleDetailWelcomeMedia).HasForeignKey(d => d.WelcomeMediaId);
        });

        modelBuilder.Entity<KioskPayment>(entity =>
        {
            entity.ToTable("kiosk_payments");

            entity.HasIndex(e => e.Code, "IX_kiosk_payments_code").IsUnique();

            entity.HasIndex(e => e.MediaId, "IX_kiosk_payments_media_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.Media).WithOne(p => p.KioskPayment).HasForeignKey<KioskPayment>(d => d.MediaId);
        });

        modelBuilder.Entity<KioskServiceType>(entity =>
        {
            entity.ToTable("kiosk_service_types");

            entity.HasIndex(e => e.Code, "IX_kiosk_service_types_code").IsUnique();

            entity.HasIndex(e => e.MediaId, "IX_kiosk_service_types_media_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.Media).WithOne(p => p.KioskServiceType).HasForeignKey<KioskServiceType>(d => d.MediaId);
        });

        modelBuilder.Entity<KioskUiGroup>(entity =>
        {
            entity.ToTable("kiosk_ui_groups");

            entity.HasIndex(e => e.Code, "IX_kiosk_ui_groups_code").IsUnique();

            entity.HasIndex(e => e.GroupByTagId, "IX_kiosk_ui_groups_group_by_tag_id");

            entity.HasIndex(e => e.MediaId, "IX_kiosk_ui_groups_media_id");

            entity.HasIndex(e => e.TileTemplateId, "IX_kiosk_ui_groups_tile_template_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.GroupByTagId).HasColumnName("group_by_tag_id");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ReadableName).HasColumnName("readable_name");
            entity.Property(e => e.TileTemplateId).HasColumnName("tile_template_id");

            entity.HasOne(d => d.GroupByTag).WithMany(p => p.KioskUiGroups).HasForeignKey(d => d.GroupByTagId);

            entity.HasOne(d => d.Media).WithMany(p => p.KioskUiGroups).HasForeignKey(d => d.MediaId);

            entity.HasOne(d => d.TileTemplate).WithMany(p => p.KioskUiGroups).HasForeignKey(d => d.TileTemplateId);
        });

        modelBuilder.Entity<KioskUiGroupDetail>(entity =>
        {
            entity.ToTable("kiosk_ui_group_details");

            entity.HasIndex(e => e.ChildArticleId, "IX_kiosk_ui_group_details_child_article_id");

            entity.HasIndex(e => e.ChildKioskUiGroupId, "IX_kiosk_ui_group_details_child_kiosk_ui_group_id");

            entity.HasIndex(e => e.KioskUiGroupId, "IX_kiosk_ui_group_details_kiosk_ui_group_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChildArticleId).HasColumnName("child_article_id");
            entity.Property(e => e.ChildKioskUiGroupId).HasColumnName("child_kiosk_ui_group_id");
            entity.Property(e => e.KioskUiGroupId).HasColumnName("kiosk_ui_group_id");
            entity.Property(e => e.OrderNumber).HasColumnName("order_number");
            entity.Property(e => e.ValidForServiceTypes)
                .HasDefaultValueSql("''::text")
                .HasColumnName("valid_for_service_types");

            entity.HasOne(d => d.ChildArticle).WithMany(p => p.KioskUiGroupDetails).HasForeignKey(d => d.ChildArticleId);

            entity.HasOne(d => d.ChildKioskUiGroup).WithMany(p => p.KioskUiGroupDetailChildKioskUiGroups)
                .HasForeignKey(d => d.ChildKioskUiGroupId)
                .HasConstraintName("FK_kiosk_ui_group_details_kiosk_ui_groups_child_kiosk_ui_group~");

            entity.HasOne(d => d.KioskUiGroup).WithMany(p => p.KioskUiGroupDetailKioskUiGroups).HasForeignKey(d => d.KioskUiGroupId);
        });

        modelBuilder.Entity<KioskUiGroupLang>(entity =>
        {
            entity.HasKey(e => new { e.KioskUiGroupId, e.LanguageCode });

            entity.ToTable("kiosk_ui_group_lang");

            entity.HasIndex(e => e.MediaId, "IX_kiosk_ui_group_lang_media_id");

            entity.Property(e => e.KioskUiGroupId).HasColumnName("kiosk_ui_group_id");
            entity.Property(e => e.LanguageCode).HasColumnName("language_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.ReadableName).HasColumnName("readable_name");

            entity.HasOne(d => d.KioskUiGroup).WithMany(p => p.KioskUiGroupLangs).HasForeignKey(d => d.KioskUiGroupId);

            entity.HasOne(d => d.Media).WithMany(p => p.KioskUiGroupLangs).HasForeignKey(d => d.MediaId);
        });

        modelBuilder.Entity<KioskUiGroupLayoutsLink>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.KioskUiGroupId });

            entity.ToTable("kiosk_ui_group_layouts_links");

            entity.HasIndex(e => e.KioskUiGroupId, "IX_kiosk_ui_group_layouts_links_kiosk_ui_group_id");

            entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            entity.Property(e => e.KioskUiGroupId).HasColumnName("kiosk_ui_group_id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ValidForServiceTypes)
                .HasDefaultValueSql("''::text")
                .HasColumnName("valid_for_service_types");

            entity.HasOne(d => d.KioskUiGroup).WithMany(p => p.KioskUiGroupLayoutsLinks)
                .HasForeignKey(d => d.KioskUiGroupId)
                .HasConstraintName("FK_kiosk_ui_group_layouts_links_kiosk_ui_groups_kiosk_ui_group~");

            entity.HasOne(d => d.Layout).WithMany(p => p.KioskUiGroupLayoutsLinks).HasForeignKey(d => d.LayoutId);
        });

        modelBuilder.Entity<KioskUiTileTemplate>(entity =>
        {
            entity.ToTable("kiosk_ui_tile_templates");

            entity.HasIndex(e => e.Code, "IX_kiosk_ui_tile_templates_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CssClass)
                .HasMaxLength(50)
                .HasColumnName("css_class");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.IsBackground)
                .HasDefaultValue(true)
                .HasColumnName("is_background");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ShowDescription)
                .HasDefaultValue(true)
                .HasColumnName("show_description");
            entity.Property(e => e.ShowName)
                .HasDefaultValue(true)
                .HasColumnName("show_name");
            entity.Property(e => e.ShowPrice)
                .HasDefaultValue(true)
                .HasColumnName("show_price");
        });

        modelBuilder.Entity<KiosksView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("kiosks_view", "kiosk");

            entity.Property(e => e.CashPaymentEnabled).HasColumnName("cash_payment_enabled");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreditCardPaymentEnabled).HasColumnName("credit_card_payment_enabled");
            entity.Property(e => e.ExternalId).HasColumnName("external_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Languages).HasColumnName("languages");
            entity.Property(e => e.LayoutScheduleId).HasColumnName("layout_schedule_id");
            entity.Property(e => e.MediaScheduleId).HasColumnName("media_schedule_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PosType).HasColumnName("pos_type");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.TableServiceEnabled).HasColumnName("table_service_enabled");
            entity.Property(e => e.TakeAwayEnabled).HasColumnName("take_away_enabled");
        });

        modelBuilder.Entity<LanguagesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("languages_view", "kiosk");

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("code");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<LayoutScheduleDetailsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("layout_schedule_details_view", "kiosk");

            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            entity.Property(e => e.LayoutScheduleId).HasColumnName("layout_schedule_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.Weekdays).HasColumnName("weekdays");
        });

        modelBuilder.Entity<LayoutSchedulesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("layout_schedules_view", "kiosk");

            entity.Property(e => e.DefaultLayoutId).HasColumnName("default_layout_id");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<LayoutsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("layouts_view", "kiosk");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<LegalDocument>(entity =>
        {
            entity.ToTable("legal_documents");

            entity.HasIndex(e => e.BrandId, "IX_legal_documents_brand_id");

            entity.HasIndex(e => e.Code, "IX_legal_documents_code").IsUnique();

            entity.HasIndex(e => e.UploadedDocumentId, "IX_legal_documents_uploaded_document_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.IssueDate).HasColumnName("issue_date");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PublicTitle)
                .HasMaxLength(200)
                .HasColumnName("public_title");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UploadedDocumentId).HasColumnName("uploaded_document_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.LegalDocuments)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UploadedDocument).WithMany(p => p.LegalDocuments)
                .HasForeignKey(d => d.UploadedDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<LegalDocumentsLang>(entity =>
        {
            entity.HasKey(e => new { e.LegalDocumentId, e.LanguageCode });

            entity.ToTable("legal_documents_lang");

            entity.HasIndex(e => e.UploadedDocumentId, "IX_legal_documents_lang_uploaded_document_id");

            entity.Property(e => e.LegalDocumentId).HasColumnName("legal_document_id");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.PublicTitle)
                .HasMaxLength(200)
                .HasColumnName("public_title");
            entity.Property(e => e.UploadedDocumentId).HasColumnName("uploaded_document_id");

            entity.HasOne(d => d.LegalDocument).WithMany(p => p.LegalDocumentsLangs).HasForeignKey(d => d.LegalDocumentId);

            entity.HasOne(d => d.UploadedDocument).WithMany(p => p.LegalDocumentsLangs).HasForeignKey(d => d.UploadedDocumentId);
        });

        modelBuilder.Entity<MeasUnit>(entity =>
        {
            entity.ToTable("meas_units");

            entity.HasIndex(e => e.Code, "IX_meas_units_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<MeasUnitsConversion>(entity =>
        {
            entity.ToTable("meas_units_conversions");

            entity.HasIndex(e => new { e.FromMeasUnitId, e.ToMeasUnitId, e.Value }, "IX_meas_units_conversions_from_meas_unit_id_to_meas_unit_id_va~").IsUnique();

            entity.HasIndex(e => e.ToMeasUnitId, "IX_meas_units_conversions_to_meas_unit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FromMeasUnitId).HasColumnName("from_meas_unit_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .HasColumnName("notes");
            entity.Property(e => e.ToMeasUnitId).HasColumnName("to_meas_unit_id");
            entity.Property(e => e.Value)
                .HasPrecision(15, 5)
                .HasColumnName("value");

            entity.HasOne(d => d.FromMeasUnit).WithMany(p => p.MeasUnitsConversionFromMeasUnits).HasForeignKey(d => d.FromMeasUnitId);

            entity.HasOne(d => d.ToMeasUnit).WithMany(p => p.MeasUnitsConversionToMeasUnits)
                .HasForeignKey(d => d.ToMeasUnitId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<MeasUnitsStaging>(entity =>
        {
            entity.ToTable("meas_units_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<MediaScheduleDetailsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("media_schedule_details_view", "kiosk");

            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MediaScheduleId).HasColumnName("media_schedule_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.TopBannerMediaId).HasColumnName("top_banner_media_id");
            entity.Property(e => e.Weekdays)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("weekdays");
            entity.Property(e => e.WelcomeMediaId).HasColumnName("welcome_media_id");
        });

        modelBuilder.Entity<MediaSchedulesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("media_schedules_view", "kiosk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TopBannerMediaId).HasColumnName("top_banner_media_id");
            entity.Property(e => e.WelcomeMediaId).HasColumnName("welcome_media_id");
        });

        modelBuilder.Entity<MediaView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("media_view", "kiosk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Url)
                .HasMaxLength(2048)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Medium>(entity =>
        {
            entity.ToTable("media");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsPending)
                .HasDefaultValue(true)
                .HasColumnName("is_pending");
            entity.Property(e => e.Type)
                .HasDefaultValue(1)
                .HasColumnName("type");
            entity.Property(e => e.Url)
                .HasMaxLength(2048)
                .HasColumnName("url");
        });

        modelBuilder.Entity<OutOfStock>(entity =>
        {
            entity.ToTable("out_of_stock");

            entity.HasIndex(e => new { e.ArticleId, e.ShopId }, "IX_out_of_stock_article_id_shop_id").IsUnique();

            entity.HasIndex(e => e.ShopId, "IX_out_of_stock_shop_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");

            entity.HasOne(d => d.Article).WithMany(p => p.OutOfStocks).HasForeignKey(d => d.ArticleId);

            entity.HasOne(d => d.Shop).WithMany(p => p.OutOfStocks).HasForeignKey(d => d.ShopId);
        });

        modelBuilder.Entity<OutOfStockView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("out_of_stock_view", "kiosk");

            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
        });

        modelBuilder.Entity<PaymentsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("payments_view", "kiosk");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Po>(entity =>
        {
            entity.ToTable("pos");

            entity.HasIndex(e => e.Code, "IX_pos_code").IsUnique();

            entity.HasIndex(e => e.ShopId, "IX_pos_shop_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.ExternalId).HasColumnName("external_id");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PosType).HasColumnName("pos_type");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");

            entity.HasOne(d => d.Shop).WithMany(p => p.Pos).HasForeignKey(d => d.ShopId);
        });

        modelBuilder.Entity<PosKiosk>(entity =>
        {
            entity.ToTable("pos_kiosk");

            entity.HasIndex(e => e.LayoutScheduleId, "IX_pos_kiosk_layout_schedule_id");

            entity.HasIndex(e => e.MediaScheduleId, "IX_pos_kiosk_media_schedule_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CashPaymentEnabled).HasColumnName("cash_payment_enabled");
            entity.Property(e => e.CreditCardPaymentEnabled).HasColumnName("credit_card_payment_enabled");
            entity.Property(e => e.Languages).HasColumnName("languages");
            entity.Property(e => e.LayoutScheduleId).HasColumnName("layout_schedule_id");
            entity.Property(e => e.MediaScheduleId).HasColumnName("media_schedule_id");
            entity.Property(e => e.TableServiceEnabled).HasColumnName("table_service_enabled");
            entity.Property(e => e.TakeAwayEnabled).HasColumnName("take_away_enabled");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PosKiosk).HasForeignKey<PosKiosk>(d => d.Id);

            entity.HasOne(d => d.LayoutSchedule).WithMany(p => p.PosKiosks)
                .HasForeignKey(d => d.LayoutScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.MediaSchedule).WithMany(p => p.PosKiosks)
                .HasForeignKey(d => d.MediaScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PosStaging>(entity =>
        {
            entity.ToTable("pos_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.ExternalId).HasColumnName("external_id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PosType).HasColumnName("pos_type");
            entity.Property(e => e.ShopCode).HasColumnName("shop_code");
        });

        modelBuilder.Entity<PurchasePriceList>(entity =>
        {
            entity.ToTable("purchase_price_lists");

            entity.HasIndex(e => e.Code, "IX_purchase_price_lists_code").IsUnique();

            entity.HasIndex(e => e.CurrencyId, "IX_purchase_price_lists_currency_id");

            entity.HasIndex(e => e.SupplierId, "IX_purchase_price_lists_supplier_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.ValidityFrom).HasColumnName("validity_from");
            entity.Property(e => e.ValidityTo).HasColumnName("validity_to");

            entity.HasOne(d => d.Currency).WithMany(p => p.PurchasePriceLists).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchasePriceLists).HasForeignKey(d => d.SupplierId);

            entity.HasMany(d => d.ShopGroups).WithMany(p => p.PurchasePriceLists)
                .UsingEntity<Dictionary<string, object>>(
                    "PurchasePriceListShopGroupLink",
                    r => r.HasOne<ShopGroup>().WithMany()
                        .HasForeignKey("ShopGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("FK_purchase_price_list_shop_group_links_shop_groups_shop_group~"),
                    l => l.HasOne<PurchasePriceList>().WithMany()
                        .HasForeignKey("PurchasePriceListId")
                        .HasConstraintName("FK_purchase_price_list_shop_group_links_purchase_price_lists_p~"),
                    j =>
                    {
                        j.HasKey("PurchasePriceListId", "ShopGroupId");
                        j.ToTable("purchase_price_list_shop_group_links");
                        j.HasIndex(new[] { "ShopGroupId" }, "IX_purchase_price_list_shop_group_links_shop_group_id");
                        j.IndexerProperty<int>("PurchasePriceListId").HasColumnName("purchase_price_list_id");
                        j.IndexerProperty<int>("ShopGroupId").HasColumnName("shop_group_id");
                    });
        });

        modelBuilder.Entity<PurchasePriceListDetail>(entity =>
        {
            entity.ToTable("purchase_price_list_details");

            entity.HasIndex(e => e.MeasUnitId, "IX_purchase_price_list_details_meas_unit_id");

            entity.HasIndex(e => e.OrderMeasUnitId, "IX_purchase_price_list_details_order_meas_unit_id");

            entity.HasIndex(e => e.PurchasePriceListId, "IX_purchase_price_list_details_purchase_price_list_id");

            entity.HasIndex(e => new { e.ArticleId, e.MeasUnitId, e.IsValid, e.ValidityFrom, e.ValidityTo }, "idx_ppd_dedup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.ConversionFactor)
                .HasPrecision(15, 5)
                .HasColumnName("conversion_factor");
            entity.Property(e => e.DiscountA)
                .HasPrecision(15, 5)
                .HasColumnName("discount_a");
            entity.Property(e => e.DiscountB)
                .HasPrecision(15, 5)
                .HasColumnName("discount_b");
            entity.Property(e => e.DiscountC)
                .HasPrecision(15, 5)
                .HasColumnName("discount_c");
            entity.Property(e => e.DiscountD)
                .HasPrecision(15, 5)
                .HasColumnName("discount_d");
            entity.Property(e => e.DiscountE)
                .HasPrecision(15, 5)
                .HasColumnName("discount_e");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_update_date");
            entity.Property(e => e.MeasUnitId).HasColumnName("meas_unit_id");
            entity.Property(e => e.NetCost)
                .HasPrecision(15, 5)
                .HasColumnName("net_cost");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.OrderConversionFactor)
                .HasPrecision(15, 5)
                .HasColumnName("order_conversion_factor");
            entity.Property(e => e.OrderMeasUnitId).HasColumnName("order_meas_unit_id");
            entity.Property(e => e.PurchasePriceListId).HasColumnName("purchase_price_list_id");
            entity.Property(e => e.SupplierArticleCode)
                .HasMaxLength(20)
                .HasColumnName("supplier_article_code");
            entity.Property(e => e.SupplierDescription)
                .HasMaxLength(100)
                .HasColumnName("supplier_description");
            entity.Property(e => e.ValidityFrom).HasColumnName("validity_from");
            entity.Property(e => e.ValidityTo).HasColumnName("validity_to");

            entity.HasOne(d => d.Article).WithMany(p => p.PurchasePriceListDetails).HasForeignKey(d => d.ArticleId);

            entity.HasOne(d => d.MeasUnit).WithMany(p => p.PurchasePriceListDetailMeasUnits).HasForeignKey(d => d.MeasUnitId);

            entity.HasOne(d => d.OrderMeasUnit).WithMany(p => p.PurchasePriceListDetailOrderMeasUnits).HasForeignKey(d => d.OrderMeasUnitId);

            entity.HasOne(d => d.PurchasePriceList).WithMany(p => p.PurchasePriceListDetails)
                .HasForeignKey(d => d.PurchasePriceListId)
                .HasConstraintName("FK_purchase_price_list_details_purchase_price_lists_purchase_p~");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.ToTable("recipes");

            entity.HasIndex(e => e.Code, "IX_recipes_code").IsUnique();

            entity.HasIndex(e => e.ProducedMeasUnitId, "IX_recipes_produced_meas_unit_id");

            entity.HasIndex(e => e.RecipeCategoryId, "IX_recipes_recipe_category_id");

            entity.HasIndex(e => e.RecipeClassId, "IX_recipes_recipe_class_id");

            entity.HasIndex(e => e.RecipeProvenanceId, "IX_recipes_recipe_provenance_id");

            entity.HasIndex(e => e.RecipeSeasonId, "IX_recipes_recipe_season_id");

            entity.HasIndex(e => e.RecipeTypeId, "IX_recipes_recipe_type_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdditionalCost)
                .HasPrecision(15, 5)
                .HasColumnName("additional_cost");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ProducedMeasUnitId).HasColumnName("produced_meas_unit_id");
            entity.Property(e => e.ProducedQuantity)
                .HasPrecision(15, 5)
                .HasColumnName("produced_quantity");
            entity.Property(e => e.RecipeCategoryId).HasColumnName("recipe_category_id");
            entity.Property(e => e.RecipeClassId).HasColumnName("recipe_class_id");
            entity.Property(e => e.RecipeProvenanceId).HasColumnName("recipe_provenance_id");
            entity.Property(e => e.RecipeSeasonId).HasColumnName("recipe_season_id");
            entity.Property(e => e.RecipeTypeId).HasColumnName("recipe_type_id");

            entity.HasOne(d => d.ProducedMeasUnit).WithMany(p => p.Recipes).HasForeignKey(d => d.ProducedMeasUnitId);

            entity.HasOne(d => d.RecipeCategory).WithMany(p => p.Recipes).HasForeignKey(d => d.RecipeCategoryId);

            entity.HasOne(d => d.RecipeClass).WithMany(p => p.Recipes).HasForeignKey(d => d.RecipeClassId);

            entity.HasOne(d => d.RecipeProvenance).WithMany(p => p.Recipes).HasForeignKey(d => d.RecipeProvenanceId);

            entity.HasOne(d => d.RecipeSeason).WithMany(p => p.Recipes).HasForeignKey(d => d.RecipeSeasonId);

            entity.HasOne(d => d.RecipeType).WithMany(p => p.Recipes).HasForeignKey(d => d.RecipeTypeId);

            entity.HasMany(d => d.Brands).WithMany(p => p.Recipes)
                .UsingEntity<Dictionary<string, object>>(
                    "RecipeBrand",
                    r => r.HasOne<Brand>().WithMany().HasForeignKey("BrandId"),
                    l => l.HasOne<Recipe>().WithMany().HasForeignKey("RecipeId"),
                    j =>
                    {
                        j.HasKey("RecipeId", "BrandId");
                        j.ToTable("recipe_brands");
                        j.HasIndex(new[] { "BrandId" }, "IX_recipe_brands_brand_id");
                        j.IndexerProperty<int>("RecipeId").HasColumnName("recipe_id");
                        j.IndexerProperty<int>("BrandId").HasColumnName("brand_id");
                    });
        });

        modelBuilder.Entity<RecipeCategory>(entity =>
        {
            entity.ToTable("recipe_categories");

            entity.HasIndex(e => e.Code, "IX_recipe_categories_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RecipeClass>(entity =>
        {
            entity.ToTable("recipe_classes");

            entity.HasIndex(e => e.Code, "IX_recipe_classes_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RecipeIngredient>(entity =>
        {
            entity.ToTable("recipe_ingredients");

            entity.HasIndex(e => e.ArticleId, "IX_recipe_ingredients_article_id");

            entity.HasIndex(e => e.DateMinimumDurabilityId, "IX_recipe_ingredients_date_minimum_durability_id");

            entity.HasIndex(e => e.MeasUnitId, "IX_recipe_ingredients_meas_unit_id");

            entity.HasIndex(e => e.RecipeId, "IX_recipe_ingredients_recipe_id");

            entity.HasIndex(e => e.ReferenceRecipeId, "IX_recipe_ingredients_reference_recipe_id");

            entity.HasIndex(e => e.ReferencedMeasUnitId, "IX_recipe_ingredients_referenced_meas_unit_id");

            entity.HasIndex(e => e.SubstArticleId, "IX_recipe_ingredients_subst_article_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.ConversionFactor)
                .HasPrecision(15, 5)
                .HasColumnName("conversion_factor");
            entity.Property(e => e.DateMinimumDurabilityId).HasColumnName("date_minimum_durability_id");
            entity.Property(e => e.DontUnload).HasColumnName("dont_unload");
            entity.Property(e => e.MeasUnitId).HasColumnName("meas_unit_id");
            entity.Property(e => e.NetQuantity)
                .HasPrecision(15, 5)
                .HasColumnName("net_quantity");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ProductionSurplus)
                .HasPrecision(15, 5)
                .HasColumnName("production_surplus");
            entity.Property(e => e.Quantity)
                .HasPrecision(15, 5)
                .HasColumnName("quantity");
            entity.Property(e => e.RecipeId).HasColumnName("recipe_id");
            entity.Property(e => e.ReferenceRecipeId).HasColumnName("reference_recipe_id");
            entity.Property(e => e.ReferencedMeasUnitId).HasColumnName("referenced_meas_unit_id");
            entity.Property(e => e.ReferencedQuantity)
                .HasPrecision(15, 5)
                .HasColumnName("referenced_quantity");
            entity.Property(e => e.SubstArticleId).HasColumnName("subst_article_id");
            entity.Property(e => e.SubstShopIds).HasColumnName("subst_shop_ids");
            entity.Property(e => e.SurplusInPercentual).HasColumnName("surplus_in_percentual");

            entity.HasOne(d => d.Article).WithMany(p => p.RecipeIngredientArticles).HasForeignKey(d => d.ArticleId);

            entity.HasOne(d => d.DateMinimumDurability).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.DateMinimumDurabilityId)
                .HasConstraintName("FK_recipe_ingredients_date_minimum_durabilities_date_minimum_d~");

            entity.HasOne(d => d.MeasUnit).WithMany(p => p.RecipeIngredientMeasUnits).HasForeignKey(d => d.MeasUnitId);

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeIngredientRecipes).HasForeignKey(d => d.RecipeId);

            entity.HasOne(d => d.ReferenceRecipe).WithMany(p => p.RecipeIngredientReferenceRecipes).HasForeignKey(d => d.ReferenceRecipeId);

            entity.HasOne(d => d.ReferencedMeasUnit).WithMany(p => p.RecipeIngredientReferencedMeasUnits).HasForeignKey(d => d.ReferencedMeasUnitId);

            entity.HasOne(d => d.SubstArticle).WithMany(p => p.RecipeIngredientSubstArticles).HasForeignKey(d => d.SubstArticleId);
        });

        modelBuilder.Entity<RecipeIngredientsFlat>(entity =>
        {
            entity.ToTable("recipe_ingredients_flat");

            entity.HasIndex(e => e.ArticleId, "IX_recipe_ingredients_flat_article_id");

            entity.HasIndex(e => e.BaseArticleId, "IX_recipe_ingredients_flat_base_article_id");

            entity.HasIndex(e => e.IngredientId, "IX_recipe_ingredients_flat_ingredient_id");

            entity.HasIndex(e => e.MeasUnitId, "IX_recipe_ingredients_flat_meas_unit_id");

            entity.HasIndex(e => e.RecipeId, "IX_recipe_ingredients_flat_recipe_id");

            entity.HasIndex(e => e.ShopId, "IX_recipe_ingredients_flat_shop_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.BaseArticleId).HasColumnName("base_article_id");
            entity.Property(e => e.ConversionFactor)
                .HasPrecision(15, 5)
                .HasDefaultValue(1.0m)
                .HasColumnName("conversion_factor");
            entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");
            entity.Property(e => e.IngredientLevel).HasColumnName("ingredient_level");
            entity.Property(e => e.MeasUnitId).HasColumnName("meas_unit_id");
            entity.Property(e => e.Quantity)
                .HasPrecision(15, 5)
                .HasColumnName("quantity");
            entity.Property(e => e.RecipeId).HasColumnName("recipe_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.SurplusQuantity)
                .HasPrecision(15, 5)
                .HasColumnName("surplus_quantity");
            entity.Property(e => e.UsedQuantity)
                .HasPrecision(15, 5)
                .HasColumnName("used_quantity");

            entity.HasOne(d => d.Article).WithMany(p => p.RecipeIngredientsFlatArticles).HasForeignKey(d => d.ArticleId);

            entity.HasOne(d => d.BaseArticle).WithMany(p => p.RecipeIngredientsFlatBaseArticles).HasForeignKey(d => d.BaseArticleId);

            entity.HasOne(d => d.Ingredient).WithMany(p => p.RecipeIngredientsFlats)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.MeasUnit).WithMany(p => p.RecipeIngredientsFlats).HasForeignKey(d => d.MeasUnitId);

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeIngredientsFlats).HasForeignKey(d => d.RecipeId);

            entity.HasOne(d => d.Shop).WithMany(p => p.RecipeIngredientsFlats).HasForeignKey(d => d.ShopId);
        });

        modelBuilder.Entity<RecipeProvenance>(entity =>
        {
            entity.ToTable("recipe_provenances");

            entity.HasIndex(e => e.Code, "IX_recipe_provenances_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RecipeSeason>(entity =>
        {
            entity.ToTable("recipe_seasons");

            entity.HasIndex(e => e.Code, "IX_recipe_seasons_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<RecipeType>(entity =>
        {
            entity.ToTable("recipe_types");

            entity.HasIndex(e => e.Code, "IX_recipe_types_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SaleArticleLink>(entity =>
        {
            entity.HasKey(e => e.SaleArticleId);

            entity.ToTable("sale_article_links");

            entity.HasIndex(e => e.RecipeId, "IX_sale_article_links_recipe_id");

            entity.HasIndex(e => e.WarehouseArticleId, "IX_sale_article_links_warehouse_article_id");

            entity.Property(e => e.SaleArticleId)
                .ValueGeneratedNever()
                .HasColumnName("sale_article_id");
            entity.Property(e => e.PortionFactor)
                .HasPrecision(15, 5)
                .HasColumnName("portion_factor");
            entity.Property(e => e.RecipeId).HasColumnName("recipe_id");
            entity.Property(e => e.Unloadable).HasColumnName("unloadable");
            entity.Property(e => e.WarehouseArticleId).HasColumnName("warehouse_article_id");

            entity.HasOne(d => d.Recipe).WithMany(p => p.SaleArticleLinks).HasForeignKey(d => d.RecipeId);

            entity.HasOne(d => d.SaleArticle).WithOne(p => p.SaleArticleLinkSaleArticle).HasForeignKey<SaleArticleLink>(d => d.SaleArticleId);

            entity.HasOne(d => d.WarehouseArticle).WithMany(p => p.SaleArticleLinkWarehouseArticles).HasForeignKey(d => d.WarehouseArticleId);
        });

        modelBuilder.Entity<SaleArticleLinksHistory>(entity =>
        {
            entity.ToTable("sale_article_links_history");

            entity.HasIndex(e => e.NewRecipeId, "IX_sale_article_links_history_new_recipe_id");

            entity.HasIndex(e => e.NewWarehouseArticleId, "IX_sale_article_links_history_new_warehouse_article_id");

            entity.HasIndex(e => e.OldRecipeId, "IX_sale_article_links_history_old_recipe_id");

            entity.HasIndex(e => e.OldWarehouseArticleId, "IX_sale_article_links_history_old_warehouse_article_id");

            entity.HasIndex(e => e.SaleArticleId, "IX_sale_article_links_history_sale_article_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_date");
            entity.Property(e => e.NewPortionFactor)
                .HasPrecision(15, 5)
                .HasColumnName("new_portion_factor");
            entity.Property(e => e.NewRecipeId).HasColumnName("new_recipe_id");
            entity.Property(e => e.NewUnloadable).HasColumnName("new_unloadable");
            entity.Property(e => e.NewWarehouseArticleId).HasColumnName("new_warehouse_article_id");
            entity.Property(e => e.OldPortionFactor)
                .HasPrecision(15, 5)
                .HasColumnName("old_portion_factor");
            entity.Property(e => e.OldRecipeId).HasColumnName("old_recipe_id");
            entity.Property(e => e.OldUnloadable).HasColumnName("old_unloadable");
            entity.Property(e => e.OldWarehouseArticleId).HasColumnName("old_warehouse_article_id");
            entity.Property(e => e.SaleArticleId).HasColumnName("sale_article_id");
            entity.Property(e => e.ScheduledJobId).HasColumnName("scheduled_job_id");
            entity.Property(e => e.SchedulingDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("scheduling_date");
            entity.Property(e => e.StartDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_date");

            entity.HasOne(d => d.NewRecipe).WithMany(p => p.SaleArticleLinksHistoryNewRecipes).HasForeignKey(d => d.NewRecipeId);

            entity.HasOne(d => d.NewWarehouseArticle).WithMany(p => p.SaleArticleLinksHistoryNewWarehouseArticles).HasForeignKey(d => d.NewWarehouseArticleId);

            entity.HasOne(d => d.OldRecipe).WithMany(p => p.SaleArticleLinksHistoryOldRecipes).HasForeignKey(d => d.OldRecipeId);

            entity.HasOne(d => d.OldWarehouseArticle).WithMany(p => p.SaleArticleLinksHistoryOldWarehouseArticles).HasForeignKey(d => d.OldWarehouseArticleId);

            entity.HasOne(d => d.SaleArticle).WithMany(p => p.SaleArticleLinksHistorySaleArticles).HasForeignKey(d => d.SaleArticleId);
        });

        modelBuilder.Entity<SaleHeading>(entity =>
        {
            entity.ToTable("sale_headings");

            entity.HasIndex(e => e.CurrencyId, "IX_sale_headings_currency_id");

            entity.HasIndex(e => e.CustomerId, "IX_sale_headings_customer_id");

            entity.HasIndex(e => e.PosId, "IX_sale_headings_pos_id");

            entity.HasIndex(e => e.ReferenceCustomerId, "IX_sale_headings_reference_customer_id");

            entity.HasIndex(e => e.SaleCausalId, "IX_sale_headings_sale_causal_id");

            entity.HasIndex(e => e.SalePriceListId, "IX_sale_headings_sale_price_list_id");

            entity.HasIndex(e => e.ShopId, "IX_sale_headings_shop_id");

            entity.HasIndex(e => e.TransactionDate, "IX_sale_headings_transaction_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountingDate).HasColumnName("accounting_date");
            entity.Property(e => e.Acquired).HasColumnName("acquired");
            entity.Property(e => e.BillStatus)
                .HasDefaultValue(3)
                .HasColumnName("bill_status");
            entity.Property(e => e.CardNum)
                .HasMaxLength(30)
                .HasColumnName("card_num");
            entity.Property(e => e.ClosingNum).HasColumnName("closing_num");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DeleteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("delete_date");
            entity.Property(e => e.DeleteOperatorId).HasColumnName("delete_operator_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DocumentExtCode)
                .HasMaxLength(50)
                .HasColumnName("document_ext_code");
            entity.Property(e => e.ExternalCausalCode)
                .HasMaxLength(20)
                .HasColumnName("external_causal_code");
            entity.Property(e => e.ExternalId).HasColumnName("external_id");
            entity.Property(e => e.FiscalCode)
                .HasMaxLength(30)
                .HasColumnName("fiscal_code");
            entity.Property(e => e.FiscalNum).HasColumnName("fiscal_num");
            entity.Property(e => e.InvoiceNum)
                .HasMaxLength(50)
                .HasColumnName("invoice_num");
            entity.Property(e => e.LotteryCode)
                .HasMaxLength(16)
                .HasColumnName("lottery_code");
            entity.Property(e => e.LunchTableId).HasColumnName("lunch_table_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .HasColumnName("notes");
            entity.Property(e => e.OperatorId).HasColumnName("operator_id");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.PosSerialNum)
                .HasMaxLength(8)
                .HasColumnName("pos_serial_num");
            entity.Property(e => e.PrinterSerialNum)
                .HasMaxLength(20)
                .HasColumnName("printer_serial_num");
            entity.Property(e => e.ReferenceCardNum)
                .HasMaxLength(30)
                .HasColumnName("reference_card_num");
            entity.Property(e => e.ReferenceCustomerId).HasColumnName("reference_customer_id");
            entity.Property(e => e.SaleCausalId).HasColumnName("sale_causal_id");
            entity.Property(e => e.SalePriceListId).HasColumnName("sale_price_list_id");
            entity.Property(e => e.SaleTypeId).HasColumnName("sale_type_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.SourceClosingNum).HasColumnName("source_closing_num");
            entity.Property(e => e.SourceFiscalNum).HasColumnName("source_fiscal_num");
            entity.Property(e => e.SourcePosSerialNum)
                .HasMaxLength(8)
                .HasColumnName("source_pos_serial_num");
            entity.Property(e => e.SourcePrinterSerialNum)
                .HasMaxLength(20)
                .HasColumnName("source_printer_serial_num");
            entity.Property(e => e.SourceTransactionDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("source_transaction_date");
            entity.Property(e => e.Suspended).HasColumnName("suspended");
            entity.Property(e => e.TotalAmount)
                .HasPrecision(15, 5)
                .HasColumnName("total_amount");
            entity.Property(e => e.TotalDiscounts)
                .HasPrecision(15, 5)
                .HasColumnName("total_discounts");
            entity.Property(e => e.TotalItems).HasColumnName("total_items");
            entity.Property(e => e.TotalNetAmount)
                .HasPrecision(15, 5)
                .HasColumnName("total_net_amount");
            entity.Property(e => e.TotalQuantity)
                .HasPrecision(15, 5)
                .HasColumnName("total_quantity");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("transaction_date");
            entity.Property(e => e.UseSplitPayment).HasColumnName("use_split_payment");

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleHeadings).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Customer).WithMany(p => p.SaleHeadingCustomers).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Pos).WithMany(p => p.SaleHeadings).HasForeignKey(d => d.PosId);

            entity.HasOne(d => d.ReferenceCustomer).WithMany(p => p.SaleHeadingReferenceCustomers).HasForeignKey(d => d.ReferenceCustomerId);

            entity.HasOne(d => d.SaleCausal).WithMany(p => p.SaleHeadings).HasForeignKey(d => d.SaleCausalId);

            entity.HasOne(d => d.SalePriceList).WithMany(p => p.SaleHeadings).HasForeignKey(d => d.SalePriceListId);

            entity.HasOne(d => d.Shop).WithMany(p => p.SaleHeadings).HasForeignKey(d => d.ShopId);
        });

        modelBuilder.Entity<SalePriceList>(entity =>
        {
            entity.ToTable("sale_price_lists");

            entity.HasIndex(e => e.Code, "IX_sale_price_lists_code").IsUnique();

            entity.HasIndex(e => e.CurrencyId, "IX_sale_price_lists_currency_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ValidityFrom).HasColumnName("validity_from");
            entity.Property(e => e.ValidityTo).HasColumnName("validity_to");

            entity.HasOne(d => d.Currency).WithMany(p => p.SalePriceLists).HasForeignKey(d => d.CurrencyId);
        });

        modelBuilder.Entity<SalePriceListDetail>(entity =>
        {
            entity.ToTable("sale_price_list_details");

            entity.HasIndex(e => e.ArticleId, "IX_sale_price_list_details_article_id");

            entity.HasIndex(e => e.SalePriceListId, "IX_sale_price_list_details_sale_price_list_id");

            entity.HasIndex(e => e.VatId, "IX_sale_price_list_details_vat_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.BundleAdditionalPrice)
                .HasPrecision(15, 5)
                .HasColumnName("bundle_additional_price");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.Price)
                .HasPrecision(15, 5)
                .HasColumnName("price");
            entity.Property(e => e.SalePriceListId).HasColumnName("sale_price_list_id");
            entity.Property(e => e.UpsellPrice)
                .HasPrecision(15, 5)
                .HasColumnName("upsell_price");
            entity.Property(e => e.ValidityFrom).HasColumnName("validity_from");
            entity.Property(e => e.ValidityTo).HasColumnName("validity_to");
            entity.Property(e => e.VatId).HasColumnName("vat_id");

            entity.HasOne(d => d.Article).WithMany(p => p.SalePriceListDetails).HasForeignKey(d => d.ArticleId);

            entity.HasOne(d => d.SalePriceList).WithMany(p => p.SalePriceListDetails).HasForeignKey(d => d.SalePriceListId);

            entity.HasOne(d => d.Vat).WithMany(p => p.SalePriceListDetails).HasForeignKey(d => d.VatId);
        });

        modelBuilder.Entity<SalePriceListDetailsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sale_price_list_details_view", "kiosk");

            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.BundleAdditionalPrice)
                .HasPrecision(15, 5)
                .HasColumnName("bundle_additional_price");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsValid).HasColumnName("is_valid");
            entity.Property(e => e.Price)
                .HasPrecision(15, 5)
                .HasColumnName("price");
            entity.Property(e => e.SalePriceListId).HasColumnName("sale_price_list_id");
            entity.Property(e => e.UpsellPrice)
                .HasPrecision(15, 5)
                .HasColumnName("upsell_price");
            entity.Property(e => e.ValidityFrom).HasColumnName("validity_from");
            entity.Property(e => e.ValidityTo).HasColumnName("validity_to");
            entity.Property(e => e.VatId).HasColumnName("vat_id");
        });

        modelBuilder.Entity<SalePriceListLink>(entity =>
        {
            entity.ToTable("sale_price_list_links");

            entity.HasIndex(e => e.PosId, "IX_sale_price_list_links_pos_id");

            entity.HasIndex(e => new { e.SalePriceListId, e.ShopId, e.PosId, e.ServiceTypeCode }, "IX_sale_price_list_links_sale_price_list_id_shop_id_pos_id_ser~")
                .IsUnique()
                .AreNullsDistinct(false);

            entity.HasIndex(e => e.ShopId, "IX_sale_price_list_links_shop_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.SalePriceListId).HasColumnName("sale_price_list_id");
            entity.Property(e => e.ServiceTypeCode).HasColumnName("service_type_code");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");

            entity.HasOne(d => d.Pos).WithMany(p => p.SalePriceListLinks).HasForeignKey(d => d.PosId);

            entity.HasOne(d => d.SalePriceList).WithMany(p => p.SalePriceListLinks).HasForeignKey(d => d.SalePriceListId);

            entity.HasOne(d => d.Shop).WithMany(p => p.SalePriceListLinks).HasForeignKey(d => d.ShopId);
        });

        modelBuilder.Entity<SalePriceListLinksStaging>(entity =>
        {
            entity.ToTable("sale_price_list_links_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PosCode).HasColumnName("pos_code");
            entity.Property(e => e.SalePriceListCode).HasColumnName("sale_price_list_code");
            entity.Property(e => e.ServiceTypeCode).HasColumnName("service_type_code");
            entity.Property(e => e.ShopCode).HasColumnName("shop_code");
        });

        modelBuilder.Entity<SalePriceListLinksView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sale_price_list_links_view", "kiosk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.SalePriceListId).HasColumnName("sale_price_list_id");
            entity.Property(e => e.ServiceTypeCode).HasColumnName("service_type_code");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
        });

        modelBuilder.Entity<SalePriceListsStaging>(entity =>
        {
            entity.ToTable("sale_price_lists_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleCode).HasColumnName("article_code");
            entity.Property(e => e.BundleAdditionalPrice).HasColumnName("bundle_additional_price");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CurrencyCode).HasColumnName("currency_code");
            entity.Property(e => e.DetailIsValid).HasColumnName("detail_is_valid");
            entity.Property(e => e.DetailValidityFrom).HasColumnName("detail_validity_from");
            entity.Property(e => e.DetailValidityTo).HasColumnName("detail_validity_to");
            entity.Property(e => e.HeadingIsValid).HasColumnName("heading_is_valid");
            entity.Property(e => e.HeadingValidityFrom).HasColumnName("heading_validity_from");
            entity.Property(e => e.HeadingValidityTo).HasColumnName("heading_validity_to");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.SalePriceListCode).HasColumnName("sale_price_list_code");
            entity.Property(e => e.UpsellPrice).HasColumnName("upsell_price");
            entity.Property(e => e.VatCode).HasColumnName("vat_code");
        });

        modelBuilder.Entity<SalePriceListsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sale_price_lists_view", "kiosk");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsValid).HasColumnName("is_valid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ValidityFrom).HasColumnName("validity_from");
            entity.Property(e => e.ValidityTo).HasColumnName("validity_to");
        });

        modelBuilder.Entity<SaleRow>(entity =>
        {
            entity.ToTable("sale_rows");

            entity.HasIndex(e => e.HeadingId, "IX_sale_rows_heading_id");

            entity.HasIndex(e => e.MeasUnitId, "IX_sale_rows_meas_unit_id");

            entity.HasIndex(e => e.SaleArticleId, "IX_sale_rows_sale_article_id");

            entity.HasIndex(e => e.SaleCausalId, "IX_sale_rows_sale_causal_id");

            entity.HasIndex(e => e.SalePriceListId, "IX_sale_rows_sale_price_list_id");

            entity.HasIndex(e => e.VatId, "IX_sale_rows_vat_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConversionFactor)
                .HasPrecision(15, 5)
                .HasColumnName("conversion_factor");
            entity.Property(e => e.DeleteOperatorId).HasColumnName("delete_operator_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DetailOrder).HasColumnName("detail_order");
            entity.Property(e => e.Discount)
                .HasPrecision(15, 5)
                .HasColumnName("discount");
            entity.Property(e => e.DontPrint).HasColumnName("dont_print");
            entity.Property(e => e.ExternalId).HasColumnName("external_id");
            entity.Property(e => e.HeadingId).HasColumnName("heading_id");
            entity.Property(e => e.MeasUnitId).HasColumnName("meas_unit_id");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.NetDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("net_discount");
            entity.Property(e => e.NetPrice)
                .HasPrecision(15, 5)
                .HasColumnName("net_price");
            entity.Property(e => e.Price)
                .HasPrecision(15, 5)
                .HasColumnName("price");
            entity.Property(e => e.PromotionDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("promotion_discount");
            entity.Property(e => e.PromotionNetDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("promotion_net_discount");
            entity.Property(e => e.Quantity)
                .HasPrecision(15, 5)
                .HasColumnName("quantity");
            entity.Property(e => e.ReferencePrice)
                .HasPrecision(15, 5)
                .HasColumnName("reference_price");
            entity.Property(e => e.RowNetTotalPrice)
                .HasPrecision(15, 5)
                .HasColumnName("row_net_total_price");
            entity.Property(e => e.RowTotalPrice)
                .HasPrecision(15, 5)
                .HasColumnName("row_total_price");
            entity.Property(e => e.RowType)
                .HasMaxLength(20)
                .HasColumnName("row_type");
            entity.Property(e => e.SaleArticleId).HasColumnName("sale_article_id");
            entity.Property(e => e.SaleCausalId).HasColumnName("sale_causal_id");
            entity.Property(e => e.SalePriceListId).HasColumnName("sale_price_list_id");
            entity.Property(e => e.SellerId).HasColumnName("seller_id");
            entity.Property(e => e.VatId).HasColumnName("vat_id");
            entity.Property(e => e.VatPercent)
                .HasPrecision(5, 3)
                .HasColumnName("vat_percent");

            entity.HasOne(d => d.Heading).WithMany(p => p.SaleRows).HasForeignKey(d => d.HeadingId);

            entity.HasOne(d => d.MeasUnit).WithMany(p => p.SaleRows).HasForeignKey(d => d.MeasUnitId);

            entity.HasOne(d => d.SaleArticle).WithMany(p => p.SaleRows).HasForeignKey(d => d.SaleArticleId);

            entity.HasOne(d => d.SaleCausal).WithMany(p => p.SaleRows).HasForeignKey(d => d.SaleCausalId);

            entity.HasOne(d => d.SalePriceList).WithMany(p => p.SaleRows).HasForeignKey(d => d.SalePriceListId);

            entity.HasOne(d => d.Vat).WithMany(p => p.SaleRows).HasForeignKey(d => d.VatId);
        });

        modelBuilder.Entity<SaleTransaction>(entity =>
        {
            entity.ToTable("sale_transactions");

            entity.HasIndex(e => e.ArticleId, "IX_sale_transactions_article_id");

            entity.HasIndex(e => e.CausalId, "IX_sale_transactions_causal_id");

            entity.HasIndex(e => e.CurrencyId, "IX_sale_transactions_currency_id");

            entity.HasIndex(e => e.DocumentStateId, "IX_sale_transactions_document_state_id");

            entity.HasIndex(e => e.ShopId, "IX_sale_transactions_shop_id");

            entity.HasIndex(e => e.TransactionDate, "IX_sale_transactions_transaction_date");

            entity.HasIndex(e => new { e.WarehouseId, e.ArticleId, e.TransactionDate }, "IX_sale_transactions_warehouse_id_article_id_transaction_date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.CausalId).HasColumnName("causal_id");
            entity.Property(e => e.Cost)
                .HasPrecision(15, 5)
                .HasColumnName("cost");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.DocumentDetailId).HasColumnName("document_detail_id");
            entity.Property(e => e.DocumentStateId).HasColumnName("document_state_id");
            entity.Property(e => e.Operator)
                .HasMaxLength(100)
                .HasColumnName("operator");
            entity.Property(e => e.Quantity)
                .HasPrecision(15, 5)
                .HasColumnName("quantity");
            entity.Property(e => e.RowTotalCost)
                .HasPrecision(15, 5)
                .HasColumnName("row_total_cost");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("transaction_date");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

            entity.HasOne(d => d.Article).WithMany(p => p.SaleTransactions)
                .HasForeignKey(d => d.ArticleId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Causal).WithMany(p => p.SaleTransactions)
                .HasForeignKey(d => d.CausalId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Currency).WithMany(p => p.SaleTransactions)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.DocumentState).WithMany(p => p.SaleTransactions)
                .HasForeignKey(d => d.DocumentStateId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Shop).WithMany(p => p.SaleTransactions)
                .HasForeignKey(d => d.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Warehouse).WithMany(p => p.SaleTransactions)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<ServiceTypesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("service_types_view", "kiosk");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("settings");

            entity.HasIndex(e => e.Key, "IX_settings_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Shop>(entity =>
        {
            entity.ToTable("shops");

            entity.HasIndex(e => e.AddressId, "IX_shops_address_id").IsUnique();

            entity.HasIndex(e => e.BrandId, "IX_shops_brand_id");

            entity.HasIndex(e => e.Code, "IX_shops_code").IsUnique();

            entity.HasIndex(e => e.CompanyId, "IX_shops_company_id");

            entity.HasIndex(e => e.CurrencyId, "IX_shops_currency_id");

            entity.HasIndex(e => e.ShopTypeId, "IX_shops_shop_type_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ShopTypeId).HasColumnName("shop_type_id");

            entity.HasOne(d => d.Address).WithOne(p => p.Shop).HasForeignKey<Shop>(d => d.AddressId);

            entity.HasOne(d => d.Brand).WithMany(p => p.Shops)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Company).WithMany(p => p.Shops).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Currency).WithMany(p => p.Shops)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ShopType).WithMany(p => p.Shops).HasForeignKey(d => d.ShopTypeId);

            entity.HasMany(d => d.ShopGroups).WithMany(p => p.Shops)
                .UsingEntity<Dictionary<string, object>>(
                    "ShopShopGroupLink",
                    r => r.HasOne<ShopGroup>().WithMany()
                        .HasForeignKey("ShopGroupId")
                        .OnDelete(DeleteBehavior.Restrict),
                    l => l.HasOne<Shop>().WithMany().HasForeignKey("ShopId"),
                    j =>
                    {
                        j.HasKey("ShopId", "ShopGroupId");
                        j.ToTable("shop_shop_group_links");
                        j.HasIndex(new[] { "ShopGroupId" }, "IX_shop_shop_group_links_shop_group_id");
                        j.IndexerProperty<int>("ShopId").HasColumnName("shop_id");
                        j.IndexerProperty<int>("ShopGroupId").HasColumnName("shop_group_id");
                    });
        });

        modelBuilder.Entity<ShopGroup>(entity =>
        {
            entity.ToTable("shop_groups");

            entity.HasIndex(e => e.Code, "IX_shop_groups_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ShopStaging>(entity =>
        {
            entity.ToTable("shop_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandCode).HasColumnName("brand_code");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CurrencyCode).HasColumnName("currency_code");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<ShopType>(entity =>
        {
            entity.ToTable("shop_types");

            entity.HasIndex(e => e.Code, "IX_shop_types_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ShopWarehouse>(entity =>
        {
            entity.ToTable("shop_warehouses");

            entity.HasIndex(e => e.Code, "IX_shop_warehouses_code").IsUnique();

            entity.HasIndex(e => e.ShopId, "IX_shop_warehouses_shop_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.IsValid).HasColumnName("is_valid");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");

            entity.HasOne(d => d.Shop).WithMany(p => p.ShopWarehouses).HasForeignKey(d => d.ShopId);
        });

        modelBuilder.Entity<ShopsFidelityDatum>(entity =>
        {
            entity.HasKey(e => e.ShopId);

            entity.ToTable("shops_fidelity_data");

            entity.Property(e => e.ShopId)
                .ValueGeneratedNever()
                .HasColumnName("shop_id");
            entity.Property(e => e.ShowInShopLocator)
                .HasDefaultValue(true)
                .HasColumnName("show_in_shop_locator");

            entity.HasOne(d => d.Shop).WithOne(p => p.ShopsFidelityDatum).HasForeignKey<ShopsFidelityDatum>(d => d.ShopId);
        });

        modelBuilder.Entity<ShopsFiscal>(entity =>
        {
            entity.HasKey(e => e.ShopId);

            entity.ToTable("shops_fiscal");

            entity.Property(e => e.ShopId)
                .ValueGeneratedNever()
                .HasColumnName("shop_id");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(100)
                .HasColumnName("business_name");
            entity.Property(e => e.FiscalCode)
                .HasMaxLength(20)
                .HasColumnName("fiscal_code");
            entity.Property(e => e.Sdi)
                .HasMaxLength(10)
                .HasColumnName("sdi");
            entity.Property(e => e.VatNumber)
                .HasMaxLength(20)
                .HasColumnName("vat_number");

            entity.HasOne(d => d.Shop).WithOne(p => p.ShopsFiscal).HasForeignKey<ShopsFiscal>(d => d.ShopId);
        });

        modelBuilder.Entity<ShopsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("shops_view", "kiosk");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SsvDocumentsHeadingsReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ssv_documents_headings_report");

            entity.Property(e => e.BankAccount).HasColumnName("bank_account");
            entity.Property(e => e.BankAccountId).HasColumnName("bank_account_id");
            entity.Property(e => e.BankName).HasColumnName("bank_name");
            entity.Property(e => e.Change)
                .HasPrecision(15, 5)
                .HasColumnName("change");
            entity.Property(e => e.ChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("change_date");
            entity.Property(e => e.CompanyBankAccount).HasColumnName("company_bank_account");
            entity.Property(e => e.CompanyBankAccountId).HasColumnName("company_bank_account_id");
            entity.Property(e => e.CompanyBankName).HasColumnName("company_bank_name");
            entity.Property(e => e.CompanyCity)
                .HasMaxLength(50)
                .HasColumnName("company_city");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(20)
                .HasColumnName("company_code");
            entity.Property(e => e.CompanyCountry)
                .HasMaxLength(50)
                .HasColumnName("company_country");
            entity.Property(e => e.CompanyDesc)
                .HasMaxLength(50)
                .HasColumnName("company_desc");
            entity.Property(e => e.CompanyEmail)
                .HasMaxLength(50)
                .HasColumnName("company_email");
            entity.Property(e => e.CompanyFax).HasColumnName("company_fax");
            entity.Property(e => e.CompanyFiscalCodeA).HasColumnName("company_fiscal_code_a");
            entity.Property(e => e.CompanyFiscalCodeB).HasColumnName("company_fiscal_code_b");
            entity.Property(e => e.CompanyHeadquarters).HasColumnName("company_headquarters");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CompanyInternet)
                .HasMaxLength(100)
                .HasColumnName("company_internet");
            entity.Property(e => e.CompanyNation)
                .HasMaxLength(20)
                .HasColumnName("company_nation");
            entity.Property(e => e.CompanyNotes).HasColumnName("company_notes");
            entity.Property(e => e.CompanyPhoneA)
                .HasMaxLength(20)
                .HasColumnName("company_phone_a");
            entity.Property(e => e.CompanyPhoneB)
                .HasMaxLength(20)
                .HasColumnName("company_phone_b");
            entity.Property(e => e.CompanyStreet)
                .HasMaxLength(100)
                .HasColumnName("company_street");
            entity.Property(e => e.CompanyTypeCode).HasColumnName("company_type_code");
            entity.Property(e => e.CompanyTypeDescription).HasColumnName("company_type_description");
            entity.Property(e => e.CompanyTypeId).HasColumnName("company_type_id");
            entity.Property(e => e.CompanyZipCode)
                .HasMaxLength(10)
                .HasColumnName("company_zip_code");
            entity.Property(e => e.Conclused).HasColumnName("conclused");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(20)
                .HasColumnName("currency_code");
            entity.Property(e => e.CurrencyDesc)
                .HasMaxLength(50)
                .HasColumnName("currency_desc");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.CustomerCity)
                .HasMaxLength(50)
                .HasColumnName("customer_city");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(20)
                .HasColumnName("customer_code");
            entity.Property(e => e.CustomerCountry)
                .HasMaxLength(50)
                .HasColumnName("customer_country");
            entity.Property(e => e.CustomerDesc)
                .HasMaxLength(50)
                .HasColumnName("customer_desc");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(50)
                .HasColumnName("customer_email");
            entity.Property(e => e.CustomerFax).HasColumnName("customer_fax");
            entity.Property(e => e.CustomerFiscalCodeA).HasColumnName("customer_fiscal_code_a");
            entity.Property(e => e.CustomerFiscalCodeB).HasColumnName("customer_fiscal_code_b");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerInternet)
                .HasMaxLength(100)
                .HasColumnName("customer_internet");
            entity.Property(e => e.CustomerInvoiceAddress).HasColumnName("customer_invoice_address");
            entity.Property(e => e.CustomerNation)
                .HasMaxLength(20)
                .HasColumnName("customer_nation");
            entity.Property(e => e.CustomerNotes).HasColumnName("customer_notes");
            entity.Property(e => e.CustomerPhoneA)
                .HasMaxLength(20)
                .HasColumnName("customer_phone_a");
            entity.Property(e => e.CustomerPhoneB)
                .HasMaxLength(20)
                .HasColumnName("customer_phone_b");
            entity.Property(e => e.CustomerPrintPrice).HasColumnName("customer_print_price");
            entity.Property(e => e.CustomerStreet)
                .HasMaxLength(100)
                .HasColumnName("customer_street");
            entity.Property(e => e.CustomerZipCode)
                .HasMaxLength(10)
                .HasColumnName("customer_zip_code");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("delivery_date");
            entity.Property(e => e.DeliveryDescription).HasColumnName("delivery_description");
            entity.Property(e => e.DeliveryItems).HasColumnName("delivery_items");
            entity.Property(e => e.DeliveryWeight)
                .HasPrecision(15, 5)
                .HasColumnName("delivery_weight");
            entity.Property(e => e.DocumentCausalCode)
                .HasMaxLength(20)
                .HasColumnName("document_causal_code");
            entity.Property(e => e.DocumentCausalDesc)
                .HasMaxLength(50)
                .HasColumnName("document_causal_desc");
            entity.Property(e => e.DocumentCausalId).HasColumnName("document_causal_id");
            entity.Property(e => e.DocumentCode).HasColumnName("document_code");
            entity.Property(e => e.DocumentDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("document_date");
            entity.Property(e => e.DocumentExtCode)
                .HasMaxLength(20)
                .HasColumnName("document_ext_code");
            entity.Property(e => e.DocumentStateCode)
                .HasMaxLength(20)
                .HasColumnName("document_state_code");
            entity.Property(e => e.DocumentStateDesc)
                .HasMaxLength(50)
                .HasColumnName("document_state_desc");
            entity.Property(e => e.DocumentStateId).HasColumnName("document_state_id");
            entity.Property(e => e.DocumentTypeCode)
                .HasMaxLength(20)
                .HasColumnName("document_type_code");
            entity.Property(e => e.DocumentTypeDesc)
                .HasColumnType("character varying")
                .HasColumnName("document_type_desc");
            entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");
            entity.Property(e => e.DocumentYear).HasColumnName("document_year");
            entity.Property(e => e.FromWarehouseCode).HasColumnName("from_warehouse_code");
            entity.Property(e => e.FromWarehouseDesc).HasColumnName("from_warehouse_desc");
            entity.Property(e => e.FromWarehouseId).HasColumnName("from_warehouse_id");
            entity.Property(e => e.GrossAmount).HasColumnName("gross_amount");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NetAmount).HasColumnName("net_amount");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.NumberOfRows).HasColumnName("number_of_rows");
            entity.Property(e => e.OperatorCode)
                .HasMaxLength(100)
                .HasColumnName("operator_code");
            entity.Property(e => e.OperatorDesc)
                .HasMaxLength(100)
                .HasColumnName("operator_desc");
            entity.Property(e => e.OperatorId)
                .HasMaxLength(100)
                .HasColumnName("operator_id");
            entity.Property(e => e.ParentCompanyCity).HasColumnName("parent_company_city");
            entity.Property(e => e.ParentCompanyCode).HasColumnName("parent_company_code");
            entity.Property(e => e.ParentCompanyCountry).HasColumnName("parent_company_country");
            entity.Property(e => e.ParentCompanyDesc).HasColumnName("parent_company_desc");
            entity.Property(e => e.ParentCompanyEmail).HasColumnName("parent_company_email");
            entity.Property(e => e.ParentCompanyFax).HasColumnName("parent_company_fax");
            entity.Property(e => e.ParentCompanyFiscalCodeA).HasColumnName("parent_company_fiscal_code_a");
            entity.Property(e => e.ParentCompanyFiscalCodeB).HasColumnName("parent_company_fiscal_code_b");
            entity.Property(e => e.ParentCompanyHeadquarters).HasColumnName("parent_company_headquarters");
            entity.Property(e => e.ParentCompanyId).HasColumnName("parent_company_id");
            entity.Property(e => e.ParentCompanyInternet).HasColumnName("parent_company_internet");
            entity.Property(e => e.ParentCompanyNation).HasColumnName("parent_company_nation");
            entity.Property(e => e.ParentCompanyNotes).HasColumnName("parent_company_notes");
            entity.Property(e => e.ParentCompanyPhoneA).HasColumnName("parent_company_phone_a");
            entity.Property(e => e.ParentCompanyPhoneB).HasColumnName("parent_company_phone_b");
            entity.Property(e => e.ParentCompanyStreet).HasColumnName("parent_company_street");
            entity.Property(e => e.ParentCompanyZipCode).HasColumnName("parent_company_zip_code");
            entity.Property(e => e.PaymentCode).HasColumnName("payment_code");
            entity.Property(e => e.PaymentConditionId).HasColumnName("payment_condition_id");
            entity.Property(e => e.PaymentDesc).HasColumnName("payment_desc");
            entity.Property(e => e.PercentualADiscount)
                .HasPrecision(15, 5)
                .HasColumnName("percentual_a_discount");
            entity.Property(e => e.PercentualBDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("percentual_b_discount");
            entity.Property(e => e.PercentualCDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("percentual_c_discount");
            entity.Property(e => e.PosCode)
                .HasMaxLength(20)
                .HasColumnName("pos_code");
            entity.Property(e => e.PosDesc)
                .HasMaxLength(50)
                .HasColumnName("pos_desc");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.RefCustomerCity).HasColumnName("ref_customer_city");
            entity.Property(e => e.RefCustomerCode).HasColumnName("ref_customer_code");
            entity.Property(e => e.RefCustomerCountry).HasColumnName("ref_customer_country");
            entity.Property(e => e.RefCustomerDesc).HasColumnName("ref_customer_desc");
            entity.Property(e => e.RefCustomerEmail).HasColumnName("ref_customer_email");
            entity.Property(e => e.RefCustomerFax).HasColumnName("ref_customer_fax");
            entity.Property(e => e.RefCustomerFiscalCodeA).HasColumnName("ref_customer_fiscal_code_a");
            entity.Property(e => e.RefCustomerFiscalCodeB).HasColumnName("ref_customer_fiscal_code_b");
            entity.Property(e => e.RefCustomerInternet).HasColumnName("ref_customer_internet");
            entity.Property(e => e.RefCustomerInvoiceAddress).HasColumnName("ref_customer_invoice_address");
            entity.Property(e => e.RefCustomerNation).HasColumnName("ref_customer_nation");
            entity.Property(e => e.RefCustomerNotes).HasColumnName("ref_customer_notes");
            entity.Property(e => e.RefCustomerPhoneA).HasColumnName("ref_customer_phone_a");
            entity.Property(e => e.RefCustomerPhoneB).HasColumnName("ref_customer_phone_b");
            entity.Property(e => e.RefCustomerPrintPrice).HasColumnName("ref_customer_print_price");
            entity.Property(e => e.RefCustomerStreet).HasColumnName("ref_customer_street");
            entity.Property(e => e.RefCustomerZipCode).HasColumnName("ref_customer_zip_code");
            entity.Property(e => e.RefSupplierCity)
                .HasMaxLength(50)
                .HasColumnName("ref_supplier_city");
            entity.Property(e => e.RefSupplierCode)
                .HasMaxLength(20)
                .HasColumnName("ref_supplier_code");
            entity.Property(e => e.RefSupplierCountry)
                .HasMaxLength(50)
                .HasColumnName("ref_supplier_country");
            entity.Property(e => e.RefSupplierDesc)
                .HasMaxLength(50)
                .HasColumnName("ref_supplier_desc");
            entity.Property(e => e.RefSupplierEmail)
                .HasMaxLength(50)
                .HasColumnName("ref_supplier_email");
            entity.Property(e => e.RefSupplierFax).HasColumnName("ref_supplier_fax");
            entity.Property(e => e.RefSupplierFiscalCodeA).HasColumnName("ref_supplier_fiscal_code_a");
            entity.Property(e => e.RefSupplierFiscalCodeB).HasColumnName("ref_supplier_fiscal_code_b");
            entity.Property(e => e.RefSupplierInternet)
                .HasMaxLength(100)
                .HasColumnName("ref_supplier_internet");
            entity.Property(e => e.RefSupplierInvoiceAddress).HasColumnName("ref_supplier_invoice_address");
            entity.Property(e => e.RefSupplierNation)
                .HasMaxLength(20)
                .HasColumnName("ref_supplier_nation");
            entity.Property(e => e.RefSupplierNotes)
                .HasMaxLength(255)
                .HasColumnName("ref_supplier_notes");
            entity.Property(e => e.RefSupplierPhoneA)
                .HasMaxLength(20)
                .HasColumnName("ref_supplier_phone_a");
            entity.Property(e => e.RefSupplierPhoneB)
                .HasMaxLength(20)
                .HasColumnName("ref_supplier_phone_b");
            entity.Property(e => e.RefSupplierStreet)
                .HasMaxLength(100)
                .HasColumnName("ref_supplier_street");
            entity.Property(e => e.RefSupplierZipCode)
                .HasMaxLength(10)
                .HasColumnName("ref_supplier_zip_code");
            entity.Property(e => e.ReferenceCustomerId).HasColumnName("reference_customer_id");
            entity.Property(e => e.ReferenceSupplierId).HasColumnName("reference_supplier_id");
            entity.Property(e => e.RegistrationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("registration_date");
            entity.Property(e => e.RegistrationDateDesc).HasColumnName("registration_date_desc");
            entity.Property(e => e.RowsConclused).HasColumnName("rows_conclused");
            entity.Property(e => e.ShopCity)
                .HasMaxLength(50)
                .HasColumnName("shop_city");
            entity.Property(e => e.ShopCode)
                .HasMaxLength(20)
                .HasColumnName("shop_code");
            entity.Property(e => e.ShopCountry)
                .HasMaxLength(50)
                .HasColumnName("shop_country");
            entity.Property(e => e.ShopDescription)
                .HasMaxLength(50)
                .HasColumnName("shop_description");
            entity.Property(e => e.ShopEmail)
                .HasMaxLength(50)
                .HasColumnName("shop_email");
            entity.Property(e => e.ShopFax).HasColumnName("shop_fax");
            entity.Property(e => e.ShopFiscalCodeA).HasColumnName("shop_fiscal_code_a");
            entity.Property(e => e.ShopFiscalCodeB).HasColumnName("shop_fiscal_code_b");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.ShopInternet)
                .HasMaxLength(100)
                .HasColumnName("shop_internet");
            entity.Property(e => e.ShopNation)
                .HasMaxLength(20)
                .HasColumnName("shop_nation");
            entity.Property(e => e.ShopNotes).HasColumnName("shop_notes");
            entity.Property(e => e.ShopPhoneA)
                .HasMaxLength(20)
                .HasColumnName("shop_phone_a");
            entity.Property(e => e.ShopPhoneB)
                .HasMaxLength(20)
                .HasColumnName("shop_phone_b");
            entity.Property(e => e.ShopReaCode).HasColumnName("shop_rea_code");
            entity.Property(e => e.ShopReaProgr).HasColumnName("shop_rea_progr");
            entity.Property(e => e.ShopStreet)
                .HasMaxLength(100)
                .HasColumnName("shop_street");
            entity.Property(e => e.ShopZipCode)
                .HasMaxLength(10)
                .HasColumnName("shop_zip_code");
            entity.Property(e => e.SupplierCity)
                .HasMaxLength(50)
                .HasColumnName("supplier_city");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(20)
                .HasColumnName("supplier_code");
            entity.Property(e => e.SupplierCountry)
                .HasMaxLength(50)
                .HasColumnName("supplier_country");
            entity.Property(e => e.SupplierDesc)
                .HasMaxLength(50)
                .HasColumnName("supplier_desc");
            entity.Property(e => e.SupplierEmail)
                .HasMaxLength(50)
                .HasColumnName("supplier_email");
            entity.Property(e => e.SupplierFax).HasColumnName("supplier_fax");
            entity.Property(e => e.SupplierFiscalCodeA).HasColumnName("supplier_fiscal_code_a");
            entity.Property(e => e.SupplierFiscalCodeB).HasColumnName("supplier_fiscal_code_b");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.SupplierInternet)
                .HasMaxLength(100)
                .HasColumnName("supplier_internet");
            entity.Property(e => e.SupplierInvoiceAddress).HasColumnName("supplier_invoice_address");
            entity.Property(e => e.SupplierNation)
                .HasMaxLength(20)
                .HasColumnName("supplier_nation");
            entity.Property(e => e.SupplierNotes)
                .HasMaxLength(255)
                .HasColumnName("supplier_notes");
            entity.Property(e => e.SupplierPhoneA)
                .HasMaxLength(20)
                .HasColumnName("supplier_phone_a");
            entity.Property(e => e.SupplierPhoneB)
                .HasMaxLength(20)
                .HasColumnName("supplier_phone_b");
            entity.Property(e => e.SupplierStreet)
                .HasMaxLength(100)
                .HasColumnName("supplier_street");
            entity.Property(e => e.SupplierZipCode)
                .HasMaxLength(10)
                .HasColumnName("supplier_zip_code");
            entity.Property(e => e.ToCompanyCity)
                .HasMaxLength(50)
                .HasColumnName("to_company_city");
            entity.Property(e => e.ToCompanyCode)
                .HasMaxLength(20)
                .HasColumnName("to_company_code");
            entity.Property(e => e.ToCompanyCountry)
                .HasMaxLength(50)
                .HasColumnName("to_company_country");
            entity.Property(e => e.ToCompanyDesc)
                .HasMaxLength(50)
                .HasColumnName("to_company_desc");
            entity.Property(e => e.ToCompanyEmail)
                .HasMaxLength(50)
                .HasColumnName("to_company_email");
            entity.Property(e => e.ToCompanyFax).HasColumnName("to_company_fax");
            entity.Property(e => e.ToCompanyFiscalCodeA).HasColumnName("to_company_fiscal_code_a");
            entity.Property(e => e.ToCompanyFiscalCodeB).HasColumnName("to_company_fiscal_code_b");
            entity.Property(e => e.ToCompanyHeadquarters).HasColumnName("to_company_headquarters");
            entity.Property(e => e.ToCompanyInternet)
                .HasMaxLength(100)
                .HasColumnName("to_company_internet");
            entity.Property(e => e.ToCompanyNation)
                .HasMaxLength(20)
                .HasColumnName("to_company_nation");
            entity.Property(e => e.ToCompanyNotes).HasColumnName("to_company_notes");
            entity.Property(e => e.ToCompanyPhoneA)
                .HasMaxLength(20)
                .HasColumnName("to_company_phone_a");
            entity.Property(e => e.ToCompanyPhoneB)
                .HasMaxLength(20)
                .HasColumnName("to_company_phone_b");
            entity.Property(e => e.ToCompanyStreet)
                .HasMaxLength(100)
                .HasColumnName("to_company_street");
            entity.Property(e => e.ToCompanyZipCode)
                .HasMaxLength(10)
                .HasColumnName("to_company_zip_code");
            entity.Property(e => e.ToWarehouseCode).HasColumnName("to_warehouse_code");
            entity.Property(e => e.ToWarehouseDesc).HasColumnName("to_warehouse_desc");
            entity.Property(e => e.ToWarehouseId).HasColumnName("to_warehouse_id");
            entity.Property(e => e.UseSplitPayment).HasColumnName("use_split_payment");
            entity.Property(e => e.ValidationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("validation_date");
            entity.Property(e => e.ValueDiscount)
                .HasPrecision(15, 5)
                .HasColumnName("value_discount");
            entity.Property(e => e.VatAmount).HasColumnName("vat_amount");
        });

        modelBuilder.Entity<SsvSaleCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ssv_sale_categories");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(20)
                .HasColumnName("account_code");
            entity.Property(e => e.AccountType).HasColumnName("account_type");
            entity.Property(e => e.AccountingDate).HasColumnName("accounting_date");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.LastExportDate).HasColumnName("last_export_date");
            entity.Property(e => e.NetAmount).HasColumnName("net_amount");
            entity.Property(e => e.ShopCode)
                .HasMaxLength(20)
                .HasColumnName("shop_code");
            entity.Property(e => e.ShopDesc)
                .HasMaxLength(50)
                .HasColumnName("shop_desc");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
        });

        modelBuilder.Entity<SsvSalePayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ssv_sale_payments");

            entity.Property(e => e.AccountingDate).HasColumnName("accounting_date");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.LastExportDate).HasColumnName("last_export_date");
            entity.Property(e => e.PaymentCode).HasColumnName("payment_code");
            entity.Property(e => e.PaymentDesc).HasColumnName("payment_desc");
            entity.Property(e => e.PaymentNotes).HasColumnName("payment_notes");
            entity.Property(e => e.ShopCode)
                .HasMaxLength(20)
                .HasColumnName("shop_code");
            entity.Property(e => e.ShopDesc)
                .HasMaxLength(50)
                .HasColumnName("shop_desc");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
        });

        modelBuilder.Entity<SsvSaleReportsRound>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ssv_sale_reports_round");

            entity.Property(e => e.AccountingDate).HasColumnName("accounting_date");
            entity.Property(e => e.Acronym)
                .HasMaxLength(20)
                .HasColumnName("acronym");
            entity.Property(e => e.AnnullDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("annull_date");
            entity.Property(e => e.Annulled).HasColumnName("annulled");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.ArticleNotes)
                .HasMaxLength(100)
                .HasColumnName("article_notes");
            entity.Property(e => e.BillPrice).HasColumnName("bill_price");
            entity.Property(e => e.BillStatus).HasColumnName("bill_status");
            entity.Property(e => e.CardNum)
                .HasMaxLength(30)
                .HasColumnName("card_num");
            entity.Property(e => e.Change)
                .HasPrecision(15, 5)
                .HasColumnName("change");
            entity.Property(e => e.ChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("change_date");
            entity.Property(e => e.ClosingNum).HasColumnName("closing_num");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.ConversionFactor)
                .HasPrecision(15, 5)
                .HasColumnName("conversion_factor");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(20)
                .HasColumnName("customer_code");
            entity.Property(e => e.CustomerDesc)
                .HasMaxLength(50)
                .HasColumnName("customer_desc");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DeleteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("delete_date");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.DetailDeleted).HasColumnName("detail_deleted");
            entity.Property(e => e.DetailOrder).HasColumnName("detail_order");
            entity.Property(e => e.DetailSaleCausalCode)
                .HasMaxLength(20)
                .HasColumnName("detail_sale_causal_code");
            entity.Property(e => e.DetailSaleCausalDesc)
                .HasMaxLength(50)
                .HasColumnName("detail_sale_causal_desc");
            entity.Property(e => e.DetailSaleCausalId).HasColumnName("detail_sale_causal_id");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.DiscountedRowTotalPrice).HasColumnName("discounted_row_total_price");
            entity.Property(e => e.ExcludeOnStatistics).HasColumnName("exclude_on_statistics");
            entity.Property(e => e.FiscalNum).HasColumnName("fiscal_num");
            entity.Property(e => e.GroupLevel1Desc).HasColumnName("group_level_1_desc");
            entity.Property(e => e.GroupLevel1Id).HasColumnName("group_level_1_id");
            entity.Property(e => e.GroupLevel2Desc).HasColumnName("group_level_2_desc");
            entity.Property(e => e.GroupLevel2Id).HasColumnName("group_level_2_id");
            entity.Property(e => e.GroupLevel3Desc).HasColumnName("group_level_3_desc");
            entity.Property(e => e.GroupLevel3Id).HasColumnName("group_level_3_id");
            entity.Property(e => e.GroupLevel4Desc).HasColumnName("group_level_4_desc");
            entity.Property(e => e.GroupLevel4Id).HasColumnName("group_level_4_id");
            entity.Property(e => e.GroupLevel5Desc).HasColumnName("group_level_5_desc");
            entity.Property(e => e.GroupLevel5Id).HasColumnName("group_level_5_id");
            entity.Property(e => e.HeadingId).HasColumnName("heading_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InvoiceNum)
                .HasMaxLength(50)
                .HasColumnName("invoice_num");
            entity.Property(e => e.MeasUnit)
                .HasMaxLength(50)
                .HasColumnName("meas_unit");
            entity.Property(e => e.MeasUnitCode)
                .HasMaxLength(20)
                .HasColumnName("meas_unit_code");
            entity.Property(e => e.MenuCode).HasColumnName("menu_code");
            entity.Property(e => e.MenuDesc).HasColumnName("menu_desc");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.NetDiscount).HasColumnName("net_discount");
            entity.Property(e => e.NetPrice).HasColumnName("net_price");
            entity.Property(e => e.NetRowPrice).HasColumnName("net_row_price");
            entity.Property(e => e.NetRowPriceRound).HasColumnName("net_row_price_round");
            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .HasColumnName("notes");
            entity.Property(e => e.OperatorCode).HasColumnName("operator_code");
            entity.Property(e => e.OperatorDesc).HasColumnName("operator_desc");
            entity.Property(e => e.OperatorDescription).HasColumnName("operator_description");
            entity.Property(e => e.OperatorId).HasColumnName("operator_id");
            entity.Property(e => e.PosCode)
                .HasMaxLength(20)
                .HasColumnName("pos_code");
            entity.Property(e => e.PosDesc).HasColumnName("pos_desc");
            entity.Property(e => e.PosDescription)
                .HasMaxLength(50)
                .HasColumnName("pos_description");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.PosNotes).HasColumnName("pos_notes");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PriceListPrice).HasColumnName("price_list_price");
            entity.Property(e => e.PromotionDiscount).HasColumnName("promotion_discount");
            entity.Property(e => e.PromotionNetDiscount).HasColumnName("promotion_net_discount");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ReceiptNum).HasColumnName("receipt_num");
            entity.Property(e => e.ReferenceCustomerId).HasColumnName("reference_customer_id");
            entity.Property(e => e.ReferenceId).HasColumnName("reference_id");
            entity.Property(e => e.RowTotalPrice).HasColumnName("row_total_price");
            entity.Property(e => e.RowType)
                .HasMaxLength(20)
                .HasColumnName("row_type");
            entity.Property(e => e.RowVat).HasColumnName("row_vat");
            entity.Property(e => e.RowVatRound).HasColumnName("row_vat_round");
            entity.Property(e => e.SaleArticleId).HasColumnName("sale_article_id");
            entity.Property(e => e.SaleCausalCode)
                .HasMaxLength(20)
                .HasColumnName("sale_causal_code");
            entity.Property(e => e.SaleCausalDesc)
                .HasMaxLength(50)
                .HasColumnName("sale_causal_desc");
            entity.Property(e => e.SaleCausalId).HasColumnName("sale_causal_id");
            entity.Property(e => e.SalePaymentId).HasColumnName("sale_payment_id");
            entity.Property(e => e.SalePriceListCode)
                .HasMaxLength(20)
                .HasColumnName("sale_price_list_code");
            entity.Property(e => e.SalePriceListDesc)
                .HasMaxLength(50)
                .HasColumnName("sale_price_list_desc");
            entity.Property(e => e.SalePriceListId).HasColumnName("sale_price_list_id");
            entity.Property(e => e.SaleTypeCode).HasColumnName("sale_type_code");
            entity.Property(e => e.SaleTypeDesc).HasColumnName("sale_type_desc");
            entity.Property(e => e.SaleTypeId).HasColumnName("sale_type_id");
            entity.Property(e => e.SellerCode).HasColumnName("seller_code");
            entity.Property(e => e.SellerDesc).HasColumnName("seller_desc");
            entity.Property(e => e.SellerDescription).HasColumnName("seller_description");
            entity.Property(e => e.SellerId).HasColumnName("seller_id");
            entity.Property(e => e.ShopCode)
                .HasMaxLength(20)
                .HasColumnName("shop_code");
            entity.Property(e => e.ShopDesc).HasColumnName("shop_desc");
            entity.Property(e => e.ShopDescription)
                .HasMaxLength(50)
                .HasColumnName("shop_description");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.ShopNotes).HasColumnName("shop_notes");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("transaction_date");
            entity.Property(e => e.TransactionNum).HasColumnName("transaction_num");
            entity.Property(e => e.TruncAnnullDate).HasColumnName("trunc_annull_date");
            entity.Property(e => e.TruncDeleteDate).HasColumnName("trunc_delete_date");
            entity.Property(e => e.UnloadWarehouseCode).HasColumnName("unload_warehouse_code");
            entity.Property(e => e.UnloadWarehouseDesc).HasColumnName("unload_warehouse_desc");
            entity.Property(e => e.UnloadWarehouseDescription).HasColumnName("unload_warehouse_description");
            entity.Property(e => e.UnloadWarehouseId).HasColumnName("unload_warehouse_id");
            entity.Property(e => e.Vat)
                .HasMaxLength(50)
                .HasColumnName("vat");
            entity.Property(e => e.VatCode)
                .HasMaxLength(20)
                .HasColumnName("vat_code");
            entity.Property(e => e.VatId).HasColumnName("vat_id");
            entity.Property(e => e.VatPercent).HasColumnName("vat_percent");
            entity.Property(e => e.WarehouseArticleCode)
                .HasMaxLength(20)
                .HasColumnName("warehouse_article_code");
            entity.Property(e => e.WarehouseArticleDesc)
                .HasMaxLength(50)
                .HasColumnName("warehouse_article_desc");
        });

        modelBuilder.Entity<StagingLog>(entity =>
        {
            entity.ToTable("staging_logs", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EntityKey)
                .HasMaxLength(500)
                .HasColumnName("entity_key");
            entity.Property(e => e.EntityType)
                .HasMaxLength(30)
                .HasColumnName("entity_type");
            entity.Property(e => e.InsertTs)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("insert_ts");
            entity.Property(e => e.IsError).HasColumnName("is_error");
            entity.Property(e => e.LogMessage)
                .HasMaxLength(2000)
                .HasColumnName("log_message");
            entity.Property(e => e.Notified).HasColumnName("notified");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.ToTable("stocks");

            entity.HasIndex(e => new { e.ArticleId, e.WarehouseId }, "IX_stocks_article_id_warehouse_id").IsUnique();

            entity.HasIndex(e => e.WarehouseId, "IX_stocks_warehouse_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Deleter).HasColumnName("deleter");
            entity.Property(e => e.DeletionTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deletion_time");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

            entity.HasOne(d => d.Article).WithMany(p => p.Stocks).HasForeignKey(d => d.ArticleId);

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<StockField>(entity =>
        {
            entity.ToTable("stock_fields");

            entity.HasIndex(e => e.Code, "IX_stock_fields_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.IsActualQuantityField).HasColumnName("is_actual_quantity_field");
            entity.Property(e => e.IsCostField).HasColumnName("is_cost_field");
            entity.Property(e => e.IsSystem).HasColumnName("is_system");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Type)
                .HasDefaultValue(1)
                .HasColumnName("type");
            entity.Property(e => e.VisibilityLevel).HasColumnName("visibility_level");
        });

        modelBuilder.Entity<StockValue>(entity =>
        {
            entity.ToTable("stock_values");

            entity.HasIndex(e => e.StockFieldId, "IX_stock_values_stock_field_id");

            entity.HasIndex(e => new { e.StockId, e.StockFieldId }, "IX_stock_values_stock_id_stock_field_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_update_date");
            entity.Property(e => e.OperationsCount).HasColumnName("operations_count");
            entity.Property(e => e.StockFieldId).HasColumnName("stock_field_id");
            entity.Property(e => e.StockId).HasColumnName("stock_id");
            entity.Property(e => e.Value)
                .HasPrecision(15, 5)
                .HasColumnName("value");

            entity.HasOne(d => d.StockField).WithMany(p => p.StockValues)
                .HasForeignKey(d => d.StockFieldId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Stock).WithMany(p => p.StockValues).HasForeignKey(d => d.StockId);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("suppliers");

            entity.HasIndex(e => e.AddressId, "IX_suppliers_address_id").IsUnique();

            entity.HasIndex(e => e.Code, "IX_suppliers_code").IsUnique();

            entity.HasIndex(e => e.ReferenceSupplierId, "IX_suppliers_reference_supplier_id");

            entity.HasIndex(e => e.SupplierGroupId, "IX_suppliers_supplier_group_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.ReferenceSupplierId).HasColumnName("reference_supplier_id");
            entity.Property(e => e.Sdi)
                .HasMaxLength(10)
                .HasColumnName("sdi");
            entity.Property(e => e.SupplierGroupId).HasColumnName("supplier_group_id");

            entity.HasOne(d => d.Address).WithOne(p => p.Supplier).HasForeignKey<Supplier>(d => d.AddressId);

            entity.HasOne(d => d.ReferenceSupplier).WithMany(p => p.InverseReferenceSupplier).HasForeignKey(d => d.ReferenceSupplierId);

            entity.HasOne(d => d.SupplierGroup).WithMany(p => p.Suppliers).HasForeignKey(d => d.SupplierGroupId);

            entity.HasMany(d => d.Addresses).WithMany(p => p.Suppliers)
                .UsingEntity<Dictionary<string, object>>(
                    "SupplierDestination",
                    r => r.HasOne<Address>().WithMany().HasForeignKey("AddressId"),
                    l => l.HasOne<Supplier>().WithMany().HasForeignKey("SupplierId"),
                    j =>
                    {
                        j.HasKey("SupplierId", "AddressId");
                        j.ToTable("supplier_destinations");
                        j.HasIndex(new[] { "AddressId" }, "IX_supplier_destinations_address_id");
                        j.IndexerProperty<int>("SupplierId").HasColumnName("supplier_id");
                        j.IndexerProperty<int>("AddressId").HasColumnName("address_id");
                    });
        });

        modelBuilder.Entity<SuppliersGroup>(entity =>
        {
            entity.ToTable("suppliers_groups");

            entity.HasIndex(e => e.Code, "IX_suppliers_groups_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.ToTable("tags");

            entity.HasIndex(e => e.Code, "IX_tags_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(200)
                .HasColumnName("value");
        });

        modelBuilder.Entity<TagsLang>(entity =>
        {
            entity.HasKey(e => new { e.TagId, e.LanguageCode });

            entity.ToTable("tags_lang");

            entity.Property(e => e.TagId).HasColumnName("tag_id");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.Value)
                .HasMaxLength(200)
                .HasColumnName("value");

            entity.HasOne(d => d.Tag).WithMany(p => p.TagsLangs).HasForeignKey(d => d.TagId);
        });

        modelBuilder.Entity<TagsLangView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tags_lang_view", "kiosk");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("language_code");
            entity.Property(e => e.TagId).HasColumnName("tag_id");
            entity.Property(e => e.Value)
                .HasMaxLength(200)
                .HasColumnName("value");
        });

        modelBuilder.Entity<TagsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tags_view", "kiosk");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(200)
                .HasColumnName("value");
        });

        modelBuilder.Entity<UiGroupDetailsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ui_group_details_view", "kiosk");

            entity.Property(e => e.ChildArticleId).HasColumnName("child_article_id");
            entity.Property(e => e.ChildUiGroupId).HasColumnName("child_ui_group_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrderNumber).HasColumnName("order_number");
            entity.Property(e => e.UiGroupId).HasColumnName("ui_group_id");
            entity.Property(e => e.ValidForServiceTypes).HasColumnName("valid_for_service_types");
        });

        modelBuilder.Entity<UiGroupLangView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ui_group_lang_view", "kiosk");

            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.LanguageCode).HasColumnName("language_code");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.ReadableName).HasColumnName("readable_name");
            entity.Property(e => e.UiGroupId).HasColumnName("ui_group_id");
        });

        modelBuilder.Entity<UiGroupLayoutsLinksView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ui_group_layouts_links_view", "kiosk");

            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.UiGroupId).HasColumnName("ui_group_id");
            entity.Property(e => e.ValidForServiceTypes).HasColumnName("valid_for_service_types");
        });

        modelBuilder.Entity<UiGroupsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ui_groups_view", "kiosk");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.GroupByTagId).HasColumnName("group_by_tag_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MediaId).HasColumnName("media_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ReadableName).HasColumnName("readable_name");
            entity.Property(e => e.TileTemplateId).HasColumnName("tile_template_id");
        });

        modelBuilder.Entity<UiTileTemplatesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ui_tile_templates_view", "kiosk");

            entity.Property(e => e.CssClass)
                .HasMaxLength(50)
                .HasColumnName("css_class");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsBackground).HasColumnName("is_background");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ShowDescription).HasColumnName("show_description");
            entity.Property(e => e.ShowName).HasColumnName("show_name");
            entity.Property(e => e.ShowPrice).HasColumnName("show_price");
        });

        modelBuilder.Entity<Upload>(entity =>
        {
            entity.ToTable("uploads");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessLevel).HasColumnName("access_level");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("file_name");
            entity.Property(e => e.FileSize).HasColumnName("file_size");
            entity.Property(e => e.IsPending)
                .HasDefaultValue(true)
                .HasColumnName("is_pending");
            entity.Property(e => e.MimeType)
                .HasMaxLength(100)
                .HasColumnName("mime_type");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UploadDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("upload_date");
            entity.Property(e => e.Url)
                .HasMaxLength(2048)
                .HasColumnName("url");
        });

        modelBuilder.Entity<UpsellSet>(entity =>
        {
            entity.ToTable("upsell_sets");

            entity.HasIndex(e => e.Code, "IX_upsell_sets_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EndTime)
                .HasDefaultValueSql("'23:59:59'::time without time zone")
                .HasColumnName("end_time");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime)
                .HasDefaultValueSql("'00:00:00'::time without time zone")
                .HasColumnName("start_time");
            entity.Property(e => e.Weekdays)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("weekdays");
        });

        modelBuilder.Entity<UpsellSetDetail>(entity =>
        {
            entity.ToTable("upsell_set_details");

            entity.HasIndex(e => e.ChildArticleId, "IX_upsell_set_details_child_article_id");

            entity.HasIndex(e => new { e.UpsellSetId, e.ChildArticleId }, "IX_upsell_set_details_upsell_set_id_child_article_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChildArticleId).HasColumnName("child_article_id");
            entity.Property(e => e.UpsellSetId).HasColumnName("upsell_set_id");

            entity.HasOne(d => d.ChildArticle).WithMany(p => p.UpsellSetDetails).HasForeignKey(d => d.ChildArticleId);

            entity.HasOne(d => d.UpsellSet).WithMany(p => p.UpsellSetDetails).HasForeignKey(d => d.UpsellSetId);
        });

        modelBuilder.Entity<UpsellSetDetailsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("upsell_set_details_view", "kiosk");

            entity.Property(e => e.ChildArticleId).HasColumnName("child_article_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UpsellSetId).HasColumnName("upsell_set_id");
        });

        modelBuilder.Entity<UpsellSetLink>(entity =>
        {
            entity.ToTable("upsell_set_links");

            entity.HasIndex(e => e.AssociatedArticleId, "IX_upsell_set_links_associated_article_id");

            entity.HasIndex(e => e.AssociatedPosId, "IX_upsell_set_links_associated_pos_id");

            entity.HasIndex(e => e.UpsellSetId, "IX_upsell_set_links_upsell_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssociatedArticleId).HasColumnName("associated_article_id");
            entity.Property(e => e.AssociatedPosId).HasColumnName("associated_pos_id");
            entity.Property(e => e.UpsellSetId).HasColumnName("upsell_set_id");

            entity.HasOne(d => d.AssociatedArticle).WithMany(p => p.UpsellSetLinks).HasForeignKey(d => d.AssociatedArticleId);

            entity.HasOne(d => d.AssociatedPos).WithMany(p => p.UpsellSetLinks).HasForeignKey(d => d.AssociatedPosId);

            entity.HasOne(d => d.UpsellSet).WithMany(p => p.UpsellSetLinks).HasForeignKey(d => d.UpsellSetId);
        });

        modelBuilder.Entity<UpsellSetLinksView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("upsell_set_links_view", "kiosk");

            entity.Property(e => e.AssociatedArticleId).HasColumnName("associated_article_id");
            entity.Property(e => e.AssociatedPosId).HasColumnName("associated_pos_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UpsellSetId).HasColumnName("upsell_set_id");
        });

        modelBuilder.Entity<UpsellSetsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("upsell_sets_view", "kiosk");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.Weekdays)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("weekdays");
        });

        modelBuilder.Entity<Vat>(entity =>
        {
            entity.ToTable("vats");

            entity.HasIndex(e => e.Code, "IX_vats_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creation_time");
            entity.Property(e => e.Creator)
                .HasMaxLength(100)
                .HasColumnName("creator");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.LastModificationTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_modification_time");
            entity.Property(e => e.LastModifier)
                .HasMaxLength(100)
                .HasColumnName("last_modifier");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Percent)
                .HasPrecision(5, 3)
                .HasColumnName("percent");
        });

        modelBuilder.Entity<VatsExemptionKind>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("vats_exemption_kinds");

            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("code");
            entity.Property(e => e.Label).HasColumnName("label");
        });

        modelBuilder.Entity<VatsFiscal>(entity =>
        {
            entity.HasKey(e => e.VatId);

            entity.ToTable("vats_fiscal");

            entity.HasIndex(e => e.ExemptionKindCode, "IX_vats_fiscal_exemption_kind_code");

            entity.Property(e => e.VatId)
                .ValueGeneratedNever()
                .HasColumnName("vat_id");
            entity.Property(e => e.AtecoCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("ateco_code");
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("department_code");
            entity.Property(e => e.ExemptionKindCode)
                .HasMaxLength(100)
                .HasColumnName("exemption_kind_code");
            entity.Property(e => e.PrinterIndex)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("printer_index");
            entity.Property(e => e.SalesAttribute).HasColumnName("sales_attribute");
            entity.Property(e => e.SalesType).HasColumnName("sales_type");

            entity.HasOne(d => d.ExemptionKindCodeNavigation).WithMany(p => p.VatsFiscals).HasForeignKey(d => d.ExemptionKindCode);

            entity.HasOne(d => d.Vat).WithOne(p => p.VatsFiscal).HasForeignKey<VatsFiscal>(d => d.VatId);
        });

        modelBuilder.Entity<VatsFiscalDataStaging>(entity =>
        {
            entity.ToTable("vats_fiscal_data_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AtecoCode).HasColumnName("ateco_code");
            entity.Property(e => e.DepartmentCode).HasColumnName("department_code");
            entity.Property(e => e.ExemptionKindCode).HasColumnName("exemption_kind_code");
            entity.Property(e => e.PrinterIndex).HasColumnName("printer_index");
            entity.Property(e => e.SalesAttribute).HasColumnName("sales_attribute");
            entity.Property(e => e.SalesType).HasColumnName("sales_type");
            entity.Property(e => e.VatCode).HasColumnName("vat_code");
        });

        modelBuilder.Entity<VatsStaging>(entity =>
        {
            entity.ToTable("vats_staging", "staging");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.IsValid)
                .HasDefaultValue(true)
                .HasColumnName("is_valid");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Percent).HasColumnName("percent");
        });

        modelBuilder.Entity<WarehouseTransaction>(entity =>
        {
            entity.ToTable("warehouse_transactions");

            entity.HasIndex(e => e.ArticleId, "IX_warehouse_transactions_article_id");

            entity.HasIndex(e => e.CausalId, "IX_warehouse_transactions_causal_id");

            entity.HasIndex(e => e.CurrencyId, "IX_warehouse_transactions_currency_id");

            entity.HasIndex(e => new { e.DocumentHeadingId, e.DocumentDetailId }, "IX_warehouse_transactions_document_heading_id_document_detail_~").IsUnique();

            entity.HasIndex(e => e.DocumentStateId, "IX_warehouse_transactions_document_state_id");

            entity.HasIndex(e => e.ShopId, "IX_warehouse_transactions_shop_id");

            entity.HasIndex(e => new { e.TransactionDate, e.DocumentHeadingId }, "IX_warehouse_transactions_transaction_date_document_heading_id");

            entity.HasIndex(e => new { e.WarehouseId, e.ArticleId, e.TransactionDate }, "IX_warehouse_transactions_warehouse_id_article_id_transaction_~");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArticleId).HasColumnName("article_id");
            entity.Property(e => e.CausalId).HasColumnName("causal_id");
            entity.Property(e => e.Cost)
                .HasPrecision(15, 5)
                .HasColumnName("cost");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.DocumentDetailId).HasColumnName("document_detail_id");
            entity.Property(e => e.DocumentHeadingId).HasColumnName("document_heading_id");
            entity.Property(e => e.DocumentStateId).HasColumnName("document_state_id");
            entity.Property(e => e.Operator)
                .HasMaxLength(100)
                .HasColumnName("operator");
            entity.Property(e => e.Quantity)
                .HasPrecision(15, 5)
                .HasColumnName("quantity");
            entity.Property(e => e.RowTotalCost)
                .HasPrecision(15, 5)
                .HasColumnName("row_total_cost");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("transaction_date");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

            entity.HasOne(d => d.Article).WithMany(p => p.WarehouseTransactions)
                .HasForeignKey(d => d.ArticleId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Causal).WithMany(p => p.WarehouseTransactions)
                .HasForeignKey(d => d.CausalId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Currency).WithMany(p => p.WarehouseTransactions)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.DocumentHeading).WithMany(p => p.WarehouseTransactions)
                .HasForeignKey(d => d.DocumentHeadingId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.DocumentState).WithMany(p => p.WarehouseTransactions)
                .HasForeignKey(d => d.DocumentStateId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Shop).WithMany(p => p.WarehouseTransactions)
                .HasForeignKey(d => d.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Warehouse).WithMany(p => p.WarehouseTransactions)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict);
        });
        modelBuilder.HasSequence("seq_customer_card_generation");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
