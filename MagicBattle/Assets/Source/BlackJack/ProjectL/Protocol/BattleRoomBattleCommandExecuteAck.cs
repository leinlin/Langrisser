using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F5 RID: 1525
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomBattleCommandExecuteAck")]
	[Serializable]
	public class BattleRoomBattleCommandExecuteAck : IExtensible
	{
		// Token: 0x060054BF RID: 21695 RVA: 0x0018F998 File Offset: 0x0018DB98
		public BattleRoomBattleCommandExecuteAck()
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

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x060054C0 RID: 21696 RVA: 0x0018FA00 File Offset: 0x0018DC00
		// (set) Token: 0x060054C1 RID: 21697 RVA: 0x0018FA08 File Offset: 0x0018DC08
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

		// Token: 0x060054C2 RID: 21698 RVA: 0x0018FA14 File Offset: 0x0018DC14
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x0018FA24 File Offset: 0x0018DC24
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

		// Token: 0x060054C4 RID: 21700 RVA: 0x0018FAF0 File Offset: 0x0018DCF0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomBattleCommandExecuteAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FB2 RID: 16306
		private int _Result;

		// Token: 0x04003FB3 RID: 16307
		private IExtension extensionObject;

		// Token: 0x04003FB4 RID: 16308
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FB5 RID: 16309
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FB6 RID: 16310
		private LuaFunction m_ctor_hotfix;
	}
}
