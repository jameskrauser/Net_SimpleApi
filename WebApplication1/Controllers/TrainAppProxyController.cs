using Microsoft.AspNetCore.Mvc;
using TrainAppApi.Models;

namespace TrainAppApi.Controllers
{ 


    [ApiController]
    [Route("api/[controller]")]
    public class TrainAppController : ControllerBase
    {

        private static List<Passenger> _passengers = new List<Passenger>();

        [HttpPost("AddUpdatePassengers")]
        public IActionResult AddUpdatePassengers([FromBody] Passenger passenger)
        {
            if (passenger == null)
            {
                return BadRequest(new ApiResponse<string>
                {
                    Result = false,
                    Message = "Passenger data is null",
                    Data = null
                });
            }

            if (passenger.PassengerID == 0)
            {
                // 新增
                passenger.PassengerID = _passengers.Count > 0 ? _passengers.Max(p => p.PassengerID) + 1 : 1;
                _passengers.Add(passenger);
            }
            else
            {
                // 更新
                var existing = _passengers.FirstOrDefault(p => p.PassengerID == passenger.PassengerID);
                if (existing == null)
                {
                    return NotFound(new ApiResponse<string>
                    {
                        Result = false,
                        Message = "Passenger not found",
                        Data = null
                    });
                }

                existing.FirstName = passenger.FirstName;
                existing.LastName = passenger.LastName;
                existing.Email = passenger.Email;
                existing.Phone = passenger.Phone;
                existing.Password = passenger.Password;
            }

            return Ok(new ApiResponse<Passenger>
            {
                Message = "",
                Result = true,
                Data = passenger
            });
        }











        [HttpGet("GetAllStations")]
        public IActionResult GetAllStations()
        {
            var stations = new List<Station>
            {
                new Station { StationID = 1, StationName = "Solapur", StationCode = "Solapur" },
                new Station { StationID = 2, StationName = "New Delhi", StationCode = "NDLS" },
                new Station { StationID = 5, StationName = "SHIMOGA", StationCode = "SME" },
                new Station { StationID = 18, StationName = "HUBLI", StationCode = "UBL" },
                new Station { StationID = 20, StationName = "string d asas", StationCode = "string as dasdsad" },
                new Station { StationID = 79, StationName = "BELGUAM", StationCode = "BGM" },
                new Station { StationID = 94, StationName = "banglore", StationCode = "banglore" },
                new Station { StationID = 97, StationName = "Gwalior", StationCode = "Gwalior" },
                new Station { StationID = 98, StationName = "ranchi Junction", StationCode = "rNC" },
                new Station { StationID = 99, StationName = "Howrah Junction", StationCode = "HWH" },
                new Station { StationID = 100, StationName = "Chennai Central", StationCode = "MAS" },
                new Station { StationID = 101, StationName = "Kolkata", StationCode = "KOAA" },
                new Station { StationID = 102, StationName = "Bangalore City", StationCode = "SBC" },
                new Station { StationID = 104, StationName = "Ahmedabad Junction", StationCode = "ADI" },
                new Station { StationID = 105, StationName = "Pune Junction", StationCode = "PUNE" },
                new Station { StationID = 107, StationName = "Kanpur Central", StationCode = "CNB" },
                new Station { StationID = 109, StationName = "Patna Junction", StationCode = "PNBE" },
                new Station { StationID = 111, StationName = "Tirupathi", StationCode = "TPT" },
                new Station { StationID = 112, StationName = "Thiruvananthapuram Central", StationCode = "TVC" },
                new Station { StationID = 113, StationName = "Visakhapatnam", StationCode = "VSKP" },
                new Station { StationID = 114, StationName = "Nagpur", StationCode = "NGP" },
                new Station { StationID = 117, StationName = "Madurai Junction", StationCode = "MDU" },
                new Station { StationID = 118, StationName = "Mangalore Central", StationCode = "MAQ" },
                new Station { StationID = 119, StationName = "Coimbatore Junction", StationCode = "CBE" },
                new Station { StationID = 120, StationName = "Dehradun", StationCode = "DDN" },
                new Station { StationID = 122, StationName = "Cairoo", StationCode = "Egp" },
                new Station { StationID = 124, StationName = "CSMT", StationCode = "555" },
                new Station { StationID = 129, StationName = "Surat", StationCode = "SRT" },
                new Station { StationID = 130, StationName = "string", StationCode = "string" },
                new Station { StationID = 131, StationName = "Noida", StationCode = "Noida" },
                new Station { StationID = 141, StationName = "Mahrakh", StationCode = "MSK" },
                new Station { StationID = 144, StationName = "Gulbarga", StationCode = "GLB" },
                new Station { StationID = 146, StationName = "Tenkasi", StationCode = "tk" },
                new Station { StationID = 162, StationName = "aserfcxzasd", StationCode = "sdfc" },
                new Station { StationID = 163, StationName = "nashik", StationCode = "1234" },
                new Station { StationID = 164, StationName = "Lahore", StationCode = "Lahore" },
                new Station { StationID = 165, StationName = "Karachi", StationCode = "Karachi" }
            };

            return Ok(new
            {
                message = "",
                result = true,
                data = stations
            });
        }


