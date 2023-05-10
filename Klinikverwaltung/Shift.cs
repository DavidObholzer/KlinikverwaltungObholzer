using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Klinikverwaltung
{
    internal class Shift
    {
        #region properties
        private int _shiftId, _sId;
        private DateTime _startDate, _endDate;
        private string _description;

        public int shiftId 
        {
            get 
            { 
                return _shiftId;
            }
            set 
            { 
                _shiftId = value; 
            } 
        }
        public int sId
        {
            get
            {
                return _sId;
            }
            set
            {
                _sId = value;
            }
        }
        public DateTime startDate
        { 
            get 
            { return _startDate; 
            } 
            set 
            { 
                _startDate = value; 
            } 
        }
        public DateTime endDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
            }
        }
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description= value;
            }
        }
        #endregion

        #region constructors
        public Shift () { }
        public Shift(int shiftId, int sId, DateTime startDate, DateTime endDate, string description)
        {          
            this.shiftId = shiftId;
            this.sId = sId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.description = description;
        }
        #endregion
    }
}
