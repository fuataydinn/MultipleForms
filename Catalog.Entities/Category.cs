using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    // Category bir entity sınıfı olacak
    // Entity??
    // Türkçe kelime anlamı varlık. Yazılım dilinde de varlık ifadesi kullanılabilir
    // En basit tabiriyle; kendisine ait anahtar değeri (Id, Identity, Key) olan verilere
    // entity denir
    // Örneğin; ilişkisel bir veritabanı sisteminde (relational database, örn; SQL Server)
    // çoka-çok (many-to-many) bağlanan iki tablonun arasında yer alan ara/geçiş tablosu kayıtları
    // entity değildir!
    public class Category : Entity
    {
        public string Description { get; set; }
        public override string ToString() //Grid kısmında category adı gözükmüyordu o yuzden burda toString() ezdik
        {
            return Name;
        }
    }
}
