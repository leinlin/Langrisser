using System;
using System.Collections;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.ConfigData;

namespace BlackJack.ConfigData
{
	// Token: 0x020001F3 RID: 499
	public class StringTableManager : StringTableManagerBase
	{
		// Token: 0x06001C9F RID: 7327 RVA: 0x00099488 File Offset: 0x00097688
		public StringTableManager(ClientConfigDataLoaderBase configLoader) : base(configLoader)
		{
			List<string> localizationList = GameManager.Instance.GameClientSetting.StringTableSetting.LocalizationList;
			this.m_localizationList.AddRange(localizationList);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000994C8 File Offset: 0x000976C8
		protected override IEnumerator InitDefaultStringTable(Action<bool> onEnd)
		{
			bool? ret = null;
			string currLocalization = this.m_currLocalization;
			if (currLocalization != null)
			{
				if (!(currLocalization == "CN"))
				{
					if (currLocalization == "EN")
					{
						string configDataName = "ConfigDataST_EN";
						string configAssetName = string.Format("{0}/ConfigDataST_EN.asset", this.m_configLoader.GetConfigDataPath());
						ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo lazyLoadConfigAssetInfo = this.m_configLoader.GetLazyLoadConfigAssetInfo(configDataName, configAssetName);
						if (lazyLoadConfigAssetInfo == null)
						{
							Debug.LogError(string.Format("InitDefaultStringTable error: configAsset with name: {0} not exist", configAssetName));
							if (onEnd != null)
							{
								onEnd(false);
							}
							yield break;
						}
						switch (lazyLoadConfigAssetInfo.m_state)
						{
						case ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Unload:
							this.m_configLoader.LoadLazyLoadConfigDataAsset(configDataName, configAssetName, delegate(bool lret)
							{
								if (!lret)
								{
									Debug.LogError(string.Format("InitDefaultStringTable error:  LoadLazyLoadConfigDataAsset with configAssetName:{0} failed", configAssetName));
									ret = new bool?(false);
								}
								else
								{
									IConfigDataLoader configDataLoader = this.m_configLoader as IConfigDataLoader;
									IEnumerable<KeyValuePair<int, ConfigDataST_EN>> allConfigDataST_EN = configDataLoader.GetAllConfigDataST_EN();
									foreach (KeyValuePair<int, ConfigDataST_EN> keyValuePair in allConfigDataST_EN)
									{
										this.m_ConfigDataST.Add(keyValuePair.Key, keyValuePair.Value.Value);
									}
									ret = new bool?(true);
								}
							});
							break;
						case ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Loaded:
							ret = new bool?(true);
							break;
						case ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Loadfailed:
							Debug.LogError(string.Format("InitDefaultStringTable error: LazyLoadConfigAsssetState.Loadfailed", new object[0]));
							ret = new bool?(false);
							break;
						}
						goto IL_31B;
					}
				}
				else
				{
					string configDataName2 = "ConfigDataST_CN";
					string configAssetName = string.Format("{0}/ConfigDataST_CN.asset", this.m_configLoader.GetConfigDataPath());
					ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo lazyLoadConfigAssetInfo2 = this.m_configLoader.GetLazyLoadConfigAssetInfo(configDataName2, configAssetName);
					if (lazyLoadConfigAssetInfo2 == null)
					{
						Debug.LogError(string.Format("InitDefaultStringTable error: configAsset with name: {0} not exist", configAssetName));
						if (onEnd != null)
						{
							onEnd(false);
						}
						yield break;
					}
					switch (lazyLoadConfigAssetInfo2.m_state)
					{
					case ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Unload:
						this.m_configLoader.LoadLazyLoadConfigDataAsset(configDataName2, configAssetName, delegate(bool lret)
						{
							if (!lret)
							{
								Debug.LogError(string.Format("InitDefaultStringTable error:  LoadLazyLoadConfigDataAsset with configAssetName:{0} failed", configAssetName));
								ret = new bool?(false);
							}
							else
							{
								IConfigDataLoader configDataLoader = this.m_configLoader as IConfigDataLoader;
								IEnumerable<KeyValuePair<int, ConfigDataST_CN>> allConfigDataST_CN = configDataLoader.GetAllConfigDataST_CN();
								foreach (KeyValuePair<int, ConfigDataST_CN> keyValuePair in allConfigDataST_CN)
								{
									this.m_ConfigDataST.Add(keyValuePair.Key, keyValuePair.Value.Value);
								}
								ret = new bool?(true);
							}
						});
						break;
					case ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Loaded:
						ret = new bool?(true);
						break;
					case ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Loadfailed:
						Debug.LogError(string.Format("InitDefaultStringTable error: LazyLoadConfigAsssetState.Loadfailed", new object[0]));
						ret = new bool?(false);
						break;
					}
					goto IL_31B;
				}
			}
			Debug.LogError(string.Format("InitDefaultStringTable error: localization: {0} not support", this.m_currLocalization));
			ret = new bool?(false);
			IL_31B:
			while (ret == null)
			{
				yield return null;
			}
			bool rret = false;
			if (ret != null && (ret.GetValueOrDefault() && ret != null))
			{
				rret = true;
			}
			if (onEnd != null)
			{
				onEnd(rret);
			}
			yield break;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000994EC File Offset: 0x000976EC
		protected override void ClearCurrentLocalizeion()
		{
			this.m_currLocalization = string.Empty;
			this.m_ConfigDataST.Clear();
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00099504 File Offset: 0x00097704
		public override string GetStringInDefaultStringTable(string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				return string.Empty;
			}
			return this.GetStringInST(key);
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00099520 File Offset: 0x00097720
		public string GetStringInST(string key)
		{
			string text;
			int key2;
			this.ParseStringKey(key, out text, out key2);
			string empty = string.Empty;
			if (!this.m_ConfigDataST.TryGetValue(key2, out empty))
			{
				Debug.LogError(string.Format("GetStringInDefaultStringTable error: string in Localizeion({0}) with key:{1} not find", this.m_currLocalization, key));
			}
			return empty;
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00099568 File Offset: 0x00097768
		private void ParseStringKey(string key, out string stringTableName, out int stringTableId)
		{
			string[] array = key.Split(new char[]
			{
				':'
			});
			if (array.Length != 2)
			{
				Debug.LogError(string.Format("ParseStringKey error: key{0} format error", key));
				stringTableName = string.Empty;
				stringTableId = 0;
				return;
			}
			stringTableName = array[0];
			stringTableId = int.Parse(array[1]);
		}

		// Token: 0x0400110C RID: 4364
		private Dictionary<int, string> m_ConfigDataST = new Dictionary<int, string>();
	}
}
