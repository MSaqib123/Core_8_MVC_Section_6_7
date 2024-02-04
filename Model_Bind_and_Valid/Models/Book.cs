namespace Model_Bind_and_Valid.Models
{
    public class Book
    {
        public int? BookId { get; set; }
        public string? Author { get; set; }

        public override string ToString()
        {
            return $"Book object-BookId : {BookId}, Author : {Author}";
        }
    }
}
