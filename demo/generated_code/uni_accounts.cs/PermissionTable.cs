using System;
using System.Collections;
using c = Far.Core;

namespace Far.Data
{
	public class PermissionTable : c.AbstractDataTable
	{
		#region static IDataField IdField 
		public static c.IDataField IdField { get { return new IdFieldClass(); } }
		#endregion

		#region static IDataField CategoryIdField 
		public static c.IDataField CategoryIdField { get { return new CategoryIdFieldClass(); } }
		#endregion

		#region static IDataField DescriptionField 
		public static c.IDataField DescriptionField { get { return new DescriptionFieldClass(); } }
		#endregion

		#region static IDataField RankField 
		public static c.IDataField RankField { get { return new RankFieldClass(); } }
		#endregion

		#region static IDataField SelectedField 
		public static c.IDataField SelectedField { get { return new SelectedRecord(); } }
		#endregion

		#region constructor 
		public PermissionTable(ArrayList rows, int totalCount) : base(rows, totalCount) {}
		#endregion

		#region int FieldCount
		public override int FieldCount { get { return 5; } }
		#endregion

		#region PermissionRow this[int row]
		public PermissionRow this[int row] { get { return (PermissionRow)Rows[row]; } }
		#endregion

		#region private
		private class IdFieldClass : c.IDataField
		{
			public string DataField { get { return "Id"; } }
			public string SortExpression { get { return "Permission.Id"; } }
			public string Display { get { return "Id"; } }
		}

		private class CategoryIdFieldClass : c.IDataField
		{
			public string DataField { get { return "CategoryId"; } }
			public string SortExpression { get { return "Permission.CategoryId"; } }
			public string Display { get { return "CategoryId"; } }
		}

		private class DescriptionFieldClass : c.IDataField
		{
			public string DataField { get { return "Description"; } }
			public string SortExpression { get { return "Permission.Description"; } }
			public string Display { get { return "Description"; } }
		}

		private class RankFieldClass : c.IDataField
		{
			public string DataField { get { return "Rank"; } }
			public string SortExpression { get { return "Permission.Rank"; } }
			public string Display { get { return "Rank"; } }
		}

		private class SelectedRecord : c.IDataField
		{
			public string DataField { get { return "Selected"; } }
			public string SortExpression { get { return "Selected"; } }
			public string Display { get { return "Selected"; } }
		}
		#endregion
	}

	public class PermissionRow : c.IDataRow
	{
		#region int Id
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		#endregion

		#region int CategoryId
		public int CategoryId
		{
			get { return categoryId; }
			set { categoryId = value; }
		}
		#endregion

		#region string Description
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
		#endregion

		#region short Rank
		public short Rank
		{
			get { return rank; }
			set { rank = value; }
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
		private int categoryId;
		private string description;
		private short rank;
		private bool selected;
		#endregion
	}
}