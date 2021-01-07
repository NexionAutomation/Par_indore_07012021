//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.DataProvider.SqlServer;
using LinqToDB.Extensions;
using LinqToDB.Mapping;

namespace ParReports_Indore
{
	/// <summary>
	/// Database       : Data_Report
	/// Data Source    : .
	/// Server Version : 15.00.2000
	/// </summary>
	public partial class DataReportDB : LinqToDB.Data.DataConnection
	{
		public ITable<FloatTable>         FloatTables         { get { return this.GetTable<FloatTable>(); } }
		public ITable<Mapping>            Mappings            { get { return this.GetTable<Mapping>(); } }
		public ITable<MappingAHULog>      MappingAHULogs      { get { return this.GetTable<MappingAHULog>(); } }
		public ITable<MappingDEHLog>      MappingDEHLogs      { get { return this.GetTable<MappingDEHLog>(); } }
		public ITable<StringTable>        StringTables        { get { return this.GetTable<StringTable>(); } }
		public ITable<Tags1Mapping2>      Tags1Mapping2       { get { return this.GetTable<Tags1Mapping2>(); } }
		public ITable<TagsMapping2>       TagsMapping2        { get { return this.GetTable<TagsMapping2>(); } }
		public ITable<TagTable>           TagTables           { get { return this.GetTable<TagTable>(); } }
		public ITable<TrendMappingAHULog> TrendMappingAHULogs { get { return this.GetTable<TrendMappingAHULog>(); } }
		public ITable<TrendMappingDEHLog> TrendMappingDEHLogs { get { return this.GetTable<TrendMappingDEHLog>(); } }
		public ITable<TrendMappingQCLog>  TrendMappingQCLogs  { get { return this.GetTable<TrendMappingQCLog>(); } }

		public DataReportDB()
		{
			InitDataContext();
		}

		public DataReportDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		partial void InitDataContext();

		#region FreeTextTable

		public class FreeTextKey<T>
		{
			public T   Key;
			public int Rank;
		}

		private static MethodInfo _freeTextTableMethod1 = typeof(DataReportDB).GetMethod("FreeTextTable", new Type[] { typeof(string), typeof(string) });

		[FreeTextTableExpression]
		public ITable<FreeTextKey<TKey>> FreeTextTable<TTable,TKey>(string field, string text)
		{
			return this.GetTable<FreeTextKey<TKey>>(
				this,
				_freeTextTableMethod1,
				field,
				text);
		}

		private static MethodInfo _freeTextTableMethod2 = 
			typeof(DataReportDB).GetMethods()
				.Where(m => m.Name == "FreeTextTable" &&  m.IsGenericMethod && m.GetParameters().Length == 2)
				.Where(m => m.GetParameters()[0].ParameterType.IsGenericTypeEx() && m.GetParameters()[0].ParameterType.GetGenericTypeDefinition() == typeof(Expression<>))
				.Where(m => m.GetParameters()[1].ParameterType == typeof(string))
				.Single();

		[FreeTextTableExpression]
		public ITable<FreeTextKey<TKey>> FreeTextTable<TTable,TKey>(Expression<Func<TTable,string>> fieldSelector, string text)
		{
			return this.GetTable<FreeTextKey<TKey>>(
				this,
				_freeTextTableMethod2,
				fieldSelector,
				text);
		}

		#endregion
	}

	[Table(Schema="dbo", Name="FloatTable")]
	public partial class FloatTable
	{
		[Column, Nullable] public DateTime? DateAndTime { get; set; } // datetime
		[Column, Nullable] public short?    Millitm     { get; set; } // smallint
		[Column, Nullable] public short?    TagIndex    { get; set; } // smallint
		[Column, Nullable] public double?   Val         { get; set; } // float
		[Column, Nullable] public char?     Status      { get; set; } // nvarchar(1)
		[Column, Nullable] public char?     Marker      { get; set; } // nvarchar(1)
	}

