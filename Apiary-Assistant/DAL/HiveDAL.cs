using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Apiary_Assistant.Models;

namespace Apiary_Assistant.DAL
{
    public class HiveDAL : IHiveDAL
    {
        private string _connectionString;

        public HiveDAL(string connectionString)
        {
            _connectionString = connectionString;
        }


        //method that returns a list of startinghives
        public IEnumerable<Hive> GetStartHives()
        {
            List<Hive> output = new List<Hive>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM hive_list;", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var hive = new Hive();
                        hive.HiveId = Convert.ToString(reader["hive_id"]);
                        hive.CreationDate = Convert.ToDateTime(reader["creation_date"]);
                        hive.OriginLocation = Convert.ToString(reader["origin_location"]);
                        hive.OriginType = Convert.ToString(reader["origin_type"]);
                        hive.StartQueen = Convert.ToString(reader["starter_queen"]);
                        hive.QueenAge = Convert.ToString(reader["queen_age"]);
                        hive.HouseType = Convert.ToString(reader["housing_type"]);
                        hive.TotalDeepFrames = Convert.ToDouble(reader["total_deep_frames"]);
                        hive.TotalMedFrames = Convert.ToDouble(reader["total_med_frames"]);
                        hive.TotalShortFrames = Convert.ToDouble(reader["total_short_frames"]);
                        hive.DrawnDeeps = Convert.ToDouble(reader["drawn_deep"]);
                        hive.DrawnMeds = Convert.ToDouble(reader["drawn_med"]);
                        hive.DrawnShort = Convert.ToDouble(reader["drawn_short"]);
                        hive.DeepBrood = Convert.ToDouble(reader["deep_brood"]);
                        hive.MedBrood = Convert.ToDouble(reader["med_brood"]);
                        hive.ShortBrood = Convert.ToDouble(reader["short_brood"]);
                        hive.IsThereHoney = Convert.ToBoolean(reader["istherehoney"]);
                        hive.IsThereFeed = Convert.ToBoolean(reader["isfeed"]);
                        hive.FoodType = Convert.ToString(reader["food_type"]);
                        hive.LbsOfFood = Convert.ToDouble(reader["food_lbs"]);
                        hive.HiveAddress = Convert.ToString(reader["hive_address"]);
                        hive.HivePosition = Convert.ToString(reader["hive_position"]);
                        hive.PropertyOwner = Convert.ToString(reader["property_owner"]);
                        hive.SecondPropOwner = Convert.ToString(reader["second_property_owner"]);

                        hive.HivePhoto = Convert.ToString(reader["hive_photo"]);


                        output.Add(hive);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return output;
        }



    }

}
