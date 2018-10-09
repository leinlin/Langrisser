using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F3 RID: 1523
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomEndCurrentBPTurnAck")]
	[Serializable]
	public class BattleRoomEndCurrentBPTurnAck : IExtensible
	{
		// Token: 0x060054B2 RID: 21682 RVA: 0x0018F604 File Offset: 0x0018D804
		public BattleRoomEndCurrentBPTurnAck()
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

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060054B3 RID: 21683 RVA: 0x0018F66C File Offset: 0x0018D86C
		// (set) Token: 0x060054B4 RID: 21684 RVA: 0x0018F674 File Offset: 0x0018D874
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

		// Token: 0x060054B5 RID: 21685 RVA: 0x0018F680 File Offset: 0x0018D880
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x0018F690 File Offset: 0x0018D890
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

		// Token: 0x060054B7 RID: 21687 RVA: 0x0018F75C File Offset: 0x0018D95C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomEndCurrentBPTurnAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FA7 RID: 16295
		private int _Result;

		// Token: 0x04003FA8 RID: 16296
		private IExtension extensionObject;

		// Token: 0x04003FA9 RID: 16297
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FAA RID: 16298
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FAB RID: 16299
		private LuaFunction m_ctor_hotfix;
	}
}
