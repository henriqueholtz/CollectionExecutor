namespace CollectionExecutor.Model
{
    public class Collection
    {
        public int CollectionId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Request> Requests { get; set; }
    }
}