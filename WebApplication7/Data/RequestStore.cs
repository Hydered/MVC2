using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Data
{
    public static class RequestStore
    {
        public static List<Models.ConsultationRequest> Requests { get; set; } = new List<Models.ConsultationRequest>
        {
            new Models.ConsultationRequest { Id = 1, StudentName = "John Doe", Date = DateTime.Now.AddDays(1), Status = Models.RequestStatus.New },
            new Models.ConsultationRequest { Id = 2, StudentName = "Jane Smith", Date = DateTime.Now.AddDays(2), Status = Models.RequestStatus.Approved },
            new Models.ConsultationRequest { Id = 3, StudentName = "Alice Johnson", Date = DateTime.Now.AddDays(3), Status = Models.RequestStatus.Rejected },
            new Models.ConsultationRequest { Id = 4, StudentName = "Bob Brown", Date = DateTime.Now.AddDays(4), Status = Models.RequestStatus.New },
            new Models.ConsultationRequest { Id = 5, StudentName = "Charlie Davis", Date = DateTime.Now.AddDays(5), Status = Models.RequestStatus.Approved }
        };

    }
}