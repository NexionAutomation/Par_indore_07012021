﻿using System;
using System.Linq;

using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;

using NUnit.Framework;

namespace Tests.UserTests
{
	[TestFixture]
	public class CompareNullableCharTests : TestBase
	{
		class Table1
		{
			[PrimaryKey(1)]
			[Identity] public Int64 Field1 { get; set; }
			[Nullable] public Char? Foeld2 { get; set; }
		}

		class Repository : DataConnection
		{
			public Repository(string configurationString) : base(configurationString)
			{
			}

			public ITable<Table1> Table1 => this.GetTable<Table1>();
		}

		[Test, IncludeDataContextSource(ProviderName.Access)]
		public void Test(string context)
		{
			using (var db = new Repository(context))
			{
				var q =
					from current  in db.Table1
					from previous in db.Table1
					where current.Foeld2 == previous.Foeld2
					select new { current.Field1, Field2 = previous.Field1 };

				var sql = q.ToString();
			}
		}
	}
}