using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00GrdResultArgs : IContractArgs
	{
		private String _specimenSer;
		private String _labNo;
		private String _jundalGubun;
		private String _codeType;

		public String SpecimenSer
		{
			get { return this._specimenSer; }
			set { this._specimenSer = value; }
		}

		public String LabNo
		{
			get { return this._labNo; }
			set { this._labNo = value; }
		}

		public String JundalGubun
		{
			get { return this._jundalGubun; }
			set { this._jundalGubun = value; }
		}

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public CPL3020U00GrdResultArgs() { }

		public CPL3020U00GrdResultArgs(String specimenSer, String labNo, String jundalGubun, String codeType)
		{
			this._specimenSer = specimenSer;
			this._labNo = labNo;
			this._jundalGubun = jundalGubun;
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00GrdResultRequest();
		}
	}
}