namespace Modelo
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool Completed { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
