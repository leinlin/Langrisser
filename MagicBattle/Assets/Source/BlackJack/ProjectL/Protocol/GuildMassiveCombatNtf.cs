using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000789 RID: 1929
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildMassiveCombatNtf")]
	[Serializable]
	public class GuildMassiveCombatNtf : IExtensible
	{
		// Token: 0x060063A0 RID: 25504 RVA: 0x001BFAA8 File Offset: 0x001BDCA8
		public GuildMassiveCombatNtf()
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

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x060063A1 RID: 25505 RVA: 0x001BFB10 File Offset: 0x001BDD10
		// (set) Token: 0x060063A2 RID: 25506 RVA: 0x001BFB18 File Offset: 0x001BDD18
		[ProtoMember(1, IsRequired = true, Name = "GeneralInfo", DataFormat = DataFormat.Default)]
		public ProGuildMassiveCombatGeneralInfo GeneralInfo
		{
			get
			{
				return this._GeneralInfo;
			}
			set
			{
				this._GeneralInfo = value;
			}
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x001BFB24 File Offset: 0x001BDD24
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x001BFB34 File Offset: 0x001BDD34
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

		// Token: 0x060063A5 RID: 25509 RVA: 0x001BFC00 File Offset: 0x001BDE00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AAD RID: 19117
		private ProGuildMassiveCombatGeneralInfo _GeneralInfo;

		// Token: 0x04004AAE RID: 19118
		private IExtension extensionObject;

		// Token: 0x04004AAF RID: 19119
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AB0 RID: 19120
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AB1 RID: 19121
		private LuaFunction m_ctor_hotfix;
	}
}