	[Table(Schema="dbo", Name="mapping")]
	public partial class Mapping
	{
		[Column(),                 Nullable] public string F1           { get; set; } // nvarchar(255)
		[Column("MT0022 AHU-101"), Nullable] public string Mt0022ahu101 { get; set; } // nvarchar(255)
		[Column("MT0023 AHU-102"), Nullable] public string Mt0023ahu102 { get; set; } // nvarchar(255)
		[Column("MT0024 AHU-103"), Nullable] public string Mt0024ahu103 { get; set; } // nvarchar(255)
		[Column("MT0026 AHU-105"), Nullable] public string Mt0026ahu105 { get; set; } // nvarchar(255)
		[Column("MT0027 AHU-106"), Nullable] public string Mt0027ahu106 { get; set; } // nvarchar(255)
		[Column("MT0028 AHU-107"), Nullable] public string Mt0028ahu107 { get; set; } // nvarchar(255)
		[Column("MT0031 AHU-110"), Nullable] public string Mt0031ahu110 { get; set; } // nvarchar(255)
		[Column("MT0032 AHU-111"), Nullable] public string Mt0032ahu111 { get; set; } // nvarchar(255)
		[Column("MT0033 AHU-112"), Nullable] public string Mt0033ahu112 { get; set; } // nvarchar(255)
		[Column("MT0046 AHU-125"), Nullable] public string Mt0046ahu125 { get; set; } // nvarchar(255)
		[Column("MT0051 AHU-130"), Nullable] public string Mt0051ahu130 { get; set; } // nvarchar(255)
	}

	[Table(Schema="NexionAutomation", Name="MappingAHULog")]
	public partial class MappingAHULog
	{
		[Column,        Nullable] public int?   ColumnIndex { get; set; } // int
		[Column,        Nullable] public string AHUName     { get; set; } // varchar(100)
		[Column,        Nullable] public string Description { get; set; } // varchar(50)
		[PrimaryKey, NotNull    ] public string PLCTAG      { get; set; } // varchar(50)
		[Column,     NotNull    ] public string Logic       { get; set; } // varchar(50)
		[Column,     NotNull    ] public bool   Show        { get; set; } // bit
	}

	[Table(Schema="NexionAutomation", Name="MappingDEHLog")]
	public partial class MappingDEHLog
	{
		[Column,    Nullable] public int?   ColumnIndex { get; set; } // int
		[Column,    Nullable] public string AHUName     { get; set; } // varchar(100)
		[Column,    Nullable] public string Description { get; set; } // varchar(50)
		[Column, NotNull    ] public string PLCTAG      { get; set; } // varchar(50)
		[Column, NotNull    ] public string Logic       { get; set; } // varchar(50)
		[Column, NotNull    ] public bool   Show        { get; set; } // bit
	}

	[Table(Schema="dbo", Name="StringTable")]
	public partial class StringTable
	{
		[Column, Nullable] public DateTime? DateAndTime { get; set; } // datetime
		[Column, Nullable] public short?    Millitm     { get; set; } // smallint
		[Column, Nullable] public short?    TagIndex    { get; set; } // smallint
		[Column, Nullable] public string    Val         { get; set; } // nvarchar(82)
		[Column, Nullable] public char?     Status      { get; set; } // nvarchar(1)
		[Column, Nullable] public char?     Marker      { get; set; } // nvarchar(1)
	}

