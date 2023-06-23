﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewRoomreservation
    {
        public Guid Id { get; set; }
        public string Studentid { get; set; }
        public int? Acadyear { get; set; }
        public int? Residenceid { get; set; }
        public string Residence { get; set; }
        public string Gender { get; set; }
        public string Roomno { get; set; }
        public int? Bankid { get; set; }
        public string Bankname { get; set; }
        public string Branchname { get; set; }
        public DateTime? Transdate { get; set; }
        public string Transactionid { get; set; }
        public string Currencyid { get; set; }
        public decimal? Amount { get; set; }
        public DateTime Timeinserted { get; set; }
        public bool Ismanual { get; set; }
        public long? Wspaymentid { get; set; }
    }
}
