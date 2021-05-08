
using System;
using System.ComponentModel.DataAnnotations;

namespace CodigoPenalApi.Models
{
    public class CriminalCode
    {
        public CriminalCode()
        {

        }

        public CriminalCode(CriminalCode criminalCode)
        {
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Penalty { get; set; }
        public int PrisonTime { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public User CreateUser { get; set; }
        public User UpdateUser { get; set; }

    }
}
