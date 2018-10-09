using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A3 RID: 1955
	[ProtoContract(Name = "HeroPhantomBattleFinishedReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroPhantomBattleFinishedReq : IExtensible
	{
		// Token: 0x06006482 RID: 25730 RVA: 0x001C2B2C File Offset: 0x001C0D2C
		public HeroPhantomBattleFinishedReq()
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

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06006483 RID: 25731 RVA: 0x001C2B94 File Offset: 0x001C0D94
		// (set) Token: 0x06006484 RID: 25732 RVA: 0x001C2B9C File Offset: 0x001C0D9C
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

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06006485 RID: 25733 RVA: 0x001C2BA8 File Offset: 0x001C0DA8
		// (set) Token: 0x06006486 RID: 25734 RVA: 0x001C2BB0 File Offset: 0x001C0DB0
		[ProtoMember(3, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
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

		// Token: 0x06006487 RID: 25735 RVA: 0x001C2BBC File Offset: 0x001C0DBC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x001C2BCC File Offset: 0x001C0DCC
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

		// Token: 0x06006489 RID: 25737 RVA: 0x001C2C98 File Offset: 0x001C0E98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B56 RID: 19286
		private int _LevelId;

		// Token: 0x04004B57 RID: 19287
		private ProBattleReport _BattleReport;

		// Token: 0x04004B58 RID: 19288
		private IExtension extensionObject;

		// Token: 0x04004B59 RID: 19289
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B5A RID: 19290
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B5B RID: 19291
		private LuaFunction m_ctor_hotfix;
	}
}
