using System;

namespace IHIS.CloudConnector.Contracts.Models.Orca
{
    public class ORCATransferOrdersHealthInsuranceInfo
    {
        private String _countryType;
        private String _insuranceCode;
        private String _insuranceNumber;
        private String _insuranceStartDate;
        private String _insuranceEndDate;
        private String _priorityNumber;
        private String _providerName;
        private String _publicStartDate;
        private String _publicEndDate;

        public String CountryType
        {
            get { return this._countryType; }
            set { this._countryType = value; }
        }

        public String InsuranceCode
        {
            get { return this._insuranceCode; }
            set { this._insuranceCode = value; }
        }

        public String InsuranceNumber
        {
            get { return this._insuranceNumber; }
            set { this._insuranceNumber = value; }
        }

        public String InsuranceStartDate
        {
            get { return this._insuranceStartDate; }
            set { this._insuranceStartDate = value; }
        }

        public String InsuranceEndDate
        {
            get { return this._insuranceEndDate; }
            set { this._insuranceEndDate = value; }
        }

        public String PriorityNumber
        {
            get { return this._priorityNumber; }
            set { this._priorityNumber = value; }
        }

        public String ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        public String PublicStartDate
        {
            get { return this._publicStartDate; }
            set { this._publicStartDate = value; }
        }

        public String PublicEndDate
        {
            get { return this._publicEndDate; }
            set { this._publicEndDate = value; }
        }

        public ORCATransferOrdersHealthInsuranceInfo() { }

        public ORCATransferOrdersHealthInsuranceInfo(String countryType, String insuranceCode, String insuranceNumber, String insuranceStartDate, String insuranceEndDate, String priorityNumber, String providerName, String publicStartDate, String publicEndDate)
        {
            this._countryType = countryType;
            this._insuranceCode = insuranceCode;
            this._insuranceNumber = insuranceNumber;
            this._insuranceStartDate = insuranceStartDate;
            this._insuranceEndDate = insuranceEndDate;
            this._priorityNumber = priorityNumber;
            this._providerName = providerName;
            this._publicStartDate = publicStartDate;
            this._publicEndDate = publicEndDate;
        }

    }
}