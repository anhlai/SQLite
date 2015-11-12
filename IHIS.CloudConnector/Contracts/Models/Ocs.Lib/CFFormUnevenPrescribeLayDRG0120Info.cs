using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
    public class CFFormUnevenPrescribeLayDRG0120Info
    {
        private String _bogyongCode;
        private String _bogyongName;
        private String _pattern;
        private String _bogyongGubun;
        private String _bogyongJoFlag;
        private String _bogyongJuFlag;
        private String _bogyongSeokFlag;
        private String _bogyongTime1Flag;
        private String _bogyongTime2Flag;
        private String _bogyongTime3Flag;
        private String _bogyongTime4Flag;
        private String _bogyongTime5Flag;
        private String _bogyongTime6Flag;
        private String _bogyongTime7Flag;

        public String BogyongCode
        {
            get { return this._bogyongCode; }
            set { this._bogyongCode = value; }
        }

        public String BogyongName
        {
            get { return this._bogyongName; }
            set { this._bogyongName = value; }
        }

        public String Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        public String BogyongGubun
        {
            get { return this._bogyongGubun; }
            set { this._bogyongGubun = value; }
        }

        public String BogyongJoFlag
        {
            get { return this._bogyongJoFlag; }
            set { this._bogyongJoFlag = value; }
        }

        public String BogyongJuFlag
        {
            get { return this._bogyongJuFlag; }
            set { this._bogyongJuFlag = value; }
        }

        public String BogyongSeokFlag
        {
            get { return this._bogyongSeokFlag; }
            set { this._bogyongSeokFlag = value; }
        }

        public String BogyongTime1Flag
        {
            get { return this._bogyongTime1Flag; }
            set { this._bogyongTime1Flag = value; }
        }

        public String BogyongTime2Flag
        {
            get { return this._bogyongTime2Flag; }
            set { this._bogyongTime2Flag = value; }
        }

        public String BogyongTime3Flag
        {
            get { return this._bogyongTime3Flag; }
            set { this._bogyongTime3Flag = value; }
        }

        public String BogyongTime4Flag
        {
            get { return this._bogyongTime4Flag; }
            set { this._bogyongTime4Flag = value; }
        }

        public String BogyongTime5Flag
        {
            get { return this._bogyongTime5Flag; }
            set { this._bogyongTime5Flag = value; }
        }

        public String BogyongTime6Flag
        {
            get { return this._bogyongTime6Flag; }
            set { this._bogyongTime6Flag = value; }
        }

        public String BogyongTime7Flag
        {
            get { return this._bogyongTime7Flag; }
            set { this._bogyongTime7Flag = value; }
        }

        public CFFormUnevenPrescribeLayDRG0120Info() { }

        public CFFormUnevenPrescribeLayDRG0120Info(String bogyongCode, String bogyongName, String pattern, String bogyongGubun, String bogyongJoFlag, String bogyongJuFlag, String bogyongSeokFlag, String bogyongTime1Flag, String bogyongTime2Flag, String bogyongTime3Flag, String bogyongTime4Flag, String bogyongTime5Flag, String bogyongTime6Flag, String bogyongTime7Flag)
        {
            this._bogyongCode = bogyongCode;
            this._bogyongName = bogyongName;
            this._pattern = pattern;
            this._bogyongGubun = bogyongGubun;
            this._bogyongJoFlag = bogyongJoFlag;
            this._bogyongJuFlag = bogyongJuFlag;
            this._bogyongSeokFlag = bogyongSeokFlag;
            this._bogyongTime1Flag = bogyongTime1Flag;
            this._bogyongTime2Flag = bogyongTime2Flag;
            this._bogyongTime3Flag = bogyongTime3Flag;
            this._bogyongTime4Flag = bogyongTime4Flag;
            this._bogyongTime5Flag = bogyongTime5Flag;
            this._bogyongTime6Flag = bogyongTime6Flag;
            this._bogyongTime7Flag = bogyongTime7Flag;
        }

    }
}