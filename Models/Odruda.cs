using System.ComponentModel.DataAnnotations;

namespace dreviny.Models
{
    public class Odruda
    {
        public int Id { get; set; }
        [Display(Name = "Odrůda")]
        public string NazevOdrudy { get; set; }
        [Display(Name = "Dřevina")]
        public string DruhStromu { get; set; }
        [Display(Name = "Vzrůst")]
        public string Vzrust { get; set; }
        [Display(Name = "Odolnost")]
        public string Odolnost { get; set; }
        [Display(Name = "Kdy kvete")]
        public string Kveteni { get; set; }
        [Display(Name = "Kdy se sklízí")]
        public string Sklizeň { get; set; }
        [Display(Name = "Vlastnosti plodu")]
        public string Plod { get; set; }
        [Display(Name = "Další poznámky")]
        public string Ruzne { get; set; }

    }
}