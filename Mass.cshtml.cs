using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razer_Converter.Pages
{
    public class MassModel : PageModel
    {
        private string results;
        public string Results
        {
            get { return results; }
            set { results = value; }
        }
        public void OnPost()
        {
            var ConversionType = Request.Form["Conversion"];
            var MassToConvert = Request.Form["Amount"];
            if (MassToConvert == "") MassToConvert = "0";
            string Conversion = ConversionType.ToString();
            double Amount = double.Parse(MassToConvert.ToString());
            double Answer;
            if (Conversion == "Pounds to Ounces")
            {
                Answer = Amount * 16;
                results = Amount.ToString() + "Pounds is " + Answer.ToString() + "Ounces";
            }
            else if (Conversion == "Ounces to Pounds")
            {
                Answer = Amount / 16;
                results = Amount.ToString() + "Ounces is " + Answer.ToString() + "Pounds";
            }
            else if (Conversion == "Grams to Pounds")
            {
                Answer = Amount / 454;
                results = Amount.ToString() + "Grams is " + Answer.ToString() + "Pounds";
            }
            else if (Conversion == "Pounds to Grams")
            {
                Answer = Amount * 454;
                results = Amount.ToString() + "Pounds is " + Answer.ToString() + "Grams";
            }
            else if (Conversion == "Milligrams to Pounds")
            {
                Answer = Amount / 453592;
                results = Amount.ToString() + "Milligrams is " + Answer.ToString() + "Pounds";
            }
            else 
            {
                Answer = Amount * 453592;
                results = Amount.ToString() + "Pounds is " + Answer.ToString() + "Milligrams";
            }
        }
        public void OnGet()
        {

        }
    }
}