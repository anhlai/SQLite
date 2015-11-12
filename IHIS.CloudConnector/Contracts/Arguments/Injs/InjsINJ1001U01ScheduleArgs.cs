using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01ScheduleArgs : IContractArgs
	{
		private String _bunho;
		private String _orderDate;
		private String _postOrderYn;
		private String _preOrderYn;
		private String _reserDate;
		private String _actingFlag;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String PostOrderYn
		{
			get { return this._postOrderYn; }
			set { this._postOrderYn = value; }
		}

		public String PreOrderYn
		{
			get { return this._preOrderYn; }
			set { this._preOrderYn = value; }
		}

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public String ActingFlag
		{
			get { return this._actingFlag; }
			set { this._actingFlag = value; }
		}

		public InjsINJ1001U01ScheduleArgs() { }

		public InjsINJ1001U01ScheduleArgs(String bunho, String orderDate, String postOrderYn, String preOrderYn, String reserDate, String actingFlag)
		{
			this._bunho = bunho;
			this._orderDate = orderDate;
			this._postOrderYn = postOrderYn;
			this._preOrderYn = preOrderYn;
			this._reserDate = reserDate;
			this._actingFlag = actingFlag;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01ScheduleRequest();
		}
	}
}