using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Poco
{
    [Table("Employee")]
    public class Poco 
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Employee { get; set; }

        public DateTime? CompletionDate { get; set; }
        [Column("Completion_Percent")]
        public byte? CompletionPercent { get; set; }
        [Column("Time_Stamp")]

        [NotMapped]
        public byte[] TimeStamp { get; set; }


    }
}
