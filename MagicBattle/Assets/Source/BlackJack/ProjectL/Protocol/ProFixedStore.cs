using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000650 RID: 1616
	[ProtoContract(Name = "ProFixedStore")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProFixedStore : IExtensible
	{
		// Token: 0x06005842 RID: 22594 RVA: 0x0019A8AC File Offset: 0x00198AAC
		public ProFixedStore()
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

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06005843 RID: 22595 RVA: 0x0019A920 File Offset: 0x00198B20
		// (set) Token: 0x06005844 RID: 22596 RVA: 0x0019A928 File Offset: 0x00198B28
		[ProtoMember(1, IsRequired = true, Name = "StoreId", DataFormat = DataFormat.TwosComplement)]
		public int StoreId
		{
			get
			{
				return this._StoreId;
			}
			set
			{
				this._StoreId = value;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06005845 RID: 22597 RVA: 0x0019A934 File Offset: 0x00198B34
		[ProtoMember(3, Name = "Items", DataFormat = DataFormat.Default)]
		public List<ProFixedStoreItem> Items
		{
			get
			{
				return this._Items;
			}
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x0019A93C File Offset: 0x00198B3C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x0019A94C File Offset: 0x00198B4C
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

		// Token: 0x06005848 RID: 22600 RVA: 0x0019AA18 File Offset: 0x00198C18
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProFixedStore));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004240 RID: 16960
		private int _StoreId;

		// Token: 0x04004241 RID: 16961
		private readonly List<ProFixedStoreItem> _Items = new List<ProFixedStoreItem>();

		// Token: 0x04004242 RID: 16962
		private IExtension extensionObject;

		// Token: 0x04004243 RID: 16963
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004244 RID: 16964
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004245 RID: 16965
		private LuaFunction m_ctor_hotfix;
	}
}
