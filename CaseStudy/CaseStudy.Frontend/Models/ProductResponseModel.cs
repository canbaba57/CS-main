namespace CaseStudy.Frontend.Models
{
    public class ProductResponseModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double weight { get; set; }
        public double popularityScore { get; set; }
        //public string images { get; set; }
        public decimal price { get; set; }
        public string yellowimage { get; set; }
        public string roseimage { get; set; }
        public string whiteimage { get; set; }
    }
}
