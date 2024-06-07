namespace CarBook.Application.Features.Mediator.Results.RentACarResults
{
    public class GetRentACarQueryResult
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public string Amount { get; set; }
    }
}
