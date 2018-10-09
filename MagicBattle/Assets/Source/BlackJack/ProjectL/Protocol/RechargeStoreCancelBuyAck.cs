using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200074B RID: 1867
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RechargeStoreCancelBuyAck")]
	[Serializable]
	public class RechargeStoreCancelBuyAck : IExtensible
	{
		// Token: 0x060061DA RID: 25050 RVA: 0x001B8A98 File Offset: 0x001B6C98
		public RechargeStoreCancelBuyAck()
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

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x001B8B00 File Offset: 0x001B6D00
		// (set) Token: 0x060061DC RID: 25052 RVA: 0x001B8B08 File Offset: 0x001B6D08
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

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x001B8B14 File Offset: 0x001B6D14
		// (set) Token: 0x060061DE RID: 25054 RVA: 0x001B8B1C File Offset: 0x001B6D1C
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

		// Token: 0x060061DF RID: 25055 RVA: 0x001B8B28 File Offset: 0x001B6D28
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x001B8B38 File Offset: 0x001B6D38
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

		// Token: 0x060061E1 RID: 25057 RVA: 0x001B8C04 File Offset: 0x001B6E04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RechargeStoreCancelBuyAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400494B RID: 18763
		private int _Result;

		// Token: 0x0400494C RID: 18764
		private int _GoodsId;

		// Token: 0x0400494D RID: 18765
		private IExtension extensionObject;

		// Token: 0x0400494E RID: 18766
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400494F RID: 18767
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004950 RID: 18768
		private LuaFunction m_ctor_hotfix;
	}
}
