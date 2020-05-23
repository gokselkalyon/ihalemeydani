using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Models
{
    public class MenuModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Menü ismi gereklidir.")]
        [MinLength(5, ErrorMessage = "Menü ismi en az 5 karakterden oluşmalıdır")]
        [MaxLength(15, ErrorMessage = "Menü ismi en fazla 15 karakterden oluşmalıdır")]
        [Display(Name = "Menü Adı")]
        public string Name { get; set; }
        [Display(Name = "Menü Açıklaması")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Menü Url gereklidir.")]
        [MinLength(5, ErrorMessage = "Menü url'i en az 5 karakterden oluşmalıdır")]
        [MaxLength(15, ErrorMessage = "Menü url'i en fazla 15 karakterden oluşmalıdır")]
        [Display(Name = "Menü Url")]
        public string Url { get; set; }
        [Display(Name = "Üst Menü")]
        public string SubMenu { get; set; }
        [Display(Name = "İcon")]
        public string IconName { get; set; }
        [Display(Name = "Üst Menü")]
        public int SubMenuId { get; set; }
        [Display(Name = "İcon")]
        public int IconId{ get; set; }


    }
}