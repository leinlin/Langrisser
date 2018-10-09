using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200062F RID: 1583
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ClimbTowerGetReq")]
	[Serializable]
	public class ClimbTowerGetReq : IExtensible
	{
		// Token: 0x060056D9 RID: 22233 RVA: 0x001967C4 File Offset: 0x001949C4
		public ClimbTowerGetReq()
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

		// Token: 0x060056DA RID: 22234 RVA: 0x0019682C File Offset: 0x00194A2C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x0019683C File Offset: 0x00194A3C
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

		// Token: 0x060056DC RID: 22236 RVA: 0x00196908 File Offset: 0x00194B08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004140 RID: 16704
		private IExtension extensionObject;

		// Token: 0x04004141 RID: 16705
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004142 RID: 16706
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004143 RID: 16707
		private LuaFunction m_ctor_hotfix;
	}
}
