using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000839 RID: 2105
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomInviteAck")]
	[Serializable]
	public class TeamRoomInviteAck : IExtensible
	{
		// Token: 0x0600698F RID: 27023 RVA: 0x001DB634 File Offset: 0x001D9834
		public TeamRoomInviteAck()
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

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x001DB69C File Offset: 0x001D989C
		// (set) Token: 0x06006991 RID: 27025 RVA: 0x001DB6A4 File Offset: 0x001D98A4
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x001DB6B0 File Offset: 0x001D98B0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x001DB6C0 File Offset: 0x001D98C0
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

		// Token: 0x06006994 RID: 27028 RVA: 0x001DB78C File Offset: 0x001D998C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInviteAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005158 RID: 20824
		private int _Result;

		// Token: 0x04005159 RID: 20825
		private IExtension extensionObject;

		// Token: 0x0400515A RID: 20826
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400515B RID: 20827
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400515C RID: 20828
		private LuaFunction m_ctor_hotfix;
	}
}
