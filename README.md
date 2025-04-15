How to create simple web api server for test and don't need create DB table

Good for reading...
[https://medium.com/p/1f7c4bca96bc/edit](https://jameskrauserlee.medium.com/how-to-create-simple-web-api-server-for-test-and-dont-need-create-db-table-1f7c4bca96bc)



sometimes you will use free api for your test project in your laptop, but your must find the CORS problem and you dont want create the db table.
You just need a simple api for your project.
https://freeapi.miniprojectideas.com/index.html
TrainApp's Get /api/TrainApp/GetAllSatations
you can get Request URL 
https://freeapi.miniprojectideas.com/api/TrainApp/GetAllStations
Response Body
{
  "message": "",
  "result": true,
  "data": [
    {
      "stationID": 1,
      "stationName": "Solapur",
      "stationCode": "Solapur"
    },
    {
      "stationID": 2,
      "stationName": "New Delhi",
      "stationCode": "NDLS"
    },
    {
      "stationID": 5,
      "stationName": "SHIMOGA",
      "stationCode": "SME"
    },
    {
      "stationID": 18,
      "stationName": "HUBLI",
      "stationCode": "UBL"
    },
    {
      "stationID": 20,
      "stationName": "string d asas",
      "stationCode": "string as dasdsad"
    },
    {
      "stationID": 79,
      "stationName": "BELGUAM",
      "stationCode": "BGM"
    },
    {
      "stationID": 94,
      "stationName": "banglore",
      "stationCode": "banglore"
    },
    {
      "stationID": 97,
      "stationName": "Gwalior",
      "stationCode": "Gwalior"
    },
    {
      "stationID": 98,
      "stationName": "ranchi Junction",
      "stationCode": "rNC"
    },
    {
      "stationID": 99,
      "stationName": "Howrah Junction",
      "stationCode": "HWH"
    },
    {
      "stationID": 100,
      "stationName": "Chennai Central",
      "stationCode": "MAS"
    },
    {
      "stationID": 101,
      "stationName": "Kolkata",
      "stationCode": "KOAA"
    },
    {
      "stationID": 102,
      "stationName": "Bangalore City",
      "stationCode": "SBC"
    },
    {
      "stationID": 104,
      "stationName": "Ahmedabad Junction",
      "stationCode": "ADI"
    },
    {
      "stationID": 105,
      "stationName": "Pune Junction",
      "stationCode": "PUNE"
    },
    {
      "stationID": 107,
      "stationName": "Kanpur Central",
      "stationCode": "CNB"
    },
    {
      "stationID": 109,
      "stationName": "Patna Junction",
      "stationCode": "PNBE"
    },
    {
      "stationID": 111,
      "stationName": "Tirupathi",
      "stationCode": "TPT"
    },
    {
      "stationID": 112,
      "stationName": "Thiruvananthapuram Central",
      "stationCode": "TVC"
    },
    {
      "stationID": 113,
      "stationName": "Visakhapatnam",
      "stationCode": "VSKP"
    },
    {
      "stationID": 114,
      "stationName": "Nagpur",
      "stationCode": "NGP"
    },
    {
      "stationID": 117,
      "stationName": "Madurai Junction",
      "stationCode": "MDU"
    },
    {
      "stationID": 118,
      "stationName": "Mangalore Central",
      "stationCode": "MAQ"
    },
    {
      "stationID": 119,
      "stationName": "Coimbatore Junction",
      "stationCode": "CBE"
    },
    {
      "stationID": 120,
      "stationName": "Dehradun",
      "stationCode": "DDN"
    },
    {
      "stationID": 122,
      "stationName": "Cairoo",
      "stationCode": "Egp"
    },
    {
      "stationID": 124,
      "stationName": "CSMT",
      "stationCode": "555"
    },
    {
      "stationID": 129,
      "stationName": "Surat",
      "stationCode": "SRT"
    },
    {
      "stationID": 130,
      "stationName": "string",
      "stationCode": "string"
    },
    {
      "stationID": 131,
      "stationName": "Noida",
      "stationCode": "Noida"
    },
    {
      "stationID": 141,
      "stationName": "Mahrakh",
      "stationCode": "MSK"
    },
    {
      "stationID": 144,
      "stationName": "Gulbarga",
      "stationCode": "GLB"
    },
    {
      "stationID": 146,
      "stationName": "Tenkasi",
      "stationCode": "tk"
    },
    {
      "stationID": 162,
      "stationName": "aserfcxzasd",
      "stationCode": "sdfc"
    },
    {
      "stationID": 163,
      "stationName": "nashik",
      "stationCode": "1234"
    },
    {
      "stationID": 164,
      "stationName": "Lahore",
      "stationCode": "Lahore"
    },
    {
      "stationID": 165,
      "stationName": "Karachi",
      "stationCode": "Karachi"
    }
  ]
}
Use Visual Studio , create ASP.NET Core Web API project.
Create Models folder and create Station.cs file
namespace TrainAppApi.Models
{
    public class Station
    {
        public int StationID { get; set; }
        public string StationName { get; set; } = string.Empty;
        public string StationCode { get; set; } = string.Empty;
    }
}
Add new Controllers TrainAppProxyController.cs
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
Modify your Program.cs
var builder = WebApplication.CreateBuilder(args);

// 加入 CORS 服務 
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// 使用 CORS
app.UseCors("AllowAll");

app.UseAuthorization();
app.MapControllers();
app.Run();

Test http://localhost:5103/api/TrainApp/GetAllStations
Modify Angular 17
Done!
