using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebpages.Pages.Gallery
{
    public class IndexModel : PageModel
    {
        public string RequestMethod
        { get; set; }

        public string RequestValues
        { get; set; }

        public string Title { get; set; }
        public string ImageName { get; set; }
        public string Alt { get; set; }
        public string Body { get; set; }

        public void OnGet()
        {
        }

        public void OnPost(string imageType)
        {
            // For debugging
            RequestMethod = "POST";
            RequestValues = GetFormValues();

            // Assign property values here

            switch (imageType)
            {
                case "Portriat":
                    Title = "Digital Self Portriat";
                    ImageName = "/images/ValueAndColor.png";
                    Alt = "A digital self portriat that is reminiscent of Audrey Hepburn";
                    Body = "A self portriat that was made as an assignment for my Digital Art and Design class at Siena.It was completed March 2022.";
                    break;

                case "Painting":
                    Title = "Illumination Painting";
                    ImageName = "/images/Painting.jpeg";
                    Alt = "A painting of a skull with flames and flowers with a background of night.";
                    Body = "My final for Painting I, where we had to paint an illumiation from a passage from Saint Francis. I choose the Cantical of the Brother Sun and represented the elements of the story within my artwork. This was completed December 2021.";
                    break;

                case "Lake":
                    Title = "Image of the Mayfield Lake";
                    ImageName = "/images/Lake.jpg";
                    Alt = "A picture of the Mayfield Lake foggy during fall.";
                    Body = "A picture of the lake next to my house that I have spent many hours fishing and realxing with my family. This picture was taken November 2020.";
                    break;
            }

        }
        // For debugging
        private string GetFormValues(bool ignoreRequestVerificationToken = true)
        {
            string formData = "";
            string separator = " | ";

            foreach (var pair in this.Request.Form)
            {
                if (ignoreRequestVerificationToken && pair.Key == "__RequestVerificationToken")
                {
                    continue;
                }
                else
                {
                    formData += pair.Key + ": " + Request.Form[pair.Key] + separator;
                }
            }

            if (formData.EndsWith(separator))
            {
                formData = formData.Substring(0, formData.Length - separator.Length);
            }

            return formData;
        }
    }
}