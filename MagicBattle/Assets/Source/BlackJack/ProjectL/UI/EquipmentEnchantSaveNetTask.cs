using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF9 RID: 3577
	[CustomLuaClass]
	public class EquipmentEnchantSaveNetTask : UINetTask
	{
		// Token: 0x0601115F RID: 69983 RVA: 0x0046D3B8 File Offset: 0x0046B5B8
		public EquipmentEnchantSaveNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06011160 RID: 69984 RVA: 0x0046D3C8 File Offset: 0x0046B5C8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnEquipmentEnchantSaveAck += this.OnEquipmentEnchantSaveAck;
		}

		// Token: 0x06011161 RID: 69985 RVA: 0x0046D400 File Offset: 0x0046B600
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnEquipmentEnchantSaveAck -= this.OnEquipmentEnchantSaveAck;
			}
		}

		// Token: 0x06011162 RID: 69986 RVA: 0x0046D43C File Offset: 0x0046B63C
		protected void OnEquipmentEnchantSaveAck(int result, EquipmentBagItem equipmentBagItem)
		{
			base.Result = result;
			this.EquipBagItem = equipmentBagItem;
			this.OnTransactionComplete();
		}

		// Token: 0x06011163 RID: 69987 RVA: 0x0046D454 File Offset: 0x0046B654
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendEquipmentEnchantSaveReq();
		}

		// Token: 0x04009D18 RID: 40216
		public EquipmentBagItem EquipBagItem;
	}
}
