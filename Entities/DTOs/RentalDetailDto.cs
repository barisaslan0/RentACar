using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public string CarName { get; set; }
        public string CustomerName { get; set; }
        public string Date { get; set; }
    }
}
