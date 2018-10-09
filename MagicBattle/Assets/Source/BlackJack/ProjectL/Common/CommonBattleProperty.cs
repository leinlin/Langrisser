using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200036C RID: 876
	[CustomLuaClass]
	public class CommonBattleProperty
	{
		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x060031DE RID: 12766 RVA: 0x000C4500 File Offset: 0x000C2700
		// (set) Token: 0x060031DF RID: 12767 RVA: 0x000C4508 File Offset: 0x000C2708
		public PropertyModifyType Id { get; set; }

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x000C4514 File Offset: 0x000C2714
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x000C451C File Offset: 0x000C271C
		public int Value { get; set; }

		// Token: 0x060031E2 RID: 12770 RVA: 0x000C4528 File Offset: 0x000C2728
		public static ProCommonBattleProperty CommonBattlePropertyToPBCommonBattleProperty(CommonBattleProperty property)
		{
			return new ProCommonBattleProperty
			{
				Id = (int)property.Id,
				Value = property.Value
			};
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x000C4554 File Offset: 0x000C2754
		public static CommonBattleProperty PBCommonBattlePropertyToCommonBattleProperty(ProCommonBattleProperty pbProperty)
		{
			return new CommonBattleProperty
			{
				Id = (PropertyModifyType)pbProperty.Id,
				Value = pbProperty.Value
			};
		}
	}
}
