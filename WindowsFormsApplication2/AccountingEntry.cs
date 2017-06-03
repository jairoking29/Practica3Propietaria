using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class AccountingEntry
    {
        [Key]
        public int EntryId { get; set; }

        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string AccountingAccount { get; set; }

        public decimal AmountOfMovement { get; set; }

        public MovementType MovementType { get; set; }
    }

    public enum MovementType
    {
        Debit,
        Creidt
    }
}
