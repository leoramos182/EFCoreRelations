namespace EFCoreRelations
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
