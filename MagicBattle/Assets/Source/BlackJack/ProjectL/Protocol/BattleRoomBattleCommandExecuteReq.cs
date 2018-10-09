using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F4 RID: 1524
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomBattleCommandExecuteReq")]
	[Serializable]
	public class BattleRoomBattleCommandExecuteReq : IExtensible
	{
		// Token: 0x060054B8 RID: 21688 RVA: 0x0018F7C4 File Offset: 0x0018D9C4
		public BattleRoomBattleCommandExecuteReq()
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

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060054B9 RID: 21689 RVA: 0x0018F838 File Offset: 0x0018DA38
		// (set) Token: 0x060054BA RID: 21690 RVA: 0x0018F840 File Offset: 0x0018DA40
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

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060054BB RID: 21691 RVA: 0x0018F84C File Offset: 0x0018DA4C
		[ProtoMember(2, Name = "Commands", DataFormat = DataFormat.Default)]
		public List<ProBattleCommand> Commands
		{
			get
			{
				return this._Commands;
			}
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x0018F854 File Offset: 0x0018DA54
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x0018F864 File Offset: 0x0018DA64
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

		// Token: 0x060054BE RID: 21694 RVA: 0x0018F930 File Offset: 0x0018DB30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomBattleCommandExecuteReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FAC RID: 16300
		private ulong _RoomId;

		// Token: 0x04003FAD RID: 16301
		private readonly List<ProBattleCommand> _Commands = new List<ProBattleCommand>();

		// Token: 0x04003FAE RID: 16302
		private IExtension extensionObject;

		// Token: 0x04003FAF RID: 16303
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FB0 RID: 16304
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FB1 RID: 16305
		private LuaFunction m_ctor_hotfix;
	}
}
