using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C0 RID: 1472
	[ProtoContract(Name = "ArenaBattleReportNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaBattleReportNtf : IExtensible
	{
		// Token: 0x0600531F RID: 21279 RVA: 0x0018988C File Offset: 0x00187A8C
		public ArenaBattleReportNtf()
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

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x001898F4 File Offset: 0x00187AF4
		// (set) Token: 0x06005321 RID: 21281 RVA: 0x001898FC File Offset: 0x00187AFC
		[ProtoMember(1, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public ProArenaBattleReport BattleReport
		{
			get
			{
				return this._BattleReport;
			}
			set
			{
				this._BattleReport = value;
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x00189908 File Offset: 0x00187B08
		// (set) Token: 0x06005323 RID: 21283 RVA: 0x00189910 File Offset: 0x00187B10
		[ProtoMember(2, IsRequired = true, Name = "ArenaLevelId", DataFormat = DataFormat.TwosComplement)]
		public int ArenaLevelId
		{
			get
			{
				return this._ArenaLevelId;
			}
			set
			{
				this._ArenaLevelId = value;
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x0018991C File Offset: 0x00187B1C
		// (set) Token: 0x06005325 RID: 21285 RVA: 0x00189924 File Offset: 0x00187B24
		[ProtoMember(3, IsRequired = true, Name = "ArenaPoints", DataFormat = DataFormat.TwosComplement)]
		public int ArenaPoints
		{
			get
			{
				return this._ArenaPoints;
			}
			set
			{
				this._ArenaPoints = value;
			}
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x00189930 File Offset: 0x00187B30
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x00189940 File Offset: 0x00187B40
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

		// Token: 0x06005328 RID: 21288 RVA: 0x00189A0C File Offset: 0x00187C0C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaBattleReportNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E72 RID: 15986
		private ProArenaBattleReport _BattleReport;

		// Token: 0x04003E73 RID: 15987
		private int _ArenaLevelId;

		// Token: 0x04003E74 RID: 15988
		private int _ArenaPoints;

		// Token: 0x04003E75 RID: 15989
		private IExtension extensionObject;

		// Token: 0x04003E76 RID: 15990
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E77 RID: 15991
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E78 RID: 15992
		private LuaFunction m_ctor_hotfix;
	}
}
