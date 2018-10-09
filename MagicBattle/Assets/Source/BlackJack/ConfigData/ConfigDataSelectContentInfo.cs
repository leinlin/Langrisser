using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000286 RID: 646
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSelectContentInfo")]
	[Serializable]
	public class ConfigDataSelectContentInfo : IExtensible
	{
		// Token: 0x060029FE RID: 10750 RVA: 0x000B0828 File Offset: 0x000AEA28
		public ConfigDataSelectContentInfo()
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

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x000B089C File Offset: 0x000AEA9C
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x000B08A4 File Offset: 0x000AEAA4
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

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x000B08B0 File Offset: 0x000AEAB0
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x000B08B8 File Offset: 0x000AEAB8
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

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000B08C4 File Offset: 0x000AEAC4
		[ProtoMember(5, Name = "PoolContent", DataFormat = DataFormat.Default)]
		public List<PoolContentItemData> PoolContent
		{
			get
			{
				return this._PoolContent;
			}
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x000B08CC File Offset: 0x000AEACC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x000B08DC File Offset: 0x000AEADC
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

		// Token: 0x06002A06 RID: 10758 RVA: 0x000B09A8 File Offset: 0x000AEBA8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSelectContentInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040019DB RID: 6619
		private int _ID;

		// Token: 0x040019DC RID: 6620
		private string _Name;

		// Token: 0x040019DD RID: 6621
		private readonly List<PoolContentItemData> _PoolContent = new List<PoolContentItemData>();

		// Token: 0x040019DE RID: 6622
		private IExtension extensionObject;

		// Token: 0x040019DF RID: 6623
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040019E0 RID: 6624
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040019E1 RID: 6625
		private LuaFunction m_ctor_hotfix;
	}
}
