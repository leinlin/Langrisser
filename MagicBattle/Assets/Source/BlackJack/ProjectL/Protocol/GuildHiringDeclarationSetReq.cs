using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200076F RID: 1903
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildHiringDeclarationSetReq")]
	[Serializable]
	public class GuildHiringDeclarationSetReq : IExtensible
	{
		// Token: 0x060062DD RID: 25309 RVA: 0x001BCB98 File Offset: 0x001BAD98
		public GuildHiringDeclarationSetReq()
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

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x060062DE RID: 25310 RVA: 0x001BCC00 File Offset: 0x001BAE00
		// (set) Token: 0x060062DF RID: 25311 RVA: 0x001BCC08 File Offset: 0x001BAE08
		[ProtoMember(1, IsRequired = true, Name = "HiringDeclaration", DataFormat = DataFormat.Default)]
		public string HiringDeclaration
		{
			get
			{
				return this._HiringDeclaration;
			}
			set
			{
				this._HiringDeclaration = value;
			}
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x001BCC14 File Offset: 0x001BAE14
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x001BCC24 File Offset: 0x001BAE24
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

		// Token: 0x060062E2 RID: 25314 RVA: 0x001BCCF0 File Offset: 0x001BAEF0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildHiringDeclarationSetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A17 RID: 18967
		private string _HiringDeclaration;

		// Token: 0x04004A18 RID: 18968
		private IExtension extensionObject;

		// Token: 0x04004A19 RID: 18969
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A1A RID: 18970
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A1B RID: 18971
		private LuaFunction m_ctor_hotfix;
	}
}
