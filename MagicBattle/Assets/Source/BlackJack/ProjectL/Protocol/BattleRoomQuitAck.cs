using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F7 RID: 1527
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomQuitAck")]
	[Serializable]
	public class BattleRoomQuitAck : IExtensible
	{
		// Token: 0x060054CB RID: 21707 RVA: 0x0018FD18 File Offset: 0x0018DF18
		public BattleRoomQuitAck()
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

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x0018FD80 File Offset: 0x0018DF80
		// (set) Token: 0x060054CD RID: 21709 RVA: 0x0018FD88 File Offset: 0x0018DF88
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

		// Token: 0x060054CE RID: 21710 RVA: 0x0018FD94 File Offset: 0x0018DF94
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x0018FDA4 File Offset: 0x0018DFA4
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

		// Token: 0x060054D0 RID: 21712 RVA: 0x0018FE70 File Offset: 0x0018E070
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomQuitAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FBC RID: 16316
		private int _Result;

		// Token: 0x04003FBD RID: 16317
		private IExtension extensionObject;

		// Token: 0x04003FBE RID: 16318
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FBF RID: 16319
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FC0 RID: 16320
		private LuaFunction m_ctor_hotfix;
	}
}
