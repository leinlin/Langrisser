using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005DE RID: 1502
	[ProtoContract(Name = "BattleCancelReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleCancelReq : IExtensible
	{
		// Token: 0x0600541E RID: 21534 RVA: 0x0018D054 File Offset: 0x0018B254
		public BattleCancelReq()
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

		// Token: 0x0600541F RID: 21535 RVA: 0x0018D0BC File Offset: 0x0018B2BC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x0018D0CC File Offset: 0x0018B2CC
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

		// Token: 0x06005421 RID: 21537 RVA: 0x0018D198 File Offset: 0x0018B398
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleCancelReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F32 RID: 16178
		private IExtension extensionObject;

		// Token: 0x04003F33 RID: 16179
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F34 RID: 16180
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F35 RID: 16181
		private LuaFunction m_ctor_hotfix;
	}
}
