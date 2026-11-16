using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class ConsultationRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Student name is required.")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }
        public RequestStatus Status { get; set; }
    }
}