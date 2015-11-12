using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00GrdTubeQueryStartingArgs : IContractArgs
    {
        private Boolean _rbxJubsuChecked;
        private String _orderDate;
        private String _orderTime;
        private String _bunho;

        public Boolean RbxJubsuChecked
        {
            get { return this._rbxJubsuChecked; }
            set { this._rbxJubsuChecked = value; }
        }

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String OrderTime
        {
            get { return this._orderTime; }
            set { this._orderTime = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public CPL2010U00GrdTubeQueryStartingArgs() { }

        public CPL2010U00GrdTubeQueryStartingArgs(Boolean rbxJubsuChecked, String orderDate, String orderTime, String bunho)
        {
            this._rbxJubsuChecked = rbxJubsuChecked;
            this._orderDate = orderDate;
            this._orderTime = orderTime;
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00GrdTubeQueryStartingRequest();
        }
    }
}