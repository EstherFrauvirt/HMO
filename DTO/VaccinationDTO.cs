using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccinationDTO
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Manufacturer { get; set; }

        public int MemberId { get; set; }
    }
}
