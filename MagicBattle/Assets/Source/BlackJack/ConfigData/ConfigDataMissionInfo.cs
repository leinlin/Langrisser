using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000261 RID: 609
	[ProtoContract(Name = "ConfigDataMissionInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataMissionInfo : IExtensible
	{
		// Token: 0x060026F8 RID: 9976 RVA: 0x000AB010 File Offset: 0x000A9210
		public ConfigDataMissionInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000AB08C File Offset: 0x000A928C
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x000AB094 File Offset: 0x000A9294
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000AB0A0 File Offset: 0x000A92A0
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x000AB0A8 File Offset: 0x000A92A8
		[ProtoMember(3, IsRequired = true, Name = "Title", DataFormat = DataFormat.Default)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				this._Title = value;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x000AB0B4 File Offset: 0x000A92B4
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x000AB0BC File Offset: 0x000A92BC
		[ProtoMember(4, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x000AB0C8 File Offset: 0x000A92C8
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x000AB0D0 File Offset: 0x000A92D0
		[ProtoMember(5, IsRequired = true, Name = "MissionPeriod", DataFormat = DataFormat.TwosComplement)]
		public MissionPeriodType MissionPeriod
		{
			get
			{
				return this._MissionPeriod;
			}
			set
			{
				this._MissionPeriod = value;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000AB0DC File Offset: 0x000A92DC
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x000AB0E4 File Offset: 0x000A92E4
		[ProtoMember(6, IsRequired = true, Name = "MissionColumn", DataFormat = DataFormat.TwosComplement)]
		public MissionColumnType MissionColumn
		{
			get
			{
				return this._MissionColumn;
			}
			set
			{
				this._MissionColumn = value;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x000AB0F0 File Offset: 0x000A92F0
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x000AB0F8 File Offset: 0x000A92F8
		[ProtoMember(7, IsRequired = true, Name = "MissionType", DataFormat = DataFormat.TwosComplement)]
		public MissionType MissionType
		{
			get
			{
				return this._MissionType;
			}
			set
			{
				this._MissionType = value;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x000AB104 File Offset: 0x000A9304
		// (set) Token: 0x06002706 RID: 9990 RVA: 0x000AB10C File Offset: 0x000A930C
		[ProtoMember(8, IsRequired = true, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public int Param1
		{
			get
			{
				return this._Param1;
			}
			set
			{
				this._Param1 = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000AB118 File Offset: 0x000A9318
		// (set) Token: 0x06002708 RID: 9992 RVA: 0x000AB120 File Offset: 0x000A9320
		[ProtoMember(9, IsRequired = true, Name = "Param2", DataFormat = DataFormat.TwosComplement)]
		public int Param2
		{
			get
			{
				return this._Param2;
			}
			set
			{
				this._Param2 = value;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x000AB12C File Offset: 0x000A932C
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x000AB134 File Offset: 0x000A9334
		[ProtoMember(10, IsRequired = true, Name = "Param3", DataFormat = DataFormat.TwosComplement)]
		public int Param3
		{
			get
			{
				return this._Param3;
			}
			set
			{
				this._Param3 = value;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x000AB140 File Offset: 0x000A9340
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x000AB148 File Offset: 0x000A9348
		[ProtoMember(11, IsRequired = true, Name = "Param4", DataFormat = DataFormat.TwosComplement)]
		public int Param4
		{
			get
			{
				return this._Param4;
			}
			set
			{
				this._Param4 = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x000AB154 File Offset: 0x000A9354
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x000AB15C File Offset: 0x000A935C
		[ProtoMember(12, IsRequired = true, Name = "MissionUnlockPlayerLvl", DataFormat = DataFormat.TwosComplement)]
		public int MissionUnlockPlayerLvl
		{
			get
			{
				return this._MissionUnlockPlayerLvl;
			}
			set
			{
				this._MissionUnlockPlayerLvl = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x000AB168 File Offset: 0x000A9368
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x000AB170 File Offset: 0x000A9370
		[ProtoMember(13, IsRequired = true, Name = "MissionUnlockPreTaskID", DataFormat = DataFormat.TwosComplement)]
		public int MissionUnlockPreTaskID
		{
			get
			{
				return this._MissionUnlockPreTaskID;
			}
			set
			{
				this._MissionUnlockPreTaskID = value;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x000AB17C File Offset: 0x000A937C
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x000AB184 File Offset: 0x000A9384
		[ProtoMember(14, IsRequired = true, Name = "MissionUnlockScenarioID", DataFormat = DataFormat.TwosComplement)]
		public int MissionUnlockScenarioID
		{
			get
			{
				return this._MissionUnlockScenarioID;
			}
			set
			{
				this._MissionUnlockScenarioID = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x000AB190 File Offset: 0x000A9390
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x000AB198 File Offset: 0x000A9398
		[ProtoMember(15, IsRequired = true, Name = "SortID", DataFormat = DataFormat.TwosComplement)]
		public int SortID
		{
			get
			{
				return this._SortID;
			}
			set
			{
				this._SortID = value;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x000AB1A4 File Offset: 0x000A93A4
		[ProtoMember(16, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x000AB1AC File Offset: 0x000A93AC
		// (set) Token: 0x06002717 RID: 10007 RVA: 0x000AB1B4 File Offset: 0x000A93B4
		[ProtoMember(17, IsRequired = true, Name = "NoviceExt", DataFormat = DataFormat.TwosComplement)]
		public int NoviceExt
		{
			get
			{
				return this._NoviceExt;
			}
			set
			{
				this._NoviceExt = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x000AB1C0 File Offset: 0x000A93C0
		[ProtoMember(19, Name = "GetPathList", DataFormat = DataFormat.Default)]
		public List<GetPathData> GetPathList
		{
			get
			{
				return this._GetPathList;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x000AB1C8 File Offset: 0x000A93C8
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x000AB1D0 File Offset: 0x000A93D0
		[ProtoMember(20, IsRequired = true, Name = "IsMonthCardMission", DataFormat = DataFormat.Default)]
		public bool IsMonthCardMission
		{
			get
			{
				return this._IsMonthCardMission;
			}
			set
			{
				this._IsMonthCardMission = value;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x000AB1DC File Offset: 0x000A93DC
		// (set) Token: 0x0600271C RID: 10012 RVA: 0x000AB1E4 File Offset: 0x000A93E4
		[ProtoMember(21, IsRequired = true, Name = "Obsoleted", DataFormat = DataFormat.Default)]
		public bool Obsoleted
		{
			get
			{
				return this._Obsoleted;
			}
			set
			{
				this._Obsoleted = value;
			}
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000AB1F0 File Offset: 0x000A93F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000AB200 File Offset: 0x000A9400
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000AB2CC File Offset: 0x000A94CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataMissionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040017D9 RID: 6105
		private int _ID;

		// Token: 0x040017DA RID: 6106
		private string _Title;

		// Token: 0x040017DB RID: 6107
		private string _Desc;

		// Token: 0x040017DC RID: 6108
		private MissionPeriodType _MissionPeriod;

		// Token: 0x040017DD RID: 6109
		private MissionColumnType _MissionColumn;

		// Token: 0x040017DE RID: 6110
		private MissionType _MissionType;

		// Token: 0x040017DF RID: 6111
		private int _Param1;

		// Token: 0x040017E0 RID: 6112
		private int _Param2;

		// Token: 0x040017E1 RID: 6113
		private int _Param3;

		// Token: 0x040017E2 RID: 6114
		private int _Param4;

		// Token: 0x040017E3 RID: 6115
		private int _MissionUnlockPlayerLvl;

		// Token: 0x040017E4 RID: 6116
		private int _MissionUnlockPreTaskID;

		// Token: 0x040017E5 RID: 6117
		private int _MissionUnlockScenarioID;

		// Token: 0x040017E6 RID: 6118
		private int _SortID;

		// Token: 0x040017E7 RID: 6119
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x040017E8 RID: 6120
		private int _NoviceExt;

		// Token: 0x040017E9 RID: 6121
		private readonly List<GetPathData> _GetPathList = new List<GetPathData>();

		// Token: 0x040017EA RID: 6122
		private bool _IsMonthCardMission;

		// Token: 0x040017EB RID: 6123
		private bool _Obsoleted;

		// Token: 0x040017EC RID: 6124
		private IExtension extensionObject;

		// Token: 0x040017ED RID: 6125
		public ConfigDataMissionExtNoviceInfo m_Novice;

		// Token: 0x040017EE RID: 6126
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040017EF RID: 6127
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040017F0 RID: 6128
		private LuaFunction m_ctor_hotfix;
	}
}
