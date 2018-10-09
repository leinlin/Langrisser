using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000779 RID: 1913
	[ProtoContract(Name = "GuildKickOutReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildKickOutReq : IExtensible
	{
		// Token: 0x06006335 RID: 25397 RVA: 0x001BDE30 File Offset: 0x001BC030
		public GuildKickOutReq()
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

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06006336 RID: 25398 RVA: 0x001BDE98 File Offset: 0x001BC098
		// (set) Token: 0x06006337 RID: 25399 RVA: 0x001BDEA0 File Offset: 0x001BC0A0
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x001BDEAC File Offset: 0x001BC0AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x001BDEBC File Offset: 0x001BC0BC
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

		// Token: 0x0600633A RID: 25402 RVA: 0x001BDF88 File Offset: 0x001BC188
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildKickOutReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A57 RID: 19031
		private string _UserId;

		// Token: 0x04004A58 RID: 19032
		private IExtension extensionObject;

		// Token: 0x04004A59 RID: 19033
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A5A RID: 19034
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A5B RID: 19035
		private LuaFunction m_ctor_hotfix;
	}
}
