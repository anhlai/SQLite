using System;
using System.Collections.Generic;
using System.Text;

namespace IHIS.CloudConnector.Contracts.Models.System
{
    public class PatientInfo
    {
        private string _patientName1;
        private string _patientName2;
        private string _sex;
        private string _yearAge;
        private string _monthAge;
        private string _type;
        private string _codeNm;
        private string _birth;
        private string _tel;
        private string _tel1;
        private string _telHp;
        private string _email;
        private string _zipCode1;
        private string _zipCode2;
        private string _address1;
        private string _address2;

        public PatientInfo()
        {
        }

        public PatientInfo(string patientName1, string patientName2, string sex, string yearAge, string monthAge, string type, string codeNm, string birth, string tel, string tel1, string telHp, string email, string zipCode1, string zipCode2, string address1, string address2)
        {
            _patientName1 = patientName1;
            _patientName2 = patientName2;
            _sex = sex;
            _yearAge = yearAge;
            _monthAge = monthAge;
            _type = type;
            _codeNm = codeNm;
            _birth = birth;
            _tel = tel;
            _tel1 = tel1;
            _telHp = telHp;
            _email = email;
            _zipCode1 = zipCode1;
            _zipCode2 = zipCode2;
            _address1 = address1;
            _address2 = address2;
        }

        public string PatientName1
        {
            get { return _patientName1; }
            set { _patientName1 = value; }
        }

        public string PatientName2
        {
            get { return _patientName2; }
            set { _patientName2 = value; }
        }

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public string YearAge
        {
            get { return _yearAge; }
            set { _yearAge = value; }
        }

        public string MonthAge
        {
            get { return _monthAge; }
            set { _monthAge = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string CodeNm
        {
            get { return _codeNm; }
            set { _codeNm = value; }
        }

        public string Birth
        {
            get { return _birth; }
            set { _birth = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Tel1
        {
            get { return _tel1; }
            set { _tel1 = value; }
        }

        public string TelHp
        {
            get { return _telHp; }
            set { _telHp = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string ZipCode1
        {
            get { return _zipCode1; }
            set { _zipCode1 = value; }
        }

        public string ZipCode2
        {
            get { return _zipCode2; }
            set { _zipCode2 = value; }
        }

        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }

        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
    }
}
