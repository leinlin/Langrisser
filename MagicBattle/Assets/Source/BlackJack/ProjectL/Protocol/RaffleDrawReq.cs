using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000804 RID: 2052
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RaffleDrawReq")]
	[Serializable]
	public class RaffleDrawReq : IExtensible
	{
		// Token: 0x060067DB RID: 26587 RVA: 0x001D546C File Offset: 0x001D366C
		public RaffleDrawReq()
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

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x060067DC RID: 26588 RVA: 0x001D54D4 File Offset: 0x001D36D4
		// (set) Token: 0x060067DD RID: 26589 RVA: 0x001D54DC File Offset: 0x001D36DC
		[ProtoMember(1, IsRequired = true, Name = "PoolId", DataFormat = DataFormat.TwosComplement)]
		public int PoolId
		{
			get
			{
				return this._PoolId;
			}
			set
			{
				this._PoolId = value;
			}
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x001D54E8 File Offset: 0x001D36E8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x001D54F8 File Offset: 0x001D36F8
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

		// Token: 0x060067E0 RID: 26592 RVA: 0x001D55C4 File Offset: 0x001D37C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaffleDrawReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400500E RID: 20494
		private int _PoolId;

		// Token: 0x0400500F RID: 20495
		private IExtension extensionObject;

		// Token: 0x04005010 RID: 20496
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005011 RID: 20497
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005012 RID: 20498
		private LuaFunction m_ctor_hotfix;
	}
}
