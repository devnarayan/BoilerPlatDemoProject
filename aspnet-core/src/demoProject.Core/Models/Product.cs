using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace demoProject.Models
{
    public class Product:FullAuditedEntity
    {
        [Required]
        [Display(Name ="Product Name")]
        [StringLength(50, ErrorMessage ="Max length is 50")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Product Code")]
        [StringLength(50, ErrorMessage = "Max length is 50")]
        public string ProductCode { get; set; }
        public int Price { get; set; }
    }
}