	[Table(Schema="dbo", Name="Tags1_Mapping2")]
	public partial class Tags1Mapping2
	{
		[Column(),                                       Nullable] public double? Plc                              { get; set; } // float
		[Column("AHU List"),                             Nullable] public string  AHUList                          { get; set; } // varchar(255)
		[Column("Run Status"),                           Nullable] public string  RunStatus                        { get; set; } // varchar(255)
		[Column("Return Duct Temprature"),               Nullable] public string  ReturnDuctTemprature             { get; set; } // varchar(255)
		[Column("Return Duct Temprature Set Point"),     Nullable] public string  ReturnDuctTempratureSetPoint     { get; set; } // varchar(255)
		[Column("Return Duct RH"),                       Nullable] public string  ReturnDuctRH                     { get; set; } // varchar(255)
		[Column("Return Duct RH Set Point"),             Nullable] public string  ReturnDuctRHSetPoint             { get; set; } // varchar(255)
		[Column("Airflow (CFM)"),                        Nullable] public string  AirflowCfm                       { get; set; } // varchar(255)
		[Column("Airflow Set Point (CFM)"),              Nullable] public string  AirflowsetpointCfm               { get; set; } // varchar(255)
		[Column("FG Hold DPT"),                          Nullable] public string  FGHoldDPT                        { get; set; } // varchar(255)
		[Column("Material Exit Airlock DPT"),            Nullable] public string  MaterialExitAirlockDPT           { get; set; } // varchar(255)
		[Column("Overgrown DPT"),                        Nullable] public string  OvergrownDPT                     { get; set; } // varchar(255)
		[Column("Main Airlock DPT"),                     Nullable] public string  MainAirlockDPT                   { get; set; } // varchar(255)
		[Column("Packing Area DPT"),                     Nullable] public string  PackingAreaDPT                   { get; set; } // varchar(255)
		[Column("PM In DPT"),                            Nullable] public string  PMInDPT                          { get; set; } // varchar(255)
		[Column("PM Hold DPT"),                          Nullable] public string  PMHoldDPT                        { get; set; } // varchar(255)
		[Column("Blending & Packing DPT"),               Nullable] public string  BlendingPackingdpt               { get; set; } // varchar(255)
		[Column("Milling Shifting And Micronizer DPT"),  Nullable] public string  MillingShiftingAndMicronizerDPT  { get; set; } // varchar(255)
		[Column("RCVD Room-2 DPT"),                      Nullable] public string  Rcvdroom2dpt                     { get; set; } // varchar(255)
		[Column("Micronizer DPT"),                       Nullable] public string  MicronizerDPT                    { get; set; } // varchar(255)
		[Column("RCVD Room-1 DPT"),                      Nullable] public string  Rcvdroom1dpt                     { get; set; } // varchar(255)
		[Column("RM Day Store DPT"),                     Nullable] public string  RMDayStoreDPT                    { get; set; } // varchar(255)
		[Column("Wash DPT"),                             Nullable] public string  WashDPT                          { get; set; } // varchar(255)
		[Column("RM IN DPT"),                            Nullable] public string  RMINDPT                          { get; set; } // varchar(255)
		[Column("ANFD DPT"),                             Nullable] public string  ANFDDPT                          { get; set; } // varchar(255)
		[Column("Crystallisation Area 1 DPT"),           Nullable] public string  CrystallisationArea1DPT          { get; set; } // varchar(255)
		[Column("Crystallisation Area 2 DPT"),           Nullable] public string  CrystallisationArea2DPT          { get; set; } // varchar(255)
		[Column("FG Hold Temp"),                         Nullable] public string  FGHoldTemp                       { get; set; } // varchar(255)
		[Column("Packing Area Temp"),                    Nullable] public string  PackingAreaTemp                  { get; set; } // varchar(255)
		[Column("PM IN Temp"),                           Nullable] public string  PMINTemp                         { get; set; } // varchar(255)
		[Column("PM Hold Temp"),                         Nullable] public string  PMHoldTemp                       { get; set; } // varchar(255)
		[Column("Blending & Packing Temp"),              Nullable] public string  BlendingPackingtemp              { get; set; } // varchar(255)
		[Column("Micronizer Temp"),                      Nullable] public string  MicronizerTemp                   { get; set; } // varchar(255)
		[Column("Milling Shifting And Micronizer Temp"), Nullable] public string  MillingShiftingAndMicronizerTemp { get; set; } // varchar(255)
		[Column("RCVD Room 1 Temp"),                     Nullable] public string  RCVDRoom1Temp                    { get; set; } // varchar(255)
		[Column("Motor And Gear Bold Area Temp"),        Nullable] public string  MotorAndGearBoldAreaTemp         { get; set; } // varchar(255)
		[Column("RM Day Store Temp"),                    Nullable] public string  RMDayStoreTemp                   { get; set; } // varchar(255)
		[Column("RM In Temp "),                          Nullable] public string  RMInTemp                         { get; set; } // varchar(255)
		[Column("ANFD Room Temp"),                       Nullable] public string  ANFDRoomTemp                     { get; set; } // varchar(255)
		[Column("RCVD Room 2 Temp"),                     Nullable] public string  RCVDRoom2Temp                    { get; set; } // varchar(255)
		[Column("Crystallisation Area 1 Temp 1"),        Nullable] public string  CrystallisationArea1Temp1        { get; set; } // varchar(255)
		[Column("Crystallisation Area 1 Temp 2"),        Nullable] public string  CrystallisationArea1Temp2        { get; set; } // varchar(255)
		[Column("Crystallisation Area 2 Temp 1"),        Nullable] public string  CrystallisationArea2Temp1        { get; set; } // varchar(255)
		[Column("Crystallisation Area 2 Temp 2"),        Nullable] public string  CrystallisationArea2Temp2        { get; set; } // varchar(255)
		[Column("FG Hold RH"),                           Nullable] public string  FGHoldRH                         { get; set; } // varchar(255)
		[Column("Packing Area RH"),                      Nullable] public string  PackingAreaRH                    { get; set; } // varchar(255)
		[Column("PM Hold RH"),                           Nullable] public string  PMHoldRH                         { get; set; } // varchar(255)
		[Column("Blending And Packing RH"),              Nullable] public string  BlendingAndPackingRH             { get; set; } // varchar(255)
		[Column("Milling Shifting And Micronizer RH "),  Nullable] public string  MillingShiftingAndMicronizerRH   { get; set; } // varchar(255)
		[Column("RCVD Room 1 RH "),                      Nullable] public string  RCVDRoom1RH                      { get; set; } // varchar(255)
		[Column("Micronizer RH"),                        Nullable] public string  MicronizerRH                     { get; set; } // varchar(255)
		[Column("ANFD Room RH"),                         Nullable] public string  ANFDRoomRH                       { get; set; } // varchar(255)
		[Column("RCVD Room 2 RH"),                       Nullable] public string  RCVDRoom2RH                      { get; set; } // varchar(255)
		[Column("Crystallisation Area 1 RH 1"),          Nullable] public string  CrystallisationArea1RH1          { get; set; } // varchar(255)
		[Column("Crystallisation Area 1 RH 2"),          Nullable] public string  CrystallisationArea1RH2          { get; set; } // varchar(255)
		[Column("Crystallisation Area 2 RH 1"),          Nullable] public string  CrystallisationArea2RH1          { get; set; } // varchar(255)
		[Column("Crystallisation Area 2 RH 2"),          Nullable] public string  CrystallisationArea2RH2          { get; set; } // varchar(255)
	}

