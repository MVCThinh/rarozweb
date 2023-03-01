using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace rarozweb.models
{
    public class AppUser : IdentityUser
    {
         [Column(TypeName = "nvarchar")]
        [StringLength(400)]
        
        public string? HomeAdress {set; get;}       
    }
}