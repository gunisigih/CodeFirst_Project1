namespace CodeFirstOgrenciSinif
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;

    public class OgrenciSinif : DbContext
    {
        // Your context has been configured to use a 'OgrenciSinif' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirstOgrenciSinif.OgrenciSinif' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OgrenciSinif' 
        // connection string in the application configuration file.
        public OgrenciSinif()
            : base("name=OgrenciSinif")
        {
        }

        public virtual DbSet<Ogrenci> Ogrenciler{ get; set; } //facade 
        public virtual DbSet<Sinif> Siniflar { get; set; }//facade



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    [Table("Ogrenci")]
    public class Ogrenci   //Entitylerdir
    {
        [Key,DisplayName ("Kimlik Numaras�")]
        public long TcKimlikID { get; set; } [StringLength(80)]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Ad soyad bos olamaz")]
       
        public string AdSoyad { get; set; }
        public int SinifID { get; set; }

        public int Yas { get; set; }
        public virtual Sinif sinif{ get; set; }
    }
    [Table("Sinif")]
    public class Sinif
    {
        public Sinif()
        {
            this.ogrenciler = new HashSet<Ogrenci>();
        }
        [Key]
        public int SinifID { get; set; } [StringLength(50)]
        public string Aciklama { get; set; }
        public virtual ICollection<Ogrenci> ogrenciler { get; set; }
    }
}