using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000659 RID: 1625
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProArenaPlayerDefensiveTeam")]
	[Serializable]
	public class ProArenaPlayerDefensiveTeam : IExtensible
	{
		// Token: 0x060058A2 RID: 22690 RVA: 0x0019BA48 File Offset: 0x00199C48
		public ProArenaPlayerDefensiveTeam()
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

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x060058A3 RID: 22691 RVA: 0x0019BABC File Offset: 0x00199CBC
		// (set) Token: 0x060058A4 RID: 22692 RVA: 0x0019BAC4 File Offset: 0x00199CC4
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

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x060058A5 RID: 22693 RVA: 0x0019BAD0 File Offset: 0x00199CD0
		// (set) Token: 0x060058A6 RID: 22694 RVA: 0x0019BAD8 File Offset: 0x00199CD8
		[ProtoMember(2, IsRequired = true, Name = "ArenaDefenderRuleId", DataFormat = DataFormat.TwosComplement)]
		public int ArenaDefenderRuleId
		{
			get
			{
				return this._ArenaDefenderRuleId;
			}
			set
			{
				this._ArenaDefenderRuleId = value;
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x060058A7 RID: 22695 RVA: 0x0019BAE4 File Offset: 0x00199CE4
		[ProtoMember(3, Name = "DefenderHeroes", DataFormat = DataFormat.Default)]
		public List<ProArenaPlayerDefensiveHero> DefenderHeroes
		{
			get
			{
				return this._DefenderHeroes;
			}
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x0019BAEC File Offset: 0x00199CEC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x0019BAFC File Offset: 0x00199CFC
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

		// Token: 0x060058AA RID: 22698 RVA: 0x0019BBC8 File Offset: 0x00199DC8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProArenaPlayerDefensiveTeam));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004285 RID: 17029
		private int _BattleId;

		// Token: 0x04004286 RID: 17030
		private int _ArenaDefenderRuleId;

		// Token: 0x04004287 RID: 17031
		private readonly List<ProArenaPlayerDefensiveHero> _DefenderHeroes = new List<ProArenaPlayerDefensiveHero>();

		// Token: 0x04004288 RID: 17032
		private IExtension extensionObject;

		// Token: 0x04004289 RID: 17033
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400428A RID: 17034
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400428B RID: 17035
		private LuaFunction m_ctor_hotfix;
	}
}
