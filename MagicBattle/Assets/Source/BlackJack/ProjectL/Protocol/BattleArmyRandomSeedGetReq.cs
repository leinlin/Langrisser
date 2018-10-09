using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E2 RID: 1506
	[ProtoContract(Name = "BattleArmyRandomSeedGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleArmyRandomSeedGetReq : IExtensible
	{
		// Token: 0x0600543C RID: 21564 RVA: 0x0018D7A4 File Offset: 0x0018B9A4
		public BattleArmyRandomSeedGetReq()
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

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x0018D80C File Offset: 0x0018BA0C
		// (set) Token: 0x0600543E RID: 21566 RVA: 0x0018D814 File Offset: 0x0018BA14
		[ProtoMember(1, IsRequired = true, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
		public int BattleId
		{
			get
			{
				return this._BattleId;
			}
			set
			{
				this._BattleId = value;
			}
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x0018D820 File Offset: 0x0018BA20
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x0018D830 File Offset: 0x0018BA30
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

		// Token: 0x06005441 RID: 21569 RVA: 0x0018D8FC File Offset: 0x0018BAFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleArmyRandomSeedGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F4A RID: 16202
		private int _BattleId;

		// Token: 0x04003F4B RID: 16203
		private IExtension extensionObject;

		// Token: 0x04003F4C RID: 16204
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F4D RID: 16205
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F4E RID: 16206
		private LuaFunction m_ctor_hotfix;
	}
}
