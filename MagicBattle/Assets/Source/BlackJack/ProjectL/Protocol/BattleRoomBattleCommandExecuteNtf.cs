using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000606 RID: 1542
	[ProtoContract(Name = "BattleRoomBattleCommandExecuteNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomBattleCommandExecuteNtf : IExtensible
	{
		// Token: 0x06005567 RID: 21863 RVA: 0x00191A68 File Offset: 0x0018FC68
		public BattleRoomBattleCommandExecuteNtf()
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

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06005568 RID: 21864 RVA: 0x00191ADC File Offset: 0x0018FCDC
		// (set) Token: 0x06005569 RID: 21865 RVA: 0x00191AE4 File Offset: 0x0018FCE4
		[ProtoMember(1, IsRequired = true, Name = "SessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				this._SessionId = value;
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x0600556A RID: 21866 RVA: 0x00191AF0 File Offset: 0x0018FCF0
		[ProtoMember(2, Name = "Commands", DataFormat = DataFormat.Default)]
		public List<ProBattleCommand> Commands
		{
			get
			{
				return this._Commands;
			}
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x00191AF8 File Offset: 0x0018FCF8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x00191B08 File Offset: 0x0018FD08
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

		// Token: 0x0600556D RID: 21869 RVA: 0x00191BD4 File Offset: 0x0018FDD4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomBattleCommandExecuteNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400402E RID: 16430
		private ulong _SessionId;

		// Token: 0x0400402F RID: 16431
		private readonly List<ProBattleCommand> _Commands = new List<ProBattleCommand>();

		// Token: 0x04004030 RID: 16432
		private IExtension extensionObject;

		// Token: 0x04004031 RID: 16433
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004032 RID: 16434
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004033 RID: 16435
		private LuaFunction m_ctor_hotfix;
	}
}
