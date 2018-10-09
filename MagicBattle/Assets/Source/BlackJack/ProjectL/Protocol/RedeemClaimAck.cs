using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200070D RID: 1805
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RedeemClaimAck")]
	[Serializable]
	public class RedeemClaimAck : IExtensible
	{
		// Token: 0x06005FA6 RID: 24486 RVA: 0x001B14F0 File Offset: 0x001AF6F0
		public RedeemClaimAck()
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

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06005FA7 RID: 24487 RVA: 0x001B1558 File Offset: 0x001AF758
		// (set) Token: 0x06005FA8 RID: 24488 RVA: 0x001B1560 File Offset: 0x001AF760
		[ProtoMember(1, IsRequired = true, Name = "Crystals", DataFormat = DataFormat.TwosComplement)]
		public int Crystals
		{
			get
			{
				return this._Crystals;
			}
			set
			{
				this._Crystals = value;
			}
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x001B156C File Offset: 0x001AF76C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x001B157C File Offset: 0x001AF77C
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

		// Token: 0x06005FAB RID: 24491 RVA: 0x001B1648 File Offset: 0x001AF848
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RedeemClaimAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400479E RID: 18334
		private int _Crystals;

		// Token: 0x0400479F RID: 18335
		private IExtension extensionObject;

		// Token: 0x040047A0 RID: 18336
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047A1 RID: 18337
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047A2 RID: 18338
		private LuaFunction m_ctor_hotfix;
	}
}
