using Core.Entities;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CourseDetailsDto : IDto
    {
        public string CourseName { get; set; }
        public string CategoryName { get; set; }
    }
}
