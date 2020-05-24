using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Models
{
    public class ContactModelView
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Adres")]
        [Required(ErrorMessage = "Adres Bilgisi Giriniz.")]
        public string Address { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Geçersiz Email")]
        [Required(ErrorMessage = "Email Bilgisi Giriniz.")]
        public string Email { get; set; }
        [Display(Name = "Faks")]
        [Required(ErrorMessage = "Faks Bilgisi Giriniz.")]
        [MaxLength(20, ErrorMessage = "Faks 20 karakterden fazla olamaz")]
        public int? Faks { get; set; }
        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "Telefon Bilgisi Giriniz.")]
        [StringLength(11, ErrorMessage = "Telefon 11 haneli olmaldırır.")]
        [Phone(ErrorMessage ="Telefon Bilgisi Geçersiz")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Harita Bilgisi Giriniz.")]
        [Display(Name = "Harita")]
        public string GoogleMapUrl { get; set; }
    }
}