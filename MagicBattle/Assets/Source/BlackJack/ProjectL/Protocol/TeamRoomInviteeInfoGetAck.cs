using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200083D RID: 2109
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomInviteeInfoGetAck")]
	[Serializable]
	public class TeamRoomInviteeInfoGetAck : IExtensible
	{
		// Token: 0x060069B0 RID: 27056 RVA: 0x001DBD98 File Offset: 0x001D9F98
		public TeamRoomInviteeInfoGetAck()
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

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x060069B1 RID: 27057 RVA: 0x001DBE00 File Offset: 0x001DA000
		// (set) Token: 0x060069B2 RID: 27058 RVA: 0x001DBE08 File Offset: 0x001DA008
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

		// Token: 0x060069B3 RID: 27059 RVA: 0x001DBE14 File Offset: 0x001DA014
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069B4 RID: 27060 RVA: 0x001DBE24 File Offset: 0x001DA024
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

		// Token: 0x060069B5 RID: 27061 RVA: 0x001DBEF0 File Offset: 0x001DA0F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInviteeInfoGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005171 RID: 20849
		private int _Result;

		// Token: 0x04005172 RID: 20850
		private IExtension extensionObject;

		// Token: 0x04005173 RID: 20851
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005174 RID: 20852
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005175 RID: 20853
		private LuaFunction m_ctor_hotfix;
	}
}
