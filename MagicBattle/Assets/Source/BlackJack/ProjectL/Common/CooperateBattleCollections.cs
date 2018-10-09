using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000536 RID: 1334
	[CustomLuaClass]
	public class CooperateBattleCollections
	{
		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06004F59 RID: 20313 RVA: 0x0017EAC0 File Offset: 0x0017CCC0
		// (set) Token: 0x06004F5A RID: 20314 RVA: 0x0017EAC8 File Offset: 0x0017CCC8
		public IConfigDataLoader ConfigDataLoader
		{
			get
			{
				return this._ConfigDataLoader;
			}
			set
			{
				if (value != this._ConfigDataLoader)
				{
					this._ConfigDataLoader = value;
					this.ReloadConfigData();
				}
			}
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x0017EAE4 File Offset: 0x0017CCE4
		public void ReloadConfigData()
		{
			List<int> list = new List<int>();
			for (int i = this.Battles.Count - 1; i >= 0; i--)
			{
				if (this.ConfigDataLoader.GetConfigDataCooperateBattleInfo(this.Battles[i].ID) == null)
				{
					list.Add(i);
				}
			}
			foreach (int index in list)
			{
				this.Battles.RemoveAt(index);
			}
			IEnumerable<KeyValuePair<int, ConfigDataCooperateBattleInfo>> allConfigDataCooperateBattleInfo = this.ConfigDataLoader.GetAllConfigDataCooperateBattleInfo();
			using (IEnumerator<KeyValuePair<int, ConfigDataCooperateBattleInfo>> enumerator2 = allConfigDataCooperateBattleInfo.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, ConfigDataCooperateBattleInfo> kv = enumerator2.Current;
					CooperateBattle cooperateBattle = this.Battles.Find((CooperateBattle b) => b.ID == kv.Value.ID);
					if (cooperateBattle == null)
					{
						cooperateBattle = new CooperateBattle
						{
							ID = kv.Value.ID,
							WhichBattleCollections = this
						};
						this.Battles.Add(cooperateBattle);
					}
					cooperateBattle.ConfigDataLoader = this.ConfigDataLoader;
				}
			}
		}

		// Token: 0x040039AD RID: 14765
		public GetUserLevel GetLevel;

		// Token: 0x040039AE RID: 14766
		public CurrentTime Now;

		// Token: 0x040039AF RID: 14767
		public List<CooperateBattle> Battles = new List<CooperateBattle>();

		// Token: 0x040039B0 RID: 14768
		private IConfigDataLoader _ConfigDataLoader;
	}
}
