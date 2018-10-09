using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E5 RID: 1509
	[ProtoContract(Name = "BattleRoomCreateAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomCreateAck : IExtensible
	{
		// Token: 0x06005450 RID: 21584 RVA: 0x0018DCF8 File Offset: 0x0018BEF8
		public BattleRoomCreateAck()
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

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x0018DD60 File Offset: 0x0018BF60
		// (set) Token: 0x06005452 RID: 21586 RVA: 0x0018DD68 File Offset: 0x0018BF68
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

		// Token: 0x06005453 RID: 21587 RVA: 0x0018DD74 File Offset: 0x0018BF74
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x0018DD84 File Offset: 0x0018BF84
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

		// Token: 0x06005455 RID: 21589 RVA: 0x0018DE50 File Offset: 0x0018C050
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomCreateAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F5A RID: 16218
		private int _Result;

		// Token: 0x04003F5B RID: 16219
		private IExtension extensionObject;

		// Token: 0x04003F5C RID: 16220
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F5D RID: 16221
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F5E RID: 16222
		private LuaFunction m_ctor_hotfix;
	}
}
