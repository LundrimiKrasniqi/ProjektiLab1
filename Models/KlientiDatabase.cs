using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudTest2.Models
{
    public class KlientiDatabase
    {
            [Key]
            public int KlientiID { get; set; }
            [Column(TypeName = "nvarchar(200)")]
            public string Emri { get; set; }
            [Column(TypeName = "nvarchar(200)")]
            public string Mbiemri { get; set; }
            [Column(TypeName = "nvarchar(200)")]
            public string Adresa { get; set; }
            [Column(TypeName = "nvarchar(200)")]
            public string Qyteti { get; set; }
            [Column(TypeName = "nvarchar(200)")]
            public string Shteti { get; set; }
            public int ZipCodi { get; set; }
            public int NumriKlientave { get; set; }
            [Column(TypeName = "nvarchar(200)")]
            public string NumriTelefonit { get; set; }
            [Column(TypeName = "nvarchar(200)")]
            public string Email { get; set; }
        }
}

