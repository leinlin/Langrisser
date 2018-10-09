using System;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000425 RID: 1061
	public static class UserSummaryCommonExtension
	{
		// Token: 0x06003D55 RID: 15701 RVA: 0x00114DBC File Offset: 0x00112FBC
		public static UserSummary ToUserSummary(this ProUserSummary Pro)
		{
			if (Pro == null)
			{
				return null;
			}
			return new UserSummary
			{
				UserId = Pro.UserId,
				HeadIcon = Pro.HeadIcon,
				Level = Pro.Level,
				LogoutTime = new DateTime(Pro.LogoutTime),
				Name = Pro.Name,
				Online = Pro.Online,
				TopHeroBattlePower = Pro.TopHeroBattlePower
			};
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00114E34 File Offset: 0x00113034
		public static ProUserSummary ToPro(this UserSummary Summary)
		{
			if (Summary == null)
			{
				return null;
			}
			return new ProUserSummary
			{
				HeadIcon = Summary.HeadIcon,
				Level = Summary.Level,
				LogoutTime = Summary.LogoutTime.Ticks,
				Name = Summary.Name,
				Online = Summary.Online,
				UserId = Summary.UserId,
				TopHeroBattlePower = Summary.TopHeroBattlePower
			};
		}
	}
}
