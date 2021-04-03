using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entity.Concrete
{
    public class OperationClaim:IEntity
    {
        [Key]
        public int OperationClaimId { get; set; }
        public string Name { get; set; }
    }
}
