using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000691 RID: 1681
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ClientAppResumeNtf")]
	[Serializable]
	public class ClientAppResumeNtf : IExtensible
	{
		// Token: 0x06005B51 RID: 23377 RVA: 0x001A2B90 File Offset: 0x001A0D90
		public ClientAppResumeNtf()
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

		// Token: 0x06005B52 RID: 23378 RVA: 0x001A2BF8 File Offset: 0x001A0DF8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x001A2C08 File Offset: 0x001A0E08
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

		// Token: 0x06005B54 RID: 23380 RVA: 0x001A2CD4 File Offset: 0x001A0ED4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientAppResumeNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004460 RID: 17504
		private IExtension extensionObject;

		// Token: 0x04004461 RID: 17505
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004462 RID: 17506
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004463 RID: 17507
		private LuaFunction m_ctor_hotfix;
	}
}
