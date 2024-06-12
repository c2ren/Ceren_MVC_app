namespace Sube2.HelloMvc.Models
{
    public class OgrenciDers
    {
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }

        public int DersId { get; set; }
        public Ders Ders { get; set; }
    }
}
