using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E4 RID: 1764
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePracticeCancelReq")]
	[Serializable]
	public class BattlePracticeCancelReq : IExtensible
	{
		// Token: 0x06005E52 RID: 24146 RVA: 0x001AC920 File Offset: 0x001AAB20
		public BattlePracticeCancelReq()
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

		// Token: 0x06005E53 RID: 24147 RVA: 0x001AC988 File Offset: 0x001AAB88
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x001AC998 File Offset: 0x001AAB98
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

		// Token: 0x06005E55 RID: 24149 RVA: 0x001ACA64 File Offset: 0x001AAC64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeCancelReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400469E RID: 18078
		private IExtension extensionObject;

		// Token: 0x0400469F RID: 18079
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046A0 RID: 18080
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046A1 RID: 18081
		private LuaFunction m_ctor_hotfix;
	}
}
