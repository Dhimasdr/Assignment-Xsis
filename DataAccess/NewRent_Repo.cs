using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DataAccess
{
    public class NewRent_Repo
    {
        public static ResponseResult Create(Rent_lists model)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new RentalContext())
                {
                    DataRent User = new DataRent();

                    User.Id = Guid.NewGuid().ToString();
                    //User.Id = "123abv";
                    User.id_Kendaraan = model.id_Kendaraan;
                    User.Start_Date = model.Start_Date;
                    User.End_Date = model.End_Date;
                    User.Nomor_Pesanan = DateTime.Now.ToString("ddmmyyyy")+"001";

                    db.DataRents.Add(User);
                    db.SaveChanges();

                    result.list = model;
                    result.success = true;
                }
            }
            catch (Exception ex)
            {
                result.success = false;
                result.message = ex.Message;
                throw;
            }




            return result;
        }
    }
}
