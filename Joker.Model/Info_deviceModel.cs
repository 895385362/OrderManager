using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joker.Model
{
    public class Info_deviceModel
    {
        public Info_deviceModel()
        { }
        #region Model
        private int _deviceid;
        private string _devicenum;
        private int _devicecount;
        private bool _isdelete = false;
        /// <summary>
        /// 
        /// </summary>
        public int deviceID
        {
            set { _deviceid = value; }
            get { return _deviceid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string deviceNum
        {
            set { _devicenum = value; }
            get { return _devicenum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int deviceCount
        {
            set { _devicecount = value; }
            get { return _devicecount; }
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
