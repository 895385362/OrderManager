using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joker.DBUtility;
using Joker.Model;


namespace Joker.DAL
{
    public class Info_staffDAL
    {
        public Info_staffDAL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int staffID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Info_staff");
            strSql.Append(" where staffID=SQL2012staffID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012staffID", SqlDbType.Int,4)
            };
            parameters[0].Value = staffID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Info_staffModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Info_staff(");
            strSql.Append("staffNum,staffName,staffAvatar,staffSex,staffAge,staffMobile,staffPassword,ProvinceID,ProvinceName,CityID,CityName,DistrictID,DistrictName,Address,IsDelete)");
            strSql.Append(" values (");
            strSql.Append("SQL2012staffNum,SQL2012staffName,SQL2012staffAvatar,SQL2012staffSex,SQL2012staffAge,SQL2012staffMobile,SQL2012staffPassword,SQL2012ProvinceID,SQL2012ProvinceName,SQL2012CityID,SQL2012CityName,SQL2012DistrictID,SQL2012DistrictName,SQL2012Address,SQL2012IsDelete)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012staffNum", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012staffName", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012staffAvatar", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012staffSex", SqlDbType.Int,4),
                    new SqlParameter("SQL2012staffAge", SqlDbType.Int,4),
                    new SqlParameter("SQL2012staffMobile", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012staffPassword", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012ProvinceID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012ProvinceName", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012CityID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012CityName", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012DistrictID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012DistrictName", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012Address", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1)};
            parameters[0].Value = model.staffNum;
            parameters[1].Value = model.staffName;
            parameters[2].Value = model.staffAvatar;
            parameters[3].Value = model.staffSex;
            parameters[4].Value = model.staffAge;
            parameters[5].Value = model.staffMobile;
            parameters[6].Value = model.staffPassword;
            parameters[7].Value = model.ProvinceID;
            parameters[8].Value = model.ProvinceName;
            parameters[9].Value = model.CityID;
            parameters[10].Value = model.CityName;
            parameters[11].Value = model.DistrictID;
            parameters[12].Value = model.DistrictName;
            parameters[13].Value = model.Address;
            parameters[14].Value = model.IsDelete;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Info_staffModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Info_staff set ");
            strSql.Append("staffNum=SQL2012staffNum,");
            strSql.Append("staffName=SQL2012staffName,");
            strSql.Append("staffAvatar=SQL2012staffAvatar,");
            strSql.Append("staffSex=SQL2012staffSex,");
            strSql.Append("staffAge=SQL2012staffAge,");
            strSql.Append("staffMobile=SQL2012staffMobile,");
            strSql.Append("staffPassword=SQL2012staffPassword,");
            strSql.Append("ProvinceID=SQL2012ProvinceID,");
            strSql.Append("ProvinceName=SQL2012ProvinceName,");
            strSql.Append("CityID=SQL2012CityID,");
            strSql.Append("CityName=SQL2012CityName,");
            strSql.Append("DistrictID=SQL2012DistrictID,");
            strSql.Append("DistrictName=SQL2012DistrictName,");
            strSql.Append("Address=SQL2012Address,");
            strSql.Append("IsDelete=SQL2012IsDelete");
            strSql.Append(" where staffID=SQL2012staffID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012staffNum", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012staffName", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012staffAvatar", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012staffSex", SqlDbType.Int,4),
                    new SqlParameter("SQL2012staffAge", SqlDbType.Int,4),
                    new SqlParameter("SQL2012staffMobile", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012staffPassword", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012ProvinceID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012ProvinceName", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012CityID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012CityName", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012DistrictID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012DistrictName", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012Address", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1)};
            parameters[0].Value = model.staffNum;
            parameters[1].Value = model.staffName;
            parameters[2].Value = model.staffAvatar;
            parameters[3].Value = model.staffSex;
            parameters[4].Value = model.staffAge;
            parameters[5].Value = model.staffMobile;
            parameters[6].Value = model.staffPassword;
            parameters[7].Value = model.ProvinceID;
            parameters[8].Value = model.ProvinceName;
            parameters[9].Value = model.CityID;
            parameters[10].Value = model.CityName;
            parameters[11].Value = model.DistrictID;
            parameters[12].Value = model.DistrictName;
            parameters[13].Value = model.Address;
            parameters[14].Value = model.IsDelete;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int staffID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Info_staff ");
            strSql.Append(" where staffID=SQL2012staffID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012staffID", SqlDbType.Int,4)
            };
            parameters[0].Value = staffID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string staffIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Info_staff ");
            strSql.Append(" where staffID in (" + staffIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Info_staffModel GetModel(int staffID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 staffNum,staffName,staffAvatar,staffSex,staffAge,staffMobile,staffPassword,ProvinceID,ProvinceName,CityID,CityName,DistrictID,DistrictName,Address,IsDelete from Info_staff ");
            strSql.Append(" where staffID=SQL2012staffID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012staffID", SqlDbType.Int,4)
            };
            parameters[0].Value = staffID;

            Info_staffModel model = new Info_staffModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Info_staffModel DataRowToModel(DataRow row)
        {
            Info_staffModel model = new Info_staffModel();
            if (row != null)
            {
                if (row["staffNum"] != null)
                {
                    model.staffNum = row["staffNum"].ToString();
                }
                if (row["staffName"] != null)
                {
                    model.staffName = row["staffName"].ToString();
                }
                if (row["staffAvatar"] != null)
                {
                    model.staffAvatar = row["staffAvatar"].ToString();
                }
                if (row["staffSex"] != null && row["staffSex"].ToString() != "")
                {
                    model.staffSex = int.Parse(row["staffSex"].ToString());
                }
                if (row["staffAge"] != null && row["staffAge"].ToString() != "")
                {
                    model.staffAge = int.Parse(row["staffAge"].ToString());
                }
                if (row["staffMobile"] != null)
                {
                    model.staffMobile = row["staffMobile"].ToString();
                }
                if (row["staffPassword"] != null)
                {
                    model.staffPassword = row["staffPassword"].ToString();
                }
                if (row["ProvinceID"] != null && row["ProvinceID"].ToString() != "")
                {
                    model.ProvinceID = int.Parse(row["ProvinceID"].ToString());
                }
                if (row["ProvinceName"] != null)
                {
                    model.ProvinceName = row["ProvinceName"].ToString();
                }
                if (row["CityID"] != null && row["CityID"].ToString() != "")
                {
                    model.CityID = int.Parse(row["CityID"].ToString());
                }
                if (row["CityName"] != null)
                {
                    model.CityName = row["CityName"].ToString();
                }
                if (row["DistrictID"] != null && row["DistrictID"].ToString() != "")
                {
                    model.DistrictID = int.Parse(row["DistrictID"].ToString());
                }
                if (row["DistrictName"] != null)
                {
                    model.DistrictName = row["DistrictName"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["IsDelete"] != null && row["IsDelete"].ToString() != "")
                {
                    if ((row["IsDelete"].ToString() == "1") || (row["IsDelete"].ToString().ToLower() == "true"))
                    {
                        model.IsDelete = true;
                    }
                    else
                    {
                        model.IsDelete = false;
                    }
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select staffNum,staffName,staffAvatar,staffSex,staffAge,staffMobile,staffPassword,ProvinceID,ProvinceName,CityID,CityName,DistrictID,DistrictName,Address,IsDelete ");
            strSql.Append(" FROM Info_staff ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" staffNum,staffName,staffAvatar,staffSex,staffAge,staffMobile,staffPassword,ProvinceID,ProvinceName,CityID,CityName,DistrictID,DistrictName,Address,IsDelete ");
            strSql.Append(" FROM Info_staff ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Info_staff ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.staffID desc");
            }
            strSql.Append(")AS Row, T.*  from Info_staff T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Info_staff";
			parameters[1].Value = "staffID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
