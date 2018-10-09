using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E7 RID: 1511
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomPlayerStatusChangeAck")]
	[Serializable]
	public class BattleRoomPlayerStatusChangeAck : IExtensible
	{
		// Token: 0x0600545C RID: 21596 RVA: 0x0018E078 File Offset: 0x0018C278
		public BattleRoomPlayerStatusChangeAck()
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

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x0018E0E0 File Offset: 0x0018C2E0
		// (set) Token: 0x0600545E RID: 21598 RVA: 0x0018E0E8 File Offset: 0x0018C2E8
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

		// Token: 0x0600545F RID: 21599 RVA: 0x0018E0F4 File Offset: 0x0018C2F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x0018E104 File Offset: 0x0018C304
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

		// Token: 0x06005461 RID: 21601 RVA: 0x0018E1D0 File Offset: 0x0018C3D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomPlayerStatusChangeAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F64 RID: 16228
		private int _Result;

		// Token: 0x04003F65 RID: 16229
		private IExtension extensionObject;

		// Token: 0x04003F66 RID: 16230
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F67 RID: 16231
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F68 RID: 16232
		private LuaFunction m_ctor_hotfix;
	}
}