	[Table(Schema="dbo", Name="TagsMapping2")]
	public partial class TagsMapping2
	{
		[Column(),                       Nullable] public string F1               { get; set; } // nvarchar(255)
		[Column("AHU START COMMAND"),    Nullable] public string AHUSTARTCOMMAND  { get; set; } // nvarchar(255)
		[Column("AHU RUN STATUS"),       Nullable] public string AHURUNSTATUS     { get; set; } // nvarchar(255)
		[Column("RETURN AIR TEMP"),      Nullable] public string RETURNAIRTEMP    { get; set; } // nvarchar(255)
		[Column("RETURN AIR TEMP SP"),   Nullable] public string RETURNAIRTEMPSP  { get; set; } // nvarchar(255)
		[Column("RETURN AIR RH"),        Nullable] public string RETURNAIRRH      { get; set; } // nvarchar(255)
		[Column("RETURN AIR RH SP"),     Nullable] public string RETURNAIRRHSP    { get; set; } // nvarchar(255)
		[Column(),                       Nullable] public string CFM              { get; set; } // nvarchar(255)
		[Column("CFM SP"),               Nullable] public string CFMSP            { get; set; } // nvarchar(255)
		[Column("CHILLED WATER TEMP"),   Nullable] public string CHILLEDWATERTEMP { get; set; } // nvarchar(255)
		[Column("HOT WATER TEMP"),       Nullable] public string HOTWATERTEMP     { get; set; } // nvarchar(255)
		[Column("DX UNIT-1 COMMAND"),    Nullable] public string Dxunit1command   { get; set; } // nvarchar(255)
		[Column("DX UNIT-1 RUN STATUS"), Nullable] public string Dxunit1runstatus { get; set; } // nvarchar(255)
		[Column("DX UNIT-2 COMMAND"),    Nullable] public string Dxunit2command   { get; set; } // nvarchar(255)
		[Column("DX UNIT-2 RUN STATUS"), Nullable] public string Dxunit2runstatus { get; set; } // nvarchar(255)
		[Column("DX UNIT-3 COMMAND"),    Nullable] public string Dxunit3command   { get; set; } // nvarchar(255)
		[Column("DX UNIT-3 RUN STATUS"), Nullable] public string Dxunit3runstatus { get; set; } // nvarchar(255)
		[Column("plc"),                  Nullable] public int?   Plc              { get; set; } // int
	}

