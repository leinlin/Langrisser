using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005FE RID: 1534
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomPVPBattleJoinNtf")]
	[Serializable]
	public class BattleRoomPVPBattleJoinNtf : IExtensible
	{
		// Token: 0x0600551A RID: 21786 RVA: 0x00190B04 File Offset: 0x0018ED04
		public BattleRoomPVPBattleJoinNtf()
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

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600551B RID: 21787 RVA: 0x00190B78 File Offset: 0x0018ED78
		// (set) Token: 0x0600551C RID: 21788 RVA: 0x00190B80 File Offset: 0x0018ED80
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

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600551D RID: 21789 RVA: 0x00190B8C File Offset: 0x0018ED8C
		// (set) Token: 0x0600551E RID: 21790 RVA: 0x00190B94 File Offset: 0x0018ED94
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

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x0600551F RID: 21791 RVA: 0x00190BA0 File Offset: 0x0018EDA0
		[ProtoMember(3, Name = "Players", DataFormat = DataFormat.Default)]
		public List<ProBattleRoomPlayer> Players
		{
			get
			{
				return this._Players;
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06005520 RID: 21792 RVA: 0x00190BA8 File Offset: 0x0018EDA8
		// (set) Token: 0x06005521 RID: 21793 RVA: 0x00190BB0 File Offset: 0x0018EDB0
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

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06005522 RID: 21794 RVA: 0x00190BBC File Offset: 0x0018EDBC
		// (set) Token: 0x06005523 RID: 21795 RVA: 0x00190BC4 File Offset: 0x0018EDC4
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

		// Token: 0x06005524 RID: 21796 RVA: 0x00190BD0 File Offset: 0x0018EDD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x00190BE0 File Offset: 0x0018EDE0
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

		// Token: 0x06005526 RID: 21798 RVA: 0x00190CAC File Offset: 0x0018EEAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomPVPBattleJoinNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FF4 RID: 16372
		private ulong _RoomId;

		// Token: 0x04003FF5 RID: 16373
		private int _BattleId;

		// Token: 0x04003FF6 RID: 16374
		private readonly List<ProBattleRoomPlayer> _Players = new List<ProBattleRoomPlayer>();

		// Token: 0x04003FF7 RID: 16375
		private int _RandomSeed;

		// Token: 0x04003FF8 RID: 16376
		private long _ReadyTimeOut;

		// Token: 0x04003FF9 RID: 16377
		private IExtension extensionObject;

		// Token: 0x04003FFA RID: 16378
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FFB RID: 16379
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FFC RID: 16380
		private LuaFunction m_ctor_hotfix;
	}
}
