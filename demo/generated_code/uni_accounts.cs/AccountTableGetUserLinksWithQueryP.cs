using System;
using System.Collections;
using c = Far.Core;

namespace Far.Data
{
	public class AccountTableGetUserLinksWithQueryP : c.AbstractDataTable
	{
		#region static IDataField IdField 
		public static c.IDataField IdField { get { return new IdFieldClass(); } }
		#endregion

		#region static IDataField AccountNumberField 
		public static c.IDataField AccountNumberField { get { return new AccountNumberFieldClass(); } }
		#endregion

		#region static IDataField FullAccountNumberField 
		public static c.IDataField FullAccountNumberField { get { return new FullAccountNumberFieldClass(); } }
		#endregion

		#region static IDataField AccountDescriptionField 
		public static c.IDataField AccountDescriptionField { get { return new AccountDescriptionFieldClass(); } }
		#endregion

		#region static IDataField SelectedField 
		public static c.IDataField SelectedField { get { return new SelectedFieldClass(); } }
		#endregion

		#region constructor 
		public AccountTableGetUserLinksWithQueryP(ArrayList rows, int totalCount) : base(rows, totalCount) {}
		#endregion

		#region int FieldCount
		public override int FieldCount { get { return 5; } }
		#endregion

		#region AccountRowGetUserLinksWithQueryP this[int row]
		public AccountRowGetUserLinksWithQueryP this[int row] { get { return (AccountRowGetUserLinksWithQueryP)Rows[row]; } }
		#endregion

		#region private
		private class IdFieldClass : c.IDataField
		{
			public string DataField { get { return "Id"; } }
			public string SortExpression { get { return "Account.Id"; } }
			public string Display { get { return "Id"; } }
		}

		private class AccountNumberFieldClass : c.IDataField
		{
			public string DataField { get { return "AccountNumber"; } }
			public string SortExpression { get { return "Account.AccountNumber"; } }
			public string Display { get { return "Account Number"; } }
		}

		private class FullAccountNumberFieldClass : c.IDataField
		{
			public string DataField { get { return "FullAccountNumber"; } }
			public string SortExpression { get { return "Account.FullAccountNumber"; } }
			public string Display { get { return "Full Account Number"; } }
		}

		private class AccountDescriptionFieldClass : c.IDataField
		{
			public string DataField { get { return "AccountDescription"; } }
			public string SortExpression { get { return "Account.AccountDescription"; } }
			public string Display { get { return "Account Description"; } }
		}

		private class SelectedFieldClass : c.IDataField
		{
			public string DataField { get { return "Selected"; } }
			public string SortExpression { get { return "Selected"; } }
			public string Display { get { return "Selected"; } }
		}

		private class SelectedRecord : c.IDataField
		{
			public string DataField { get { return "Selected"; } }
			public string SortExpression { get { return "Selected"; } }
			public string Display { get { return "Selected"; } }
		}
		#endregion
	}

	public class AccountRowGetUserLinksWithQueryP : c.IDataRow
	{
		#region int Id
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		#endregion

		#region string AccountNumber
		public string AccountNumber
		{
			get { return accountNumber; }
			set { accountNumber = value; }
		}
		#endregion

		#region string FullAccountNumber
		public string FullAccountNumber
		{
			get { return fullAccountNumber; }
			set { fullAccountNumber = value; }
		}
		#endregion

		#region string AccountDescription
		public string AccountDescription
		{
			get { return accountDescription; }
			set { accountDescription = value; }
		}
		#endregion

		#region bool Selected
		public bool Selected
		{
			get { return selected; }
			set { selected = value; }
		}
		#endregion

		#region private
		private int id;
		private string accountNumber;
		private string fullAccountNumber;
		private string accountDescription;
		private bool selected;
		#endregion
	}
}