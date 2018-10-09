using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F1 RID: 1521
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomHeroBanAck")]
	[Serializable]
	public class BattleRoomHeroBanAck : IExtensible
	{
		// Token: 0x060054A6 RID: 21670 RVA: 0x0018F284 File Offset: 0x0018D484
		public BattleRoomHeroBanAck()
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

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x0018F2EC File Offset: 0x0018D4EC
		// (set) Token: 0x060054A8 RID: 21672 RVA: 0x0018F2F4 File Offset: 0x0018D4F4
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

		// Token: 0x060054A9 RID: 21673 RVA: 0x0018F300 File Offset: 0x0018D500
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x0018F310 File Offset: 0x0018D510
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

		// Token: 0x060054AB RID: 21675 RVA: 0x0018F3DC File Offset: 0x0018D5DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroBanAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F9D RID: 16285
		private int _Result;

		// Token: 0x04003F9E RID: 16286
		private IExtension extensionObject;

		// Token: 0x04003F9F RID: 16287
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FA0 RID: 16288
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FA1 RID: 16289
		private LuaFunction m_ctor_hotfix;
	}
}
