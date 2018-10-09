using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000846 RID: 2118
	[ProtoContract(Name = "TeamRoomInvitationRefusedNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomInvitationRefusedNtf : IExtensible
	{
		// Token: 0x060069E9 RID: 27113 RVA: 0x001DCD80 File Offset: 0x001DAF80
		public TeamRoomInvitationRefusedNtf()
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

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x060069EA RID: 27114 RVA: 0x001DCDE8 File Offset: 0x001DAFE8
		// (set) Token: 0x060069EB RID: 27115 RVA: 0x001DCDF0 File Offset: 0x001DAFF0
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

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x060069EC RID: 27116 RVA: 0x001DCDFC File Offset: 0x001DAFFC
		// (set) Token: 0x060069ED RID: 27117 RVA: 0x001DCE04 File Offset: 0x001DB004
		[ProtoMember(2, IsRequired = true, Name = "InviteeName", DataFormat = DataFormat.Default)]
		public string InviteeName
		{
			get
			{
				return this._InviteeName;
			}
			set
			{
				this._InviteeName = value;
			}
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x001DCE10 File Offset: 0x001DB010
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x001DCE20 File Offset: 0x001DB020
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

		// Token: 0x060069F0 RID: 27120 RVA: 0x001DCEEC File Offset: 0x001DB0EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInvitationRefusedNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051A0 RID: 20896
		private int _Result;

		// Token: 0x040051A1 RID: 20897
		private string _InviteeName;

		// Token: 0x040051A2 RID: 20898
		private IExtension extensionObject;

		// Token: 0x040051A3 RID: 20899
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051A4 RID: 20900
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051A5 RID: 20901
		private LuaFunction m_ctor_hotfix;
	}
}
