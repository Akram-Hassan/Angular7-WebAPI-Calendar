namespace DAL
{
    public class Attendee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
    }
}