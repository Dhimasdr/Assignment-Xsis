using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DataAccess
{
    public class NewUser_Repo
    {
        public static ResponseResult Create(List_User model)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new RentalContext())
                {
                    data_user User = new data_user();

                    User.Id = Guid.NewGuid().ToString();
                    //User.Id = "123abv";
                    User.Email = model.Email;
                    User.Nama = model.Nama;
                    User.Alamat = model.Alamat;
                    User.nomor_id = model.nomor_id;

                    db.data_users.Add(User);
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