	[Table(Schema="dbo", Name="TagTable")]
	public partial class TagTable
	{
		[Column, Nullable] public string TagName     { get; set; } // nvarchar(255)
		[Column, Nullable] public short? TagIndex    { get; set; } // smallint
		[Column, Nullable] public short? TagType     { get; set; } // smallint
		[Column, Nullable] public short? TagDataType { get; set; } // smallint
	}

	[Table(Schema="NexionAutomation", Name="TrendMappingAHULog")]
	public partial class TrendMappingAHULog
	{
		[Column,    Nullable] public int?   ColumnIndex { get; set; } // int
		[Column,    Nullable] public string AHUName     { get; set; } // varchar(100)
		[Column,    Nullable] public string Description { get; set; } // varchar(50)
		[Column, NotNull    ] public string PLCTAG      { get; set; } // varchar(50)
		[Column, NotNull    ] public string Logic       { get; set; } // varchar(50)
		[Column, NotNull    ] public bool   Show        { get; set; } // bit
	}

	[Table(Schema="NexionAutomation", Name="TrendMappingDEHLog")]
	public partial class TrendMappingDEHLog
	{
		[Column,    Nullable] public int?   ColumnIndex { get; set; } // int
		[Column,    Nullable] public string AHUName     { get; set; } // varchar(100)
		[Column,    Nullable] public string Description { get; set; } // varchar(50)
		[Column, NotNull    ] public string PLCTAG      { get; set; } // varchar(50)
		[Column, NotNull    ] public string Logic       { get; set; } // varchar(50)
		[Column, NotNull    ] public bool   Show        { get; set; } // bit
	}

	[Table(Schema="NexionAutomation", Name="TrendMappingQCLog")]
	public partial class TrendMappingQCLog
	{
		[Column,    Nullable] public int?   ColumnIndex { get; set; } // int
		[Column,    Nullable] public string AHUName     { get; set; } // varchar(100)
		[Column,    Nullable] public string Description { get; set; } // varchar(50)
		[Column, NotNull    ] public string PLCTAG      { get; set; } // varchar(50)
		[Column, NotNull    ] public string Logic       { get; set; } // varchar(50)
		[Column, NotNull    ] public bool   Show        { get; set; } // bit
	}

	public static partial class DataReportDBStoredProcedures
	{
		#region GetAHULogData

		public static IEnumerable<GetAHULogDataResult> GetAHULogData(this DataConnection dataConnection, DateTime? @StartDateTime, DateTime? @EndDateTime, string @AHUName)
		{
			return dataConnection.QueryProc<GetAHULogDataResult>("[NexionAutomation].[GetAHULogData]",
				new DataParameter("@StartDateTime", @StartDateTime, DataType.DateTime),
				new DataParameter("@EndDateTime",   @EndDateTime,   DataType.DateTime),
				new DataParameter("@AHUName",       @AHUName,       DataType.VarChar));
		}


		public static IEnumerable<GetAHULogDataResult> GetAHULogDataQc(this DataConnection dataConnection, DateTime? @StartDateTime, DateTime? @EndDateTime, string @AHUName)
		{
			return dataConnection.QueryProc<GetAHULogDataResult>("[NexionAutomation].[GetAHULogDataQc]",
				new DataParameter("@StartDateTime", @StartDateTime, DataType.DateTime),
				new DataParameter("@EndDateTime", @EndDateTime, DataType.DateTime),
				new DataParameter("@AHUName", @AHUName, DataType.VarChar));
		}

