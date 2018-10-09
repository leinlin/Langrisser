using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B5 RID: 693
	[ProtoContract(Name = "ConfigDataWorldMapInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataWorldMapInfo : IExtensible
	{
		// Token: 0x06002DBC RID: 11708 RVA: 0x000B7858 File Offset: 0x000B5A58
		public ConfigDataWorldMapInfo()
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

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002DBD RID: 11709 RVA: 0x000B78CC File Offset: 0x000B5ACC
		// (set) Token: 0x06002DBE RID: 11710 RVA: 0x000B78D4 File Offset: 0x000B5AD4
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

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002DBF RID: 11711 RVA: 0x000B78E0 File Offset: 0x000B5AE0
		// (set) Token: 0x06002DC0 RID: 11712 RVA: 0x000B78E8 File Offset: 0x000B5AE8
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

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x000B78F4 File Offset: 0x000B5AF4
		// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x000B78FC File Offset: 0x000B5AFC
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000B7908 File Offset: 0x000B5B08
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x000B7910 File Offset: 0x000B5B10
		[ProtoMember(5, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000B791C File Offset: 0x000B5B1C
		[ProtoMember(6, Name = "Regions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Regions_ID
		{
			get
			{
				return this._Regions_ID;
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x000B7924 File Offset: 0x000B5B24
		// (set) Token: 0x06002DC7 RID: 11719 RVA: 0x000B792C File Offset: 0x000B5B2C
		[ProtoMember(7, IsRequired = true, Name = "StartRegion_ID", DataFormat = DataFormat.TwosComplement)]
		public int StartRegion_ID
		{
			get
			{
				return this._StartRegion_ID;
			}
			set
			{
				this._StartRegion_ID = value;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x000B7938 File Offset: 0x000B5B38
		// (set) Token: 0x06002DC9 RID: 11721 RVA: 0x000B7940 File Offset: 0x000B5B40
		[ProtoMember(8, IsRequired = true, Name = "StartWaypoint_ID", DataFormat = DataFormat.TwosComplement)]
		public int StartWaypoint_ID
		{
			get
			{
				return this._StartWaypoint_ID;
			}
			set
			{
				this._StartWaypoint_ID = value;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x000B794C File Offset: 0x000B5B4C
		// (set) Token: 0x06002DCB RID: 11723 RVA: 0x000B7954 File Offset: 0x000B5B54
		[ProtoMember(9, IsRequired = true, Name = "WorldMap", DataFormat = DataFormat.Default)]
		public string WorldMap
		{
			get
			{
				return this._WorldMap;
			}
			set
			{
				this._WorldMap = value;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x000B7960 File Offset: 0x000B5B60
		// (set) Token: 0x06002DCD RID: 11725 RVA: 0x000B7968 File Offset: 0x000B5B68
		[ProtoMember(10, IsRequired = true, Name = "BackgroundWidth", DataFormat = DataFormat.TwosComplement)]
		public int BackgroundWidth
		{
			get
			{
				return this._BackgroundWidth;
			}
			set
			{
				this._BackgroundWidth = value;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x000B7974 File Offset: 0x000B5B74
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x000B797C File Offset: 0x000B5B7C
		[ProtoMember(11, IsRequired = true, Name = "BackgroundHeight", DataFormat = DataFormat.TwosComplement)]
		public int BackgroundHeight
		{
			get
			{
				return this._BackgroundHeight;
			}
			set
			{
				this._BackgroundHeight = value;
			}
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000B7988 File Offset: 0x000B5B88
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000B7998 File Offset: 0x000B5B98
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

		// Token: 0x06002DD2 RID: 11730 RVA: 0x000B7A64 File Offset: 0x000B5C64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataWorldMapInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001C4B RID: 7243
		private int _ID;

		// Token: 0x04001C4C RID: 7244
		private string _Name;

		// Token: 0x04001C4D RID: 7245
		private string _NameStrKey;

		// Token: 0x04001C4E RID: 7246
		private string _Desc;

		// Token: 0x04001C4F RID: 7247
		private readonly List<int> _Regions_ID = new List<int>();

		// Token: 0x04001C50 RID: 7248
		private int _StartRegion_ID;

		// Token: 0x04001C51 RID: 7249
		private int _StartWaypoint_ID;

		// Token: 0x04001C52 RID: 7250
		private string _WorldMap;

		// Token: 0x04001C53 RID: 7251
		private int _BackgroundWidth;

		// Token: 0x04001C54 RID: 7252
		private int _BackgroundHeight;

		// Token: 0x04001C55 RID: 7253
		private IExtension extensionObject;

		// Token: 0x04001C56 RID: 7254
		public ConfigDataRegionInfo[] m_regionInfos;

		// Token: 0x04001C57 RID: 7255
		public ConfigDataRegionInfo m_startRegionInfo;

		// Token: 0x04001C58 RID: 7256
		public ConfigDataWaypointInfo m_startWaypointInfo;

		// Token: 0x04001C59 RID: 7257
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001C5A RID: 7258
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001C5B RID: 7259
		private LuaFunction m_ctor_hotfix;
	}
}
