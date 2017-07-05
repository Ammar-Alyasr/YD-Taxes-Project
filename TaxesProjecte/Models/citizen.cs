using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace TaxesProjecte.Models
{
    public class citizen
    {
        #region
        #endregion
        [Key]
        public string tc_no { get; set; }
        public int id { get; set; }
        public string citizen_name { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen e-posta adresinizi geçerli bir formatta giriniz.")]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string password { get; set; }

    }
}