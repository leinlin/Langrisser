using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D82 RID: 3458
	[HotFix]
	public class HeroCharUIController : UIControllerBase, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x0601014A RID: 65866 RVA: 0x004351A0 File Offset: 0x004333A0
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0601014B RID: 65867 RVA: 0x0043521C File Offset: 0x0043341C
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic();
		}

		// Token: 0x0601014C RID: 65868 RVA: 0x00435284 File Offset: 0x00433484
		public void CreateGraphic(Hero hero, HeroCharUIController.PerformanceState performanceState = HeroCharUIController.PerformanceState.All, bool canClick = true, string assetPath = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGraphicHeroPerformanceStateBooleanString_hotfix != null)
			{
				this.m_CreateGraphicHeroPerformanceStateBooleanString_hotfix.call(new object[]
				{
					this,
					hero,
					performanceState,
					canClick,
					assetPath
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic();
			this.m_curState = performanceState;
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			if (assetPath == null)
			{
				assetPath = UIUtility.GetHeroCharAssetPath(hero);
			}
			if (!string.IsNullOrEmpty(charImageInfo.Spine))
			{
				this.m_spineGraphic = new UISpineGraphic();
				this.m_spineGraphic.Create(assetPath);
				this.m_spineGraphic.SetParent(this.m_root);
				this.m_spineGraphic.SetScale((float)charImageInfo.HeroDetailScale * 0.01f);
				this.m_spineGraphic.SetPosition(new Vector3(0f, (float)charImageInfo.HeroDetailYOffset, 0f));
				this.m_spineGraphic.ForceUpdate();
				this.m_image.gameObject.SetActive(false);
			}
			else if (!string.IsNullOrEmpty(charImageInfo.Image))
			{
				this.m_image.sprite = AssetUtility.Instance.GetSprite(charImageInfo.Image);
				this.m_image.gameObject.SetActive(this.m_image.sprite != null);
			}
			this.m_heroCharSkinId = hero.CharSkinId;
			this.m_charImageInfo = charImageInfo;
			this.m_hero = hero;
			HeroCharUIController.HeroPerformanceInfoList.Clear();
			int performanceIdByState = this.GetPerformanceIdByState(hero.FavorabilityLevel, hero, performanceState);
			ConfigDataPerformanceInfo configDataPerformanceInfo = this.m_configDataLoader.GetConfigDataPerformanceInfo(performanceIdByState);
			if (configDataPerformanceInfo != null && configDataPerformanceInfo.HeroPerformances_ID != null && configDataPerformanceInfo.HeroPerformances_ID.Count != 0)
			{
				foreach (int key in configDataPerformanceInfo.HeroPerformances_ID)
				{
					ConfigDataHeroPerformanceInfo configDataHeroPerformanceInfo = this.m_configDataLoader.GetConfigDataHeroPerformanceInfo(key);
					if (configDataHeroPerformanceInfo.ID != 0)
					{
						HeroCharUIController.HeroPerformanceInfoList.Add(configDataHeroPerformanceInfo);
					}
				}
			}
			this.m_wordGo.SetActive(false);
			this.m_canClick = canClick;
		}

		// Token: 0x0601014D RID: 65869 RVA: 0x0043551C File Offset: 0x0043371C
		public void CreateGraphic(ConfigDataHeroInfo heroInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGraphicConfigDataHeroInfo_hotfix != null)
			{
				this.m_CreateGraphicConfigDataHeroInfo_hotfix.call(new object[]
				{
					this,
					heroInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic();
			ConfigDataCharImageInfo charImageInfo = heroInfo.GetCharImageInfo(heroInfo.Star);
			if (!string.IsNullOrEmpty(charImageInfo.Spine))
			{
				this.m_spineGraphic = new UISpineGraphic();
				this.m_spineGraphic.Create(charImageInfo.Spine);
				this.m_spineGraphic.SetParent(this.m_root);
				this.m_spineGraphic.SetScale((float)charImageInfo.HeroDetailScale * 0.01f);
				this.m_spineGraphic.SetPosition(new Vector3(0f, (float)charImageInfo.HeroDetailYOffset, 0f));
				this.m_spineGraphic.ForceUpdate();
				this.m_image.gameObject.SetActive(false);
			}
			else if (!string.IsNullOrEmpty(charImageInfo.Image))
			{
				this.m_image.sprite = AssetUtility.Instance.GetSprite(charImageInfo.Image);
				this.m_image.gameObject.SetActive(this.m_image.sprite != null);
			}
			this.m_charImageInfo = charImageInfo;
			this.m_wordGo.SetActive(false);
			this.m_canClick = false;
		}

		// Token: 0x0601014E RID: 65870 RVA: 0x004356A4 File Offset: 0x004338A4
		public void CreateGraphic(ConfigDataHeroInfo heroInfo, string spinePath, int heroSkinId = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGraphicConfigDataHeroInfoStringInt32_hotfix != null)
			{
				this.m_CreateGraphicConfigDataHeroInfoStringInt32_hotfix.call(new object[]
				{
					this,
					heroInfo,
					spinePath,
					heroSkinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroCharSkinId = heroSkinId;
			this.DestroyGraphic();
			ConfigDataCharImageInfo charImageInfo = heroInfo.GetCharImageInfo(heroInfo.Star);
			if (!string.IsNullOrEmpty(spinePath))
			{
				this.m_spineGraphic = new UISpineGraphic();
				this.m_spineGraphic.Create(spinePath);
				this.m_spineGraphic.SetParent(this.m_root);
				this.m_spineGraphic.SetScale((float)charImageInfo.HeroDetailScale * 0.01f);
				this.m_spineGraphic.SetPosition(new Vector3(0f, (float)charImageInfo.HeroDetailYOffset, 0f));
				this.m_spineGraphic.ForceUpdate();
				this.m_image.gameObject.SetActive(false);
			}
			else if (!string.IsNullOrEmpty(charImageInfo.Image))
			{
				this.m_image.sprite = AssetUtility.Instance.GetSprite(charImageInfo.Image);
				this.m_image.gameObject.SetActive(this.m_image.sprite != null);
			}
			this.m_charImageInfo = charImageInfo;
			this.m_wordGo.SetActive(false);
			this.m_canClick = false;
		}

		// Token: 0x0601014F RID: 65871 RVA: 0x00435848 File Offset: 0x00433A48
		public ConfigDataCharImageInfo GetCharImageInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCharImageInfo_hotfix != null)
			{
				return (ConfigDataCharImageInfo)this.m_GetCharImageInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_charImageInfo;
		}

		// Token: 0x06010150 RID: 65872 RVA: 0x004358BC File Offset: 0x00433ABC
		public int GetHeroCharSkinId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroCharSkinId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroCharSkinId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroCharSkinId;
		}

		// Token: 0x06010151 RID: 65873 RVA: 0x00435930 File Offset: 0x00433B30
		public void DestroyGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyGraphic_hotfix != null)
			{
				this.m_DestroyGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StopAllCoroutines();
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.Destroy();
				this.m_spineGraphic = null;
			}
			this.m_image.gameObject.SetActive(false);
			this.m_charImageInfo = null;
			this.m_wordGo.SetActive(false);
			this.m_isAnimationPlayed = false;
			AudioUtility.PlaySound("Action_StopVoice");
		}

		// Token: 0x06010152 RID: 65874 RVA: 0x004359EC File Offset: 0x00433BEC
		public float PlayAnimation(int idx, bool loop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationInt32Boolean_hotfix != null)
			{
				return Convert.ToSingle(this.m_PlayAnimationInt32Boolean_hotfix.call(new object[]
				{
					this,
					idx,
					loop
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (idx < 0 || HeroCharUIController.HeroPerformanceInfoList.Count <= idx)
			{
				global::Debug.LogError(string.Format("PlayAnimation invlaid idx: {0}", idx));
				return 0f;
			}
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.PlayAnimation(HeroCharUIController.HeroPerformanceInfoList[idx].Animation, loop, 0);
				if (!this.m_isAnimationPlayed)
				{
					this.m_isAnimationPlayed = true;
					this.m_spineGraphic.ForceUpdate();
				}
				return this.m_spineGraphic.GetAnimationDuration(0);
			}
			return 0f;
		}

		// Token: 0x06010153 RID: 65875 RVA: 0x00435B04 File Offset: 0x00433D04
		public void PlayAnimation(string animName, bool loop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationStringBoolean_hotfix != null)
			{
				this.m_PlayAnimationStringBoolean_hotfix.call(new object[]
				{
					this,
					animName,
					loop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.PlayAnimation(animName, loop, 0);
				if (!this.m_isAnimationPlayed)
				{
					this.m_isAnimationPlayed = true;
					this.m_spineGraphic.ForceUpdate();
				}
			}
		}

		// Token: 0x06010154 RID: 65876 RVA: 0x00435BBC File Offset: 0x00433DBC
		public IAudioPlayback PlayVoice(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayVoiceInt32_hotfix != null)
			{
				return (IAudioPlayback)this.m_PlayVoiceInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (idx < 0 || HeroCharUIController.HeroPerformanceInfoList.Count <= idx)
			{
				global::Debug.LogError(string.Format("PlayVoice invlaid idx: {0}", idx));
				return null;
			}
			if (this.m_audioPlayback != null && !this.m_audioPlayback.IsStoped())
			{
				this.m_audioPlayback.Stop();
				this.m_audioPlayback = null;
			}
			return AudioUtility.PlaySound(HeroCharUIController.HeroPerformanceInfoList[idx].Voice);
		}

		// Token: 0x06010155 RID: 65877 RVA: 0x00435CA8 File Offset: 0x00433EA8
		public float ShowWords(int idx, float autoCloseTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWordsInt32Single_hotfix != null)
			{
				return Convert.ToSingle(this.m_ShowWordsInt32Single_hotfix.call(new object[]
				{
					this,
					idx,
					autoCloseTime
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (idx < 0 || HeroCharUIController.HeroPerformanceInfoList.Count <= idx)
			{
				global::Debug.LogError(string.Format("ShowWords invlaid idx: {0}", idx));
				return 0f;
			}
			base.StopAllCoroutines();
			this.m_text.text = HeroCharUIController.HeroPerformanceInfoList[idx].Word;
			if (autoCloseTime < 0f)
			{
				autoCloseTime = Math.Max(2f, (float)this.m_text.text.Length * 0.2f);
			}
			this.m_wordGo.SetActive(true);
			this.m_wordGo.GetComponent<CommonUIStateController>().SetToUIState("Show", false, true);
			base.StartCoroutine(this.CloseWordPanel(autoCloseTime));
			return autoCloseTime;
		}

		// Token: 0x06010156 RID: 65878 RVA: 0x00435DE8 File Offset: 0x00433FE8
		[DebuggerHidden]
		private IEnumerator CloseWordPanel(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseWordPanelSingle_hotfix != null)
			{
				return (IEnumerator)this.m_CloseWordPanelSingle_hotfix.call(new object[]
				{
					this,
					time
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroCharUIController.<CloseWordPanel>c__Iterator0 <CloseWordPanel>c__Iterator = new HeroCharUIController.<CloseWordPanel>c__Iterator0();
			<CloseWordPanel>c__Iterator.time = time;
			<CloseWordPanel>c__Iterator.$this = this;
			return <CloseWordPanel>c__Iterator;
		}

		// Token: 0x06010157 RID: 65879 RVA: 0x00435E7C File Offset: 0x0043407C
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null && !this.m_spineGraphic.IsPlayAnimation(0))
			{
				this.m_spineGraphic.PlayAnimation("idle_Normal", true, 0);
			}
		}

		// Token: 0x06010158 RID: 65880 RVA: 0x00435F0C File Offset: 0x0043410C
		public void SetSpineColor(Color color)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSpineColorColor_hotfix != null)
			{
				this.m_SetSpineColorColor_hotfix.call(new object[]
				{
					this,
					color
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.SetColor(color);
			}
		}

		// Token: 0x06010159 RID: 65881 RVA: 0x00435F94 File Offset: 0x00434194
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick();
			}
			GameObject gameObject = eventData.pointerCurrentRaycast.gameObject;
			if (this.IsClickInCharRoot(gameObject) && this.m_canClick)
			{
				this.PlayOneRandomPerformance(false);
			}
		}

		// Token: 0x0601015A RID: 65882 RVA: 0x00436048 File Offset: 0x00434248
		private bool IsClickInCharRoot(GameObject clickGameObject)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsClickInCharRootGameObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsClickInCharRootGameObject_hotfix.call(new object[]
				{
					this,
					clickGameObject
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Transform parent = clickGameObject.transform.parent;
			while (parent != null)
			{
				if (parent.gameObject == this.m_charRoot)
				{
					return true;
				}
				parent = parent.parent;
			}
			return false;
		}

		// Token: 0x0601015B RID: 65883 RVA: 0x00436104 File Offset: 0x00434304
		public void SetCanClick(bool canClick)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCanClickBoolean_hotfix != null)
			{
				this.m_SetCanClickBoolean_hotfix.call(new object[]
				{
					this,
					canClick
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_canClick = canClick;
		}

		// Token: 0x0601015C RID: 65884 RVA: 0x0043617C File Offset: 0x0043437C
		public float PlayOneRandomPerformance(bool canInterrupt = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayOneRandomPerformanceBoolean_hotfix != null)
			{
				return Convert.ToSingle(this.m_PlayOneRandomPerformanceBoolean_hotfix.call(new object[]
				{
					this,
					canInterrupt
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic == null)
			{
				global::Debug.LogError("PlayOneRandomPerformance m_spineGraphic is null.");
				return 0f;
			}
			if (!canInterrupt && this.m_spineGraphic.IsPlayAnimation(0) && !this.m_spineGraphic.IsLoop(0))
			{
				return 0f;
			}
			int num = this.m_performanceIndex;
			if (HeroCharUIController.HeroPerformanceInfoList.Count > 0)
			{
				int num2 = 0;
				for (;;)
				{
					num = UnityEngine.Random.Range(0, HeroCharUIController.HeroPerformanceInfoList.Count);
					if (num2++ > 100)
					{
						break;
					}
					if (!this.CanPlayRandomHeroPerformancesIndex(num))
					{
						goto Block_10;
					}
				}
				global::Debug.LogError("Check excel , there is no animation can be used");
				global::Debug.LogError("May be : " + this.m_charImageInfo.Name + " , " + HeroCharUIController.HeroPerformanceInfoList[num].Animation);
				return 0f;
				Block_10:
				float val = this.PlayAnimation(num, false);
				this.m_audioPlayback = this.PlayVoice(num);
				float val2 = this.ShowWords(num, (this.m_audioPlayback != null) ? this.m_audioPlayback.Seconds : -1f);
				return Math.Max(val, val2);
			}
			return 0f;
		}

		// Token: 0x0601015D RID: 65885 RVA: 0x00436314 File Offset: 0x00434514
		private bool CanPlayRandomHeroPerformancesIndex(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanPlayRandomHeroPerformancesIndexInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanPlayRandomHeroPerformancesIndexInt32_hotfix.call(new object[]
				{
					this,
					index
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curState != HeroCharUIController.PerformanceState.All)
			{
				return !this.m_spineGraphic.HasAnimation(HeroCharUIController.HeroPerformanceInfoList[index].Animation);
			}
			if (!this.m_spineGraphic.HasAnimation(HeroCharUIController.HeroPerformanceInfoList[index].Animation))
			{
				return false;
			}
			int performanceIdByState = this.GetPerformanceIdByState(this.m_hero.FavorabilityLevel, this.m_hero, HeroCharUIController.PerformanceState.List);
			ConfigDataPerformanceInfo configDataPerformanceInfo = this.m_configDataLoader.GetConfigDataPerformanceInfo(performanceIdByState);
			return !configDataPerformanceInfo.HeroPerformances_ID.Contains(HeroCharUIController.HeroPerformanceInfoList[index].ID);
		}

		// Token: 0x0601015E RID: 65886 RVA: 0x00436420 File Offset: 0x00434620
		public float PlayOneSpecifiedPerformance(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayOneSpecifiedPerformanceInt32_hotfix != null)
			{
				return Convert.ToSingle(this.m_PlayOneSpecifiedPerformanceInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroPerformanceId = heroPerformanceId2;
			if (this.m_spineGraphic == null)
			{
				global::Debug.LogError("PlayOneRandomPerformance m_spineGraphic is null.");
				return 0f;
			}
			if (this.m_audioPlayback != null && !this.m_audioPlayback.IsStoped())
			{
				if (this.m_heroPerformanceId == heroPerformanceId)
				{
					return 0f;
				}
				this.m_heroPerformanceId = heroPerformanceId;
			}
			else
			{
				this.m_heroPerformanceId = heroPerformanceId;
			}
			int num = HeroCharUIController.HeroPerformanceInfoList.FindIndex((ConfigDataHeroPerformanceInfo info) => info.ID == heroPerformanceId);
			if (num == -1)
			{
				return 0f;
			}
			float val = 0f;
			if (this.m_spineGraphic.HasAnimation(HeroCharUIController.HeroPerformanceInfoList[num].Animation))
			{
				val = this.PlayAnimation(num, false);
			}
			this.m_audioPlayback = this.PlayVoice(num);
			float val2 = this.ShowWords(num, (this.m_audioPlayback != null) ? this.m_audioPlayback.Seconds : -1f);
			return Math.Max(val, val2);
		}

		// Token: 0x0601015F RID: 65887 RVA: 0x004365A4 File Offset: 0x004347A4
		private int GetPerformanceIdByState(int favorabilityLevel, Hero hero, HeroCharUIController.PerformanceState performanceState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPerformanceIdByStateInt32HeroPerformanceState_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPerformanceIdByStateInt32HeroPerformanceState_hotfix.call(new object[]
				{
					this,
					favorabilityLevel,
					hero,
					performanceState
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<FavourabilityPerformance> list = null;
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			switch (performanceState)
			{
			case HeroCharUIController.PerformanceState.All:
				if (hero.HeroInfo.m_informationInfo != null)
				{
					return hero.HeroInfo.m_informationInfo.HeroPerformance_ID;
				}
				break;
			case HeroCharUIController.PerformanceState.List:
				list = charImageInfo.NewPerformances;
				break;
			case HeroCharUIController.PerformanceState.Break:
				list = charImageInfo.NewBreakPerformances;
				break;
			case HeroCharUIController.PerformanceState.Summon:
				list = charImageInfo.NewSummonPerformances;
				break;
			case HeroCharUIController.PerformanceState.JobTransfer:
				list = charImageInfo.NewJobTransferPerformances;
				break;
			}
			if (list != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (i + 1 == list.Count)
					{
						return list[i].PerformanceId;
					}
					if (list[i].FavourabilityLevel <= favorabilityLevel && favorabilityLevel < list[i + 1].FavourabilityLevel)
					{
						return list[i].PerformanceId;
					}
				}
			}
			return int.MinValue;
		}

		// Token: 0x14000360 RID: 864
		// (add) Token: 0x06010160 RID: 65888 RVA: 0x00436740 File Offset: 0x00434940
		// (remove) Token: 0x06010161 RID: 65889 RVA: 0x004367DC File Offset: 0x004349DC
		public event Action EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction_hotfix != null)
				{
					this.m_add_EventOnClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction_hotfix != null)
				{
					this.m_remove_EventOnClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x06010162 RID: 65890 RVA: 0x00436878 File Offset: 0x00434A78
		// (set) Token: 0x06010163 RID: 65891 RVA: 0x00436898 File Offset: 0x00434A98
		[DoNotToLua]
		public new HeroCharUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroCharUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010164 RID: 65892 RVA: 0x004368A4 File Offset: 0x00434AA4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010165 RID: 65893 RVA: 0x004368B0 File Offset: 0x00434AB0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010166 RID: 65894 RVA: 0x004368B8 File Offset: 0x00434AB8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010167 RID: 65895 RVA: 0x004368C0 File Offset: 0x00434AC0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010168 RID: 65896 RVA: 0x004368D4 File Offset: 0x00434AD4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010169 RID: 65897 RVA: 0x004368DC File Offset: 0x00434ADC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601016A RID: 65898 RVA: 0x004368E8 File Offset: 0x00434AE8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601016B RID: 65899 RVA: 0x004368F4 File Offset: 0x00434AF4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601016C RID: 65900 RVA: 0x00436900 File Offset: 0x00434B00
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601016D RID: 65901 RVA: 0x0043690C File Offset: 0x00434B0C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601016E RID: 65902 RVA: 0x00436918 File Offset: 0x00434B18
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601016F RID: 65903 RVA: 0x00436924 File Offset: 0x00434B24
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010170 RID: 65904 RVA: 0x00436930 File Offset: 0x00434B30
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010171 RID: 65905 RVA: 0x0043693C File Offset: 0x00434B3C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010172 RID: 65906 RVA: 0x00436948 File Offset: 0x00434B48
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010173 RID: 65907 RVA: 0x00436950 File Offset: 0x00434B50
		private void __callDele_EventOnClick()
		{
			Action eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick();
			}
		}

		// Token: 0x06010174 RID: 65908 RVA: 0x00436970 File Offset: 0x00434B70
		private void __clearDele_EventOnClick()
		{
			this.EventOnClick = null;
		}

		// Token: 0x06010176 RID: 65910 RVA: 0x00436988 File Offset: 0x00434B88
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_CreateGraphicHeroPerformanceStateBooleanString_hotfix = (luaObj.RawGet("CreateGraphic") as LuaFunction);
					this.m_CreateGraphicConfigDataHeroInfo_hotfix = (luaObj.RawGet("CreateGraphic") as LuaFunction);
					this.m_CreateGraphicConfigDataHeroInfoStringInt32_hotfix = (luaObj.RawGet("CreateGraphic") as LuaFunction);
					this.m_GetCharImageInfo_hotfix = (luaObj.RawGet("GetCharImageInfo") as LuaFunction);
					this.m_GetHeroCharSkinId_hotfix = (luaObj.RawGet("GetHeroCharSkinId") as LuaFunction);
					this.m_DestroyGraphic_hotfix = (luaObj.RawGet("DestroyGraphic") as LuaFunction);
					this.m_PlayAnimationInt32Boolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_PlayAnimationStringBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_PlayVoiceInt32_hotfix = (luaObj.RawGet("PlayVoice") as LuaFunction);
					this.m_ShowWordsInt32Single_hotfix = (luaObj.RawGet("ShowWords") as LuaFunction);
					this.m_CloseWordPanelSingle_hotfix = (luaObj.RawGet("CloseWordPanel") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_SetSpineColorColor_hotfix = (luaObj.RawGet("SetSpineColor") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_IsClickInCharRootGameObject_hotfix = (luaObj.RawGet("IsClickInCharRoot") as LuaFunction);
					this.m_SetCanClickBoolean_hotfix = (luaObj.RawGet("SetCanClick") as LuaFunction);
					this.m_PlayOneRandomPerformanceBoolean_hotfix = (luaObj.RawGet("PlayOneRandomPerformance") as LuaFunction);
					this.m_CanPlayRandomHeroPerformancesIndexInt32_hotfix = (luaObj.RawGet("CanPlayRandomHeroPerformancesIndex") as LuaFunction);
					this.m_PlayOneSpecifiedPerformanceInt32_hotfix = (luaObj.RawGet("PlayOneSpecifiedPerformance") as LuaFunction);
					this.m_GetPerformanceIdByStateInt32HeroPerformanceState_hotfix = (luaObj.RawGet("GetPerformanceIdByState") as LuaFunction);
					this.m_add_EventOnClickAction_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010177 RID: 65911 RVA: 0x00436C94 File Offset: 0x00434E94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCharUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009606 RID: 38406
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charRoot;

		// Token: 0x04009607 RID: 38407
		[AutoBind("./Char/0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_root;

		// Token: 0x04009608 RID: 38408
		[AutoBind("./Word", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_wordGo;

		// Token: 0x04009609 RID: 38409
		[AutoBind("./Word/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_text;

		// Token: 0x0400960A RID: 38410
		[AutoBind("./Char/0/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x0400960B RID: 38411
		private UISpineGraphic m_spineGraphic;

		// Token: 0x0400960C RID: 38412
		private int m_performanceIndex;

		// Token: 0x0400960D RID: 38413
		private int m_heroPerformanceId;

		// Token: 0x0400960E RID: 38414
		private static List<ConfigDataHeroPerformanceInfo> HeroPerformanceInfoList = new List<ConfigDataHeroPerformanceInfo>();

		// Token: 0x0400960F RID: 38415
		private int m_heroCharSkinId;

		// Token: 0x04009610 RID: 38416
		private ConfigDataCharImageInfo m_charImageInfo;

		// Token: 0x04009611 RID: 38417
		private bool m_canClick;

		// Token: 0x04009612 RID: 38418
		private bool m_isAnimationPlayed;

		// Token: 0x04009613 RID: 38419
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009614 RID: 38420
		private HeroCharUIController.PerformanceState m_curState;

		// Token: 0x04009615 RID: 38421
		private IAudioPlayback m_audioPlayback;

		// Token: 0x04009616 RID: 38422
		private Hero m_hero;

		// Token: 0x04009617 RID: 38423
		[DoNotToLua]
		private HeroCharUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009618 RID: 38424
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009619 RID: 38425
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400961A RID: 38426
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400961B RID: 38427
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x0400961C RID: 38428
		private LuaFunction m_CreateGraphicHeroPerformanceStateBooleanString_hotfix;

		// Token: 0x0400961D RID: 38429
		private LuaFunction m_CreateGraphicConfigDataHeroInfo_hotfix;

		// Token: 0x0400961E RID: 38430
		private LuaFunction m_CreateGraphicConfigDataHeroInfoStringInt32_hotfix;

		// Token: 0x0400961F RID: 38431
		private LuaFunction m_GetCharImageInfo_hotfix;

		// Token: 0x04009620 RID: 38432
		private LuaFunction m_GetHeroCharSkinId_hotfix;

		// Token: 0x04009621 RID: 38433
		private LuaFunction m_DestroyGraphic_hotfix;

		// Token: 0x04009622 RID: 38434
		private LuaFunction m_PlayAnimationInt32Boolean_hotfix;

		// Token: 0x04009623 RID: 38435
		private LuaFunction m_PlayAnimationStringBoolean_hotfix;

		// Token: 0x04009624 RID: 38436
		private LuaFunction m_PlayVoiceInt32_hotfix;

		// Token: 0x04009625 RID: 38437
		private LuaFunction m_ShowWordsInt32Single_hotfix;

		// Token: 0x04009626 RID: 38438
		private LuaFunction m_CloseWordPanelSingle_hotfix;

		// Token: 0x04009627 RID: 38439
		private LuaFunction m_Update_hotfix;

		// Token: 0x04009628 RID: 38440
		private LuaFunction m_SetSpineColorColor_hotfix;

		// Token: 0x04009629 RID: 38441
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x0400962A RID: 38442
		private LuaFunction m_IsClickInCharRootGameObject_hotfix;

		// Token: 0x0400962B RID: 38443
		private LuaFunction m_SetCanClickBoolean_hotfix;

		// Token: 0x0400962C RID: 38444
		private LuaFunction m_PlayOneRandomPerformanceBoolean_hotfix;

		// Token: 0x0400962D RID: 38445
		private LuaFunction m_CanPlayRandomHeroPerformancesIndexInt32_hotfix;

		// Token: 0x0400962E RID: 38446
		private LuaFunction m_PlayOneSpecifiedPerformanceInt32_hotfix;

		// Token: 0x0400962F RID: 38447
		private LuaFunction m_GetPerformanceIdByStateInt32HeroPerformanceState_hotfix;

		// Token: 0x04009630 RID: 38448
		private LuaFunction m_add_EventOnClickAction_hotfix;

		// Token: 0x04009631 RID: 38449
		private LuaFunction m_remove_EventOnClickAction_hotfix;

		// Token: 0x02000D83 RID: 3459
		public enum PerformanceState
		{
			// Token: 0x04009633 RID: 38451
			All,
			// Token: 0x04009634 RID: 38452
			List,
			// Token: 0x04009635 RID: 38453
			Break,
			// Token: 0x04009636 RID: 38454
			Summon,
			// Token: 0x04009637 RID: 38455
			JobTransfer
		}

		// Token: 0x02000D84 RID: 3460
		public new class LuaExportHelper
		{
			// Token: 0x06010178 RID: 65912 RVA: 0x00436CFC File Offset: 0x00434EFC
			public LuaExportHelper(HeroCharUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010179 RID: 65913 RVA: 0x00436D0C File Offset: 0x00434F0C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601017A RID: 65914 RVA: 0x00436D1C File Offset: 0x00434F1C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601017B RID: 65915 RVA: 0x00436D2C File Offset: 0x00434F2C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601017C RID: 65916 RVA: 0x00436D3C File Offset: 0x00434F3C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601017D RID: 65917 RVA: 0x00436D54 File Offset: 0x00434F54
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601017E RID: 65918 RVA: 0x00436D64 File Offset: 0x00434F64
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601017F RID: 65919 RVA: 0x00436D74 File Offset: 0x00434F74
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010180 RID: 65920 RVA: 0x00436D84 File Offset: 0x00434F84
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010181 RID: 65921 RVA: 0x00436D94 File Offset: 0x00434F94
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010182 RID: 65922 RVA: 0x00436DA4 File Offset: 0x00434FA4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010183 RID: 65923 RVA: 0x00436DB4 File Offset: 0x00434FB4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010184 RID: 65924 RVA: 0x00436DC4 File Offset: 0x00434FC4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010185 RID: 65925 RVA: 0x00436DD4 File Offset: 0x00434FD4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010186 RID: 65926 RVA: 0x00436DE4 File Offset: 0x00434FE4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010187 RID: 65927 RVA: 0x00436DF4 File Offset: 0x00434FF4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010188 RID: 65928 RVA: 0x00436E04 File Offset: 0x00435004
			public void __callDele_EventOnClick()
			{
				this.m_owner.__callDele_EventOnClick();
			}

			// Token: 0x06010189 RID: 65929 RVA: 0x00436E14 File Offset: 0x00435014
			public void __clearDele_EventOnClick()
			{
				this.m_owner.__clearDele_EventOnClick();
			}

			// Token: 0x1700316B RID: 12651
			// (get) Token: 0x0601018A RID: 65930 RVA: 0x00436E24 File Offset: 0x00435024
			// (set) Token: 0x0601018B RID: 65931 RVA: 0x00436E34 File Offset: 0x00435034
			public GameObject m_charRoot
			{
				get
				{
					return this.m_owner.m_charRoot;
				}
				set
				{
					this.m_owner.m_charRoot = value;
				}
			}

			// Token: 0x1700316C RID: 12652
			// (get) Token: 0x0601018C RID: 65932 RVA: 0x00436E44 File Offset: 0x00435044
			// (set) Token: 0x0601018D RID: 65933 RVA: 0x00436E54 File Offset: 0x00435054
			public GameObject m_root
			{
				get
				{
					return this.m_owner.m_root;
				}
				set
				{
					this.m_owner.m_root = value;
				}
			}

			// Token: 0x1700316D RID: 12653
			// (get) Token: 0x0601018E RID: 65934 RVA: 0x00436E64 File Offset: 0x00435064
			// (set) Token: 0x0601018F RID: 65935 RVA: 0x00436E74 File Offset: 0x00435074
			public GameObject m_wordGo
			{
				get
				{
					return this.m_owner.m_wordGo;
				}
				set
				{
					this.m_owner.m_wordGo = value;
				}
			}

			// Token: 0x1700316E RID: 12654
			// (get) Token: 0x06010190 RID: 65936 RVA: 0x00436E84 File Offset: 0x00435084
			// (set) Token: 0x06010191 RID: 65937 RVA: 0x00436E94 File Offset: 0x00435094
			public Text m_text
			{
				get
				{
					return this.m_owner.m_text;
				}
				set
				{
					this.m_owner.m_text = value;
				}
			}

			// Token: 0x1700316F RID: 12655
			// (get) Token: 0x06010192 RID: 65938 RVA: 0x00436EA4 File Offset: 0x004350A4
			// (set) Token: 0x06010193 RID: 65939 RVA: 0x00436EB4 File Offset: 0x004350B4
			public Image m_image
			{
				get
				{
					return this.m_owner.m_image;
				}
				set
				{
					this.m_owner.m_image = value;
				}
			}

			// Token: 0x17003170 RID: 12656
			// (get) Token: 0x06010194 RID: 65940 RVA: 0x00436EC4 File Offset: 0x004350C4
			// (set) Token: 0x06010195 RID: 65941 RVA: 0x00436ED4 File Offset: 0x004350D4
			public UISpineGraphic m_spineGraphic
			{
				get
				{
					return this.m_owner.m_spineGraphic;
				}
				set
				{
					this.m_owner.m_spineGraphic = value;
				}
			}

			// Token: 0x17003171 RID: 12657
			// (get) Token: 0x06010196 RID: 65942 RVA: 0x00436EE4 File Offset: 0x004350E4
			// (set) Token: 0x06010197 RID: 65943 RVA: 0x00436EF4 File Offset: 0x004350F4
			public int m_performanceIndex
			{
				get
				{
					return this.m_owner.m_performanceIndex;
				}
				set
				{
					this.m_owner.m_performanceIndex = value;
				}
			}

			// Token: 0x17003172 RID: 12658
			// (get) Token: 0x06010198 RID: 65944 RVA: 0x00436F04 File Offset: 0x00435104
			// (set) Token: 0x06010199 RID: 65945 RVA: 0x00436F14 File Offset: 0x00435114
			public int m_heroPerformanceId
			{
				get
				{
					return this.m_owner.m_heroPerformanceId;
				}
				set
				{
					this.m_owner.m_heroPerformanceId = value;
				}
			}

			// Token: 0x17003173 RID: 12659
			// (get) Token: 0x0601019A RID: 65946 RVA: 0x00436F24 File Offset: 0x00435124
			// (set) Token: 0x0601019B RID: 65947 RVA: 0x00436F2C File Offset: 0x0043512C
			public static List<ConfigDataHeroPerformanceInfo> HeroPerformanceInfoList
			{
				get
				{
					return HeroCharUIController.HeroPerformanceInfoList;
				}
				set
				{
					HeroCharUIController.HeroPerformanceInfoList = value;
				}
			}

			// Token: 0x17003174 RID: 12660
			// (get) Token: 0x0601019C RID: 65948 RVA: 0x00436F34 File Offset: 0x00435134
			// (set) Token: 0x0601019D RID: 65949 RVA: 0x00436F44 File Offset: 0x00435144
			public int m_heroCharSkinId
			{
				get
				{
					return this.m_owner.m_heroCharSkinId;
				}
				set
				{
					this.m_owner.m_heroCharSkinId = value;
				}
			}

			// Token: 0x17003175 RID: 12661
			// (get) Token: 0x0601019E RID: 65950 RVA: 0x00436F54 File Offset: 0x00435154
			// (set) Token: 0x0601019F RID: 65951 RVA: 0x00436F64 File Offset: 0x00435164
			public ConfigDataCharImageInfo m_charImageInfo
			{
				get
				{
					return this.m_owner.m_charImageInfo;
				}
				set
				{
					this.m_owner.m_charImageInfo = value;
				}
			}

			// Token: 0x17003176 RID: 12662
			// (get) Token: 0x060101A0 RID: 65952 RVA: 0x00436F74 File Offset: 0x00435174
			// (set) Token: 0x060101A1 RID: 65953 RVA: 0x00436F84 File Offset: 0x00435184
			public bool m_canClick
			{
				get
				{
					return this.m_owner.m_canClick;
				}
				set
				{
					this.m_owner.m_canClick = value;
				}
			}

			// Token: 0x17003177 RID: 12663
			// (get) Token: 0x060101A2 RID: 65954 RVA: 0x00436F94 File Offset: 0x00435194
			// (set) Token: 0x060101A3 RID: 65955 RVA: 0x00436FA4 File Offset: 0x004351A4
			public bool m_isAnimationPlayed
			{
				get
				{
					return this.m_owner.m_isAnimationPlayed;
				}
				set
				{
					this.m_owner.m_isAnimationPlayed = value;
				}
			}

			// Token: 0x17003178 RID: 12664
			// (get) Token: 0x060101A4 RID: 65956 RVA: 0x00436FB4 File Offset: 0x004351B4
			// (set) Token: 0x060101A5 RID: 65957 RVA: 0x00436FC4 File Offset: 0x004351C4
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17003179 RID: 12665
			// (get) Token: 0x060101A6 RID: 65958 RVA: 0x00436FD4 File Offset: 0x004351D4
			// (set) Token: 0x060101A7 RID: 65959 RVA: 0x00436FE4 File Offset: 0x004351E4
			public HeroCharUIController.PerformanceState m_curState
			{
				get
				{
					return this.m_owner.m_curState;
				}
				set
				{
					this.m_owner.m_curState = value;
				}
			}

			// Token: 0x1700317A RID: 12666
			// (get) Token: 0x060101A8 RID: 65960 RVA: 0x00436FF4 File Offset: 0x004351F4
			// (set) Token: 0x060101A9 RID: 65961 RVA: 0x00437004 File Offset: 0x00435204
			public IAudioPlayback m_audioPlayback
			{
				get
				{
					return this.m_owner.m_audioPlayback;
				}
				set
				{
					this.m_owner.m_audioPlayback = value;
				}
			}

			// Token: 0x1700317B RID: 12667
			// (get) Token: 0x060101AA RID: 65962 RVA: 0x00437014 File Offset: 0x00435214
			// (set) Token: 0x060101AB RID: 65963 RVA: 0x00437024 File Offset: 0x00435224
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x060101AC RID: 65964 RVA: 0x00437034 File Offset: 0x00435234
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060101AD RID: 65965 RVA: 0x00437044 File Offset: 0x00435244
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x060101AE RID: 65966 RVA: 0x00437054 File Offset: 0x00435254
			public IEnumerator CloseWordPanel(float time)
			{
				return this.m_owner.CloseWordPanel(time);
			}

			// Token: 0x060101AF RID: 65967 RVA: 0x00437064 File Offset: 0x00435264
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x060101B0 RID: 65968 RVA: 0x00437074 File Offset: 0x00435274
			public bool IsClickInCharRoot(GameObject clickGameObject)
			{
				return this.m_owner.IsClickInCharRoot(clickGameObject);
			}

			// Token: 0x060101B1 RID: 65969 RVA: 0x00437084 File Offset: 0x00435284
			public bool CanPlayRandomHeroPerformancesIndex(int index)
			{
				return this.m_owner.CanPlayRandomHeroPerformancesIndex(index);
			}

			// Token: 0x060101B2 RID: 65970 RVA: 0x00437094 File Offset: 0x00435294
			public int GetPerformanceIdByState(int favorabilityLevel, Hero hero, HeroCharUIController.PerformanceState performanceState)
			{
				return this.m_owner.GetPerformanceIdByState(favorabilityLevel, hero, performanceState);
			}

			// Token: 0x04009638 RID: 38456
			private HeroCharUIController m_owner;
		}
	}
}
