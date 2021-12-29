using System.ComponentModel.DataAnnotations;

namespace dreviny.Models
{
    public class Drevina
    {
        public int Id { get; set; }
        [Display(Name = "Název stromu nebo keře")]
        public string Strom { get; set; }
        [Display(Name = "Vzrůst")]
        public string Vzrust { get; set; }
        [Display(Name = "Doba výsadby")]
        public string Vysadba { get; set; }
        [Display(Name = "Stanoviště")]
        public string Stanoviste { get; set; }
        [Display(Name = "Půda")]
        public string Puda { get; set; }
        [Display(Name = "Sprašnost")]
        public string Sprasnost { get; set; }
        [Display(Name = "Odolnost (mráz, sucho, škůdci...")]
        public string Odolnost { get; set; }
        [Display(Name = "Řez")]
        public string Rez { get; set; }
        [Display(Name = "Hnojení aj. péče")]
        public string Hnojeni { get; set; }
        [Display(Name = "Období květu")]
        public string Kveteni { get; set; }
        [Display(Name = "Sklizeň")]
        public string Sklizeň { get; set; }
        [Display(Name = "Zazimování")]
        public string Zazimovani { get; set; }
        [Display(Name = "Další poznámky")]
        public string Ruzne { get; set; }
        
    }
}
    


    
