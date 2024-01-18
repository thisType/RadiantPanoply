namespace BlazorAppUser.Model
{
    public class DisplayArt
    {


        public Guid ArtId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }    
        public string category { get; set; }


        public int StartingPrice { get; set; }

            
        public string Img{  get; set; }
    }
}
