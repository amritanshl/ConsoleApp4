namespace InstagramApp
{
    public interface IShareable
    {
        void Share();
    }

    public interface IFilterable
    {
        void ApplyFilter(string FilterName);
    }
    public class Content
    {
        public string Name { get; set; }
        public int Likes { get; set; }

        public void getInfo()
        {
            Console.WriteLine($"{Name}  {Likes}");
            
        }
    }

    public class PhotoPost: Content, IShareable, IFilterable
    {
        public void Share()
        {

        }
        public void ApplyFilter( string FilterName)
        {

        }
    }
}