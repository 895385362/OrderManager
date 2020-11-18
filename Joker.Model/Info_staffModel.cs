using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joker.Model
{
    public class Info_staffModel
    {
        public Info_staffModel()
        { }
        #region Model
        private int _staffid;
        private string _staffnum;
        private string _staffname;
        private string _staffavatar;
        private int _staffsex;
        private int _staffage;
        private string _staffmobile;
        private string _staffpassword;
        private int? _provinceid;
        private string _provincename;
        private int? _cityid;
        private string _cityname;
        private int? _districtid;
        private string _districtname;
        private string _address;
        private bool _isdelete = false;
        /// <summary>
        /// 
        /// </summary>
        public int staffID
        {
            set { _staffid = value; }
            get { return _staffid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string staffNum
        {
            set { _staffnum = value; }
            get { return _staffnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string staffName
        {
            set { _staffname = value; }
            get { return _staffname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string staffAvatar
        {
            set { _staffavatar = value; }
            get { return _staffavatar; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int staffSex
        {
            set { _staffsex = value; }
            get { return _staffsex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int staffAge
        {
            set { _staffage = value; }
            get { return _staffage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string staffMobile
        {
            set { _staffmobile = value; }
            get { return _staffmobile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string staffPassword
        {
            set { _staffpassword = value; }
            get { return _staffpassword; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ProvinceID
        {
            set { _provinceid = value; }
            get { return _provinceid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ProvinceName
        {
            set { _provincename = value; }
            get { return _provincename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CityID
        {
            set { _cityid = value; }
            get { return _cityid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CityName
        {
            set { _cityname = value; }
            get { return _cityname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DistrictID
        {
            set { _districtid = value; }
            get { return _districtid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DistrictName
        {
            set { _districtname = value; }
            get { return _districtname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
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
