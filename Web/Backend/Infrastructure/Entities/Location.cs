using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Entities
{
    class Location
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
        public City City { get; set; }
        public string AddedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}
