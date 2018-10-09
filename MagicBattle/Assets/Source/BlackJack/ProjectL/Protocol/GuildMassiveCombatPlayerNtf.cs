using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200078A RID: 1930
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildMassiveCombatPlayerNtf")]
	[Serializable]
	public class GuildMassiveCombatPlayerNtf : IExtensible
	{
		// Token: 0x060063A6 RID: 25510 RVA: 0x001BFC68 File Offset: 0x001BDE68
		public GuildMassiveCombatPlayerNtf()
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

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x060063A7 RID: 25511 RVA: 0x001BFCD0 File Offset: 0x001BDED0
		// (set) Token: 0x060063A8 RID: 25512 RVA: 0x001BFCD8 File Offset: 0x001BDED8
		[ProtoMember(1, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public ProGuildPlayerMassiveCombatInfo Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				this._Info = value;
			}
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x001BFCE4 File Offset: 0x001BDEE4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x001BFCF4 File Offset: 0x001BDEF4
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

		// Token: 0x060063AB RID: 25515 RVA: 0x001BFDC0 File Offset: 0x001BDFC0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatPlayerNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AB2 RID: 19122
		private ProGuildPlayerMassiveCombatInfo _Info;

		// Token: 0x04004AB3 RID: 19123
		private IExtension extensionObject;

		// Token: 0x04004AB4 RID: 19124
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AB5 RID: 19125
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AB6 RID: 19126
		private LuaFunction m_ctor_hotfix;
	}
}
