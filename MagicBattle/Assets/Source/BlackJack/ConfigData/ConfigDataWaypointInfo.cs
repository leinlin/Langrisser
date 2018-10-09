using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B4 RID: 692
	[ProtoContract(Name = "ConfigDataWaypointInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataWaypointInfo : IExtensible
	{
		// Token: 0x06002DA2 RID: 11682 RVA: 0x000B75C0 File Offset: 0x000B57C0
		public ConfigDataWaypointInfo()
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

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002DA3 RID: 11683 RVA: 0x000B763C File Offset: 0x000B583C
		// (set) Token: 0x06002DA4 RID: 11684 RVA: 0x000B7644 File Offset: 0x000B5844
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

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06002DA5 RID: 11685 RVA: 0x000B7650 File Offset: 0x000B5850
		// (set) Token: 0x06002DA6 RID: 11686 RVA: 0x000B7658 File Offset: 0x000B5858
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

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06002DA7 RID: 11687 RVA: 0x000B7664 File Offset: 0x000B5864
		// (set) Token: 0x06002DA8 RID: 11688 RVA: 0x000B766C File Offset: 0x000B586C
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

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x000B7678 File Offset: 0x000B5878
		// (set) Token: 0x06002DAA RID: 11690 RVA: 0x000B7680 File Offset: 0x000B5880
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

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002DAB RID: 11691 RVA: 0x000B768C File Offset: 0x000B588C
		// (set) Token: 0x06002DAC RID: 11692 RVA: 0x000B7694 File Offset: 0x000B5894
		[ProtoMember(6, IsRequired = true, Name = "DescStrKey", DataFormat = DataFormat.Default)]
		public string DescStrKey
		{
			get
			{
				return this._DescStrKey;
			}
			set
			{
				this._DescStrKey = value;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002DAD RID: 11693 RVA: 0x000B76A0 File Offset: 0x000B58A0
		// (set) Token: 0x06002DAE RID: 11694 RVA: 0x000B76A8 File Offset: 0x000B58A8
		[ProtoMember(7, IsRequired = true, Name = "FuncType", DataFormat = DataFormat.TwosComplement)]
		public WaypointFuncType FuncType
		{
			get
			{
				return this._FuncType;
			}
			set
			{
				this._FuncType = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002DAF RID: 11695 RVA: 0x000B76B4 File Offset: 0x000B58B4
		// (set) Token: 0x06002DB0 RID: 11696 RVA: 0x000B76BC File Offset: 0x000B58BC
		[ProtoMember(8, IsRequired = true, Name = "FuncTypeParam1", DataFormat = DataFormat.TwosComplement)]
		public int FuncTypeParam1
		{
			get
			{
				return this._FuncTypeParam1;
			}
			set
			{
				this._FuncTypeParam1 = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002DB1 RID: 11697 RVA: 0x000B76C8 File Offset: 0x000B58C8
		[ProtoMember(9, Name = "Waypoints_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Waypoints_ID
		{
			get
			{
				return this._Waypoints_ID;
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x000B76D0 File Offset: 0x000B58D0
		// (set) Token: 0x06002DB3 RID: 11699 RVA: 0x000B76D8 File Offset: 0x000B58D8
		[ProtoMember(10, IsRequired = true, Name = "StyleType", DataFormat = DataFormat.TwosComplement)]
		public WaypointStyleType StyleType
		{
			get
			{
				return this._StyleType;
			}
			set
			{
				this._StyleType = value;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x000B76E4 File Offset: 0x000B58E4
		// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x000B76EC File Offset: 0x000B58EC
		[ProtoMember(11, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				this._Model = value;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x000B76F8 File Offset: 0x000B58F8
		// (set) Token: 0x06002DB7 RID: 11703 RVA: 0x000B7700 File Offset: 0x000B5900
		[ProtoMember(12, IsRequired = true, Name = "Background", DataFormat = DataFormat.Default)]
		public string Background
		{
			get
			{
				return this._Background;
			}
			set
			{
				this._Background = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x000B770C File Offset: 0x000B590C
		[ProtoMember(13, Name = "StateList", DataFormat = DataFormat.Default)]
		public List<WaypointInfoStateList> StateList
		{
			get
			{
				return this._StateList;
			}
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000B7714 File Offset: 0x000B5914
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000B7724 File Offset: 0x000B5924
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

		// Token: 0x06002DBB RID: 11707 RVA: 0x000B77F0 File Offset: 0x000B59F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataWaypointInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001C39 RID: 7225
		private int _ID;

		// Token: 0x04001C3A RID: 7226
		private string _Name;

		// Token: 0x04001C3B RID: 7227
		private string _NameStrKey;

		// Token: 0x04001C3C RID: 7228
		private string _Desc;

		// Token: 0x04001C3D RID: 7229
		private string _DescStrKey;

		// Token: 0x04001C3E RID: 7230
		private WaypointFuncType _FuncType;

		// Token: 0x04001C3F RID: 7231
		private int _FuncTypeParam1;

		// Token: 0x04001C40 RID: 7232
		private readonly List<int> _Waypoints_ID = new List<int>();

		// Token: 0x04001C41 RID: 7233
		private WaypointStyleType _StyleType;

		// Token: 0x04001C42 RID: 7234
		private string _Model;

		// Token: 0x04001C43 RID: 7235
		private string _Background;

		// Token: 0x04001C44 RID: 7236
		private readonly List<WaypointInfoStateList> _StateList = new List<WaypointInfoStateList>();

		// Token: 0x04001C45 RID: 7237
		private IExtension extensionObject;

		// Token: 0x04001C46 RID: 7238
		public ConfigDataWaypointInfo[] m_waypointInfos;

		// Token: 0x04001C47 RID: 7239
		public ConfigDataRegionInfo m_regionInfo;

		// Token: 0x04001C48 RID: 7240
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001C49 RID: 7241
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001C4A RID: 7242
		private LuaFunction m_ctor_hotfix;
	}
}
