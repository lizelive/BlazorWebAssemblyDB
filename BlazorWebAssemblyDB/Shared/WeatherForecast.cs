using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorWebAssemblyDB.Shared
{
    public class WeatherForecast
    {
        [Key]
        public int WeatherForecastId { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
