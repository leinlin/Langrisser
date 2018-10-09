using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020001F9 RID: 505
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataAnikiGymInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataAnikiGymInfo : IExtensible
	{
		// Token: 0x06001CC0 RID: 7360 RVA: 0x00099DA8 File Offset: 0x00097FA8
		public ConfigDataAnikiGymInfo()
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

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00099E24 File Offset: 0x00098024
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x00099E2C File Offset: 0x0009802C
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

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00099E38 File Offset: 0x00098038
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x00099E40 File Offset: 0x00098040
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

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00099E4C File Offset: 0x0009804C
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x00099E54 File Offset: 0x00098054
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

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00099E60 File Offset: 0x00098060
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x00099E68 File Offset: 0x00098068
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

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00099E74 File Offset: 0x00098074
		[ProtoMember(6, Name = "LevelList", DataFormat = DataFormat.TwosComplement)]
		public List<int> LevelList
		{
			get
			{
				return this._LevelList;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00099E7C File Offset: 0x0009807C
		[ProtoMember(7, Name = "StartTimeList", DataFormat = DataFormat.TwosComplement)]
		public List<int> StartTimeList
		{
			get
			{
				return this._StartTimeList;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00099E84 File Offset: 0x00098084
		// (set) Token: 0x06001CCC RID: 7372 RVA: 0x00099E8C File Offset: 0x0009808C
		[ProtoMember(8, IsRequired = true, Name = "OpenDesc", DataFormat = DataFormat.Default)]
		public string OpenDesc
		{
			get
			{
				return this._OpenDesc;
			}
			set
			{
				this._OpenDesc = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00099E98 File Offset: 0x00098098
		// (set) Token: 0x06001CCE RID: 7374 RVA: 0x00099EA0 File Offset: 0x000980A0
		[ProtoMember(9, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00099EAC File Offset: 0x000980AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00099EBC File Offset: 0x000980BC
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

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00099F88 File Offset: 0x00098188
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataAnikiGymInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001125 RID: 4389
		private int _ID;

		// Token: 0x04001126 RID: 4390
		private string _Name;

		// Token: 0x04001127 RID: 4391
		private string _Desc;

		// Token: 0x04001128 RID: 4392
		private string _TeamName;

		// Token: 0x04001129 RID: 4393
		private readonly List<int> _LevelList = new List<int>();

		// Token: 0x0400112A RID: 4394
		private readonly List<int> _StartTimeList = new List<int>();

		// Token: 0x0400112B RID: 4395
		private string _OpenDesc;

		// Token: 0x0400112C RID: 4396
		private string _Icon;

		// Token: 0x0400112D RID: 4397
		private IExtension extensionObject;

		// Token: 0x0400112E RID: 4398
		public List<ConfigDataAnikiLevelInfo> m_levelInfos;

		// Token: 0x0400112F RID: 4399
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001130 RID: 4400
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001131 RID: 4401
		private LuaFunction m_ctor_hotfix;
	}
}
