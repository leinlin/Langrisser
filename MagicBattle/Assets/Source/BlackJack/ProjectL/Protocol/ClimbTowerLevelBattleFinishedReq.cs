using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000633 RID: 1587
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ClimbTowerLevelBattleFinishedReq")]
	[Serializable]
	public class ClimbTowerLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x060056F9 RID: 22265 RVA: 0x00196F14 File Offset: 0x00195114
		public ClimbTowerLevelBattleFinishedReq()
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

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x060056FA RID: 22266 RVA: 0x00196F7C File Offset: 0x0019517C
		// (set) Token: 0x060056FB RID: 22267 RVA: 0x00196F84 File Offset: 0x00195184
		[ProtoMember(1, IsRequired = true, Name = "FloorId", DataFormat = DataFormat.TwosComplement)]
		public int FloorId
		{
			get
			{
				return this._FloorId;
			}
			set
			{
				this._FloorId = value;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x060056FC RID: 22268 RVA: 0x00196F90 File Offset: 0x00195190
		// (set) Token: 0x060056FD RID: 22269 RVA: 0x00196F98 File Offset: 0x00195198
		[ProtoMember(2, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public ProBattleReport BattleReport
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

		// Token: 0x060056FE RID: 22270 RVA: 0x00196FA4 File Offset: 0x001951A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x00196FB4 File Offset: 0x001951B4
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

		// Token: 0x06005700 RID: 22272 RVA: 0x00197080 File Offset: 0x00195280
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004158 RID: 16728
		private int _FloorId;

		// Token: 0x04004159 RID: 16729
		private ProBattleReport _BattleReport;

		// Token: 0x0400415A RID: 16730
		private IExtension extensionObject;

		// Token: 0x0400415B RID: 16731
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400415C RID: 16732
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400415D RID: 16733
		private LuaFunction m_ctor_hotfix;
	}
}
