using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DataAccess
{
    public class RentList_Repo
    {
        public static List<Rent_lists> All() {
            List<Rent_lists> result = new List<Rent_lists>();
            List<TP_List> transport = new List<TP_List>();
            using (var db = new RentalContext())
            {

                result = (from r in db.DataRents
                          join t in db.Transport_Lists on r.id_Kendaraan equals t.Id
                          select new Rent_lists
                          {
                              Id = r.Id,
                              id_Kendaraan = t.nama,
                              id_User = r.id_User,
                              Nomor_Pesanan = r.Nomor_Pesanan,
                              Start_Date = r.Start_Date,
                              End_Date = r.End_Date,
                              Status = r.Status

                          }).ToList();
            }
            return result;
        }
        public static List<Rent_lists> Search(string search)
        {
            ResponseResult final = new ResponseResult();
            List<Rent_lists> result = new List<Rent_lists>();
            List<TP_List> transport = new List<TP_List>();
            final.success = true;
            using (var db = new RentalContext())
            {

                result = (from r in db.DataRents
                          join t in db.Transport_Lists on r.id_Kendaraan equals t.Id
                          where(r.id_User==search)
                          select new Rent_lists
                          {
                              Id = r.Id,
                              id_Kendaraan = t.nama,
                              id_User = r.id_User,
                              Nomor_Pesanan = r.Nomor_Pesanan,
                              Start_Date = r.Start_Date,
                              End_Date = r.End_Date,
                              Status = r.Status

                          }).ToList();
            }
            if (result.Count<1)
            {
                final.success = false;
                final.message = "User  ID not Found";
            }
            final.list = result;
            return result;
        }
    }
}
