using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x0200087B RID: 2171
	[CustomLuaClass]
	public class LocalConfig
	{
		// Token: 0x06006BAD RID: 27565 RVA: 0x001E2FD0 File Offset: 0x001E11D0
		public LocalConfig()
		{
			this.m_data = new LocalConfigData();
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x001E2FE4 File Offset: 0x001E11E4
		public void SetFileName(string name)
		{
			LocalConfig.m_fileName = name;
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x001E2FEC File Offset: 0x001E11EC
		public bool Save()
		{
			if (string.IsNullOrEmpty(LocalConfig.m_fileName))
			{
				return false;
			}
			string txt = JsonUtility.Serialize(this.m_data);
			return FileUtility.WriteText(LocalConfig.m_fileName, txt);
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x001E3024 File Offset: 0x001E1224
		public bool Load()
		{
			if (string.IsNullOrEmpty(LocalConfig.m_fileName))
			{
				return false;
			}
			if (!FileUtility.IsFileExist(LocalConfig.m_fileName))
			{
				return false;
			}
			string text = FileUtility.ReadText(LocalConfig.m_fileName);
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			LocalConfigData localConfigData = JsonUtility.Deserialize<LocalConfigData>(text);
			if (localConfigData == null)
			{
				global::Debug.LogError(string.Format("LocalConfig.Load {0} failed.", text));
				return false;
			}
			this.m_data = localConfigData;
			return true;
		}

		// Token: 0x06006BB1 RID: 27569 RVA: 0x001E3094 File Offset: 0x001E1294
		public void ApplyVolume(string category, bool isInitialize = false)
		{
			if (category != null)
			{
				if (!(category == "Music_VolumeControl"))
				{
					if (!(category == "SFX_VolumeControl"))
					{
						if (category == "Voice_VolumeControl")
						{
							if (this.m_data.VoiceVolume < 0f)
							{
								this.m_data.VoiceVolume = ((!this.m_data.VoiceOn) ? 0f : 1f);
							}
							AudioUtility.SetVolume("Voice_VolumeControl", this.m_data.VoiceVolume, !isInitialize);
						}
					}
					else
					{
						if (this.m_data.SoundVolumn < 0f)
						{
							this.m_data.SoundVolumn = ((!this.m_data.SoundOn) ? 0f : 1f);
						}
						AudioUtility.SetVolume("SFX_VolumeControl", this.m_data.SoundVolumn, !isInitialize);
					}
				}
				else
				{
					if (this.m_data.MusicVolume < 0f)
					{
						this.m_data.MusicVolume = ((!this.m_data.MusicOn) ? 0f : 1f);
					}
					AudioUtility.SetVolume("Music_VolumeControl", this.m_data.MusicVolume, !isInitialize);
				}
			}
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x001E31F4 File Offset: 0x001E13F4
		public void Apply(bool isInitialize = false)
		{
			this.ApplyVolume("Music_VolumeControl", isInitialize);
			this.ApplyVolume("SFX_VolumeControl", isInitialize);
			this.ApplyVolume("Voice_VolumeControl", isInitialize);
			if (this.m_data.PowerSaveModeOn)
			{
				Application.targetFrameRate = 30;
			}
			else
			{
				Application.targetFrameRate = 60;
			}
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x001E3248 File Offset: 0x001E1448
		public void AddRecentLoginServerID(int id)
		{
			List<int> list;
			if (this.Data.RecentLoginServerIDs != null)
			{
				list = new List<int>(this.Data.RecentLoginServerIDs);
			}
			else
			{
				list = new List<int>();
			}
			if (list.Count == 0)
			{
				list.Add(id);
				this.Data.RecentLoginServerIDs = list.ToArray();
				return;
			}
			if (list[0] == id)
			{
				return;
			}
			list.Insert(0, id);
			if (list.Count > 2)
			{
				list.RemoveRange(2, list.Count - 2);
			}
			this.Data.RecentLoginServerIDs = list.ToArray();
		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x001E32E8 File Offset: 0x001E14E8
		public void SetAutoBattle(BattleType battleType, bool autoBattle)
		{
			this.m_data.AutoBattleBits = (int)MathUtility.SetBit((uint)this.m_data.AutoBattleBits, (int)battleType, autoBattle);
		}

		// Token: 0x06006BB5 RID: 27573 RVA: 0x001E3308 File Offset: 0x001E1508
		public bool IsAutoBattle(BattleType battleType)
		{
			return MathUtility.GetBit((uint)this.m_data.AutoBattleBits, (int)battleType);
		}

		// Token: 0x06006BB6 RID: 27574 RVA: 0x001E331C File Offset: 0x001E151C
		public void ClearAutoBattle()
		{
			this.m_data.AutoBattleBits = 0;
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x001E332C File Offset: 0x001E152C
		public void SetTestUIId(int testType, int testId)
		{
			if (this.m_data.TestListItemIds == null)
			{
				this.m_data.TestListItemIds = new int[5];
			}
			if (testType >= 0 && testType < this.m_data.TestListItemIds.Length)
			{
				this.m_data.TestListItemIds[testType] = testId;
			}
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x001E3384 File Offset: 0x001E1584
		public int GetTestUIId(int testType)
		{
			if (this.m_data.TestListItemIds != null && testType >= 0 && testType < this.m_data.TestListItemIds.Length)
			{
				return this.m_data.TestListItemIds[testType];
			}
			return -1;
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x001E33C0 File Offset: 0x001E15C0
		public void SetBattleDanmakuState(bool isShow)
		{
			this.m_data.ShowBattleDanmaku = isShow;
			this.Save();
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x001E33D8 File Offset: 0x001E15D8
		public void SetHeroListSortType(int type)
		{
			this.m_data.HeroListSortType = type;
			this.Save();
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x001E33F0 File Offset: 0x001E15F0
		public void SetIsOnlyShowCurJobSkin(bool onlyShowCurJobSkin)
		{
			this.m_data.OnlyShowCurJobSkin = onlyShowCurJobSkin;
			this.Save();
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x001E3408 File Offset: 0x001E1608
		public void SetIsSetSkinToAllSoldier(bool setSkinToAllSoldier)
		{
			this.m_data.SetSkinToAllSoldier = setSkinToAllSoldier;
			this.Save();
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x001E3420 File Offset: 0x001E1620
		public void UpdateGMUser(bool isGMUser)
		{
			if (!isGMUser)
			{
				this.m_data.IsDeveloper = false;
				this.m_data.IsFastEnterGame = false;
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06006BBE RID: 27582 RVA: 0x001E3440 File Offset: 0x001E1640
		public LocalConfigData Data
		{
			get
			{
				return this.m_data;
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06006BC0 RID: 27584 RVA: 0x001E3450 File Offset: 0x001E1650
		// (set) Token: 0x06006BBF RID: 27583 RVA: 0x001E3448 File Offset: 0x001E1648
		public static LocalConfig Instance
		{
			get
			{
				return LocalConfig.s_instance;
			}
			set
			{
				LocalConfig.s_instance = value;
			}
		}

		// Token: 0x040052E0 RID: 21216
		private static LocalConfig s_instance;

		// Token: 0x040052E1 RID: 21217
		private static string m_fileName;

		// Token: 0x040052E2 RID: 21218
		private LocalConfigData m_data;

		// Token: 0x040052E3 RID: 21219
		private const int m_maxRecentLoginServerCount = 2;
	}
}
