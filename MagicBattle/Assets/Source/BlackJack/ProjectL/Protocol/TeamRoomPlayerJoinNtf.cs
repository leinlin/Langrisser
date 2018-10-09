using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000840 RID: 2112
	[ProtoContract(Name = "TeamRoomPlayerJoinNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomPlayerJoinNtf : IExtensible
	{
		// Token: 0x060069C1 RID: 27073 RVA: 0x001DC2D8 File Offset: 0x001DA4D8
		public TeamRoomPlayerJoinNtf()
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

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x060069C2 RID: 27074 RVA: 0x001DC340 File Offset: 0x001DA540
		// (set) Token: 0x060069C3 RID: 27075 RVA: 0x001DC348 File Offset: 0x001DA548
		[ProtoMember(1, IsRequired = true, Name = "Player", DataFormat = DataFormat.Default)]
		public ProTeamRoomPlayer Player
		{
			get
			{
				return this._Player;
			}
			set
			{
				this._Player = value;
			}
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x001DC354 File Offset: 0x001DA554
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x001DC364 File Offset: 0x001DA564
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

		// Token: 0x060069C6 RID: 27078 RVA: 0x001DC430 File Offset: 0x001DA630
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomPlayerJoinNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005180 RID: 20864
		private ProTeamRoomPlayer _Player;

		// Token: 0x04005181 RID: 20865
		private IExtension extensionObject;

		// Token: 0x04005182 RID: 20866
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005183 RID: 20867
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005184 RID: 20868
		private LuaFunction m_ctor_hotfix;
	}
}
