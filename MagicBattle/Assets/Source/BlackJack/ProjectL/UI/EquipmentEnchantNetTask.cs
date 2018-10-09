using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF8 RID: 3576
	[CustomLuaClass]
	public class EquipmentEnchantNetTask : UINetTask
	{
		// Token: 0x0601115A RID: 69978 RVA: 0x0046D2CC File Offset: 0x0046B4CC
		public EquipmentEnchantNetTask(ulong equipmentInstanceId, ulong enchantStoneInstanceId) : base(10f, null, true)
		{
			this.m_instanceId = equipmentInstanceId;
			this.m_enchantStoneInstanceId = enchantStoneInstanceId;
		}

		// Token: 0x0601115B RID: 69979 RVA: 0x0046D2EC File Offset: 0x0046B4EC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnEquipmentEnchantAck += this.OnEquipmentEnchantAck;
		}

		// Token: 0x0601115C RID: 69980 RVA: 0x0046D324 File Offset: 0x0046B524
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnEquipmentEnchantAck -= this.OnEquipmentEnchantAck;
			}
		}

		// Token: 0x0601115D RID: 69981 RVA: 0x0046D360 File Offset: 0x0046B560
		protected void OnEquipmentEnchantAck(int result, int newResonanceId, List<CommonBattleProperty> properties)
		{
			base.Result = result;
			this.NewResonanceId = newResonanceId;
			this.Properties = properties;
			this.OnTransactionComplete();
		}

		// Token: 0x0601115E RID: 69982 RVA: 0x0046D380 File Offset: 0x0046B580
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendEquipmentEnchantReq(this.m_instanceId, this.m_enchantStoneInstanceId);
		}

		// Token: 0x04009D14 RID: 40212
		private ulong m_instanceId;

		// Token: 0x04009D15 RID: 40213
		private ulong m_enchantStoneInstanceId;

		// Token: 0x04009D16 RID: 40214
		public int NewResonanceId;

		// Token: 0x04009D17 RID: 40215
		public List<CommonBattleProperty> Properties;
	}
}
