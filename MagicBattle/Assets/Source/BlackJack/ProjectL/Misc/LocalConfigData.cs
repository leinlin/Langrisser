using System;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x0200087A RID: 2170
	[CustomLuaClass]
	public class LocalConfigData
	{
		// Token: 0x040052BF RID: 21183
		public bool MusicOn = true;

		// Token: 0x040052C0 RID: 21184
		public bool SoundOn = true;

		// Token: 0x040052C1 RID: 21185
		public bool VoiceOn = true;

		// Token: 0x040052C2 RID: 21186
		public bool IsFasBattle;

		// Token: 0x040052C3 RID: 21187
		public int SkipCombatMode;

		// Token: 0x040052C4 RID: 21188
		public bool ClickActorEndAction;

		// Token: 0x040052C5 RID: 21189
		public bool ShowBattleDanmaku = true;

		// Token: 0x040052C6 RID: 21190
		public int AutoBattleBits;

		// Token: 0x040052C7 RID: 21191
		public bool OnlyShowCurJobSkin;

		// Token: 0x040052C8 RID: 21192
		public bool SetSkinToAllSoldier = true;

		// Token: 0x040052C9 RID: 21193
		public int HeroListSortType;

		// Token: 0x040052CA RID: 21194
		public bool NotifyEnergyRecover;

		// Token: 0x040052CB RID: 21195
		public bool NotifyRandomEvent;

		// Token: 0x040052CC RID: 21196
		public bool NotifyArenaTicket;

		// Token: 0x040052CD RID: 21197
		public bool NotifyStoreRefresh;

		// Token: 0x040052CE RID: 21198
		public bool PowerSaveModeOn;

		// Token: 0x040052CF RID: 21199
		public bool ScreenRecordOn;

		// Token: 0x040052D0 RID: 21200
		public int[] RecentLoginServerIDs;

		// Token: 0x040052D1 RID: 21201
		public string AccountName = string.Empty;

		// Token: 0x040052D2 RID: 21202
		public string Password = string.Empty;

		// Token: 0x040052D3 RID: 21203
		public bool IsDeveloper;

		// Token: 0x040052D4 RID: 21204
		public bool IsFastEnterGame;

		// Token: 0x040052D5 RID: 21205
		public bool EnableUserGuide = true;

		// Token: 0x040052D6 RID: 21206
		public int TestListType = 1;

		// Token: 0x040052D7 RID: 21207
		public int[] TestListItemIds;

		// Token: 0x040052D8 RID: 21208
		public int TestMonsterLevel = 10;

		// Token: 0x040052D9 RID: 21209
		public bool TestMarginFix;

		// Token: 0x040052DA RID: 21210
		public string LastBecomeStrongHeroStarLevel = "6";

		// Token: 0x040052DB RID: 21211
		public string LastBecomeStrongPlayerLevel = "60";

		// Token: 0x040052DC RID: 21212
		public string LastBecomeStrongEquipmentLevel = "50";

		// Token: 0x040052DD RID: 21213
		public float MusicVolume = -1f;

		// Token: 0x040052DE RID: 21214
		public float SoundVolumn = -1f;

		// Token: 0x040052DF RID: 21215
		public float VoiceVolume = -1f;
	}
}
