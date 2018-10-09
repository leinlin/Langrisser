using System;
using System.Collections;
using System.Collections.Generic;

namespace BlackJack.BJFramework.Runtime.ConfigData
{
	// Token: 0x02000038 RID: 56
	public abstract class StringTableManagerBase
	{
		// Token: 0x0600031C RID: 796 RVA: 0x0000F514 File Offset: 0x0000D714
		public StringTableManagerBase(ClientConfigDataLoaderBase configLoader)
		{
			this.m_configLoader = configLoader;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000F530 File Offset: 0x0000D730
		public IEnumerator InitLocalization(string localization, Action<bool> onEnd)
		{
			return this.SetLocalization(localization, onEnd);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000F53C File Offset: 0x0000D73C
		public virtual IEnumerator SetLocalization(string localization, Action<bool> onEnd)
		{
			if (string.IsNullOrEmpty(localization) || !this.m_localizationList.Contains(localization))
			{
				onEnd(false);
				yield break;
			}
			if (this.m_currLocalization == localization)
			{
				onEnd(true);
				yield break;
			}
			this.ClearCurrentLocalizeion();
			this.m_currLocalization = localization;
			IEnumerator iter = this.InitDefaultStringTable(onEnd);
			yield return iter;
			yield break;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000F568 File Offset: 0x0000D768
		protected virtual IEnumerator InitDefaultStringTable(Action<bool> onEnd)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000F570 File Offset: 0x0000D770
		protected virtual void ClearCurrentLocalizeion()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000F578 File Offset: 0x0000D778
		public virtual string GetStringInDefaultStringTable(string key)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000108 RID: 264
		protected ClientConfigDataLoaderBase m_configLoader;

		// Token: 0x04000109 RID: 265
		protected string m_currLocalization;

		// Token: 0x0400010A RID: 266
		protected List<string> m_localizationList = new List<string>();
	}
}
