using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99ExecIUDArgs : IContractArgs
	{
		private String _iIudGubun;
		private String _iFksch0201;
		private String _iReserDate;
		private String _iReserTime;
		private String _iInputId;

		public String IIudGubun
		{
			get { return this._iIudGubun; }
			set { this._iIudGubun = value; }
		}

		public String IFksch0201
		{
			get { return this._iFksch0201; }
			set { this._iFksch0201 = value; }
		}

		public String IReserDate
		{
			get { return this._iReserDate; }
			set { this._iReserDate = value; }
		}

		public String IReserTime
		{
			get { return this._iReserTime; }
			set { this._iReserTime = value; }
		}

		public String IInputId
		{
			get { return this._iInputId; }
			set { this._iInputId = value; }
		}

		public SchsSCH0201U99ExecIUDArgs() { }

		public SchsSCH0201U99ExecIUDArgs(String iIudGubun, String iFksch0201, String iReserDate, String iReserTime, String iInputId)
		{
			this._iIudGubun = iIudGubun;
			this._iFksch0201 = iFksch0201;
			this._iReserDate = iReserDate;
			this._iReserTime = iReserTime;
			this._iInputId = iInputId;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99ExecIUDRequest();
		}
	}
}