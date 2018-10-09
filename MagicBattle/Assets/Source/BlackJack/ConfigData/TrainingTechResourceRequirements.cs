using System;
using System.Collections.Generic;
using System.Linq;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000353 RID: 851
	[CustomLuaClass]
	public class TrainingTechResourceRequirements
	{
		// Token: 0x06003157 RID: 12631 RVA: 0x000C0B98 File Offset: 0x000BED98
		public static TrainingTechResourceRequirements operator +(TrainingTechResourceRequirements x, TrainingTechResourceRequirements y)
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = new TrainingTechResourceRequirements
			{
				Gold = x.Gold + y.Gold,
				RoomLevel = Math.Max(x.RoomLevel, y.RoomLevel),
				PreTechs = x.PreTechs.Concat(y.PreTechs).ToList<int>(),
				PreTechLevels = x.PreTechLevels.Concat(y.PreTechLevels).ToList<int>()
			};
			using (IEnumerator<Goods> enumerator = x.Materials.Concat(y.Materials).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Goods m = enumerator.Current;
					int num = trainingTechResourceRequirements.Materials.FindIndex((Goods material) => material.Id == m.Id && material.GoodsType == m.GoodsType);
					if (num >= 0)
					{
						trainingTechResourceRequirements.Materials[num].Count += m.Count;
					}
					else
					{
						trainingTechResourceRequirements.Materials.Add(new Goods
						{
							Count = m.Count,
							GoodsType = m.GoodsType,
							Id = m.Id
						});
					}
				}
			}
			return trainingTechResourceRequirements;
		}

		// Token: 0x04002591 RID: 9617
		public int Gold;

		// Token: 0x04002592 RID: 9618
		public int RoomLevel;

		// Token: 0x04002593 RID: 9619
		public List<int> PreTechs;

		// Token: 0x04002594 RID: 9620
		public List<int> PreTechLevels;

		// Token: 0x04002595 RID: 9621
		public List<Goods> Materials;
	}
}
