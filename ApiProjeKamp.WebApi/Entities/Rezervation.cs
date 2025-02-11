namespace ApiProjeKamp.WebApi.Entities
{
    public class Rezervation
    {
        public int RezervationId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string RezervationTime { get; set; }
        public DateTime RezervationDate { get; set; }
        public int CountofPeople { get; set; }
        public string Message { get; set; }
        public string RezervationStatus { get; set; }
    }
}
