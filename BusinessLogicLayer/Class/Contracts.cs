using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Class
{
    public class Contracts
    {
        private int _contractID;
        private string _contractType;
        private int _employeeID;
        private string _workHours;
        private string _position;
        private bool _active;
        private DateOnly _startDate;
        private DateOnly? _endDate;
        private string? _reason;

        public Contracts(int contractID, string contractType, int employeeID, string workHours, string position, DateOnly startDate, DateOnly endDate) 
        {
            _contractID = contractID;
            _contractType = contractType;
            _employeeID = employeeID;
            _workHours = workHours;
            _position = position;
            _startDate = startDate;
            _endDate = endDate;
        }

        public Contracts(int contractID, string contractType, int employeeID, string workHours, string position, DateOnly startDate)
        {
            _contractID = contractID;
            _contractType = contractType;
            _employeeID = employeeID;
            _workHours = workHours;
            _position = position;
            _startDate = startDate;
        }

        public string Reason
        {
            get { return _reason; }
            set 
            {
                if ( value != null )
                {
                    _reason = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{_contractID} - {_contractType}";
        }

    }
}
