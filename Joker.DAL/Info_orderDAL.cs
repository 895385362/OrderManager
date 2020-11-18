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
    public class Info_orderDAL
    {
        public Info_orderDAL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int orderID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Info_order");
            strSql.Append(" where orderID=SQL2012orderID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012orderID", SqlDbType.Int,4)
            };
            parameters[0].Value = orderID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Info_orderMode model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Info_order(");
            strSql.Append("orderNum,orderDate,staffID,deviceID,Count,IsDelete)");
            strSql.Append(" values (");
            strSql.Append("SQL2012orderNum,SQL2012orderDate,SQL2012staffID,SQL2012deviceID,SQL2012Count,SQL2012IsDelete)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012orderNum", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012orderDate", SqlDbType.DateTime),
                    new SqlParameter("SQL2012staffID", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012deviceID", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012Count", SqlDbType.Int,4),
                    new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1)};
            parameters[0].Value = model.orderNum;
            parameters[1].Value = model.orderDate;
            parameters[2].Value = model.staffID;
            parameters[3].Value = model.deviceID;
            parameters[4].Value = model.Count;
            parameters[5].Value = model.IsDelete;

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
        public bool Update(Info_orderMode model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Info_order set ");
            strSql.Append("orderNum=SQL2012orderNum,");
            strSql.Append("orderDate=SQL2012orderDate,");
            strSql.Append("staffID=SQL2012staffID,");
            strSql.Append("deviceID=SQL2012deviceID,");
            strSql.Append("Count=SQL2012Count,");
            strSql.Append("IsDelete=SQL2012IsDelete");
            strSql.Append(" where orderID=SQL2012orderID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012orderNum", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012orderDate", SqlDbType.DateTime),
                    new SqlParameter("SQL2012staffID", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012deviceID", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012Count", SqlDbType.Int,4),
                    new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012orderID", SqlDbType.Int,4)};
            parameters[0].Value = model.orderNum;
            parameters[1].Value = model.orderDate;
            parameters[2].Value = model.staffID;
            parameters[3].Value = model.deviceID;
            parameters[4].Value = model.Count;
            parameters[5].Value = model.IsDelete;
            parameters[6].Value = model.orderID;

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
        public bool Delete(int orderID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Info_order ");
            strSql.Append(" where orderID=SQL2012orderID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012orderID", SqlDbType.Int,4)
            };
            parameters[0].Value = orderID;

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
        public bool DeleteList(string orderIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Info_order ");
            strSql.Append(" where orderID in (" + orderIDlist + ")  ");
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
        public Info_orderMode GetModel(int orderID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 orderID,orderNum,orderDate,staffID,deviceID,Count,IsDelete from Info_order ");
            strSql.Append(" where orderID=SQL2012orderID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012orderID", SqlDbType.Int,4)
            };
            parameters[0].Value = orderID;

            Info_orderMode model = new Info_orderMode();
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
        public Info_orderMode DataRowToModel(DataRow row)
        {
            Info_orderMode model = new Info_orderMode();
            if (row != null)
            {
                if (row["orderID"] != null && row["orderID"].ToString() != "")
                {
                    model.orderID = int.Parse(row["orderID"].ToString());
                }
                if (row["orderNum"] != null)
                {
                    model.orderNum = row["orderNum"].ToString();
                }
                if (row["orderDate"] != null && row["orderDate"].ToString() != "")
                {
                    model.orderDate = DateTime.Parse(row["orderDate"].ToString());
                }
                if (row["staffID"] != null)
                {
                    model.staffID = row["staffID"].ToString();
                }
                if (row["deviceID"] != null)
                {
                    model.deviceID = row["deviceID"].ToString();
                }
                if (row["Count"] != null && row["Count"].ToString() != "")
                {
                    model.Count = int.Parse(row["Count"].ToString());
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
            strSql.Append("select orderID,orderNum,orderDate,staffID,deviceID,Count,IsDelete ");
            strSql.Append(" FROM Info_order ");
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
            strSql.Append(" orderID,orderNum,orderDate,staffID,deviceID,Count,IsDelete ");
            strSql.Append(" FROM Info_order ");
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
            strSql.Append("select count(1) FROM Info_order ");
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
                strSql.Append("order by T.orderID desc");
            }
            strSql.Append(")AS Row, T.*  from Info_order T ");
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
			parameters[0].Value = "Info_order";
			parameters[1].Value = "orderID";
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
