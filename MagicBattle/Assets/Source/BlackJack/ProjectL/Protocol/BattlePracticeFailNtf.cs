using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E6 RID: 1766
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePracticeFailNtf")]
	[Serializable]
	public class BattlePracticeFailNtf : IExtensible
	{
		// Token: 0x06005E5C RID: 24156 RVA: 0x001ACC8C File Offset: 0x001AAE8C
		public BattlePracticeFailNtf()
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

		// Token: 0x06005E5D RID: 24157 RVA: 0x001ACCF4 File Offset: 0x001AAEF4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x001ACD04 File Offset: 0x001AAF04
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

		// Token: 0x06005E5F RID: 24159 RVA: 0x001ACDD0 File Offset: 0x001AAFD0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeFailNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046A7 RID: 18087
		private IExtension extensionObject;

		// Token: 0x040046A8 RID: 18088
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046A9 RID: 18089
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046AA RID: 18090
		private LuaFunction m_ctor_hotfix;
	}
}
