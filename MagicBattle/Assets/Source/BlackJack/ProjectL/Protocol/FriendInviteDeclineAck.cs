using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C3 RID: 1731
	[ProtoContract(Name = "FriendInviteDeclineAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendInviteDeclineAck : IExtensible
	{
		// Token: 0x06005D6E RID: 23918 RVA: 0x001A8DEC File Offset: 0x001A6FEC
		public FriendInviteDeclineAck()
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

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06005D6F RID: 23919 RVA: 0x001A8E54 File Offset: 0x001A7054
		// (set) Token: 0x06005D70 RID: 23920 RVA: 0x001A8E5C File Offset: 0x001A705C
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

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06005D71 RID: 23921 RVA: 0x001A8E68 File Offset: 0x001A7068
		// (set) Token: 0x06005D72 RID: 23922 RVA: 0x001A8E70 File Offset: 0x001A7070
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public FriendInviteDeclineReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x001A8E7C File Offset: 0x001A707C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x001A8E8C File Offset: 0x001A708C
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

		// Token: 0x06005D75 RID: 23925 RVA: 0x001A8F58 File Offset: 0x001A7158
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInviteDeclineAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045E7 RID: 17895
		private int _Result;

		// Token: 0x040045E8 RID: 17896
		private FriendInviteDeclineReq _Req;

		// Token: 0x040045E9 RID: 17897
		private IExtension extensionObject;

		// Token: 0x040045EA RID: 17898
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045EB RID: 17899
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045EC RID: 17900
		private LuaFunction m_ctor_hotfix;
	}
}
