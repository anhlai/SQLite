using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPLBMLUPLOADERExcelInsertArgs : IContractArgs
    {
        private List<CPLBMLUPLOADERExcelInsertInfo> _uploaderExcelList = new List<CPLBMLUPLOADERExcelInsertInfo>();

        public List<CPLBMLUPLOADERExcelInsertInfo> UploaderExcelList
        {
            get { return this._uploaderExcelList; }
            set { this._uploaderExcelList = value; }
        }

        public CPLBMLUPLOADERExcelInsertArgs() { }

        public CPLBMLUPLOADERExcelInsertArgs(List<CPLBMLUPLOADERExcelInsertInfo> uploaderExcelList)
        {
            this._uploaderExcelList = uploaderExcelList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPLBMLUPLOADERExcelInsertRequest();
        }
    }
}