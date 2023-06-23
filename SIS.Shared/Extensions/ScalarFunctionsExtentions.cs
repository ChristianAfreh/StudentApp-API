using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.Extensions
{
    public static class ScalarFunctionsExtentions
    {
        public static int GetStudentCurrentProgrammeStreamId(DbContext dbContext, string studentId)
        {
            var connString = dbContext.Database.GetConnectionString();
            int programmeStreamId = 0;
            string sql = $"SELECT dbo.getStudentCurrentProgrammeStreamID('{studentId}')";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    programmeStreamId = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return programmeStreamId;
        }

        public static int GetDefaultProgrammeStreamAcadYear(DbContext dbContext, int programmeStreamId)
        {
            var connString = dbContext.Database.GetConnectionString();
            int result = 0;
            string sql = $"SELECT dbo.getProgrammeStreamCurrentAcadYear({programmeStreamId})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }

        public static int GetDefaultProgrammeStreamAcadYearSem(this DbContext dbContext, int programmeStreamId)
        {
            var connString = dbContext.Database.GetConnectionString();
            int result = 0;
            string sql = $"SELECT dbo.getProgrammeStreamCurrentAcadYearSem({programmeStreamId})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }
    }
}
