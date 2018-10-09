using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000781 RID: 1921
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildLogGetReq")]
	[Serializable]
	public class GuildLogGetReq : IExtensible
	{
		// Token: 0x06006371 RID: 25457 RVA: 0x001BECA8 File Offset: 0x001BCEA8
		public GuildLogGetReq()
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

		// Token: 0x06006372 RID: 25458 RVA: 0x001BED10 File Offset: 0x001BCF10
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x001BED20 File Offset: 0x001BCF20
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

		// Token: 0x06006374 RID: 25460 RVA: 0x001BEDEC File Offset: 0x001BCFEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildLogGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A85 RID: 19077
		private IExtension extensionObject;

		// Token: 0x04004A86 RID: 19078
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A87 RID: 19079
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A88 RID: 19080
		private LuaFunction m_ctor_hotfix;
	}
}
