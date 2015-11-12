using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3010U00DsvUrineArgs : IContractArgs
	{
		private String _specimenSer;
		private String _fkocs;
		private String _inOutGubun;
		private String _gubun;

		public String SpecimenSer
		{
			get { return this._specimenSer; }
			set { this._specimenSer = value; }
		}

		public String Fkocs
		{
			get { return this._fkocs; }
			set { this._fkocs = value; }
		}

		public String InOutGubun
		{
			get { return this._inOutGubun; }
			set { this._inOutGubun = value; }
		}

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public CPL3010U00DsvUrineArgs() { }

		public CPL3010U00DsvUrineArgs(String specimenSer, String fkocs, String inOutGubun, String gubun)
		{
			this._specimenSer = specimenSer;
			this._fkocs = fkocs;
			this._inOutGubun = inOutGubun;
			this._gubun = gubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3010U00DsvUrineRequest();
		}
	}
}