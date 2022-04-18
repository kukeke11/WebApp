using System;
using System.Collections.Generic;
using System.Text;
using UritusedData.Models;

namespace UritusedData
{
    //Ühendab UritusService.cs ja ÜritusedController.cs
    public interface IUritusedInterface
    {
        IEnumerable<Uritused> GetAll();
        Uritused GetById(int id);
        Osalejad GetOById(int id);
        void AddU(Uritused newUritus);
        void AddO(int id, Osalejad newOsaleja);
        void AddE(int id, Ettevote newEttevote);
        void DeleteU(int id);
        void DeleteO(int id, int ido);
        void DeleteE(int id, int ido);
        void UpdateO(Osalejad newOsaleja);
        void UpdateE(Ettevote newEttevote);
        string GetUrituseNimi(int id);
        DateTime GetToimumisaeg(int id);
        string GetKoht(int id);
        string LisaInfo(int id);
        List<Osalejad> GetUrituseOsalejad(int id);
        List<Ettevote> GetUrituseEttevotted(int id);
        Osalejad GetOsaleja(int id, int idosalejad);
        Ettevote GetEttevote(int id, int idettevote);
    }
}
