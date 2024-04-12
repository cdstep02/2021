//Grade ID: K5060
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class RepairRecord
    {
        public const int ZIP_LOW = 00000; //Zip code must be above this
        public const int ZIP_HIGH = 99999; //Zip code must be below this
        public const int ZIP_DEFAULT = 40204; //Default zipcode if incorrect Zip is put in
        public const int TEN = 10; //will be used to make sure the serial number entered is equal to 10
        const int APPT_TIME_LOW = 15; //the minimum amount of time an appointment can be
        const int APPT_TIME_HIGH = 180; //the maximum amount of time an appointment can be 
        const int MINUTE = 60; //used to calculate appointment hours property
        public const string DEFAULT_VEHICLE_NAME = "Unknown Make/Model"; //default value if there is no model entered
        public const string DEFAULT_SERIAL_NUM = "A000000000"; //default value if the serial number is not 10 numbers
        public const string DEFAULT_TECH_NAME = "John Smith"; //default value if no technician name is entered
        public const int DEFAULT_APPT_TIME = 30; //default value if incorrect appointment time is entered
        private int serviceLocationZip;//backing field for the ServiceLocationZip property
        private string vehicleMakerModel; //backing field for the VehicleMakerModel property
        private string serialNumber; //backing field for the SerialNumber property
        private int modelYear;//backing field for the ModelYear property
        private int appointmentLength; //backing field for the AppointmentLength property
        private string technicianName;//backing field for the TechnicianName property
        private bool warrantyConverage = false;//backing field for the WarrantyCoverage property
        public RepairRecord(int zip, string maker, string serialNum, int year, int length, string techName, bool warrantyCov)
        {
            ServiceLocationZip = zip;
            VehicleMakerModel = maker;
            SerialNumber = serialNum;
            ModelYear = year;
            AppointmentLength = length;
            TechnicianName = techName;
            WarrantyCoverage = warrantyCov;
        }
        public int ServiceLocationZip
        {
            //precondition: none
            //postcondition: the serviceLocationZip is returned
            get
            {
                return serviceLocationZip;
            }
            //precondition: 15 <= value <= 180
            //postcondition: the service location zip has been set to a specified value
            set
            {
                if (value >= ZIP_LOW && value <= ZIP_HIGH)
                    serviceLocationZip = value;
                else
                    serviceLocationZip = ZIP_DEFAULT;
            }
        }
        public string VehicleMakerModel
        {
            //precondition: none
            //postcondition: the vehicleMakerModel is returned
            get
            {
                return vehicleMakerModel;
            }
            //precondition: string is empty
            //postcondition:the vehicleMaker model has been set to a specified value
            set
            {
                if (String.IsNullOrWhiteSpace(vehicleMakerModel))
                    vehicleMakerModel = value;
                else
                    vehicleMakerModel = DEFAULT_VEHICLE_NAME;
            }
        }
        public string SerialNumber
        {
            //precondition: none
            //postcondition: the serialNumber is returned
            get
            {
                return serialNumber;
            }
            //precondition: value.Length == 10
            //postcondition: the serialNumber has a specified value
            set
            {
                if (value.Length == TEN)
                    serialNumber = value;
                else
                    serialNumber = DEFAULT_SERIAL_NUM;
            }
        }
        public string TechnicianName
        {
            //precondition: none
            //postcondition: the technicainName is returned
            get
            {
                return technicianName;
            }
            //precondtion: string is empty
            //postcondition: the technicianName has a been set to a specified value
            set
            {
                if (String.IsNullOrWhiteSpace(technicianName))
                    technicianName = value;
                else
                    technicianName = DEFAULT_TECH_NAME;
            }
        }
        public int AppointmentLength
        {
            //precondition: none
            //postcondition: the appointmentLength is returned
            get
            {
                return appointmentLength;
            }
            //precondition: 15 <= value <= 180
            //postcondition: appointmet length has been set to a specified value
            set
            {
                if (value >= APPT_TIME_LOW && value <= APPT_TIME_HIGH)
                    appointmentLength = value;
                else
                    appointmentLength = DEFAULT_APPT_TIME;
            }
        }
        public double AppointmentHours
        {
            //precondition: none
            //postcondition: the apptHours is returned after calculation takes place
            get
            {
                double apptHours;
                apptHours = appointmentLength / MINUTE; //calculation
                return apptHours;
            }
        }
        public int ModelYear
        {
            //precondition: none
            //postcondition: modelYear is returned
            get
            {
                return modelYear;
            }
            //precondition: none
            //postcodition: model year is assigned a value
            set
            {
                modelYear = value;
            }
        }
        public
            bool WarrantyCoverage
        {
            //precondition: none
            //postcondition: warrantyCoverage is returned
            get
            {
                return warrantyConverage;
            }
            //precondition: none
            //postcondition: warrantyCoverage is assigned a value
            set
            {
                warrantyConverage = value;
            }
        }
        private static void CalcCost(int appointmentTime, bool warranty)
        {
            const int FLAT_FEE = 25;
            const int WCOST = 20;
            const double perMinute = 1.5;
            double cost;           
            if (warranty == true)
                cost = WCOST;
            else
                cost = FLAT_FEE + perMinute * appointmentTime;
        }
        public override string ToString()
        {
            string output;
            return "Service Location Zip Code: " + ServiceLocationZip + "Year: " + ModelYear + "Maker and mode: " + VehicleMakerModel + "Serial Number: " + SerialNumber + "Appointment Length: " + AppointmentLength + "Appointment Hours: " + AppointmentHours + "Technicain Name: " + TechnicianName + "Warranty Coverage?: " + WarrantyCoverage;
            
        }
    }
}

