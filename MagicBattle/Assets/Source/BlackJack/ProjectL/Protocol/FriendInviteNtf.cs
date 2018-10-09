using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006BE RID: 1726
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendInviteNtf")]
	[Serializable]
	public class FriendInviteNtf : IExtensible
	{
		// Token: 0x06005D4D RID: 23885 RVA: 0x001A84F0 File Offset: 0x001A66F0
		public FriendInviteNtf()
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

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06005D4E RID: 23886 RVA: 0x001A8558 File Offset: 0x001A6758
		// (set) Token: 0x06005D4F RID: 23887 RVA: 0x001A8560 File Offset: 0x001A6760
		[ProtoMember(1, IsRequired = true, Name = "Inviter", DataFormat = DataFormat.Default)]
		public ProUserSummary Inviter
		{
			get
			{
				return this._Inviter;
			}
			set
			{
				this._Inviter = value;
			}
		}

		// Token: 0x06005D50 RID: 23888 RVA: 0x001A856C File Offset: 0x001A676C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x001A857C File Offset: 0x001A677C
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

		// Token: 0x06005D52 RID: 23890 RVA: 0x001A8648 File Offset: 0x001A6848
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInviteNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045CB RID: 17867
		private ProUserSummary _Inviter;

		// Token: 0x040045CC RID: 17868
		private IExtension extensionObject;

		// Token: 0x040045CD RID: 17869
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045CE RID: 17870
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045CF RID: 17871
		private LuaFunction m_ctor_hotfix;
	}
}
