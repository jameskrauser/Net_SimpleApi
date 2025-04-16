namespace TrainAppApi.Models
{
    public class Station
    {
        public int StationID { get; set; }
        public string StationName { get; set; } = string.Empty;
        public string StationCode { get; set; } = string.Empty;

        public string departureTime { get; set; } = string.Empty;

        public string departureStationName { get; set; } = string.Empty;
    }



    //for Register data Array
    public class Passenger
    {
        public int PassengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }


    public class ApiResponse<T>
    {
        public string Message { get; set; } = "";
        public bool Result { get; set; } = true;
        public T Data { get; set; }
    }

}