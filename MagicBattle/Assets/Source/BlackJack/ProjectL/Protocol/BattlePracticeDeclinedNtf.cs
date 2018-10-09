using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E7 RID: 1767
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePracticeDeclinedNtf")]
	[Serializable]
	public class BattlePracticeDeclinedNtf : IExtensible
	{
		// Token: 0x06005E60 RID: 24160 RVA: 0x001ACE38 File Offset: 0x001AB038
		public BattlePracticeDeclinedNtf()
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

		// Token: 0x06005E61 RID: 24161 RVA: 0x001ACEA0 File Offset: 0x001AB0A0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x001ACEB0 File Offset: 0x001AB0B0
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

		// Token: 0x06005E63 RID: 24163 RVA: 0x001ACF7C File Offset: 0x001AB17C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeDeclinedNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046AB RID: 18091
		private IExtension extensionObject;

		// Token: 0x040046AC RID: 18092
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046AD RID: 18093
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046AE RID: 18094
		private LuaFunction m_ctor_hotfix;
	}
}
