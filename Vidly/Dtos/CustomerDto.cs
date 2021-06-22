using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        //[Min18ForMemberShip]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Required(ErrorMessage = "You need to select a membership type")]
        public byte MemberShipTypeId { get; set; }
        public MemberShipTypeDto MemberShipType { get; set; }
    }
}