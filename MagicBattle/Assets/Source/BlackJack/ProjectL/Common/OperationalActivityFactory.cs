using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200055B RID: 1371
	[CustomLuaClass]
	public class OperationalActivityFactory
	{
		// Token: 0x0600504D RID: 20557 RVA: 0x00180A18 File Offset: 0x0017EC18
		public static OperationalActivityBase CreateOperationalActivity(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType)
		{
			switch (operationalActivityType)
			{
			case OperationalActivityType.OperationalActivityType_PlayerLevelUp:
				return new PlayerLevelUpOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
			case OperationalActivityType.OperationalActivityType_LimitedTimeExchange:
				return new LimitedTimeExchangeOperationActivity(instanceId, operationalActivityId, operationalActivityType);
			case OperationalActivityType.OperationalActivityType_SpecificDaysLogin:
				return new SpecificDaysLoginOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
			case OperationalActivityType.OperationalActivityType_AccumulateDaysLogin:
				return new AccumulateLoginOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
			case OperationalActivityType.OperationalActivityType_RewardAdd:
			case OperationalActivityType.OperationalActivityType_ChallengeNumsAdd:
			case OperationalActivityType.OperationalActivityType_ActivitySelectCard:
			case OperationalActivityType.OperationalActivityType_Raffle:
			case OperationalActivityType.OperationalActivityType_UnchartedScore:
			case OperationalActivityType.OperationalActivityType_Web:
			case OperationalActivityType.OperationalActivityType_BuyItemGuide:
				return new EffectOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
			case OperationalActivityType.OperationalActivityType_AccumulateRecharge:
				return new AccumulateRechargeOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
			case OperationalActivityType.OperationalActivityType_AccumulateConsumeCrystal:
				return new AccumulateConsumeCrystalOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
			}
			return null;
		}
	}
}
