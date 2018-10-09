using System;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x0200087E RID: 2174
	[CustomLuaClass]
	public class LocalProcessingBattle
	{
		// Token: 0x06006BC6 RID: 27590 RVA: 0x001E359C File Offset: 0x001E179C
		public LocalProcessingBattle()
		{
			this.m_data = new LocalProcessingBattleData();
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x001E35B0 File Offset: 0x001E17B0
		public void SetFileName(string name)
		{
			this.m_fileName = name;
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x001E35BC File Offset: 0x001E17BC
		public bool Save()
		{
			if (string.IsNullOrEmpty(this.m_fileName))
			{
				return false;
			}
			string txt = JsonUtility.Serialize(this.m_data);
			return FileUtility.WriteText(this.m_fileName, txt);
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x001E35F4 File Offset: 0x001E17F4
		public bool Load()
		{
			if (string.IsNullOrEmpty(this.m_fileName))
			{
				return false;
			}
			if (!FileUtility.IsFileExist(this.m_fileName))
			{
				return false;
			}
			string text = FileUtility.ReadText(this.m_fileName);
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			LocalProcessingBattleData localProcessingBattleData = JsonUtility.Deserialize<LocalProcessingBattleData>(text);
			if (localProcessingBattleData == null)
			{
				Debug.LogError(string.Format("LocalProcessingBattle.Load {0} failed.", text));
				return false;
			}
			this.m_data = localProcessingBattleData;
			return true;
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x001E3668 File Offset: 0x001E1868
		public bool Delete()
		{
			if (string.IsNullOrEmpty(this.m_fileName))
			{
				return false;
			}
			if (!FileUtility.IsFileExist(this.m_fileName))
			{
				return false;
			}
			this.m_data.Clear();
			FileUtility.DeleteFile(this.m_fileName);
			return true;
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06006BCB RID: 27595 RVA: 0x001E36A8 File Offset: 0x001E18A8
		public LocalProcessingBattleData Data
		{
			get
			{
				return this.m_data;
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06006BCD RID: 27597 RVA: 0x001E36B8 File Offset: 0x001E18B8
		// (set) Token: 0x06006BCC RID: 27596 RVA: 0x001E36B0 File Offset: 0x001E18B0
		public static LocalProcessingBattle Instance
		{
			get
			{
				return LocalProcessingBattle.s_instance;
			}
			set
			{
				LocalProcessingBattle.s_instance = value;
			}
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06006BCF RID: 27599 RVA: 0x001E36C8 File Offset: 0x001E18C8
		// (set) Token: 0x06006BCE RID: 27598 RVA: 0x001E36C0 File Offset: 0x001E18C0
		public static LocalProcessingBattle ArenaInstance
		{
			get
			{
				return LocalProcessingBattle.s_arenaInstance;
			}
			set
			{
				LocalProcessingBattle.s_arenaInstance = value;
			}
		}

		// Token: 0x040052F4 RID: 21236
		private static LocalProcessingBattle s_instance;

		// Token: 0x040052F5 RID: 21237
		private static LocalProcessingBattle s_arenaInstance;

		// Token: 0x040052F6 RID: 21238
		private string m_fileName;

		// Token: 0x040052F7 RID: 21239
		private LocalProcessingBattleData m_data;
	}
}
