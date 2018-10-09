using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A57 RID: 2647
	[CustomLuaClass]
	public class BagItemUseNetTask : UINetTask
	{
		// Token: 0x0600A4F9 RID: 42233 RVA: 0x002E6B84 File Offset: 0x002E4D84
		public BagItemUseNetTask(GoodsType goodsType, int itemId, int count) : base(10f, null, true)
		{
			this.m_goodsType = goodsType;
			this.m_itemId = itemId;
			this.m_count = count;
		}

		// Token: 0x0600A4FA RID: 42234 RVA: 0x002E6BA8 File Offset: 0x002E4DA8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnUseBagItemAck += this.OnUseBagItemAck;
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x002E6BE0 File Offset: 0x002E4DE0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnUseBagItemAck -= this.OnUseBagItemAck;
			}
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x002E6C1C File Offset: 0x002E4E1C
		protected void OnUseBagItemAck(int result, List<Goods> reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x002E6C34 File Offset: 0x002E4E34
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendUseBagItemReq(this.m_goodsType, this.m_itemId, this.m_count, -1);
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x0600A4FE RID: 42238 RVA: 0x002E6C74 File Offset: 0x002E4E74
		public GoodsType GoodsType
		{
			get
			{
				return this.m_goodsType;
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x0600A4FF RID: 42239 RVA: 0x002E6C7C File Offset: 0x002E4E7C
		public int ItemID
		{
			get
			{
				return this.m_itemId;
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x0600A500 RID: 42240 RVA: 0x002E6C84 File Offset: 0x002E4E84
		public int Count
		{
			get
			{
				return this.m_count;
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x0600A502 RID: 42242 RVA: 0x002E6C98 File Offset: 0x002E4E98
		// (set) Token: 0x0600A501 RID: 42241 RVA: 0x002E6C8C File Offset: 0x002E4E8C
		public List<Goods> Reward { get; private set; }

		// Token: 0x04006DE4 RID: 28132
		private GoodsType m_goodsType;

		// Token: 0x04006DE5 RID: 28133
		private int m_itemId;

		// Token: 0x04006DE6 RID: 28134
		private int m_count;
	}
}
