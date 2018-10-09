using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005ED RID: 1517
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomHeroPutdownAck")]
	[Serializable]
	public class BattleRoomHeroPutdownAck : IExtensible
	{
		// Token: 0x0600548A RID: 21642 RVA: 0x0018EB5C File Offset: 0x0018CD5C
		public BattleRoomHeroPutdownAck()
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

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x0600548B RID: 21643 RVA: 0x0018EBC4 File Offset: 0x0018CDC4
		// (set) Token: 0x0600548C RID: 21644 RVA: 0x0018EBCC File Offset: 0x0018CDCC
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

		// Token: 0x0600548D RID: 21645 RVA: 0x0018EBD8 File Offset: 0x0018CDD8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x0018EBE8 File Offset: 0x0018CDE8
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

		// Token: 0x0600548F RID: 21647 RVA: 0x0018ECB4 File Offset: 0x0018CEB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroPutdownAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F87 RID: 16263
		private int _Result;

		// Token: 0x04003F88 RID: 16264
		private IExtension extensionObject;

		// Token: 0x04003F89 RID: 16265
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F8A RID: 16266
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F8B RID: 16267
		private LuaFunction m_ctor_hotfix;
	}
}
