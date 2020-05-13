

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROJECT_2
{


    
     
    abstract class hayvanlar
    {
        public  int Hayvan_hayati = 100; //Program basladigi zaman tum hayvanlarin hayati 100 olacaktir.
        protected int HP_herSaniye;
        public  int uretilen     { get; set; }
        public  int tane_fiyati  { get; set; }

        public abstract int HP_herSaniye_hayvanlar { get; set; }
        

        public bool oldu = false;


        abstract public int para_ekle();    
        public abstract void HP_herSaniye_fu();
        abstract public void Add_Hp();
        abstract public void Add_uretilen();
       


        // Bu metotda iki deger aliancak int cinsinden. 
        public hayvanlar( int HP_herSaniye, int tane_fiyati)
        {
          
            this.HP_herSaniye = HP_herSaniye;
            this.tane_fiyati = tane_fiyati;
        }


       


    }



    class Tavuk : hayvanlar
    {
        public override int HP_herSaniye_hayvanlar
        {
            get { return HP_herSaniye; } 
            set { HP_herSaniye = value; }
        }




        public Tavuk(int HP_herSaniye, int tane_fiyati) : base(HP_herSaniye, tane_fiyati)
        {
            this.HP_herSaniye = HP_herSaniye;
            this.tane_fiyati = tane_fiyati;
        }
        public override void HP_herSaniye_fu()
        {
            //Eeger Tavuku olmazsa yavasla azilir
            if (!oldu)
            {
                Hayvan_hayati -= HP_herSaniye;

                // Ama olmazsa  hayatinin degeri 0 olacak.
                if (Hayvan_hayati <= 0)
                {
                    
                    oldu = true;
                    Hayvan_hayati = 0;
                    
                }
            }
        }
        public override void Add_Hp()
        {
            if (!oldu)
                Hayvan_hayati = 100;
        }
        public override void Add_uretilen()
        {
            if (!oldu)
            {
                uretilen++; // Buradaki tavuk olmasza urettigi artarilir 
            }
        }
        //Bu metotda urettigi tane sayisiyle carpilir sonra sonuc geri donecek int cinsinden ondan sonra uretelen degeri 0 donecek
        public override int para_ekle()
        {
            int para_ekle = uretilen * tane_fiyati; // Urettigi tane sayisiyle carpilir .
            uretilen = 0;
            return para_ekle;
        }

    }


    class ordek : hayvanlar
    {
        public override int HP_herSaniye_hayvanlar
        {
            get { return HP_herSaniye; }
            set { HP_herSaniye = value; }
        }
        public ordek( int HP_herSaniye, int tane_fiyati) : base(HP_herSaniye, tane_fiyati)
        {
            this.HP_herSaniye = HP_herSaniye;
            this.tane_fiyati = tane_fiyati;
        }

        public override void HP_herSaniye_fu()
        {
            //Eeger ordek olmazsa yavasla azilir
            if (!oldu)
            {
                Hayvan_hayati -= HP_herSaniye;

                if (Hayvan_hayati <= 0)
                {
                  
                    oldu = true;
                    Hayvan_hayati = 0;
                  
                }
            }
        }
        public override void Add_Hp()
        {
            if (!oldu)
                Hayvan_hayati = 100;
        }
        public override void Add_uretilen()
        {
            if (!oldu)
            {
                uretilen++; // Buradaki ordek olmasza urettigi artarilir
            }
        }
        //Bu metotda urettigi tane sayisiyle carpilir sonra sonuc geri donecek int cinsinden ondan sonra uretelen degeri 0 donecek
        public override int para_ekle()
        {
            int para_ekle = uretilen * tane_fiyati;
            uretilen = 0;
            return para_ekle;
        }
    }


    class inek : hayvanlar
    {
        public override int HP_herSaniye_hayvanlar
        {
            get { return HP_herSaniye; }
            set { HP_herSaniye = value; }
        }


        public inek( int HP_herSaniye, int tane_fiyati) : base(HP_herSaniye, tane_fiyati)
        {
            this.HP_herSaniye = HP_herSaniye;
            this.tane_fiyati = tane_fiyati;
        }

        public override void HP_herSaniye_fu()
        {
            //Eeger inek olmazsa yavasla azilir

            if (!oldu)
            {
                Hayvan_hayati -= HP_herSaniye;

                if (Hayvan_hayati <= 0)
                {
                    
                    oldu = true;
                    Hayvan_hayati = 0;
                
                }
            }
        }
        public override void Add_Hp()
        {
            if (!oldu)
                Hayvan_hayati = 100;
        }
        public override void Add_uretilen()
        {

            if (!oldu)
            {
                uretilen++; // Buradaki inek olmasza urettigi artarilir
            }
        }
        //Bu metotda urettigi tane sayisiyle carpilir sonra sonuc geri donecek int cinsinden ondan sonra uretelen degeri 0 donecek
        public override int para_ekle()
        {
            int para_ekle = uretilen * tane_fiyati;
            uretilen = 0;
            return para_ekle;
        }
    }

    class keci : hayvanlar
    {
        public override int HP_herSaniye_hayvanlar
        {
            get { return HP_herSaniye; }
            set { HP_herSaniye = value; }
        }
        public keci(int HP_herSaniye, int tane_fiyati) : base(HP_herSaniye, tane_fiyati)
        {
            this.HP_herSaniye = HP_herSaniye;
            this.tane_fiyati = tane_fiyati;
        }

        public override void HP_herSaniye_fu()
        {
            //Eeger keci olmazsa yavasla azilir

            if (!oldu)
            {
                Hayvan_hayati -= HP_herSaniye;

                if (Hayvan_hayati <= 0)
                {
                    
                    oldu = true;
                    Hayvan_hayati = 0;
                 
                }
            }
        }
        public override void Add_Hp()
        {
            if (!oldu)
                Hayvan_hayati = 100;
        }
        public override void Add_uretilen()
        {
            if (!oldu)
            {
                uretilen++; // Buradaki keci olmasza urettigi artarilir
            }
        }
        //Bu metotda urettigi tane sayisiyle carpilir sonra sonuc geri donecek int cinsinden ondan sonra uretelen degeri 0 donecek
        public override int para_ekle()
        {
            int para_ekle = uretilen * tane_fiyati; 
            uretilen = 0;                           
            return para_ekle;                       
        }
    }
}
