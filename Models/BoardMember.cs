namespace KanbanApi.Models
{
    public class BoardMember
    {
        public string Role { get; set; } // should be enum?
        public ApplicationUser User { get; set; }
        public Board Board { get; set; }
    }
}