        [HttpGet("GetTrainsBetweenStations")]
        public IActionResult GetTrainsBetweenStations(int departureStationId, int arrivalStationId, DateTime departureDate)
        {
            // 模擬查詢：從現有 stations 中找出兩個站點
            var stations = GetStationData(); // 方法放在下方

            var departureStation = stations.FirstOrDefault(s => s.StationID == departureStationId);
            var arrivalStation = stations.FirstOrDefault(s => s.StationID == arrivalStationId);

            if (departureStation == null || arrivalStation == null)
            {
                return NotFound(new  
                {
                    Message = "Invalid station ID(s)",
                    Result = false,
                    data = ""
                });
            }

            // 模擬回傳（可改成回傳車次）
            var result = new List<Station>
            {
                departureStation,
                arrivalStation
            };

            return Ok(new  
            {
                Message = "",
                Result = true,
                Data = result
            });
        }

        private List<Station> GetStationData()
        {
            return new List<Station>
            {

                new Station { StationID = 1, StationName = "Solapur", StationCode = "Solapur", departureTime = "08:15", departureStationName = "New Delhi" },
                new Station { StationID = 2, StationName = "New Delhi", StationCode = "NDLS", departureTime = "12:30", departureStationName = "SHIMOGA" },
                new Station { StationID = 5, StationName = "SHIMOGA", StationCode = "SME", departureTime = "06:45", departureStationName = "HUBLI" },
                new Station { StationID = 18, StationName = "HUBLI", StationCode = "UBL", departureTime = "10:20", departureStationName = "Solapur" },
                new Station { StationID = 20, StationName = "string d asas", StationCode = "string as dasdsad", departureTime = "14:10", departureStationName = "BELGUAM" },
                new Station { StationID = 79, StationName = "BELGUAM", StationCode = "BGM", departureTime = "09:50", departureStationName = "Gwalior" },
                new Station { StationID = 94, StationName = "banglore", StationCode = "banglore", departureTime = "07:05", departureStationName = "MAS" },
                new Station { StationID = 97, StationName = "Gwalior", StationCode = "Gwalior", departureTime = "13:30", departureStationName = "KOAA" },
                new Station { StationID = 98, StationName = "ranchi Junction", StationCode = "rNC", departureTime = "17:25", departureStationName = "Ahmedabad Junction" },
                new Station { StationID = 99, StationName = "Howrah Junction", StationCode = "HWH", departureTime = "11:15", departureStationName = "Pune Junction" },
                new Station { StationID = 100, StationName = "Chennai Central", StationCode = "MAS", departureTime = "15:40", departureStationName = "Kanpur Central" },
                new Station { StationID = 101, StationName = "Kolkata", StationCode = "KOAA", departureTime = "16:10", departureStationName = "Patna Junction" },
                new Station { StationID = 102, StationName = "Bangalore City", StationCode = "SBC", departureTime = "18:45", departureStationName = "Tirupathi" },
                new Station { StationID = 104, StationName = "Ahmedabad Junction", StationCode = "ADI", departureTime = "09:00", departureStationName = "Thiruvananthapuram Central" },
                new Station { StationID = 105, StationName = "Pune Junction", StationCode = "PUNE", departureTime = "20:20", departureStationName = "Visakhapatnam" },
                new Station { StationID = 107, StationName = "Kanpur Central", StationCode = "CNB", departureTime = "22:10", departureStationName = "Nagpur" },
                new Station { StationID = 109, StationName = "Patna Junction", StationCode = "PNBE", departureTime = "05:55", departureStationName = "Madurai Junction" },
                new Station { StationID = 111, StationName = "Tirupathi", StationCode = "TPT", departureTime = "08:35", departureStationName = "Mangalore Central" },
                new Station { StationID = 112, StationName = "Thiruvananthapuram Central", StationCode = "TVC", departureTime = "19:45", departureStationName = "Coimbatore Junction" },
                new Station { StationID = 113, StationName = "Visakhapatnam", StationCode = "VSKP", departureTime = "21:30", departureStationName = "Dehradun" },
                new Station { StationID = 114, StationName = "Nagpur", StationCode = "NGP", departureTime = "04:10", departureStationName = "Cairoo" },
                new Station { StationID = 117, StationName = "Madurai Junction", StationCode = "MDU", departureTime = "06:25", departureStationName = "CSMT" },
                new Station { StationID = 118, StationName = "Mangalore Central", StationCode = "MAQ", departureTime = "07:50", departureStationName = "Surat" },
                new Station { StationID = 119, StationName = "Coimbatore Junction", StationCode = "CBE", departureTime = "13:15", departureStationName = "Noida" },
                new Station { StationID = 120, StationName = "Dehradun", StationCode = "DDN", departureTime = "23:05", departureStationName = "Mahrakh" },
                new Station { StationID = 122, StationName = "Cairoo", StationCode = "Egp", departureTime = "12:00", departureStationName = "Gulbarga" },
                new Station { StationID = 124, StationName = "CSMT", StationCode = "555", departureTime = "03:30", departureStationName = "Tenkasi" },
                new Station { StationID = 129, StationName = "Surat", StationCode = "SRT", departureTime = "02:10", departureStationName = "aserfcxzasd" },
                new Station { StationID = 130, StationName = "string", StationCode = "string", departureTime = "10:30", departureStationName = "nashik" },
                new Station { StationID = 131, StationName = "Noida", StationCode = "Noida", departureTime = "16:55", departureStationName = "Lahore" },
                new Station { StationID = 141, StationName = "Mahrakh", StationCode = "MSK", departureTime = "01:45", departureStationName = "Karachi" },
                new Station { StationID = 144, StationName = "Gulbarga", StationCode = "GLB", departureTime = "11:20", departureStationName = "Bangalore City" },
                new Station { StationID = 146, StationName = "Tenkasi", StationCode = "tk", departureTime = "17:50", departureStationName = "Howrah Junction" },
                new Station { StationID = 162, StationName = "aserfcxzasd", StationCode = "sdfc", departureTime = "19:00", departureStationName = "New Delhi" },
                new Station { StationID = 163, StationName = "nashik", StationCode = "1234", departureTime = "20:40", departureStationName = "Solapur" },
                new Station { StationID = 164, StationName = "Lahore", StationCode = "Lahore", departureTime = "06:00", departureStationName = "Gwalior" },
                new Station { StationID = 165, StationName = "Karachi", StationCode = "Karachi", departureTime = "09:30", departureStationName = "SHIMOGA" }


            };
        }

    }



}