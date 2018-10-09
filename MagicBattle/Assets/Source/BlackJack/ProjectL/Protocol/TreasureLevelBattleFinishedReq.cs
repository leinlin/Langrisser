using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000852 RID: 2130
	[ProtoContract(Name = "TreasureLevelBattleFinishedReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TreasureLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x06006A4D RID: 27213 RVA: 0x001DE3BC File Offset: 0x001DC5BC
		public TreasureLevelBattleFinishedReq()
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

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06006A4E RID: 27214 RVA: 0x001DE424 File Offset: 0x001DC624
		// (set) Token: 0x06006A4F RID: 27215 RVA: 0x001DE42C File Offset: 0x001DC62C
		[ProtoMember(1, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06006A50 RID: 27216 RVA: 0x001DE438 File Offset: 0x001DC638
		// (set) Token: 0x06006A51 RID: 27217 RVA: 0x001DE440 File Offset: 0x001DC640
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

		// Token: 0x06006A52 RID: 27218 RVA: 0x001DE44C File Offset: 0x001DC64C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x001DE45C File Offset: 0x001DC65C
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

		// Token: 0x06006A54 RID: 27220 RVA: 0x001DE528 File Offset: 0x001DC728
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051EC RID: 20972
		private int _LevelId;

		// Token: 0x040051ED RID: 20973
		private ProBattleReport _BattleReport;

		// Token: 0x040051EE RID: 20974
		private IExtension extensionObject;

		// Token: 0x040051EF RID: 20975
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051F0 RID: 20976
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051F1 RID: 20977
		private LuaFunction m_ctor_hotfix;
	}
}
