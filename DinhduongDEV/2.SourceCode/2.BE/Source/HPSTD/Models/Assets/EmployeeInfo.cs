﻿using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HPSTD.Models
{
    public class EmployeeInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
        public string LastUpdatedUser { get; set; }
        public int DepartmentID { get; set; }
        public string Phone { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string CompanyID { get; set; }
        public string LevelID { get; set; }
        public string Description { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public DateTime StartWorkingDay { get; set; }
        public DateTime TerminatedDate { get; set; }
        public string XLiteID { get; set; }
        public string XLiteCode { get; set; }
        public string Email { get; set; }
        public int Active { get; set; }
        public string Region { get; set; }
    }
}