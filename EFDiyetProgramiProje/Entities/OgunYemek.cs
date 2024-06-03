using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Entities
{
    internal class OgunYemek
    {
        public int OgunId { get; set; }
        public int YemekId { get; set; }
        public int BirimAdedi { get; set; }
        public DateOnly Tarih { get; set; }
        public int MyProperty { get; set; }

    }
}
