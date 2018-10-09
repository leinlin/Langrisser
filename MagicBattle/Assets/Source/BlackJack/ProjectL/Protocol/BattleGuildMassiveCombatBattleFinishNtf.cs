using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200060A RID: 1546
	[ProtoContract(Name = "BattleGuildMassiveCombatBattleFinishNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleGuildMassiveCombatBattleFinishNtf : IExtensible
	{
		// Token: 0x06005598 RID: 21912 RVA: 0x001922A0 File Offset: 0x001904A0
		public BattleGuildMassiveCombatBattleFinishNtf()
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

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06005599 RID: 21913 RVA: 0x00192308 File Offset: 0x00190508
		// (set) Token: 0x0600559A RID: 21914 RVA: 0x00192310 File Offset: 0x00190510
		[ProtoMember(1, IsRequired = true, Name = "Stars", DataFormat = DataFormat.TwosComplement)]
		public int Stars
		{
			get
			{
				return this._Stars;
			}
			set
			{
				this._Stars = value;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x0600559B RID: 21915 RVA: 0x0019231C File Offset: 0x0019051C
		// (set) Token: 0x0600559C RID: 21916 RVA: 0x00192324 File Offset: 0x00190524
		[ProtoMember(2, IsRequired = true, Name = "ntf", DataFormat = DataFormat.Default)]
		public ProGuildMassiveCombatAttackResultNtf Ntf
		{
			get
			{
				return this._ntf;
			}
			set
			{
				this._ntf = value;
			}
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x00192330 File Offset: 0x00190530
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x00192340 File Offset: 0x00190540
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

		// Token: 0x0600559F RID: 21919 RVA: 0x0019240C File Offset: 0x0019060C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleGuildMassiveCombatBattleFinishNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004052 RID: 16466
		private int _Stars;

		// Token: 0x04004053 RID: 16467
		private ProGuildMassiveCombatAttackResultNtf _ntf;

		// Token: 0x04004054 RID: 16468
		private IExtension extensionObject;

		// Token: 0x04004055 RID: 16469
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004056 RID: 16470
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004057 RID: 16471
		private LuaFunction m_ctor_hotfix;
	}
}
