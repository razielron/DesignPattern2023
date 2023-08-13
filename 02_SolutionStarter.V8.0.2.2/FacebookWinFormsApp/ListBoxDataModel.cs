namespace BasicFacebookFeatures
{
    public class ListBoxDataModel<T>
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public T Data { get; set; }
    }
}
