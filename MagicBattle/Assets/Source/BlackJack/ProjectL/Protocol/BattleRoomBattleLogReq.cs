using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005FC RID: 1532
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomBattleLogReq")]
	[Serializable]
	public class BattleRoomBattleLogReq : IExtensible
	{
		// Token: 0x06005503 RID: 21763 RVA: 0x00190700 File Offset: 0x0018E900
		public BattleRoomBattleLogReq()
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

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06005504 RID: 21764 RVA: 0x00190774 File Offset: 0x0018E974
		// (set) Token: 0x06005505 RID: 21765 RVA: 0x0019077C File Offset: 0x0018E97C
		[ProtoMember(1, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
		public ulong RoomId
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

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x00190788 File Offset: 0x0018E988
		// (set) Token: 0x06005507 RID: 21767 RVA: 0x00190790 File Offset: 0x0018E990
		[DefaultValue("")]
		[ProtoMember(2, IsRequired = false, Name = "Log", DataFormat = DataFormat.Default)]
		public string Log
		{
			get
			{
				return this._Log;
			}
			set
			{
				this._Log = value;
			}
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x0019079C File Offset: 0x0018E99C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x001907AC File Offset: 0x0018E9AC
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

		// Token: 0x0600550A RID: 21770 RVA: 0x00190878 File Offset: 0x0018EA78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomBattleLogReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FE4 RID: 16356
		private ulong _RoomId;

		// Token: 0x04003FE5 RID: 16357
		private string _Log = string.Empty;

		// Token: 0x04003FE6 RID: 16358
		private IExtension extensionObject;

		// Token: 0x04003FE7 RID: 16359
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FE8 RID: 16360
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FE9 RID: 16361
		private LuaFunction m_ctor_hotfix;
	}
}
