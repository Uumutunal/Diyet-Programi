using EFDiyetProgramiProje_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Repository.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public DateTime? DeletedTime { get; set; }
        public DataStatus DataStatus { get; set; }

    }
}
