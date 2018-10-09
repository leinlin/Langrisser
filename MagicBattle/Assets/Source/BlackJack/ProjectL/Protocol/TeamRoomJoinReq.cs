using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000832 RID: 2098
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomJoinReq")]
	[Serializable]
	public class TeamRoomJoinReq : IExtensible
	{
		// Token: 0x0600695E RID: 26974 RVA: 0x001DA9A4 File Offset: 0x001D8BA4
		public TeamRoomJoinReq()
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

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x0600695F RID: 26975 RVA: 0x001DAA0C File Offset: 0x001D8C0C
		// (set) Token: 0x06006960 RID: 26976 RVA: 0x001DAA14 File Offset: 0x001D8C14
		[ProtoMember(1, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
		public int RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				this._RoomId = value;
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06006961 RID: 26977 RVA: 0x001DAA20 File Offset: 0x001D8C20
		// (set) Token: 0x06006962 RID: 26978 RVA: 0x001DAA28 File Offset: 0x001D8C28
		[ProtoMember(2, IsRequired = true, Name = "GameFunctionTypeId", DataFormat = DataFormat.TwosComplement)]
		public int GameFunctionTypeId
		{
			get
			{
				return this._GameFunctionTypeId;
			}
			set
			{
				this._GameFunctionTypeId = value;
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06006963 RID: 26979 RVA: 0x001DAA34 File Offset: 0x001D8C34
		// (set) Token: 0x06006964 RID: 26980 RVA: 0x001DAA3C File Offset: 0x001D8C3C
		[ProtoMember(3, IsRequired = true, Name = "LocationId", DataFormat = DataFormat.TwosComplement)]
		public int LocationId
		{
			get
			{
				return this._LocationId;
			}
			set
			{
				this._LocationId = value;
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06006965 RID: 26981 RVA: 0x001DAA48 File Offset: 0x001D8C48
		// (set) Token: 0x06006966 RID: 26982 RVA: 0x001DAA50 File Offset: 0x001D8C50
		[DefaultValue(0f)]
		[ProtoMember(4, IsRequired = false, Name = "InviterSessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong InviterSessionId
		{
			get
			{
				return this._InviterSessionId;
			}
			set
			{
				this._InviterSessionId = value;
			}
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x001DAA5C File Offset: 0x001D8C5C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x001DAA6C File Offset: 0x001D8C6C
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

		// Token: 0x06006969 RID: 26985 RVA: 0x001DAB38 File Offset: 0x001D8D38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomJoinReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005131 RID: 20785
		private int _RoomId;

		// Token: 0x04005132 RID: 20786
		private int _GameFunctionTypeId;

		// Token: 0x04005133 RID: 20787
		private int _LocationId;

		// Token: 0x04005134 RID: 20788
		private ulong _InviterSessionId;

		// Token: 0x04005135 RID: 20789
		private IExtension extensionObject;

		// Token: 0x04005136 RID: 20790
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005137 RID: 20791
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005138 RID: 20792
		private LuaFunction m_ctor_hotfix;
	}
}
