using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProzzoroTest.Domain.Entities
{
    public class GalleryImage
    {
        public int Id { get; set; }
        public string ImageSource { get; set; }
        public string Description { get; set; }
        public string Alt { get; set; }
    }
}
