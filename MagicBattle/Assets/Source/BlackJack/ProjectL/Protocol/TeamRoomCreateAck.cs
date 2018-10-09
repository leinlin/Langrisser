using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000829 RID: 2089
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomCreateAck")]
	[Serializable]
	public class TeamRoomCreateAck : IExtensible
	{
		// Token: 0x06006917 RID: 26903 RVA: 0x001D9930 File Offset: 0x001D7B30
		public TeamRoomCreateAck()
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

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06006918 RID: 26904 RVA: 0x001D9998 File Offset: 0x001D7B98
		// (set) Token: 0x06006919 RID: 26905 RVA: 0x001D99A0 File Offset: 0x001D7BA0
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

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x0600691A RID: 26906 RVA: 0x001D99AC File Offset: 0x001D7BAC
		// (set) Token: 0x0600691B RID: 26907 RVA: 0x001D99B4 File Offset: 0x001D7BB4
		[ProtoMember(2, IsRequired = true, Name = "Room", DataFormat = DataFormat.Default)]
		public ProTeamRoom Room
		{
			get
			{
				return this._Room;
			}
			set
			{
				this._Room = value;
			}
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x001D99C0 File Offset: 0x001D7BC0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x001D99D0 File Offset: 0x001D7BD0
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

		// Token: 0x0600691E RID: 26910 RVA: 0x001D9A9C File Offset: 0x001D7C9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomCreateAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050FB RID: 20731
		private int _Result;

		// Token: 0x040050FC RID: 20732
		private ProTeamRoom _Room;

		// Token: 0x040050FD RID: 20733
		private IExtension extensionObject;

		// Token: 0x040050FE RID: 20734
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050FF RID: 20735
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005100 RID: 20736
		private LuaFunction m_ctor_hotfix;
	}
}
