using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using UritusedData;
using UritusedData.Models;


namespace UritusedServices
{
    public class UritusService : IUritusedInterface
    {
        private UritusedContext _context;

        public UritusService(UritusedContext context)
        {
            _context = context;
        }
        public void AddU(Uritused newUritus)//Lisab uue urituse ja uuendab andmebaasi
        {
            _context.Add(newUritus);//Lisab andmebaasi
            _context.SaveChanges();//Uuendab andmebaasi
        }

        public void DeleteU(int id)// Kustutab urituse
        {
            _context.Remove(_context.Uritused.Find(id));
            _context.SaveChanges();
        }
        public void AddO(int id, Osalejad newOsaleja)//Lisab osaleja Urituse osalejate nimekirja
        {
            GetById(id).Osalejad.Add(newOsaleja);
            _context.SaveChanges();
        }

        public void AddE(int id, Ettevote newEttevote)//Lisab ettevote Urituse osalejate nimekirja
        {
            GetById(id).Ettevotted.Add(newEttevote);
            _context.SaveChanges();
        }
        public void DeleteO(int id, int idosaleja)//Kustutab osaleja urituse nimekirjast
        {
            _context.Remove(_context.Uritused.Find(id).Osalejad.Remove(GetOsaleja(id,idosaleja)));
            _context.SaveChanges();
        }
        public void DeleteE(int id, int idettevote)//Kustutab ettevote urituse nimekirjast
        {
            _context.Remove(_context.Uritused.Find(id).Ettevotted.Remove(GetEttevote(id, idettevote)));
            _context.SaveChanges();
        }
        public void UpdateO(Osalejad updateOsaleja)
        {
            _context.Entry(updateOsaleja).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void UpdateE(Ettevote updateEttevote)
        {
            _context.Entry(updateEttevote).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<Uritused> GetAll()
        {
            return _context.Uritused
                .Include(uritus => uritus.Osalejad)
                .Include(uritus => uritus.Ettevotted);
        }
        public IEnumerable<Osalejad> FindOsaleja()
        {
            return _context.Osalejad;
        }
        public Osalejad GetOById(int id)
        {
            return
                FindOsaleja()
                .FirstOrDefault(osaleja => osaleja.ID == id);
        }
        public IEnumerable<Ettevote> FindEttevot()
        {
            return _context.Ettevotted;
        }

        public Uritused GetById(int id)
        {
            return
                GetAll()
                .FirstOrDefault(uritus => uritus.Id == id);
        }

        public string GetKoht(int id)
        {
            return GetById(id).Koht;
        }

        public DateTime GetToimumisaeg(int id)
        {
            return GetById(id).Toimumisaeg;
        }

        public string GetUrituseNimi(int id)
        {
            return GetById(id).Uritusenimi;
        }

        public List<Osalejad> GetUrituseOsalejad(int id)
        {
            return GetById(id).Osalejad;
        }

        public List<Ettevote> GetUrituseEttevotted(int id)
        {
            return GetById(id).Ettevotted;
        }

        public Osalejad GetOsaleja(int id, int idosaleja)
        {
            return GetById(id).Osalejad.Find(osaleja => osaleja.ID == idosaleja);
        }

        public Ettevote GetEttevote(int id, int idettevote)
        {
            return GetById(id).Ettevotted.Find(ettevote => ettevote.ID == idettevote);
        }

        public string LisaInfo(int id)
        {
            return GetById(id).Lisainfo;
        }
    }
}
