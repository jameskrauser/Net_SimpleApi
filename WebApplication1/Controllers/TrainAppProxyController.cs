using Microsoft.AspNetCore.Mvc;
using TrainAppApi.Models;

namespace TrainAppApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainAppController : ControllerBase
    {
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
    }
}