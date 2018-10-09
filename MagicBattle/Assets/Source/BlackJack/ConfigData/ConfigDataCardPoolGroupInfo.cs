using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200021B RID: 539
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataCardPoolGroupInfo")]
	[Serializable]
	public class ConfigDataCardPoolGroupInfo : IExtensible
	{
		// Token: 0x06001F9E RID: 8094 RVA: 0x0009F57C File Offset: 0x0009D77C
		public ConfigDataCardPoolGroupInfo()
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

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0009F5F0 File Offset: 0x0009D7F0
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0009F5F8 File Offset: 0x0009D7F8
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

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0009F604 File Offset: 0x0009D804
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x0009F60C File Offset: 0x0009D80C
		[ProtoMember(3, IsRequired = true, Name = "CardPoolID", DataFormat = DataFormat.TwosComplement)]
		public int CardPoolID
		{
			get
			{
				return this._CardPoolID;
			}
			set
			{
				this._CardPoolID = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0009F618 File Offset: 0x0009D818
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0009F620 File Offset: 0x0009D820
		[ProtoMember(4, IsRequired = true, Name = "FirstSingleSelectWeight", DataFormat = DataFormat.TwosComplement)]
		public int FirstSingleSelectWeight
		{
			get
			{
				return this._FirstSingleSelectWeight;
			}
			set
			{
				this._FirstSingleSelectWeight = value;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0009F62C File Offset: 0x0009D82C
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x0009F634 File Offset: 0x0009D834
		[ProtoMember(5, IsRequired = true, Name = "DefaultSingleSelectWeight", DataFormat = DataFormat.TwosComplement)]
		public int DefaultSingleSelectWeight
		{
			get
			{
				return this._DefaultSingleSelectWeight;
			}
			set
			{
				this._DefaultSingleSelectWeight = value;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0009F640 File Offset: 0x0009D840
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x0009F648 File Offset: 0x0009D848
		[ProtoMember(6, IsRequired = true, Name = "DefaultTenSelectWeight", DataFormat = DataFormat.TwosComplement)]
		public int DefaultTenSelectWeight
		{
			get
			{
				return this._DefaultTenSelectWeight;
			}
			set
			{
				this._DefaultTenSelectWeight = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0009F654 File Offset: 0x0009D854
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x0009F65C File Offset: 0x0009D85C
		[ProtoMember(7, IsRequired = true, Name = "FirstTenSelectWeight", DataFormat = DataFormat.TwosComplement)]
		public int FirstTenSelectWeight
		{
			get
			{
				return this._FirstTenSelectWeight;
			}
			set
			{
				this._FirstTenSelectWeight = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0009F668 File Offset: 0x0009D868
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x0009F670 File Offset: 0x0009D870
		[ProtoMember(8, IsRequired = true, Name = "TenSelectAccumulateWeight", DataFormat = DataFormat.TwosComplement)]
		public int TenSelectAccumulateWeight
		{
			get
			{
				return this._TenSelectAccumulateWeight;
			}
			set
			{
				this._TenSelectAccumulateWeight = value;
			}
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x0009F67C File Offset: 0x0009D87C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0009F68C File Offset: 0x0009D88C
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

		// Token: 0x06001FAF RID: 8111 RVA: 0x0009F758 File Offset: 0x0009D958
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataCardPoolGroupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001314 RID: 4884
		private int _ID;

		// Token: 0x04001315 RID: 4885
		private int _CardPoolID;

		// Token: 0x04001316 RID: 4886
		private int _FirstSingleSelectWeight;

		// Token: 0x04001317 RID: 4887
		private int _DefaultSingleSelectWeight;

		// Token: 0x04001318 RID: 4888
		private int _DefaultTenSelectWeight;

		// Token: 0x04001319 RID: 4889
		private int _FirstTenSelectWeight;

		// Token: 0x0400131A RID: 4890
		private int _TenSelectAccumulateWeight;

		// Token: 0x0400131B RID: 4891
		private IExtension extensionObject;

		// Token: 0x0400131C RID: 4892
		public Dictionary<int, ICardPoolItemWeight> CardItemList = new Dictionary<int, ICardPoolItemWeight>();

		// Token: 0x0400131D RID: 4893
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400131E RID: 4894
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400131F RID: 4895
		private LuaFunction m_ctor_hotfix;
	}
}
