using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000607 RID: 1543
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomTeamBattleFinishNtf")]
	[Serializable]
	public class BattleRoomTeamBattleFinishNtf : IExtensible
	{
		// Token: 0x0600556E RID: 21870 RVA: 0x00191C3C File Offset: 0x0018FE3C
		public BattleRoomTeamBattleFinishNtf()
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

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x0600556F RID: 21871 RVA: 0x00191CE4 File Offset: 0x0018FEE4
		// (set) Token: 0x06005570 RID: 21872 RVA: 0x00191CEC File Offset: 0x0018FEEC
		[ProtoMember(1, IsRequired = true, Name = "Stars", DataFormat = DataFormat.TwosComplement)]
		public int Stars
		{
			get
			{
				return this._Stars;
			}
			set
			{
				this._Stars = value;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06005571 RID: 21873 RVA: 0x00191CF8 File Offset: 0x0018FEF8
		// (set) Token: 0x06005572 RID: 21874 RVA: 0x00191D00 File Offset: 0x0018FF00
		[ProtoMember(2, IsRequired = true, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06005573 RID: 21875 RVA: 0x00191D0C File Offset: 0x0018FF0C
		[ProtoMember(3, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06005574 RID: 21876 RVA: 0x00191D14 File Offset: 0x0018FF14
		[ProtoMember(4, Name = "DailyRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> DailyRewards
		{
			get
			{
				return this._DailyRewards;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x00191D1C File Offset: 0x0018FF1C
		[ProtoMember(5, Name = "TeamRewards1", DataFormat = DataFormat.Default)]
		public List<ProGoods> TeamRewards1
		{
			get
			{
				return this._TeamRewards1;
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06005576 RID: 21878 RVA: 0x00191D24 File Offset: 0x0018FF24
		[ProtoMember(6, Name = "TeamRewards2", DataFormat = DataFormat.Default)]
		public List<ProGoods> TeamRewards2
		{
			get
			{
				return this._TeamRewards2;
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06005577 RID: 21879 RVA: 0x00191D2C File Offset: 0x0018FF2C
		[ProtoMember(7, Name = "FriendRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> FriendRewards
		{
			get
			{
				return this._FriendRewards;
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06005578 RID: 21880 RVA: 0x00191D34 File Offset: 0x0018FF34
		// (set) Token: 0x06005579 RID: 21881 RVA: 0x00191D3C File Offset: 0x0018FF3C
		[ProtoMember(8, IsRequired = true, Name = "FriendshipPoints", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipPoints
		{
			get
			{
				return this._FriendshipPoints;
			}
			set
			{
				this._FriendshipPoints = value;
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x0600557A RID: 21882 RVA: 0x00191D48 File Offset: 0x0018FF48
		[ProtoMember(9, Name = "UnchartedScoreRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> UnchartedScoreRewards
		{
			get
			{
				return this._UnchartedScoreRewards;
			}
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x00191D50 File Offset: 0x0018FF50
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x00191D60 File Offset: 0x0018FF60
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

		// Token: 0x0600557D RID: 21885 RVA: 0x00191E2C File Offset: 0x0019002C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomTeamBattleFinishNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004034 RID: 16436
		private int _Stars;

		// Token: 0x04004035 RID: 16437
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004036 RID: 16438
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004037 RID: 16439
		private readonly List<ProGoods> _DailyRewards = new List<ProGoods>();

		// Token: 0x04004038 RID: 16440
		private readonly List<ProGoods> _TeamRewards1 = new List<ProGoods>();

		// Token: 0x04004039 RID: 16441
		private readonly List<ProGoods> _TeamRewards2 = new List<ProGoods>();

		// Token: 0x0400403A RID: 16442
		private readonly List<ProGoods> _FriendRewards = new List<ProGoods>();

		// Token: 0x0400403B RID: 16443
		private int _FriendshipPoints;

		// Token: 0x0400403C RID: 16444
		private readonly List<ProGoods> _UnchartedScoreRewards = new List<ProGoods>();

		// Token: 0x0400403D RID: 16445
		private IExtension extensionObject;

		// Token: 0x0400403E RID: 16446
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400403F RID: 16447
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004040 RID: 16448
		private LuaFunction m_ctor_hotfix;
	}
}
