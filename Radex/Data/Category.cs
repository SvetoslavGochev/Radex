namespace Radex.Data
{
    using System.Collections.Generic;
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; init; }

        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }

        public ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    }
}
