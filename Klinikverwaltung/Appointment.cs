using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinikverwaltung
{
    public class Appointment
    {
        #region
        private string _patient, _staff, _room, _description, _id;

        public string patient
        {
            get
            {
                return _patient;
            }
            set
            {
                _patient = value;
            }
        }
        public string staff
        {
            get
            {
                return _staff;
            }
            set
            {
                _staff = value;
            }
        }
        public string room
        {
            get
            {
                return _room;
            }
            set
            {
                _room = value;
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
                _description = value;
            }
        }
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        #endregion

        #region
        public Appointment() { }

        public Appointment(string patient, string staff, string room, string description)
        {
            this.patient = patient;
            this.staff = staff;
            this.room = room;
            this.description = description;
        }
        #endregion
    }
}
