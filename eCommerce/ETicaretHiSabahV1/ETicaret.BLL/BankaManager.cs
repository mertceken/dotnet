using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.DLL;

namespace ETicaret.BLL
{
    public class BankaManager
    {
        Repository<Bankalar> repBank = new Repository<Bankalar>();

        public List<Bankalar> bankaListesi()
        {
            return repBank.Liste();
        }

        public Bankalar bankaBul(int? bankalar_id)
        {
            return repBank.ListeFiltre(b => b.BankalarID == bankalar_id).FirstOrDefault();
        }

        public void BankaKaydet(string bankaAdi)
        {
            int ekleBanka = repBank.insert(new Bankalar()
            {
                BankaAdi = bankaAdi,
            });
        }

        public int BankaGuncelle(Bankalar tabloBanka)
        {
            Bankalar guncelle = repBank.VeriBul(b => b.BankalarID == tabloBanka.BankalarID);

            if (guncelle!=null)
            {
                guncelle.BankaAdi = tabloBanka.BankaAdi;

                if (repBank.Update(tabloBanka)>0)
                {
                    return 1;
                }

            }
            return 0;

        }
        
        public int BankaSil(int idBanka)
        {
            Bankalar silBanka = repBank.VeriBul(b => b.BankalarID == idBanka);

            if (silBanka!=null)
            {
                if (repBank.Delete(silBanka)>0)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
