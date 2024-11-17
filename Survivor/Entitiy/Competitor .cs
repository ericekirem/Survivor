namespace Survivor.Entitiy
{
    public class Competitor : BaseEntity
    {
        public string Name { get; set; }
        public string Skill { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }  // Category ile ilişki
    }

}
