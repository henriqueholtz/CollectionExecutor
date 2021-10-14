namespace CollectionExecutor.Model
{
    public  class Request
    {
        public int RequestId { get; set; }
        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; }
        public string Name { get; set; }
    }
}
