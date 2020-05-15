using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razer_Converter.Pages
{
    public class TemperatureModel : PageModel
    {
        private string results;
        public string Results
        {
        get{ return results; }
        set { results = value; }
        }
        public void OnPost()
        {
            var ConversionType = Request.Form["Conversion"];
            var TempToConvert = Request.Form["Amount"];
            if (TempToConvert == "") TempToConvert = "0";
            string Conversion = ConversionType.ToString();
            double Amount = double.Parse(TempToConvert.ToString());
            double Answer;
            if (Conversion == "Fahrenheit to Celsius")
            {
                Answer = ((Amount - 32) * (0.555556));
                results = Amount.ToString() + "Fahrenheit is " + Answer.ToString() + " Degrees Celsius";
            }
            else if (Conversion == "Fahrenheit to Kelvin")
            {
                Answer = ((Amount - 32) * (0.555556) + 273.15);
                results = Amount.ToString() + "Fahrenheit is " + Answer.ToString() + " Degrees Kelvin";
            }
            else if (Conversion == "Celsius to Fahrenheit")
            {
                Answer = ((Amount * (1.8)) + 32);
                results = Amount.ToString() + "Celsius is " + Answer.ToString() + " Degrees Fahrenheit";
            }
            else if (Conversion == "Celsius to Kelvin")
            {
                Answer = (Amount + 273.15);
                results = Amount.ToString() + "Celsius is " + Answer.ToString() + " Degrees Kelvin";
            }
            else if (Conversion == "Kelvin to Fahrenheit")
            {
                Answer = ((Amount - 273.15) * (1.8) + 32);
                results = Amount.ToString() + "Kelvin is " + Answer.ToString() + " Degrees Fahrenheit";
            }
            else
            {
                Answer = (Amount - 273.15);
                results = Amount.ToString() + "Kelvin is " + Answer.ToString() + " Degrees Celsius";
            }


        }
        public void OnGet()
        {

        }
    }
}