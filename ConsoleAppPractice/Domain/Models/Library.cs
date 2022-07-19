using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Library: BaseEntity
    {
        public string Name { get; set; }
        public string SeatCount { get; set; }

        public static implicit operator Library(Library v)
        {
            throw new NotImplementedException();
        }
    }
}