		public partial class GetAHULogDataResult
		{
			public DateTime DateAndTime { get; set; }
			public string   TagName     { get; set; }
			public string   Description { get; set; }
			public string   Val         { get; set; }
		}

		#endregion

		#region GetDEHLogData

		public static IEnumerable<GetDEHLogDataResult> GetDEHLogData(this DataConnection dataConnection, DateTime? @StartDateTime, DateTime? @EndDateTime, string @AHUName)
		{
			return dataConnection.QueryProc<GetDEHLogDataResult>("[NexionAutomation].[GetDEHLogData]",
				new DataParameter("@StartDateTime", @StartDateTime, DataType.DateTime),
				new DataParameter("@EndDateTime",   @EndDateTime,   DataType.DateTime),
				new DataParameter("@AHUName",       @AHUName,       DataType.VarChar));
		}

		public partial class GetDEHLogDataResult
		{
			public DateTime DateAndTime { get; set; }
			public string   TagName     { get; set; }
			public string   Description { get; set; }
			public string   Val         { get; set; }
		}

		#endregion

		#region GetLastAHULogData

		public static IEnumerable<GetLastAHULogDataResult> GetLastAHULogData(this DataConnection dataConnection, DateTime? @StartDateTime, DateTime? @EndDateTime, string @AHUName)
		{
			return dataConnection.QueryProc<GetLastAHULogDataResult>("[NexionAutomation].[GetLastAHULogData]",
				new DataParameter("@StartDateTime", @StartDateTime, DataType.DateTime),
				new DataParameter("@EndDateTime",   @EndDateTime,   DataType.DateTime),
				new DataParameter("@AHUName",       @AHUName,       DataType.VarChar));
		}

		public partial class GetLastAHULogDataResult
		{
			public DateTime? DateAndTime { get; set; }
			public string    TagName     { get; set; }
			public string    Description { get; set; }
			public string    Val         { get; set; }
			public long?     Rank        { get; set; }
		}

		#endregion

		#region GettrendAhulogdata

		public static IEnumerable<GettrendAhulogdataresult> GettrendAhulogdata(this DataConnection dataConnection, DateTime? @StartDateTime, DateTime? @EndDateTime, string @AHUName)
		{
			return dataConnection.QueryProc<GettrendAhulogdataresult>("[NexionAutomation].[GetTREND_AHULogData]",
				new DataParameter("@StartDateTime", @StartDateTime, DataType.DateTime),
				new DataParameter("@EndDateTime",   @EndDateTime,   DataType.DateTime),
				new DataParameter("@AHUName",       @AHUName,       DataType.VarChar));
		}

		public partial class GettrendAhulogdataresult
		{
			public DateTime DateAndTime { get; set; }
			public string   TagName     { get; set; }
			public string   Description { get; set; }
			public string   Val         { get; set; }
		}

		#endregion

		#region GettrendDehlogdata

		public static IEnumerable<GettrendDehlogdataresult> GettrendDehlogdata(this DataConnection dataConnection, DateTime? @StartDateTime, DateTime? @EndDateTime, string @AHUName)
		{
			return dataConnection.QueryProc<GettrendDehlogdataresult>("[NexionAutomation].[GetTREND_DEHLogData]",
				new DataParameter("@StartDateTime", @StartDateTime, DataType.DateTime),
				new DataParameter("@EndDateTime",   @EndDateTime,   DataType.DateTime),
				new DataParameter("@AHUName",       @AHUName,       DataType.VarChar));
		}

		public partial class GettrendDehlogdataresult
		{
			public DateTime DateAndTime { get; set; }
			public string   TagName     { get; set; }
			public string   Description { get; set; }
			public string   Val         { get; set; }
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static MappingAHULog Find(this ITable<MappingAHULog> table, string PLCTAG)
		{
			return table.FirstOrDefault(t =>
				t.PLCTAG == PLCTAG);
		}
	}
}