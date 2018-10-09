using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000791 RID: 1937
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildMassiveCombatAttackFinishedReq")]
	[Serializable]
	public class GuildMassiveCombatAttackFinishedReq : IExtensible
	{
		// Token: 0x060063D5 RID: 25557 RVA: 0x001C08E4 File Offset: 0x001BEAE4
		public GuildMassiveCombatAttackFinishedReq()
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

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x001C094C File Offset: 0x001BEB4C
		// (set) Token: 0x060063D7 RID: 25559 RVA: 0x001C0954 File Offset: 0x001BEB54
		[ProtoMember(1, IsRequired = true, Name = "levelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._levelId;
			}
			set
			{
				this._levelId = value;
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060063D8 RID: 25560 RVA: 0x001C0960 File Offset: 0x001BEB60
		// (set) Token: 0x060063D9 RID: 25561 RVA: 0x001C0968 File Offset: 0x001BEB68
		[ProtoMember(2, IsRequired = true, Name = "report", DataFormat = DataFormat.Default)]
		public ProBattleReport Report
		{
			get
			{
				return this._report;
			}
			set
			{
				this._report = value;
			}
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x001C0974 File Offset: 0x001BEB74
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x001C0984 File Offset: 0x001BEB84
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

		// Token: 0x060063DC RID: 25564 RVA: 0x001C0A50 File Offset: 0x001BEC50
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatAttackFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AD8 RID: 19160
		private int _levelId;

		// Token: 0x04004AD9 RID: 19161
		private ProBattleReport _report;

		// Token: 0x04004ADA RID: 19162
		private IExtension extensionObject;

		// Token: 0x04004ADB RID: 19163
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004ADC RID: 19164
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004ADD RID: 19165
		private LuaFunction m_ctor_hotfix;
	}
}
