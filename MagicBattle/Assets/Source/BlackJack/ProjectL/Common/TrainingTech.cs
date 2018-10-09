using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000421 RID: 1057
	[CustomLuaClass]
	public class TrainingTech
	{
		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06003D3C RID: 15676 RVA: 0x00114904 File Offset: 0x00112B04
		// (set) Token: 0x06003D3D RID: 15677 RVA: 0x0011490C File Offset: 0x00112B0C
		public int ConfigId { get; set; }

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06003D3E RID: 15678 RVA: 0x00114918 File Offset: 0x00112B18
		public List<TrainingTechInfo> Infos
		{
			get
			{
				return this.Config.m_Infos;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06003D3F RID: 15679 RVA: 0x00114928 File Offset: 0x00112B28
		// (set) Token: 0x06003D40 RID: 15680 RVA: 0x00114930 File Offset: 0x00112B30
		public int Level { get; set; }

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x0011493C File Offset: 0x00112B3C
		public ConfigDataTrainingTechInfo Config
		{
			get
			{
				return this.ConfigDataLoader.GetConfigDataTrainingTechInfo(this.ConfigId);
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06003D42 RID: 15682 RVA: 0x00114950 File Offset: 0x00112B50
		// (set) Token: 0x06003D43 RID: 15683 RVA: 0x00114958 File Offset: 0x00112B58
		public IConfigDataLoader ConfigDataLoader { get; set; }

		// Token: 0x06003D44 RID: 15684 RVA: 0x00114964 File Offset: 0x00112B64
		public void UpdateInstantiatedData(List<TrainingTech> AvailableTechs)
		{
			int num = AvailableTechs.FindIndex((TrainingTech t) => t.ConfigId == this.ConfigId);
			if (num >= 0)
			{
				this.Level = AvailableTechs[num].Level;
			}
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x001149A0 File Offset: 0x00112BA0
		public static TrainingTech FromDataSection(ProTrainingTech Tech)
		{
			return new TrainingTech
			{
				ConfigId = Tech.ConfigId,
				Level = Tech.Level
			};
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x001149CC File Offset: 0x00112BCC
		public ProTrainingTech ToPro()
		{
			return new ProTrainingTech
			{
				ConfigId = this.ConfigId,
				Level = this.Level
			};
		}
	}
}
