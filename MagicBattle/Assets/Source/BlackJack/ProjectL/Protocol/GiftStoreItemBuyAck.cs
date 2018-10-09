using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200073F RID: 1855
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GiftStoreItemBuyAck")]
	[Serializable]
	public class GiftStoreItemBuyAck : IExtensible
	{
		// Token: 0x0600617F RID: 24959 RVA: 0x001B74D0 File Offset: 0x001B56D0
		public GiftStoreItemBuyAck()
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

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06006180 RID: 24960 RVA: 0x001B7538 File Offset: 0x001B5738
		// (set) Token: 0x06006181 RID: 24961 RVA: 0x001B7540 File Offset: 0x001B5740
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x06006182 RID: 24962 RVA: 0x001B754C File Offset: 0x001B574C
		// (set) Token: 0x06006183 RID: 24963 RVA: 0x001B7554 File Offset: 0x001B5754
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

		// Token: 0x06006184 RID: 24964 RVA: 0x001B7560 File Offset: 0x001B5760
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x001B7570 File Offset: 0x001B5770
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

		// Token: 0x06006186 RID: 24966 RVA: 0x001B763C File Offset: 0x001B583C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreItemBuyAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004905 RID: 18693
		private int _Result;

		// Token: 0x04004906 RID: 18694
		private int _GoodsId;

		// Token: 0x04004907 RID: 18695
		private IExtension extensionObject;

		// Token: 0x04004908 RID: 18696
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004909 RID: 18697
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400490A RID: 18698
		private LuaFunction m_ctor_hotfix;
	}
}
