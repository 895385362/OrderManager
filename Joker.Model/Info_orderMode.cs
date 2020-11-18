using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joker.Model
{
    public class Info_orderMode
    {
        public Info_orderMode()
        { }
        #region Model
        private int _orderid;
        private string _ordernum;
        private DateTime? _orderdate = DateTime.Now;
        private string _staffid;
        private string _deviceid;
        private int _count;
        private bool _isdelete = false;
        /// <summary>
        /// 
        /// </summary>
        public int orderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string orderNum
        {
            set { _ordernum = value; }
            get { return _ordernum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? orderDate
        {
            set { _orderdate = value; }
            get { return _orderdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string staffID
        {
            set { _staffid = value; }
            get { return _staffid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string deviceID
        {
            set { _deviceid = value; }
            get { return _deviceid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Count
        {
            set { _count = value; }
            get { return _count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDelete
        {
            set { _isdelete = value; }
            get { return _isdelete; }
        }
        #endregion Model
    }
}
