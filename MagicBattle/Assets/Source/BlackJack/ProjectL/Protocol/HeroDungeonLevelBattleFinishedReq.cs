using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200079B RID: 1947
	[ProtoContract(Name = "HeroDungeonLevelBattleFinishedReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroDungeonLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x0600642E RID: 25646 RVA: 0x001C1B90 File Offset: 0x001BFD90
		public HeroDungeonLevelBattleFinishedReq()
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

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x001C1BF8 File Offset: 0x001BFDF8
		// (set) Token: 0x06006430 RID: 25648 RVA: 0x001C1C00 File Offset: 0x001BFE00
		[ProtoMember(1, IsRequired = true, Name = "HeroDungeonLevelId", DataFormat = DataFormat.TwosComplement)]
		public int HeroDungeonLevelId
		{
			get
			{
				return this._HeroDungeonLevelId;
			}
			set
			{
				this._HeroDungeonLevelId = value;
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06006431 RID: 25649 RVA: 0x001C1C0C File Offset: 0x001BFE0C
		// (set) Token: 0x06006432 RID: 25650 RVA: 0x001C1C14 File Offset: 0x001BFE14
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

		// Token: 0x06006433 RID: 25651 RVA: 0x001C1C20 File Offset: 0x001BFE20
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x001C1C30 File Offset: 0x001BFE30
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

		// Token: 0x06006435 RID: 25653 RVA: 0x001C1CFC File Offset: 0x001BFEFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B19 RID: 19225
		private int _HeroDungeonLevelId;

		// Token: 0x04004B1A RID: 19226
		private ProBattleReport _BattleReport;

		// Token: 0x04004B1B RID: 19227
		private IExtension extensionObject;

		// Token: 0x04004B1C RID: 19228
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B1D RID: 19229
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B1E RID: 19230
		private LuaFunction m_ctor_hotfix;
	}
}
