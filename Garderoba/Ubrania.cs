using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    class Ubrania
    {        
        public bool KolorCzyJasny;

        public Ubrania(bool kolorCzyJasny, string image)
        {
            KolorCzyJasny = kolorCzyJasny;
            Image = image;
        }

        public string Image { get; set; }
    }
    class Góra : Ubrania
    {
        public bool czyDługiRękaw;

        public Góra(bool kolorCzyJasny, string image, bool czyDługiRękaw) : base(kolorCzyJasny, image)
        {
            this.czyDługiRękaw = czyDługiRękaw;
        }
    }
    class Dół : Ubrania
    {
        private bool czySpodnie;

        public Dół(bool kolorCzyJasny, string image, bool czySpodnie) : base(kolorCzyJasny, image)
        {
            this.czySpodnie = czySpodnie;           
        }

        private enum Rajstopy { cieliste, czarne };
        
    }
    class Sukienka : Ubrania
    {
        public Sukienka(bool kolorCzyJasny, string image) : base(kolorCzyJasny, image)
        {
        }

        private enum Rajstopy { jasne, ciemne };
    }
}
