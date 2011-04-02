using NHibernate.Cfg.MappingSchema;

namespace NHibernate.Mapping.ByCode
{
	public abstract class FetchMode
	{
		public static FetchMode Select = new SelectFetchMode();
		public static FetchMode Join = new JoinFetchMode();

		public abstract HbmFetchMode ToHbm();

		#region Nested type: JoinFetchMode

		private class JoinFetchMode : FetchMode
		{
			public override HbmFetchMode ToHbm()
			{
				return HbmFetchMode.Join;
			}
		}

		#endregion

		#region Nested type: SelectFetchMode

		private class SelectFetchMode : FetchMode
		{
			public override HbmFetchMode ToHbm()
			{
				return HbmFetchMode.Select;
			}
		}

		#endregion
	}
}