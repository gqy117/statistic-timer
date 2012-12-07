using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataBase;
using System.Configuration;

namespace StatisticTimer
{
    public static class StatisticTimer_Logic
    {
        public static string DBConnectString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        public static void Insert_StatisticTime_Header()
        {
            StatisticTimer_Logic.Insert_StatisticTime_Header(0, 0, 0);
        }
        public static void Insert_StatisticTime_Header(double seconds, double minutes, double hours)
        {
            SqlParameter[] paramList ={ 
            SqlHelper.MakeInParam("@Ts_Id", SqlDbType.DateTime, 0, DateTime.Now),
            SqlHelper.MakeInParam("@Seconds", SqlDbType.Int, 0, seconds),
            SqlHelper.MakeInParam("@Minutes", SqlDbType.Int, 0, minutes),
            SqlHelper.MakeInParam("@Hours", SqlDbType.Int, 0, hours),
        };
            string sql = "INSERT INTO StatisticTime_Header (Ts_Id,[Seconds],[Minutes],[Hours]) VALUES(@Ts_Id,@Seconds,@Minutes,@Hours) ";

            SqlHelper.ExecuteNonQuery(DBConnectString, CommandType.Text, sql, paramList);
        }
        public static void Update_StatisticTime_Header(double seconds, double minutes, double hours, int ST_Id)
        {
            SqlParameter[] paramList ={ 
            SqlHelper.MakeInParam("@Ts_Id", SqlDbType.DateTime, 0, DateTime.Now),
            SqlHelper.MakeInParam("@Seconds", SqlDbType.Int, 0, seconds),
            SqlHelper.MakeInParam("@Minutes", SqlDbType.Int, 0, minutes),
            SqlHelper.MakeInParam("@Hours", SqlDbType.Int, 0, hours),
            SqlHelper.MakeInParam("@ST_Id", SqlDbType.Int, 0, ST_Id),
        };
            string sql = @"UPDATE StatisticTime_Header 
                                SET Ts_Id = @Ts_Id ,
                                [Seconds] = @Seconds ,
                                [Minutes] = @Minutes ,
                                [Hours] = @Hours
                                WHERE ST_Id = @ST_Id";

            SqlHelper.ExecuteNonQuery(DBConnectString, CommandType.Text, sql, paramList);
        }
        public static DataTable Get_StatisticTime_Header()
        {
            string sql = "SELECT TOP 1 * FROM StatisticTime_Header ORDER BY ST_Id DESC ";
            return SqlHelper.ExecuteDataTable(DBConnectString, CommandType.Text, sql);
        }
        public static void Insert_StatisticTime_Detail(int ST_Id, double totalSenconds)
        {
            SqlParameter[] paramList ={ 
            SqlHelper.MakeInParam("@Ts_Id", SqlDbType.DateTime, 0, DateTime.Now),
            SqlHelper.MakeInParam("@ST_Id", SqlDbType.Int, 0, ST_Id),
            SqlHelper.MakeInParam("@TotalSenconds", SqlDbType.BigInt, 0, totalSenconds),
        };
            string sql = "INSERT INTO StatisticTime_Detail (ST_Id,TotalSenconds,Ts_Id) VALUES(@ST_Id,@TotalSenconds,@Ts_Id) ";

            SqlHelper.ExecuteNonQuery(DBConnectString, CommandType.Text, sql, paramList);
        }
    }
}
