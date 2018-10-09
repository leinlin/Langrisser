using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200082B RID: 2091
	[ProtoContract(Name = "TeamRoomViewAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomViewAck : IExtensible
	{
		// Token: 0x06006929 RID: 26921 RVA: 0x001D9CEC File Offset: 0x001D7EEC
		public TeamRoomViewAck()
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

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x001D9D60 File Offset: 0x001D7F60
		// (set) Token: 0x0600692B RID: 26923 RVA: 0x001D9D68 File Offset: 0x001D7F68
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

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x0600692C RID: 26924 RVA: 0x001D9D74 File Offset: 0x001D7F74
		[ProtoMember(2, Name = "Rooms", DataFormat = DataFormat.Default)]
		public List<ProTeamRoom> Rooms
		{
			get
			{
				return this._Rooms;
			}
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x001D9D7C File Offset: 0x001D7F7C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x001D9D8C File Offset: 0x001D7F8C
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

		// Token: 0x0600692F RID: 26927 RVA: 0x001D9E58 File Offset: 0x001D8058
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomViewAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005108 RID: 20744
		private int _Result;

		// Token: 0x04005109 RID: 20745
		private readonly List<ProTeamRoom> _Rooms = new List<ProTeamRoom>();

		// Token: 0x0400510A RID: 20746
		private IExtension extensionObject;

		// Token: 0x0400510B RID: 20747
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400510C RID: 20748
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400510D RID: 20749
		private LuaFunction m_ctor_hotfix;
	}
}
