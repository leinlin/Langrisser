using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000790 RID: 1936
	[ProtoContract(Name = "GuildMassiveCombatAttackAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildMassiveCombatAttackAck : IExtensible
	{
		// Token: 0x060063C9 RID: 25545 RVA: 0x001C06E8 File Offset: 0x001BE8E8
		public GuildMassiveCombatAttackAck()
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

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x060063CA RID: 25546 RVA: 0x001C0750 File Offset: 0x001BE950
		// (set) Token: 0x060063CB RID: 25547 RVA: 0x001C0758 File Offset: 0x001BE958
		[ProtoMember(1, IsRequired = true, Name = "req", DataFormat = DataFormat.Default)]
		public GuildMassiveCombatAttackReq Req
		{
			get
			{
				return this._req;
			}
			set
			{
				this._req = value;
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x060063CC RID: 25548 RVA: 0x001C0764 File Offset: 0x001BE964
		// (set) Token: 0x060063CD RID: 25549 RVA: 0x001C076C File Offset: 0x001BE96C
		[ProtoMember(2, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x060063CE RID: 25550 RVA: 0x001C0778 File Offset: 0x001BE978
		// (set) Token: 0x060063CF RID: 25551 RVA: 0x001C0780 File Offset: 0x001BE980
		[ProtoMember(3, IsRequired = true, Name = "BeginInfo", DataFormat = DataFormat.Default)]
		public ProBattleBeginInfo BeginInfo
		{
			get
			{
				return this._BeginInfo;
			}
			set
			{
				this._BeginInfo = value;
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x060063D0 RID: 25552 RVA: 0x001C078C File Offset: 0x001BE98C
		// (set) Token: 0x060063D1 RID: 25553 RVA: 0x001C0794 File Offset: 0x001BE994
		[ProtoMember(4, IsRequired = true, Name = "ArmyRandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int ArmyRandomSeed
		{
			get
			{
				return this._ArmyRandomSeed;
			}
			set
			{
				this._ArmyRandomSeed = value;
			}
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x001C07A0 File Offset: 0x001BE9A0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x001C07B0 File Offset: 0x001BE9B0
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

		// Token: 0x060063D4 RID: 25556 RVA: 0x001C087C File Offset: 0x001BEA7C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AD0 RID: 19152
		private GuildMassiveCombatAttackReq _req;

		// Token: 0x04004AD1 RID: 19153
		private int _Result;

		// Token: 0x04004AD2 RID: 19154
		private ProBattleBeginInfo _BeginInfo;

		// Token: 0x04004AD3 RID: 19155
		private int _ArmyRandomSeed;

		// Token: 0x04004AD4 RID: 19156
		private IExtension extensionObject;

		// Token: 0x04004AD5 RID: 19157
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AD6 RID: 19158
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AD7 RID: 19159
		private LuaFunction m_ctor_hotfix;
	}
}
