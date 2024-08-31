namespace ELDOKKAN.Models.EntityConfiguration;
class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(category => category.CategoryID);
    }
}