using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200080F RID: 2063
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPCancelWaitingForOpponentReq")]
	[Serializable]
	public class RealTimePVPCancelWaitingForOpponentReq : IExtensible
	{
		// Token: 0x06006841 RID: 26689 RVA: 0x001D6914 File Offset: 0x001D4B14
		public RealTimePVPCancelWaitingForOpponentReq()
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

		// Token: 0x06006842 RID: 26690 RVA: 0x001D697C File Offset: 0x001D4B7C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x001D698C File Offset: 0x001D4B8C
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

		// Token: 0x06006844 RID: 26692 RVA: 0x001D6A58 File Offset: 0x001D4C58
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPCancelWaitingForOpponentReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005057 RID: 20567
		private IExtension extensionObject;

		// Token: 0x04005058 RID: 20568
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005059 RID: 20569
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400505A RID: 20570
		private LuaFunction m_ctor_hotfix;
	}
}
