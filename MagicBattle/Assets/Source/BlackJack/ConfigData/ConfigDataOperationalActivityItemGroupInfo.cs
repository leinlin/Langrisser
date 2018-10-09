using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000266 RID: 614
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataOperationalActivityItemGroupInfo")]
	[Serializable]
	public class ConfigDataOperationalActivityItemGroupInfo : IExtensible
	{
		// Token: 0x06002772 RID: 10098 RVA: 0x000ABC9C File Offset: 0x000A9E9C
		public ConfigDataOperationalActivityItemGroupInfo()
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

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x000ABD10 File Offset: 0x000A9F10
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x000ABD18 File Offset: 0x000A9F18
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

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000ABD24 File Offset: 0x000A9F24
		[ProtoMember(3, Name = "ItemList", DataFormat = DataFormat.Default)]
		public List<Goods> ItemList
		{
			get
			{
				return this._ItemList;
			}
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000ABD2C File Offset: 0x000A9F2C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x000ABD3C File Offset: 0x000A9F3C
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

		// Token: 0x06002778 RID: 10104 RVA: 0x000ABE08 File Offset: 0x000AA008
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataOperationalActivityItemGroupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001827 RID: 6183
		private int _ID;

		// Token: 0x04001828 RID: 6184
		private readonly List<Goods> _ItemList = new List<Goods>();

		// Token: 0x04001829 RID: 6185
		private IExtension extensionObject;

		// Token: 0x0400182A RID: 6186
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400182B RID: 6187
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400182C RID: 6188
		private LuaFunction m_ctor_hotfix;
	}
}
