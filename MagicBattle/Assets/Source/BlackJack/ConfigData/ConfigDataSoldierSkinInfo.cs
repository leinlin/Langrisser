using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200028E RID: 654
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataSoldierSkinInfo")]
	[Serializable]
	public class ConfigDataSoldierSkinInfo : IExtensible
	{
		// Token: 0x06002B32 RID: 11058 RVA: 0x000B2250 File Offset: 0x000B0450
		public ConfigDataSoldierSkinInfo()
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

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x000B22D8 File Offset: 0x000B04D8
		// (set) Token: 0x06002B34 RID: 11060 RVA: 0x000B22E0 File Offset: 0x000B04E0
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

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000B22EC File Offset: 0x000B04EC
		// (set) Token: 0x06002B36 RID: 11062 RVA: 0x000B22F4 File Offset: 0x000B04F4
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

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000B2300 File Offset: 0x000B0500
		[ProtoMember(4, Name = "ShowInListSkinResInfo", DataFormat = DataFormat.Default)]
		public List<Soldier2SkinResource> ShowInListSkinResInfo
		{
			get
			{
				return this._ShowInListSkinResInfo;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x000B2308 File Offset: 0x000B0508
		[ProtoMember(5, Name = "SpecifiedSoldier", DataFormat = DataFormat.Default)]
		public List<Soldier2SkinResource> SpecifiedSoldier
		{
			get
			{
				return this._SpecifiedSoldier;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x000B2310 File Offset: 0x000B0510
		// (set) Token: 0x06002B3A RID: 11066 RVA: 0x000B2318 File Offset: 0x000B0518
		[ProtoMember(6, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000B2324 File Offset: 0x000B0524
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x000B232C File Offset: 0x000B052C
		[ProtoMember(7, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000B2338 File Offset: 0x000B0538
		[ProtoMember(8, Name = "GetPathList", DataFormat = DataFormat.Default)]
		public List<GetPathData> GetPathList
		{
			get
			{
				return this._GetPathList;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000B2340 File Offset: 0x000B0540
		// (set) Token: 0x06002B3F RID: 11071 RVA: 0x000B2348 File Offset: 0x000B0548
		[ProtoMember(9, IsRequired = true, Name = "GetPathDesc", DataFormat = DataFormat.Default)]
		public string GetPathDesc
		{
			get
			{
				return this._GetPathDesc;
			}
			set
			{
				this._GetPathDesc = value;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x000B2354 File Offset: 0x000B0554
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x000B235C File Offset: 0x000B055C
		[ProtoMember(10, IsRequired = true, Name = "IsShowBeforeGet", DataFormat = DataFormat.Default)]
		public bool IsShowBeforeGet
		{
			get
			{
				return this._IsShowBeforeGet;
			}
			set
			{
				this._IsShowBeforeGet = value;
			}
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000B2368 File Offset: 0x000B0568
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000B2378 File Offset: 0x000B0578
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

		// Token: 0x06002B44 RID: 11076 RVA: 0x000B2444 File Offset: 0x000B0644
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSoldierSkinInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001A8E RID: 6798
		private int _ID;

		// Token: 0x04001A8F RID: 6799
		private string _Name;

		// Token: 0x04001A90 RID: 6800
		private readonly List<Soldier2SkinResource> _ShowInListSkinResInfo = new List<Soldier2SkinResource>();

		// Token: 0x04001A91 RID: 6801
		private readonly List<Soldier2SkinResource> _SpecifiedSoldier = new List<Soldier2SkinResource>();

		// Token: 0x04001A92 RID: 6802
		private string _Desc;

		// Token: 0x04001A93 RID: 6803
		private string _Icon;

		// Token: 0x04001A94 RID: 6804
		private readonly List<GetPathData> _GetPathList = new List<GetPathData>();

		// Token: 0x04001A95 RID: 6805
		private string _GetPathDesc;

		// Token: 0x04001A96 RID: 6806
		private bool _IsShowBeforeGet;

		// Token: 0x04001A97 RID: 6807
		private IExtension extensionObject;

		// Token: 0x04001A98 RID: 6808
		public int FixedStoreItemId;

		// Token: 0x04001A99 RID: 6809
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001A9A RID: 6810
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001A9B RID: 6811
		private LuaFunction m_ctor_hotfix;
	}
}
