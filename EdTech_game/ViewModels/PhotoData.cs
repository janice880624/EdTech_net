using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security;
using System.Web;

namespace EdTech_game.ViewModels
{
    public class PhotoData
    {
        public MultipartFileData image { get; set; }
        public string vendorId { get; set; }
    }
}