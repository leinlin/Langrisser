using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005EB RID: 1515
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomHeroSwapAck")]
	[Serializable]
	public class BattleRoomHeroSwapAck : IExtensible
	{
		// Token: 0x0600547C RID: 21628 RVA: 0x0018E7C8 File Offset: 0x0018C9C8
		public BattleRoomHeroSwapAck()
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

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x0018E830 File Offset: 0x0018CA30
		// (set) Token: 0x0600547E RID: 21630 RVA: 0x0018E838 File Offset: 0x0018CA38
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

		// Token: 0x0600547F RID: 21631 RVA: 0x0018E844 File Offset: 0x0018CA44
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x0018E854 File Offset: 0x0018CA54
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

		// Token: 0x06005481 RID: 21633 RVA: 0x0018E920 File Offset: 0x0018CB20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroSwapAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F7C RID: 16252
		private int _Result;

		// Token: 0x04003F7D RID: 16253
		private IExtension extensionObject;

		// Token: 0x04003F7E RID: 16254
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F7F RID: 16255
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F80 RID: 16256
		private LuaFunction m_ctor_hotfix;
	}
}
