using System;
using SLua;

// Token: 0x02000871 RID: 2161
[CustomLuaClass]
public class GameEventID4PD
{
	// Token: 0x04005286 RID: 21126
	public const string launchGame = "1";

	// Token: 0x04005287 RID: 21127
	public const string showLoginUI = "3";

	// Token: 0x04005288 RID: 21128
	public const string loginPDSucceed = "20";

	// Token: 0x04005289 RID: 21129
	public const string updateClientBegin = "15";

	// Token: 0x0400528A RID: 21130
	public const string updateClientFromServer1 = "16";

	// Token: 0x0400528B RID: 21131
	public const string updateClientFromServer2 = "17";

	// Token: 0x0400528C RID: 21132
	public const string updateClientAllFailed = "18";

	// Token: 0x0400528D RID: 21133
	public const string updateAudioFilesFailed = "18.1";

	// Token: 0x0400528E RID: 21134
	public const string updateClientFinished = "19";

	// Token: 0x0400528F RID: 21135
	public const string confirmGameMessageBoard = "21";

	// Token: 0x04005290 RID: 21136
	public const string clickOpenAnnounceButton = "22";

	// Token: 0x04005291 RID: 21137
	public const string showServerList = "23";

	// Token: 0x04005292 RID: 21138
	public const string selectServer = "24";

	// Token: 0x04005293 RID: 21139
	public const string clickStartGameButton = "25";

	// Token: 0x04005294 RID: 21140
	public const string showSelectCharactorUI = "25.5";

	// Token: 0x04005295 RID: 21141
	public const string clickRandomCharName = "26";

	// Token: 0x04005296 RID: 21142
	public const string clickCreateCharactorButton = "27";

	// Token: 0x04005297 RID: 21143
	public const string showGoddessDialogUI = "28";

	// Token: 0x04005298 RID: 21144
	public const string showGoddessGivingJobUI = "29";

	// Token: 0x04005299 RID: 21145
	public const string clickAcceptJobButton = "30";

	// Token: 0x0400529A RID: 21146
	public const string clickReselectJobButton = "31";

	// Token: 0x0400529B RID: 21147
	public const string showWorldScene = "34";

	// Token: 0x0400529C RID: 21148
	public const string battle_start = "40";

	// Token: 0x0400529D RID: 21149
	public const string battle_arena_start = "41";

	// Token: 0x0400529E RID: 21150
	public const string battle_team = "42";

	// Token: 0x0400529F RID: 21151
	public const string battle_move = "43";

	// Token: 0x040052A0 RID: 21152
	public const string battle_attack = "44";

	// Token: 0x040052A1 RID: 21153
	public const string battle_skill = "45";

	// Token: 0x040052A2 RID: 21154
	public const string battle_standby = "46";

	// Token: 0x040052A3 RID: 21155
	public const string battle_die = "47";

	// Token: 0x040052A4 RID: 21156
	public const string battle_stop = "48";

	// Token: 0x040052A5 RID: 21157
	public const string startPreload = "50";

	// Token: 0x040052A6 RID: 21158
	public const string endPreload = "51";

	// Token: 0x040052A7 RID: 21159
	public const int completeUserGuideBaseNum = 1000;
}
