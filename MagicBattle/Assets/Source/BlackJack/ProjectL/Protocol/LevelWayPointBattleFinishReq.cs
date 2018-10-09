using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007DD RID: 2013
	[ProtoContract(Name = "LevelWayPointBattleFinishReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class LevelWayPointBattleFinishReq : IExtensible
	{
		// Token: 0x060066A0 RID: 26272 RVA: 0x001C989C File Offset: 0x001C7A9C
		public LevelWayPointBattleFinishReq()
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

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x060066A1 RID: 26273 RVA: 0x001C9904 File Offset: 0x001C7B04
		// (set) Token: 0x060066A2 RID: 26274 RVA: 0x001C990C File Offset: 0x001C7B0C
		[ProtoMember(1, IsRequired = true, Name = "WayPointId", DataFormat = DataFormat.TwosComplement)]
		public int WayPointId
		{
			get
			{
				return this._WayPointId;
			}
			set
			{
				this._WayPointId = value;
			}
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x060066A3 RID: 26275 RVA: 0x001C9918 File Offset: 0x001C7B18
		// (set) Token: 0x060066A4 RID: 26276 RVA: 0x001C9920 File Offset: 0x001C7B20
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

		// Token: 0x060066A5 RID: 26277 RVA: 0x001C992C File Offset: 0x001C7B2C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066A6 RID: 26278 RVA: 0x001C993C File Offset: 0x001C7B3C
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

		// Token: 0x060066A7 RID: 26279 RVA: 0x001C9A08 File Offset: 0x001C7C08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelWayPointBattleFinishReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CDE RID: 19678
		private int _WayPointId;

		// Token: 0x04004CDF RID: 19679
		private ProBattleReport _BattleReport;

		// Token: 0x04004CE0 RID: 19680
		private IExtension extensionObject;

		// Token: 0x04004CE1 RID: 19681
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CE2 RID: 19682
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CE3 RID: 19683
		private LuaFunction m_ctor_hotfix;
	}
}
