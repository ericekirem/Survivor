namespace Survivor.Entitiy
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Competitor> Competitors { get; set; }  // Competitor'lar ile ilişki
    }

}
