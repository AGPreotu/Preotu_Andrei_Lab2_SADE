using System;
using System.ComponentModel.DataAnnotations;

namespace Preotu_Andrei_Lab2_SADE.Models.LibraryViewModels
{
    public class OrderGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public int BookCount { get; set; }

    }
}
