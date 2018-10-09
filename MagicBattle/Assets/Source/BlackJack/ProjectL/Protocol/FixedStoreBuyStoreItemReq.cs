using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B8 RID: 1720
	[ProtoContract(Name = "FixedStoreBuyStoreItemReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FixedStoreBuyStoreItemReq : IExtensible
	{
		// Token: 0x06005D0F RID: 23823 RVA: 0x001A7924 File Offset: 0x001A5B24
		public FixedStoreBuyStoreItemReq()
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

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06005D10 RID: 23824 RVA: 0x001A798C File Offset: 0x001A5B8C
		// (set) Token: 0x06005D11 RID: 23825 RVA: 0x001A7994 File Offset: 0x001A5B94
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

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06005D12 RID: 23826 RVA: 0x001A79A0 File Offset: 0x001A5BA0
		// (set) Token: 0x06005D13 RID: 23827 RVA: 0x001A79A8 File Offset: 0x001A5BA8
		[ProtoMember(2, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
		public int GoodsId
		{
			get
			{
				return this._GoodsId;
			}
			set
			{
				this._GoodsId = value;
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06005D14 RID: 23828 RVA: 0x001A79B4 File Offset: 0x001A5BB4
		// (set) Token: 0x06005D15 RID: 23829 RVA: 0x001A79BC File Offset: 0x001A5BBC
		[ProtoMember(3, IsRequired = true, Name = "SelectedIndex", DataFormat = DataFormat.TwosComplement)]
		public int SelectedIndex
		{
			get
			{
				return this._SelectedIndex;
			}
			set
			{
				this._SelectedIndex = value;
			}
		}

		// Token: 0x06005D16 RID: 23830 RVA: 0x001A79C8 File Offset: 0x001A5BC8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D17 RID: 23831 RVA: 0x001A79D8 File Offset: 0x001A5BD8
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

		// Token: 0x06005D18 RID: 23832 RVA: 0x001A7AA4 File Offset: 0x001A5CA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FixedStoreBuyStoreItemReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400459C RID: 17820
		private int _StoreId;

		// Token: 0x0400459D RID: 17821
		private int _GoodsId;

		// Token: 0x0400459E RID: 17822
		private int _SelectedIndex;

		// Token: 0x0400459F RID: 17823
		private IExtension extensionObject;

		// Token: 0x040045A0 RID: 17824
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045A1 RID: 17825
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045A2 RID: 17826
		private LuaFunction m_ctor_hotfix;
	}
}
