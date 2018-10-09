using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005FD RID: 1533
	[ProtoContract(Name = "BattleRoomTeamBattleJoinNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomTeamBattleJoinNtf : IExtensible
	{
		// Token: 0x0600550B RID: 21771 RVA: 0x001908E0 File Offset: 0x0018EAE0
		public BattleRoomTeamBattleJoinNtf()
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

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600550C RID: 21772 RVA: 0x00190954 File Offset: 0x0018EB54
		// (set) Token: 0x0600550D RID: 21773 RVA: 0x0019095C File Offset: 0x0018EB5C
		[ProtoMember(1, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
		public ulong RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				this._RoomId = value;
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x0600550E RID: 21774 RVA: 0x00190968 File Offset: 0x0018EB68
		// (set) Token: 0x0600550F RID: 21775 RVA: 0x00190970 File Offset: 0x0018EB70
		[ProtoMember(2, IsRequired = true, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06005510 RID: 21776 RVA: 0x0019097C File Offset: 0x0018EB7C
		[ProtoMember(3, Name = "Players", DataFormat = DataFormat.Default)]
		public List<ProBattleRoomPlayer> Players
		{
			get
			{
				return this._Players;
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x00190984 File Offset: 0x0018EB84
		// (set) Token: 0x06005512 RID: 21778 RVA: 0x0019098C File Offset: 0x0018EB8C
		[ProtoMember(4, IsRequired = true, Name = "RandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int RandomSeed
		{
			get
			{
				return this._RandomSeed;
			}
			set
			{
				this._RandomSeed = value;
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06005513 RID: 21779 RVA: 0x00190998 File Offset: 0x0018EB98
		// (set) Token: 0x06005514 RID: 21780 RVA: 0x001909A0 File Offset: 0x0018EBA0
		[ProtoMember(5, IsRequired = true, Name = "ReadyTimeOut", DataFormat = DataFormat.TwosComplement)]
		public long ReadyTimeOut
		{
			get
			{
				return this._ReadyTimeOut;
			}
			set
			{
				this._ReadyTimeOut = value;
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x001909AC File Offset: 0x0018EBAC
		// (set) Token: 0x06005516 RID: 21782 RVA: 0x001909B4 File Offset: 0x0018EBB4
		[ProtoMember(6, IsRequired = true, Name = "ArmyRandomSeed", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005517 RID: 21783 RVA: 0x001909C0 File Offset: 0x0018EBC0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x001909D0 File Offset: 0x0018EBD0
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

		// Token: 0x06005519 RID: 21785 RVA: 0x00190A9C File Offset: 0x0018EC9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomTeamBattleJoinNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FEA RID: 16362
		private ulong _RoomId;

		// Token: 0x04003FEB RID: 16363
		private int _BattleId;

		// Token: 0x04003FEC RID: 16364
		private readonly List<ProBattleRoomPlayer> _Players = new List<ProBattleRoomPlayer>();

		// Token: 0x04003FED RID: 16365
		private int _RandomSeed;

		// Token: 0x04003FEE RID: 16366
		private long _ReadyTimeOut;

		// Token: 0x04003FEF RID: 16367
		private int _ArmyRandomSeed;

		// Token: 0x04003FF0 RID: 16368
		private IExtension extensionObject;

		// Token: 0x04003FF1 RID: 16369
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FF2 RID: 16370
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FF3 RID: 16371
		private LuaFunction m_ctor_hotfix;
	}
}
