using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Resource;
using ProtoBuf;
using ProtoBuf.Meta;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.ConfigData
{
	// Token: 0x0200002D RID: 45
	[HotFix]
	public abstract class ClientConfigDataLoaderBase
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x0000D910 File Offset: 0x0000BB10
		[DoNotToLua]
		public ClientConfigDataLoaderBase(string luaModuleName)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000D930 File Offset: 0x0000BB30
		[DoNotToLua]
		public virtual bool StartInitializeFromAsset(Action<bool> onEnd, out int initLoadDataCount)
		{
			global::Debug.Log("ClientConfigDataLoaderBase.StartInitializeFromAsset");
			this.m_gameClientSetting = GameManager.Instance.GameClientSetting;
			int initThreadCount = (!this.IsUseMulitThreadOnInitLoadFromAssetEnd()) ? 1 : this.m_gameClientSetting.ConfigDataSetting.InitThreadCount;
			int loadCountForSingleYield = this.m_gameClientSetting.ConfigDataSetting.InitloadCountForSingleYield;
			this.m_lazyLoadConfigDataAssetPathDict = this.GetAllLazyLoadConfigDataAssetPath();
			HashSet<string> pathSet = this.GetAllInitLoadConfigDataAssetPath();
			initLoadDataCount = pathSet.Count;
			this.InitLoadDataCount = pathSet.Count;
			if (pathSet.Count == 0)
			{
				onEnd(true);
				return true;
			}
			ResourceManager.Instance.StartLoadAssetsCorutine(pathSet, this.m_assetDict, delegate
			{
				if (pathSet.Count == this.m_assetDict.Count && !this.m_assetDict.ContainsValue(null))
				{
					GameManager.Instance.StartCorutine(this.OnInitLoadFromAssetEnd(true, initThreadCount, loadCountForSingleYield, delegate(bool lret)
					{
						onEnd(lret);
						this.ClearAsset();
					}));
					return;
				}
				if (!this.ConfigDataAssetAllowNull)
				{
					global::Debug.LogError("StartInitializeFromAsset fail in LoadAssetsCorutine");
					GameManager.Instance.StartCorutine(this.OnInitLoadFromAssetEnd(true, initThreadCount, loadCountForSingleYield, delegate(bool lret)
					{
						onEnd(lret);
						this.ClearAsset();
					}));
					IEnumerator enumerator = this.OnInitLoadFromAssetEnd(false, initThreadCount, loadCountForSingleYield, onEnd);
					while (enumerator.MoveNext())
					{
					}
					this.ClearAsset();
					return;
				}
				this.ReportNullAssetInfo();
				GameManager.Instance.StartCorutine(this.OnInitLoadFromAssetEnd(true, initThreadCount, loadCountForSingleYield, delegate(bool lret)
				{
					onEnd(lret);
					this.ClearAsset();
				}));
			}, false);
			return true;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000DA20 File Offset: 0x0000BC20
		[DoNotToLua]
		protected virtual IEnumerator OnInitLoadFromAssetEnd(bool ret, int initThreadCount, int loadCountForSingleYield, Action<bool> onEnd)
		{
			if (!ret)
			{
				if (onEnd != null)
				{
					onEnd(false);
				}
				yield break;
			}
			if (initThreadCount > 1)
			{
				List<IProtobufExtensionTypeInfo> typeList = ProtobufExensionHelper.Handler.GetExtTypeInfoList();
				List<string> luaExtTypeList = new List<string>();
				foreach (IProtobufExtensionTypeInfo protobufExtensionTypeInfo in typeList)
				{
					if (protobufExtensionTypeInfo.HasExtensionInHierarchy())
					{
						luaExtTypeList.Add(protobufExtensionTypeInfo.GetTypeName());
					}
				}
				int workerRet = 0;
				List<Thread> workers = new List<Thread>(initThreadCount);
				for (int i = 0; i < initThreadCount; i++)
				{
					int id = i;
					Thread thread = new Thread(delegate()
					{
						IEnumerator enumerator2 = this.OnInitLoadFromAssetEndWorker(initThreadCount, id, loadCountForSingleYield, delegate(bool lret)
						{
							if (!lret)
							{
								Interlocked.Exchange(ref workerRet, -1);
							}
						}, luaExtTypeList, null);
						while (enumerator2.MoveNext())
						{
						}
					});
					workers.Add(thread);
					thread.Start();
				}
				int totalWorkerCount = 1;
				int workerId = 0;
				int loadCountForSingleYield2 = loadCountForSingleYield;
				Action<bool> onEnd2 = delegate(bool lret)
				{
					if (!lret)
					{
						Interlocked.Exchange(ref workerRet, -1);
					}
				};
				List<string> luaExtTypeList2 = luaExtTypeList;
				IEnumerator iters = this.OnInitLoadFromAssetEndWorker(totalWorkerCount, workerId, loadCountForSingleYield2, onEnd2, null, luaExtTypeList2);
				while (iters.MoveNext())
				{
				}
				if (!this.OnInitLoadFromAssetEndWorkerForLuaDummyType())
				{
					Interlocked.Exchange(ref workerRet, -1);
				}
				for (;;)
				{
					if (workers.Find((Thread t) => t.IsAlive) == null)
					{
						break;
					}
					yield return null;
				}
				if (onEnd != null)
				{
					onEnd(workerRet == 0);
				}
			}
			else
			{
				bool result = true;
				IEnumerator iter = this.OnInitLoadFromAssetEndWorker(1, 0, loadCountForSingleYield, delegate(bool lret)
				{
					result = lret;
				}, null, null);
				while (iter.MoveNext())
				{
					yield return null;
				}
				this.OnInitLoadFromAssetEndWorkerForLuaDummyType();
				if (onEnd != null)
				{
					onEnd(result);
				}
			}
			yield break;
		}

		// Token: 0x060002D8 RID: 728
		protected abstract IEnumerator OnInitLoadFromAssetEndWorker(int totalWorkerCount, int workerId, int loadCountForSingleYield, Action<bool> onEnd, List<string> skipTypeList = null, List<string> filterTypeList = null);

		// Token: 0x060002D9 RID: 729 RVA: 0x0000DA58 File Offset: 0x0000BC58
		protected virtual bool OnInitLoadFromAssetEndWorkerForLuaDummyType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInitLoadFromAssetEndWorkerForLuaDummyType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnInitLoadFromAssetEndWorkerForLuaDummyType_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<string> allInitLoadConfigDataTypeNameForLuaDummy = this.GetAllInitLoadConfigDataTypeNameForLuaDummy();
			foreach (string text in allInitLoadConfigDataTypeNameForLuaDummy)
			{
				string text2 = string.Format("{0}/{1}.asset", this.m_gameClientSetting.ConfigDataSetting.GetConfigDataAssetTargetPath(), text);
				BytesScriptableObjectMD5 bytesScriptableObjectMD = this.m_assetDict[text2] as BytesScriptableObjectMD5;
				if (bytesScriptableObjectMD != null)
				{
					if (bytesScriptableObjectMD.GetBytes() != null)
					{
						string key = string.Format("{0}.bin", Path.GetFileNameWithoutExtension(text2)).ToLower();
						this.m_assetMD5Dict[key] = bytesScriptableObjectMD.m_MD5;
						using (MemoryStream memoryStream = new MemoryStream(bytesScriptableObjectMD.GetBytes()))
						{
							IProtobufExtensionTypeInfo extTypeInfo = ProtobufExensionHelper.Handler.GetExtTypeInfo(text);
							List<DummyType> list = RuntimeTypeModel.Default.Deserialize(memoryStream, null, typeof(List<DummyType>), extTypeInfo) as List<DummyType>;
							foreach (DummyType dataItem in list)
							{
								this.AddConfigDataItemForLuaDummyType(text, dataItem);
							}
							global::Debug.Log(new object[]
							{
								"ClientConfigDataLoader InitConfigDataMap ok {0}",
								text
							});
							this.FireEventOnConfigDataTableLoadEnd();
						}
					}
					else
					{
						global::Debug.LogError(new object[]
						{
							"ClientConfigDataLoader InitConfigDataMap fail {0}, asset file has no data",
							text
						});
					}
				}
				else if (Application.isPlaying)
				{
					if (!this.ConfigDataAssetAllowNull)
					{
						global::Debug.LogError(new object[]
						{
							"ClientConfigDataLoader InitConfigDataMap fail {0}",
							text
						});
					}
					else
					{
						global::Debug.LogError(new object[]
						{
							"ClientConfigDataLoader InitConfigDataMap fail {0}, no asset file",
							text
						});
					}
				}
			}
			return true;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000DCD4 File Offset: 0x0000BED4
		protected virtual void AddConfigDataItemForLuaDummyType(string typeName, DummyType dataItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddConfigDataItemForLuaDummyTypeStringDummyType_hotfix != null)
			{
				this.m_AddConfigDataItemForLuaDummyTypeStringDummyType_hotfix.call(new object[]
				{
					this,
					typeName,
					dataItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000DD54 File Offset: 0x0000BF54
		protected virtual List<string> GetAllInitLoadConfigDataTypeNameForLuaDummy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllInitLoadConfigDataTypeNameForLuaDummy_hotfix != null)
			{
				return (List<string>)this.m_GetAllInitLoadConfigDataTypeNameForLuaDummy_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000DDC4 File Offset: 0x0000BFC4
		[DoNotToLua]
		protected bool IsUseMulitThreadOnInitLoadFromAssetEnd()
		{
			return Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[DoNotToLua]
		protected void ClearAsset()
		{
			this.m_assetDict.Clear();
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000DDF8 File Offset: 0x0000BFF8
		protected virtual HashSet<string> GetAllInitLoadConfigDataAssetPath()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllInitLoadConfigDataAssetPath_hotfix != null)
			{
				return (HashSet<string>)this.m_GetAllInitLoadConfigDataAssetPath_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HashSet<string> hashSet = new HashSet<string>();
			List<string> allInitLoadConfigDataTypeNameForLuaDummy = this.GetAllInitLoadConfigDataTypeNameForLuaDummy();
			if (allInitLoadConfigDataTypeNameForLuaDummy != null)
			{
				foreach (string arg in allInitLoadConfigDataTypeNameForLuaDummy)
				{
					hashSet.Add(string.Format("{0}/{1}.asset", this.m_gameClientSetting.ConfigDataSetting.GetConfigDataAssetTargetPath(), arg));
				}
			}
			return hashSet;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
		public virtual void LoadLazyLoadConfigDataAsset(string configDataName, string configAssetName, Action<bool> onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoadLazyLoadConfigDataAssetStringStringAction`1_hotfix != null)
			{
				this.m_LoadLazyLoadConfigDataAssetStringStringAction`1_hotfix.call(new object[]
				{
					this,
					configDataName2,
					configAssetName2,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string configDataName = configDataName2;
			string configAssetName = configAssetName2;
			Action<bool> onEnd = onEnd2;
			ClientConfigDataLoaderBase $this = this;
			ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo assetInfo = this.GetLazyLoadConfigAssetInfo(configDataName, configAssetName);
			if (assetInfo == null)
			{
				onEnd(false);
				return;
			}
			if (assetInfo.m_state == ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Loaded)
			{
				onEnd(true);
				return;
			}
			if (assetInfo.m_state != ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Unload)
			{
				onEnd(false);
				return;
			}
			assetInfo.m_state = ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Loading;
			ResourceManager.Instance.StartLoadAssetCorutine(configAssetName, delegate(string lpath, UnityEngine.Object lasset)
			{
				if (lasset != null)
				{
					assetInfo.m_state = ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Loaded;
					$this.OnLazyLoadFromAssetEnd(configDataName, configAssetName, lasset, onEnd);
				}
				else
				{
					assetInfo.m_state = ClientConfigDataLoaderBase.LazyLoadConfigAsssetState.Loadfailed;
					global::Debug.LogError(string.Format("LoadLazyLoadConfigDataAsset fail path={0}", configAssetName));
					onEnd(false);
				}
			});
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000E028 File Offset: 0x0000C228
		protected virtual void OnLazyLoadFromAssetEnd(string configDataName, string configAssetName, UnityEngine.Object lasset, Action<bool> onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLazyLoadFromAssetEndStringStringObjectAction`1_hotfix != null)
			{
				this.m_OnLazyLoadFromAssetEndStringStringObjectAction`1_hotfix.call(new object[]
				{
					this,
					configDataName,
					configAssetName,
					lasset,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (lasset == null && onEnd != null)
			{
				onEnd(false);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000E0E4 File Offset: 0x0000C2E4
		public virtual string GetLazyLoadConfigAssetNameByKey(string configDataName, int key)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLazyLoadConfigAssetNameByKeyStringInt32_hotfix != null)
			{
				return (string)this.m_GetLazyLoadConfigAssetNameByKeyStringInt32_hotfix.call(new object[]
				{
					this,
					configDataName,
					key
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return string.Empty;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000E178 File Offset: 0x0000C378
		public string GetConfigDataPath()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetConfigDataPath_hotfix != null)
			{
				return (string)this.m_GetConfigDataPath_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_gameClientSetting.ConfigDataSetting.GetConfigDataAssetTargetPath();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
		protected virtual Dictionary<string, List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo>> GetAllLazyLoadConfigDataAssetPath()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllLazyLoadConfigDataAssetPath_hotfix != null)
			{
				return (Dictionary<string, List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo>>)this.m_GetAllLazyLoadConfigDataAssetPath_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new Dictionary<string, List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo>>();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000E268 File Offset: 0x0000C468
		public ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo GetLazyLoadConfigAssetInfo(string configDataName, string configAssetName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLazyLoadConfigAssetInfoStringString_hotfix != null)
			{
				return (ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo)this.m_GetLazyLoadConfigAssetInfoStringString_hotfix.call(new object[]
				{
					this,
					configDataName,
					configAssetName
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo> list;
			if (!this.m_lazyLoadConfigDataAssetPathDict.TryGetValue(configDataName, out list))
			{
				global::Debug.LogError(string.Format("GetLazyLoadConfigAssetInfo error: no configData with name: {0}", configDataName));
				return null;
			}
			foreach (ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo lazyLoadConfigAssetInfo in list)
			{
				if (configAssetName == lazyLoadConfigAssetInfo.m_configAssetName)
				{
					return lazyLoadConfigAssetInfo;
				}
			}
			global::Debug.LogError(string.Format("GetLazyLoadConfigAssetInfo error: not find configAsset:{0} for configData:{1}", configAssetName, configDataName));
			return null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000E388 File Offset: 0x0000C588
		public List<DummyType> DeserializeExtensionTableOnLoadFromAssetEnd(BytesScriptableObjectMD5 dataObj, string assetPath, string typeName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeserializeExtensionTableOnLoadFromAssetEndBytesScriptableObjectMD5StringString_hotfix != null)
			{
				return (List<DummyType>)this.m_DeserializeExtensionTableOnLoadFromAssetEndBytesScriptableObjectMD5StringString_hotfix.call(new object[]
				{
					this,
					dataObj,
					assetPath,
					typeName
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dataObj == null)
			{
				return null;
			}
			if (dataObj.GetBytes() == null)
			{
				global::Debug.LogError(string.Format("ClientConfigDataLoader OnLazyLoadFromAssetEnd fail, asset file: {0} has no data", assetPath));
			}
			string key = string.Format("{0}.bin", Path.GetFileNameWithoutExtension(assetPath)).ToLower();
			this.m_assetMD5Dict[key] = dataObj.m_MD5;
			List<DummyType> result;
			using (MemoryStream memoryStream = new MemoryStream(dataObj.GetBytes()))
			{
				IProtobufExtensionTypeInfo extTypeInfo = ProtobufExensionHelper.Handler.GetExtTypeInfo(typeName);
				List<DummyType> list = RuntimeTypeModel.Default.Deserialize(memoryStream, null, typeof(List<DummyType>), extTypeInfo) as List<DummyType>;
				if (list == null)
				{
					global::Debug.LogError(string.Format("ClientConfigDataLoader DeserializeExtensionTableOnLoadFromAssetEnd fail, load asset {0}", assetPath));
					result = null;
				}
				else
				{
					global::Debug.Log(string.Format("ClientConfigDataLoader DeserializeExtensionTableOnLoadFromAssetEnd OK, load asset {0}", assetPath));
					result = list;
				}
			}
			return result;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000E500 File Offset: 0x0000C700
		private void ReportNullAssetInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReportNullAssetInfo_hotfix != null)
			{
				this.m_ReportNullAssetInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (KeyValuePair<string, UnityEngine.Object> keyValuePair in this.m_assetDict)
			{
				if (keyValuePair.Value == null)
				{
					global::Debug.LogError(string.Format("{0} asset dont exist,check you configdata!", keyValuePair.Key));
				}
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000E5D0 File Offset: 0x0000C7D0
		protected void FireEventOnConfigDataTableLoadEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FireEventOnConfigDataTableLoadEnd_hotfix != null)
			{
				this.m_FireEventOnConfigDataTableLoadEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnConfigDataTableLoadEnd != null)
			{
				this.EventOnConfigDataTableLoadEnd();
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060002E8 RID: 744 RVA: 0x0000E648 File Offset: 0x0000C848
		// (remove) Token: 0x060002E9 RID: 745 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		public event Action EventOnConfigDataTableLoadEnd
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnConfigDataTableLoadEndAction_hotfix != null)
				{
					this.m_add_EventOnConfigDataTableLoadEndAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfigDataTableLoadEnd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfigDataTableLoadEnd, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnConfigDataTableLoadEndAction_hotfix != null)
				{
					this.m_remove_EventOnConfigDataTableLoadEndAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfigDataTableLoadEnd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfigDataTableLoadEnd, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000E780 File Offset: 0x0000C980
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0000E7F4 File Offset: 0x0000C9F4
		[DoNotToLua]
		public bool ConfigDataAssetAllowNull
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ConfigDataAssetAllowNull_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_ConfigDataAssetAllowNull_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ConfigDataAssetAllowNull>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ConfigDataAssetAllowNullBoolean_hotfix != null)
				{
					this.m_set_ConfigDataAssetAllowNullBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ConfigDataAssetAllowNull>k__BackingField = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000E86C File Offset: 0x0000CA6C
		[DoNotToLua]
		public Dictionary<string, string> ConfigDataMD5Dict
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ConfigDataMD5Dict_hotfix != null)
				{
					return (Dictionary<string, string>)this.m_get_ConfigDataMD5Dict_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_assetMD5Dict;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000E954 File Offset: 0x0000CB54
		[DoNotToLua]
		public int InitLoadDataCount
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_InitLoadDataCount_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_InitLoadDataCount_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<InitLoadDataCount>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_InitLoadDataCountInt32_hotfix != null)
				{
					this.m_set_InitLoadDataCountInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<InitLoadDataCount>k__BackingField = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000E9CC File Offset: 0x0000CBCC
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		[DoNotToLua]
		public ClientConfigDataLoaderBase.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClientConfigDataLoaderBase.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
		private void __callDele_EventOnConfigDataTableLoadEnd()
		{
			Action eventOnConfigDataTableLoadEnd = this.EventOnConfigDataTableLoadEnd;
			if (eventOnConfigDataTableLoadEnd != null)
			{
				eventOnConfigDataTableLoadEnd();
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000EA18 File Offset: 0x0000CC18
		private void __clearDele_EventOnConfigDataTableLoadEnd()
		{
			this.EventOnConfigDataTableLoadEnd = null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000EA24 File Offset: 0x0000CC24
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_OnInitLoadFromAssetEndWorkerForLuaDummyType_hotfix = (luaObj.RawGet("OnInitLoadFromAssetEndWorkerForLuaDummyType") as LuaFunction);
					this.m_AddConfigDataItemForLuaDummyTypeStringDummyType_hotfix = (luaObj.RawGet("AddConfigDataItemForLuaDummyType") as LuaFunction);
					this.m_GetAllInitLoadConfigDataTypeNameForLuaDummy_hotfix = (luaObj.RawGet("GetAllInitLoadConfigDataTypeNameForLuaDummy") as LuaFunction);
					this.m_GetAllInitLoadConfigDataAssetPath_hotfix = (luaObj.RawGet("GetAllInitLoadConfigDataAssetPath") as LuaFunction);
					this.m_LoadLazyLoadConfigDataAssetStringStringAction`1_hotfix = (luaObj.RawGet("LoadLazyLoadConfigDataAsset") as LuaFunction);
					this.m_OnLazyLoadFromAssetEndStringStringObjectAction`1_hotfix = (luaObj.RawGet("OnLazyLoadFromAssetEnd") as LuaFunction);
					this.m_GetLazyLoadConfigAssetNameByKeyStringInt32_hotfix = (luaObj.RawGet("GetLazyLoadConfigAssetNameByKey") as LuaFunction);
					this.m_GetConfigDataPath_hotfix = (luaObj.RawGet("GetConfigDataPath") as LuaFunction);
					this.m_GetAllLazyLoadConfigDataAssetPath_hotfix = (luaObj.RawGet("GetAllLazyLoadConfigDataAssetPath") as LuaFunction);
					this.m_GetLazyLoadConfigAssetInfoStringString_hotfix = (luaObj.RawGet("GetLazyLoadConfigAssetInfo") as LuaFunction);
					this.m_DeserializeExtensionTableOnLoadFromAssetEndBytesScriptableObjectMD5StringString_hotfix = (luaObj.RawGet("DeserializeExtensionTableOnLoadFromAssetEnd") as LuaFunction);
					this.m_ReportNullAssetInfo_hotfix = (luaObj.RawGet("ReportNullAssetInfo") as LuaFunction);
					this.m_FireEventOnConfigDataTableLoadEnd_hotfix = (luaObj.RawGet("FireEventOnConfigDataTableLoadEnd") as LuaFunction);
					this.m_add_EventOnConfigDataTableLoadEndAction_hotfix = (luaObj.RawGet("add_EventOnConfigDataTableLoadEnd") as LuaFunction);
					this.m_remove_EventOnConfigDataTableLoadEndAction_hotfix = (luaObj.RawGet("remove_EventOnConfigDataTableLoadEnd") as LuaFunction);
					this.m_get_ConfigDataAssetAllowNull_hotfix = (luaObj.RawGet("get_ConfigDataAssetAllowNull") as LuaFunction);
					this.m_set_ConfigDataAssetAllowNullBoolean_hotfix = (luaObj.RawGet("set_ConfigDataAssetAllowNull") as LuaFunction);
					this.m_get_ConfigDataMD5Dict_hotfix = (luaObj.RawGet("get_ConfigDataMD5Dict") as LuaFunction);
					this.m_get_InitLoadDataCount_hotfix = (luaObj.RawGet("get_InitLoadDataCount") as LuaFunction);
					this.m_set_InitLoadDataCountInt32_hotfix = (luaObj.RawGet("set_InitLoadDataCount") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000ECCC File Offset: 0x0000CECC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientConfigDataLoaderBase));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040000BB RID: 187
		protected GameClientSetting m_gameClientSetting;

		// Token: 0x040000BC RID: 188
		[DoNotToLua]
		protected Dictionary<string, UnityEngine.Object> m_assetDict = new Dictionary<string, UnityEngine.Object>();

		// Token: 0x040000BD RID: 189
		[DoNotToLua]
		protected Dictionary<string, string> m_assetMD5Dict = new Dictionary<string, string>();

		// Token: 0x040000BE RID: 190
		private Dictionary<string, List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo>> m_lazyLoadConfigDataAssetPathDict;

		// Token: 0x040000C0 RID: 192
		[DoNotToLua]
		private ClientConfigDataLoaderBase.LuaExportHelper luaExportHelper;

		// Token: 0x040000C1 RID: 193
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040000C2 RID: 194
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040000C3 RID: 195
		private LuaFunction m_OnInitLoadFromAssetEndWorkerForLuaDummyType_hotfix;

		// Token: 0x040000C4 RID: 196
		private LuaFunction m_AddConfigDataItemForLuaDummyTypeStringDummyType_hotfix;

		// Token: 0x040000C5 RID: 197
		private LuaFunction m_GetAllInitLoadConfigDataTypeNameForLuaDummy_hotfix;

		// Token: 0x040000C6 RID: 198
		private LuaFunction m_GetAllInitLoadConfigDataAssetPath_hotfix;

		// Token: 0x040000C7 RID: 199
		private LuaFunction m_LoadLazyLoadConfigDataAssetStringStringAction;

		// Token: 0x040000C8 RID: 200
		private LuaFunction m_OnLazyLoadFromAssetEndStringStringObjectAction;

		// Token: 0x040000C9 RID: 201
		private LuaFunction m_GetLazyLoadConfigAssetNameByKeyStringInt32_hotfix;

		// Token: 0x040000CA RID: 202
		private LuaFunction m_GetConfigDataPath_hotfix;

		// Token: 0x040000CB RID: 203
		private LuaFunction m_GetAllLazyLoadConfigDataAssetPath_hotfix;

		// Token: 0x040000CC RID: 204
		private LuaFunction m_GetLazyLoadConfigAssetInfoStringString_hotfix;

		// Token: 0x040000CD RID: 205
		private LuaFunction m_DeserializeExtensionTableOnLoadFromAssetEndBytesScriptableObjectMD5StringString_hotfix;

		// Token: 0x040000CE RID: 206
		private LuaFunction m_ReportNullAssetInfo_hotfix;

		// Token: 0x040000CF RID: 207
		private LuaFunction m_FireEventOnConfigDataTableLoadEnd_hotfix;

		// Token: 0x040000D0 RID: 208
		private LuaFunction m_add_EventOnConfigDataTableLoadEndAction_hotfix;

		// Token: 0x040000D1 RID: 209
		private LuaFunction m_remove_EventOnConfigDataTableLoadEndAction_hotfix;

		// Token: 0x040000D2 RID: 210
		private LuaFunction m_get_ConfigDataAssetAllowNull_hotfix;

		// Token: 0x040000D3 RID: 211
		private LuaFunction m_set_ConfigDataAssetAllowNullBoolean_hotfix;

		// Token: 0x040000D4 RID: 212
		private LuaFunction m_get_ConfigDataMD5Dict_hotfix;

		// Token: 0x040000D5 RID: 213
		private LuaFunction m_get_InitLoadDataCount_hotfix;

		// Token: 0x040000D6 RID: 214
		private LuaFunction m_set_InitLoadDataCountInt32_hotfix;

		// Token: 0x0200002E RID: 46
		[DoNotToLua]
		public enum LazyLoadConfigAsssetState
		{
			// Token: 0x040000D8 RID: 216
			Unload,
			// Token: 0x040000D9 RID: 217
			Loading,
			// Token: 0x040000DA RID: 218
			Loaded,
			// Token: 0x040000DB RID: 219
			Loadfailed
		}

		// Token: 0x0200002F RID: 47
		[DoNotToLua]
		public class LazyLoadConfigAssetInfo
		{
			// Token: 0x040000DC RID: 220
			public string m_configAssetName;

			// Token: 0x040000DD RID: 221
			public ClientConfigDataLoaderBase.LazyLoadConfigAsssetState m_state;
		}

		// Token: 0x02000030 RID: 48
		public class LuaExportHelper
		{
			// Token: 0x060002F6 RID: 758 RVA: 0x0000ED3C File Offset: 0x0000CF3C
			public LuaExportHelper(ClientConfigDataLoaderBase owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x0000ED4C File Offset: 0x0000CF4C
			public void __callDele_EventOnConfigDataTableLoadEnd()
			{
				this.m_owner.__callDele_EventOnConfigDataTableLoadEnd();
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x0000ED5C File Offset: 0x0000CF5C
			public void __clearDele_EventOnConfigDataTableLoadEnd()
			{
				this.m_owner.__clearDele_EventOnConfigDataTableLoadEnd();
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000ED6C File Offset: 0x0000CF6C
			// (set) Token: 0x060002FA RID: 762 RVA: 0x0000ED7C File Offset: 0x0000CF7C
			public GameClientSetting m_gameClientSetting
			{
				get
				{
					return this.m_owner.m_gameClientSetting;
				}
				set
				{
					this.m_owner.m_gameClientSetting = value;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060002FB RID: 763 RVA: 0x0000ED8C File Offset: 0x0000CF8C
			// (set) Token: 0x060002FC RID: 764 RVA: 0x0000ED9C File Offset: 0x0000CF9C
			public Dictionary<string, List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo>> m_lazyLoadConfigDataAssetPathDict
			{
				get
				{
					return this.m_owner.m_lazyLoadConfigDataAssetPathDict;
				}
				set
				{
					this.m_owner.m_lazyLoadConfigDataAssetPathDict = value;
				}
			}

			// Token: 0x060002FD RID: 765 RVA: 0x0000EDAC File Offset: 0x0000CFAC
			public IEnumerator OnInitLoadFromAssetEndWorker(int totalWorkerCount, int workerId, int loadCountForSingleYield, Action<bool> onEnd, List<string> skipTypeList, List<string> filterTypeList)
			{
				return this.m_owner.OnInitLoadFromAssetEndWorker(totalWorkerCount, workerId, loadCountForSingleYield, onEnd, skipTypeList, filterTypeList);
			}

			// Token: 0x060002FE RID: 766 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
			public bool OnInitLoadFromAssetEndWorkerForLuaDummyType()
			{
				return this.m_owner.OnInitLoadFromAssetEndWorkerForLuaDummyType();
			}

			// Token: 0x060002FF RID: 767 RVA: 0x0000EDD4 File Offset: 0x0000CFD4
			public void AddConfigDataItemForLuaDummyType(string typeName, DummyType dataItem)
			{
				this.m_owner.AddConfigDataItemForLuaDummyType(typeName, dataItem);
			}

			// Token: 0x06000300 RID: 768 RVA: 0x0000EDE4 File Offset: 0x0000CFE4
			public List<string> GetAllInitLoadConfigDataTypeNameForLuaDummy()
			{
				return this.m_owner.GetAllInitLoadConfigDataTypeNameForLuaDummy();
			}

			// Token: 0x06000301 RID: 769 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
			public HashSet<string> GetAllInitLoadConfigDataAssetPath()
			{
				return this.m_owner.GetAllInitLoadConfigDataAssetPath();
			}

			// Token: 0x06000302 RID: 770 RVA: 0x0000EE04 File Offset: 0x0000D004
			public void OnLazyLoadFromAssetEnd(string configDataName, string configAssetName, UnityEngine.Object lasset, Action<bool> onEnd)
			{
				this.m_owner.OnLazyLoadFromAssetEnd(configDataName, configAssetName, lasset, onEnd);
			}

			// Token: 0x06000303 RID: 771 RVA: 0x0000EE18 File Offset: 0x0000D018
			public Dictionary<string, List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo>> GetAllLazyLoadConfigDataAssetPath()
			{
				return this.m_owner.GetAllLazyLoadConfigDataAssetPath();
			}

			// Token: 0x06000304 RID: 772 RVA: 0x0000EE28 File Offset: 0x0000D028
			public void ReportNullAssetInfo()
			{
				this.m_owner.ReportNullAssetInfo();
			}

			// Token: 0x06000305 RID: 773 RVA: 0x0000EE38 File Offset: 0x0000D038
			public void FireEventOnConfigDataTableLoadEnd()
			{
				this.m_owner.FireEventOnConfigDataTableLoadEnd();
			}

			// Token: 0x040000DE RID: 222
			private ClientConfigDataLoaderBase m_owner;
		}
	}
}
