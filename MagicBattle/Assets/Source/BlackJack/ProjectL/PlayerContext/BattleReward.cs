using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x02000893 RID: 2195
	[HotFix]
	public class BattleReward
	{
		// Token: 0x06006DDC RID: 28124 RVA: 0x001EA70C File Offset: 0x001E890C
		public BattleReward()
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

		// Token: 0x06006DDD RID: 28125 RVA: 0x001EA7B4 File Offset: 0x001E89B4
		public void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.PlayerExp = 0;
			this.HeroExp = 0;
			this.Gold = 0;
			this.FriendshipPoints = 0;
			this.Goods.Clear();
			this.TeamGoods1.Clear();
			this.TeamGoods2.Clear();
			this.FriendGoods.Clear();
			this.DailyGoods.Clear();
			this.ScoreGoods.Clear();
			this.Score = 0;
			this.HeroScoreBonus = 0;
			this.DailyScoreBonus = 0;
		}

		// Token: 0x06006DDE RID: 28126 RVA: 0x001EA888 File Offset: 0x001E8A88
		public bool IsEmpty()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEmpty_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEmpty_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.PlayerExp <= 0 && this.HeroExp <= 0 && this.Gold <= 0 && this.FriendshipPoints <= 0 && this.IsChestGoodsEmpty();
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x001EA930 File Offset: 0x001E8B30
		public bool IsChestGoodsEmpty()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChestGoodsEmpty_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChestGoodsEmpty_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.Goods.Count <= 0 && this.TeamGoods1.Count <= 0 && this.TeamGoods2.Count <= 0 && this.FriendGoods.Count <= 0 && this.DailyGoods.Count <= 0;
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06006DE0 RID: 28128 RVA: 0x001EA9F4 File Offset: 0x001E8BF4
		// (set) Token: 0x06006DE1 RID: 28129 RVA: 0x001EAA14 File Offset: 0x001E8C14
		[DoNotToLua]
		public BattleReward.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleReward.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x001EAA20 File Offset: 0x001E8C20
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
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_IsEmpty_hotfix = (luaObj.RawGet("IsEmpty") as LuaFunction);
					this.m_IsChestGoodsEmpty_hotfix = (luaObj.RawGet("IsChestGoodsEmpty") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x001EAB38 File Offset: 0x001E8D38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleReward));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400539A RID: 21402
		public int PlayerExp;

		// Token: 0x0400539B RID: 21403
		public int HeroExp;

		// Token: 0x0400539C RID: 21404
		public int Gold;

		// Token: 0x0400539D RID: 21405
		public int FriendshipPoints;

		// Token: 0x0400539E RID: 21406
		public List<Goods> Goods = new List<Goods>();

		// Token: 0x0400539F RID: 21407
		public List<Goods> TeamGoods1 = new List<Goods>();

		// Token: 0x040053A0 RID: 21408
		public List<Goods> TeamGoods2 = new List<Goods>();

		// Token: 0x040053A1 RID: 21409
		public List<Goods> FriendGoods = new List<Goods>();

		// Token: 0x040053A2 RID: 21410
		public List<Goods> DailyGoods = new List<Goods>();

		// Token: 0x040053A3 RID: 21411
		public List<Goods> ScoreGoods = new List<Goods>();

		// Token: 0x040053A4 RID: 21412
		public int Score;

		// Token: 0x040053A5 RID: 21413
		public int DailyScoreBonus;

		// Token: 0x040053A6 RID: 21414
		public int HeroScoreBonus;

		// Token: 0x040053A7 RID: 21415
		[DoNotToLua]
		private BattleReward.LuaExportHelper luaExportHelper;

		// Token: 0x040053A8 RID: 21416
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040053A9 RID: 21417
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040053AA RID: 21418
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040053AB RID: 21419
		private LuaFunction m_Clear_hotfix;

		// Token: 0x040053AC RID: 21420
		private LuaFunction m_IsEmpty_hotfix;

		// Token: 0x040053AD RID: 21421
		private LuaFunction m_IsChestGoodsEmpty_hotfix;

		// Token: 0x02000894 RID: 2196
		public class LuaExportHelper
		{
			// Token: 0x06006DE4 RID: 28132 RVA: 0x001EABA0 File Offset: 0x001E8DA0
			public LuaExportHelper(BattleReward owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040053AE RID: 21422
			private BattleReward m_owner;
		}
	}
}
