using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000605 RID: 1541
	[ProtoContract(Name = "BattleRoomRealTimePVPBattleStartNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomRealTimePVPBattleStartNtf : IExtensible
	{
		// Token: 0x06005560 RID: 21856 RVA: 0x00191894 File Offset: 0x0018FA94
		public BattleRoomRealTimePVPBattleStartNtf()
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

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06005561 RID: 21857 RVA: 0x00191908 File Offset: 0x0018FB08
		[ProtoMember(1, Name = "All", DataFormat = DataFormat.Default)]
		public List<ProBattleHeroSetupInfo> All
		{
			get
			{
				return this._All;
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06005562 RID: 21858 RVA: 0x00191910 File Offset: 0x0018FB10
		// (set) Token: 0x06005563 RID: 21859 RVA: 0x00191918 File Offset: 0x0018FB18
		[ProtoMember(2, IsRequired = true, Name = "BattleMode", DataFormat = DataFormat.TwosComplement)]
		public int BattleMode
		{
			get
			{
				return this._BattleMode;
			}
			set
			{
				this._BattleMode = value;
			}
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x00191924 File Offset: 0x0018FB24
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x00191934 File Offset: 0x0018FB34
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

		// Token: 0x06005566 RID: 21862 RVA: 0x00191A00 File Offset: 0x0018FC00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomRealTimePVPBattleStartNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004028 RID: 16424
		private readonly List<ProBattleHeroSetupInfo> _All = new List<ProBattleHeroSetupInfo>();

		// Token: 0x04004029 RID: 16425
		private int _BattleMode;

		// Token: 0x0400402A RID: 16426
		private IExtension extensionObject;

		// Token: 0x0400402B RID: 16427
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400402C RID: 16428
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400402D RID: 16429
		private LuaFunction m_ctor_hotfix;
	}
}
