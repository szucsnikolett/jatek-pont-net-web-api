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
    internal class ArRepository : Repository<Ar>, IArRepository
    {
        public ArRepository(jatek_pont_netContext context) : base(context) { }

        public async void Remove(Ar ar)
        {
            object[] param = new object[]
            {
                new SqlParameter("@ID", ar.Id), 
                new SqlParameter("@MUKODES", "D") 
            };
            await _context.Database.ExecuteSqlRawAsync("AR_IUD @ID, @MUKODES", param);
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
