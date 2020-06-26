using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using jatek_pont_net.Domain.Models;
using jatek_pont_net.Domain.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace jatek_pont_net.Persistence.Repositories
{
    public class ArRepository : Repository<Ar>, IArRepository
    {
        public ArRepository(jatek_pont_netContext context) : base(context) { }

        public async void Remove(Ar ar)
        {
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "@ID",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = ar.Id
            };
            SqlParameter termekParam = new SqlParameter()
            {
                ParameterName = "@TERMEK",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = ar.Termek
            };
            SqlParameter ervKezdParam = new SqlParameter()
            {
                ParameterName = "@ERV_KEZD",
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
                Value = ar.ErvKezd
            };
            SqlParameter arParam = new SqlParameter()
            {
                ParameterName = "@AR",
                SqlDbType = SqlDbType.Decimal,
                Direction = ParameterDirection.Input,
                Value = ar.Ar1
            };
            SqlParameter mukodesParam = new SqlParameter()
            {
                ParameterName = "@MUKODES",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = "D"
            };
            SqlParameter idOutParam = new SqlParameter()
            {
                ParameterName = "@ID_OUT",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            object[] param = new object[]
            {
                idParam,
                termekParam,
                ervKezdParam,
                arParam,
                mukodesParam,
                idOutParam
            };
            await _context.Database.ExecuteSqlRawAsync("AR_IUD @ID, @TERMEK, @ERV_KEZD, @AR, @MUKODES, @ID_OUT" , param);
        }

        public Task<Ar>Add(Ar entity)
        {
            SqlCommand cmd = new SqlCommand("AR_IUD");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TERMEK", entity.Termek);
            cmd.Parameters.AddWithValue("@ERV_KEZD", entity.ErvKezd);
            cmd.Parameters.AddWithValue("@AR", entity.Ar1);
            cmd.Parameters.AddWithValue("@ERV_VEG", entity.ErvVeg);
            cmd.Parameters.AddWithValue("@MUKODES", "I");

            SqlParameter outParameter = new SqlParameter();
            outParameter.ParameterName = "@ID_OUT";
            outParameter.SqlDbType = SqlDbType.Int;
            outParameter.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(outParameter);
            cmd.ExecuteNonQuery();

            int createdId = Convert.ToInt32(outParameter.Value);
            return this.GetById(createdId);
        }

        public Task<Ar> Edit(Ar entity)
        {
            throw new NotImplementedException();
        }
    }
}
