using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Models
{
    public class IconModelView
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "İcon Adı Gereklidir.")]
        [Display(Name = "İcon Adı")]
        public string Name { get; set; }
    }

}