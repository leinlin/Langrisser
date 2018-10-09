using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000222 RID: 546
	[ProtoContract(Name = "ConfigDataCooperateBattleInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataCooperateBattleInfo : IExtensible
	{
		// Token: 0x06002062 RID: 8290 RVA: 0x000A0834 File Offset: 0x0009EA34
		public ConfigDataCooperateBattleInfo()
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

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x000A08BC File Offset: 0x0009EABC
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x000A08C4 File Offset: 0x0009EAC4
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

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x000A08D0 File Offset: 0x0009EAD0
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x000A08D8 File Offset: 0x0009EAD8
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x000A08E4 File Offset: 0x0009EAE4
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x000A08EC File Offset: 0x0009EAEC
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

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x000A08F8 File Offset: 0x0009EAF8
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x000A0900 File Offset: 0x0009EB00
		[ProtoMember(5, IsRequired = true, Name = "TeamName", DataFormat = DataFormat.Default)]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				this._TeamName = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x000A090C File Offset: 0x0009EB0C
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x000A0914 File Offset: 0x0009EB14
		[ProtoMember(6, IsRequired = true, Name = "Image", DataFormat = DataFormat.Default)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				this._Image = value;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x000A0920 File Offset: 0x0009EB20
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x000A0928 File Offset: 0x0009EB28
		[ProtoMember(7, IsRequired = true, Name = "BriefView", DataFormat = DataFormat.Default)]
		public string BriefView
		{
			get
			{
				return this._BriefView;
			}
			set
			{
				this._BriefView = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x000A0934 File Offset: 0x0009EB34
		[ProtoMember(8, Name = "LevelList", DataFormat = DataFormat.TwosComplement)]
		public List<int> LevelList
		{
			get
			{
				return this._LevelList;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x000A093C File Offset: 0x0009EB3C
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x000A0944 File Offset: 0x0009EB44
		[ProtoMember(9, IsRequired = true, Name = "OpenHour", DataFormat = DataFormat.Default)]
		public string OpenHour
		{
			get
			{
				return this._OpenHour;
			}
			set
			{
				this._OpenHour = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x000A0950 File Offset: 0x0009EB50
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x000A0958 File Offset: 0x0009EB58
		[ProtoMember(10, IsRequired = true, Name = "CloseHour", DataFormat = DataFormat.Default)]
		public string CloseHour
		{
			get
			{
				return this._CloseHour;
			}
			set
			{
				this._CloseHour = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x000A0964 File Offset: 0x0009EB64
		[ProtoMember(11, Name = "OpenWeekDays", DataFormat = DataFormat.TwosComplement)]
		public List<int> OpenWeekDays
		{
			get
			{
				return this._OpenWeekDays;
			}
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000A096C File Offset: 0x0009EB6C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000A097C File Offset: 0x0009EB7C
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

		// Token: 0x06002077 RID: 8311 RVA: 0x000A0A48 File Offset: 0x0009EC48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataCooperateBattleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400138F RID: 5007
		private int _ID;

		// Token: 0x04001390 RID: 5008
		private string _Name;

		// Token: 0x04001391 RID: 5009
		private string _Desc;

		// Token: 0x04001392 RID: 5010
		private string _TeamName;

		// Token: 0x04001393 RID: 5011
		private string _Image;

		// Token: 0x04001394 RID: 5012
		private string _BriefView;

		// Token: 0x04001395 RID: 5013
		private readonly List<int> _LevelList = new List<int>();

		// Token: 0x04001396 RID: 5014
		private string _OpenHour;

		// Token: 0x04001397 RID: 5015
		private string _CloseHour;

		// Token: 0x04001398 RID: 5016
		private readonly List<int> _OpenWeekDays = new List<int>();

		// Token: 0x04001399 RID: 5017
		private IExtension extensionObject;

		// Token: 0x0400139A RID: 5018
		public List<ConfigDataCooperateBattleLevelInfo> m_levelInfos;

		// Token: 0x0400139B RID: 5019
		public TimeSpan OpenTimeSpan;

		// Token: 0x0400139C RID: 5020
		public TimeSpan CloseTimeSpan;

		// Token: 0x0400139D RID: 5021
		public List<DayOfWeek> OpenDaysOfWeek = new List<DayOfWeek>();

		// Token: 0x0400139E RID: 5022
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400139F RID: 5023
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040013A0 RID: 5024
		private LuaFunction m_ctor_hotfix;
	}
}
