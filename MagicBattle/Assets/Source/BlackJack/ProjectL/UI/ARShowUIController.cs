using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B15 RID: 2837
	[HotFix]
	public class ARShowUIController : UIControllerBase
	{
		// Token: 0x0600BED7 RID: 48855 RVA: 0x00354974 File Offset: 0x00352B74
		private ARShowUIController()
		{
		}

		// Token: 0x0600BED8 RID: 48856 RVA: 0x0035497C File Offset: 0x00352B7C
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
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_photographButton.onClick.AddListener(new UnityAction(this.OnPhotographClick));
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnClick));
			this.m_summonButton.onClick.AddListener(new UnityAction(this.OnSummonClick));
			this.m_exitButton.onClick.AddListener(new UnityAction(this.OnExitClick));
			this.m_shareReturnButton.onClick.AddListener(new UnityAction(this.OnShareReturnClick));
			this.m_shareBackgroundButton.onClick.AddListener(new UnityAction(this.OnShareBackgroundClick));
			this.m_charIdleToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharActionClick(this.m_charIdleToggle.gameObject);
				}
			});
			this.m_charAttackToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharActionClick(this.m_charAttackToggle.gameObject);
				}
			});
			this.m_charSuperAttackToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharActionClick(this.m_charSuperAttackToggle.gameObject);
				}
			});
			this.m_charMagicToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharActionClick(this.m_charMagicToggle.gameObject);
				}
			});
			this.m_charDeathToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharActionClick(this.m_charDeathToggle.gameObject);
				}
			});
			this.m_charSingToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharActionClick(this.m_charSingToggle.gameObject);
				}
			});
			this.m_charFaintToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharActionClick(this.m_charFaintToggle.gameObject);
				}
			});
			this.m_charRunToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharActionClick(this.m_charRunToggle.gameObject);
				}
			});
			this.m_turnLeftToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharDirectionClick(this.m_turnLeftToggle.gameObject);
				}
			});
			this.m_turnRightToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharDirectionClick(this.m_turnRightToggle.gameObject);
				}
			});
			this.m_scaleScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.OnScaleScrollBarValueChange));
			this.m_distanceScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.OnDistanceScrollBarValueChange));
			GameObject asset = this.m_resourceContainer.GetAsset<GameObject>("ShareButtonUIPrefab");
			this.m_shareSubPanel = UnityEngine.Object.Instantiate<GameObject>(asset);
			this.m_shareSubPanel.transform.SetParent(this.m_shareButtonDummy.transform, false);
			this.m_weiBoButton = GameObjectUtility.FindComponentByName<Button>(this.m_shareSubPanel.transform, "WeiBoButton");
			this.m_weChatButton = GameObjectUtility.FindComponentByName<Button>(this.m_shareSubPanel.transform, "WeChatButton");
			this.m_weiBoButton.onClick.AddListener(new UnityAction(this.OnWeiBoClick));
			this.m_weChatButton.onClick.AddListener(new UnityAction(this.OnWeChatClick));
			asset = this.m_resourceContainer.GetAsset<GameObject>("SharePhotoUIPrefab");
			this.m_sharePhotoUIPanel = UnityEngine.Object.Instantiate<GameObject>(asset);
			this.m_sharePhotoUIPanel.transform.SetParent(this.m_sharePhotoDummy.transform, false);
			CommonUIStateController componentInChildren = this.m_sharePhotoUIPanel.GetComponentInChildren<CommonUIStateController>();
			if (componentInChildren != null)
			{
				componentInChildren.SetToUIState("NoBg", false, true);
			}
			this.m_playerNameText = GameObjectUtility.FindComponentByName<Text>(this.m_sharePhotoUIPanel.transform, "NameText");
			this.m_playerLvText = GameObjectUtility.FindComponentByName<Text>(this.m_sharePhotoUIPanel.transform, "LvValueText");
			this.m_serverNameText = GameObjectUtility.FindComponentByName<Text>(this.m_sharePhotoUIPanel.transform, "ServerNameText");
			this.m_playerNameText.text = this.m_playerContext.GetPlayerName();
			this.m_playerLvText.text = this.m_playerContext.GetPlayerLevel().ToString();
			this.m_serverNameText.text = LoginUITask.GetCurrentSelectServerInfo().m_name;
			this.Refresh();
			this.UpdateDeveloperMode();
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600BED9 RID: 48857 RVA: 0x00354DC4 File Offset: 0x00352FC4
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
			ARShowUIController.UIState uistate = this.uiState;
			if (uistate != ARShowUIController.UIState.RecognizePanel)
			{
				if (uistate == ARShowUIController.UIState.Summon)
				{
					if (!this.m_arShowSceneController.IsFindPlane())
					{
						this.uiState = ARShowUIController.UIState.RecognizePanel;
						this.Refresh();
					}
				}
			}
			else if (this.m_arShowSceneController.IsFindPlane())
			{
				this.uiState = ARShowUIController.UIState.Summon;
				this.Refresh();
			}
		}

		// Token: 0x0600BEDA RID: 48858 RVA: 0x00354E84 File Offset: 0x00353084
		public void Refresh()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Refresh_hotfix != null)
			{
				this.m_Refresh_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (this.uiState)
			{
			case ARShowUIController.UIState.RecognizePanel:
				this.m_photographButton.gameObject.SetActive(false);
				this.m_returnButton.gameObject.SetActive(false);
				this.m_summonButton.gameObject.SetActive(false);
				this.m_exitButton.gameObject.SetActive(true);
				this.m_roleControlPanel.SetActive(false);
				this.m_sharePanel.SetActive(false);
				break;
			case ARShowUIController.UIState.Summon:
				this.m_photographButton.gameObject.SetActive(false);
				this.m_returnButton.gameObject.SetActive(false);
				this.m_summonButton.gameObject.SetActive(true);
				this.m_exitButton.gameObject.SetActive(true);
				this.m_roleControlPanel.SetActive(false);
				this.m_sharePanel.SetActive(false);
				break;
			case ARShowUIController.UIState.Show:
				this.m_photographButton.gameObject.SetActive(true);
				this.m_returnButton.gameObject.SetActive(true);
				this.m_summonButton.gameObject.SetActive(false);
				this.m_exitButton.gameObject.SetActive(false);
				if (this.m_arShowType == 1)
				{
					this.m_roleControlPanel.SetActive(true);
				}
				this.m_sharePanel.SetActive(false);
				break;
			case ARShowUIController.UIState.Photo:
				this.m_photographButton.gameObject.SetActive(false);
				this.m_returnButton.gameObject.SetActive(false);
				this.m_summonButton.gameObject.SetActive(false);
				this.m_exitButton.gameObject.SetActive(false);
				this.m_sharePhotoUIPanel.SetActive(false);
				this.m_roleControlPanel.SetActive(false);
				this.m_sharePanel.SetActive(true);
				break;
			}
		}

		// Token: 0x0600BEDB RID: 48859 RVA: 0x003550A4 File Offset: 0x003532A4
		private void UpdateDeveloperMode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDeveloperMode_hotfix != null)
			{
				this.m_UpdateDeveloperMode_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_developPanel.gameObject.SetActive(data.IsDeveloper);
		}

		// Token: 0x0600BEDC RID: 48860 RVA: 0x00355128 File Offset: 0x00353328
		public void SetUITask(ARUITask task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUITaskARUITask_hotfix != null)
			{
				this.m_SetUITaskARUITask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_task = task;
			this.LoadData();
		}

		// Token: 0x0600BEDD RID: 48861 RVA: 0x003551A8 File Offset: 0x003533A8
		public void LoadData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoadData_hotfix != null)
			{
				this.m_LoadData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable uiintentReturnable = this.m_task.CurrentIntent as UIIntentReturnable;
			this.m_arShowType = uiintentReturnable.GetStructParam<int>("Type");
			this.m_selectHeroID = uiintentReturnable.GetStructParam<int>("SelectHeroID");
		}

		// Token: 0x0600BEDE RID: 48862 RVA: 0x0035523C File Offset: 0x0035343C
		public void SetARShowSceneController(ARShowSceneController arShowSceneController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetARShowSceneControllerARShowSceneController_hotfix != null)
			{
				this.m_SetARShowSceneControllerARShowSceneController_hotfix.call(new object[]
				{
					this,
					arShowSceneController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arShowSceneController = arShowSceneController;
		}

		// Token: 0x0600BEDF RID: 48863 RVA: 0x003552B4 File Offset: 0x003534B4
		protected void OnPhotographClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPhotographClick_hotfix != null)
			{
				this.m_OnPhotographClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.uiState = ARShowUIController.UIState.Photo;
			this.Refresh();
			base.StartCoroutine(this.Photograph());
		}

		// Token: 0x0600BEE0 RID: 48864 RVA: 0x00355330 File Offset: 0x00353530
		protected void OnReturnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnClick_hotfix != null)
			{
				this.m_OnReturnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arShowSceneController.DestroyChar();
			this.m_arShowSceneController.PlaneTraceEnable(true);
			this.uiState = ARShowUIController.UIState.Summon;
			this.Refresh();
		}

		// Token: 0x0600BEE1 RID: 48865 RVA: 0x003553B4 File Offset: 0x003535B4
		protected void OnSummonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSummonClick_hotfix != null)
			{
				this.m_OnSummonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int arShowType = this.m_arShowType;
			if (arShowType != 1)
			{
				if (arShowType != 2)
				{
					if (arShowType == 3)
					{
						this.m_arShowSceneController.SummonHeroTeamShow();
					}
				}
				else
				{
					this.m_arShowSceneController.SummonHeroDrawShow(this.m_selectHeroID);
				}
			}
			else
			{
				this.m_arShowSceneController.SummonHeroBattleShow(this.m_selectHeroID);
				this.m_charActionChoose.isOn = true;
			}
			this.m_arShowSceneController.PlaneTraceEnable(false);
			this.uiState = ARShowUIController.UIState.Show;
			this.Refresh();
		}

		// Token: 0x0600BEE2 RID: 48866 RVA: 0x00355498 File Offset: 0x00353698
		protected void OnExitClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExitClick_hotfix != null)
			{
				this.m_OnExitClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_task.Stop();
				this.m_task.ReturnLastTask();
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x0600BEE3 RID: 48867 RVA: 0x0035551C File Offset: 0x0035371C
		protected void OnCharActionClick(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCharActionClickGameObject_hotfix != null)
			{
				this.m_OnCharActionClickGameObject_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (obj == this.m_charIdleToggle.gameObject)
			{
				this.m_arShowSceneController.PlaySingleCharAnimation("idle", true);
			}
			else if (obj == this.m_charAttackToggle.gameObject)
			{
				this.m_arShowSceneController.PlaySingleCharAnimation("attack1", true);
			}
			else if (obj == this.m_charSuperAttackToggle.gameObject)
			{
				this.m_arShowSceneController.PlaySingleCharAnimation("superattack", true);
			}
			else if (obj == this.m_charMagicToggle.gameObject)
			{
				this.m_arShowSceneController.PlaySingleCharAnimation("cast", true);
			}
			else if (obj == this.m_charDeathToggle.gameObject)
			{
				this.m_arShowSceneController.PlaySingleCharAnimation("death", true);
			}
			else if (obj == this.m_charSingToggle.gameObject)
			{
				this.m_arShowSceneController.PlaySingleCharAnimation("sing", true);
			}
			else if (obj == this.m_charFaintToggle.gameObject)
			{
				this.m_arShowSceneController.PlaySingleCharAnimation("stun", true);
			}
			else if (obj == this.m_charRunToggle.gameObject)
			{
				this.m_arShowSceneController.PlaySingleCharAnimation("run", true);
			}
		}

		// Token: 0x0600BEE4 RID: 48868 RVA: 0x003556E8 File Offset: 0x003538E8
		protected void OnCharDirectionClick(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCharDirectionClickGameObject_hotfix != null)
			{
				this.m_OnCharDirectionClickGameObject_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (obj == this.m_turnLeftToggle.gameObject)
			{
				this.m_arShowSceneController.SetCharDirection(false);
			}
			else if (obj == this.m_turnRightToggle.gameObject)
			{
				this.m_arShowSceneController.SetCharDirection(true);
			}
		}

		// Token: 0x0600BEE5 RID: 48869 RVA: 0x003557A4 File Offset: 0x003539A4
		protected void OnShareReturnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShareReturnClick_hotfix != null)
			{
				this.m_OnShareReturnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.uiState = ARShowUIController.UIState.Show;
			this.Refresh();
		}

		// Token: 0x0600BEE6 RID: 48870 RVA: 0x00355814 File Offset: 0x00353A14
		protected void OnWeiBoClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeiBoClick_hotfix != null)
			{
				this.m_OnWeiBoClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.ShareImage(3));
		}

		// Token: 0x0600BEE7 RID: 48871 RVA: 0x00355884 File Offset: 0x00353A84
		protected void OnWeChatClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeChatClick_hotfix != null)
			{
				this.m_OnWeChatClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.ShareImage(2));
		}

		// Token: 0x0600BEE8 RID: 48872 RVA: 0x003558F4 File Offset: 0x00353AF4
		protected void OnShareBackgroundClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShareBackgroundClick_hotfix != null)
			{
				this.m_OnShareBackgroundClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool activeSelf = this.m_shareReturnButton.gameObject.activeSelf;
			this.m_shareReturnButton.gameObject.SetActive(!activeSelf);
			this.m_shareSubPanel.SetActive(!activeSelf);
		}

		// Token: 0x0600BEE9 RID: 48873 RVA: 0x00355988 File Offset: 0x00353B88
		protected void OnScaleScrollBarValueChange(float value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScaleScrollBarValueChangeSingle_hotfix != null)
			{
				this.m_OnScaleScrollBarValueChangeSingle_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_scaleText.text = value.ToString();
			this.m_arShowSceneController.SetCharScale(value);
		}

		// Token: 0x0600BEEA RID: 48874 RVA: 0x00355A1C File Offset: 0x00353C1C
		protected void OnDistanceScrollBarValueChange(float value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDistanceScrollBarValueChangeSingle_hotfix != null)
			{
				this.m_OnDistanceScrollBarValueChangeSingle_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_distanceText.text = value.ToString();
			this.m_arShowSceneController.SetTeamDistance(value);
		}

		// Token: 0x0600BEEB RID: 48875 RVA: 0x00355AB0 File Offset: 0x00353CB0
		[DebuggerHidden]
		protected IEnumerator Photograph()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Photograph_hotfix != null)
			{
				return (IEnumerator)this.m_Photograph_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ARShowUIController.<Photograph>c__Iterator0 <Photograph>c__Iterator = new ARShowUIController.<Photograph>c__Iterator0();
			<Photograph>c__Iterator.$this = this;
			return <Photograph>c__Iterator;
		}

		// Token: 0x0600BEEC RID: 48876 RVA: 0x00355B2C File Offset: 0x00353D2C
		[DebuggerHidden]
		protected IEnumerator ShareImage(int sharePlatform)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShareImageInt32_hotfix != null)
			{
				return (IEnumerator)this.m_ShareImageInt32_hotfix.call(new object[]
				{
					this,
					sharePlatform
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ARShowUIController.<ShareImage>c__Iterator1 <ShareImage>c__Iterator = new ARShowUIController.<ShareImage>c__Iterator1();
			<ShareImage>c__Iterator.sharePlatform = sharePlatform;
			<ShareImage>c__Iterator.$this = this;
			return <ShareImage>c__Iterator;
		}

		// Token: 0x0600BEED RID: 48877 RVA: 0x00355BC0 File Offset: 0x00353DC0
		private Texture2D CopyTexture2D(Texture2D texture)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CopyTexture2DTexture2D_hotfix != null)
			{
				return (Texture2D)this.m_CopyTexture2DTexture2D_hotfix.call(new object[]
				{
					this,
					texture
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Texture2D texture2D = new Texture2D(texture.width, texture.height);
			texture2D.LoadImage(texture.EncodeToPNG());
			texture2D.filterMode = FilterMode.Point;
			return texture2D;
		}

		// Token: 0x0600BEEE RID: 48878 RVA: 0x00355C64 File Offset: 0x00353E64
		private void SaveTextureToPNG(Texture2D texture, string path, string pngName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveTextureToPNGTexture2DStringString_hotfix != null)
			{
				this.m_SaveTextureToPNGTexture2DStringString_hotfix.call(new object[]
				{
					this,
					texture,
					path,
					pngName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			byte[] buffer = texture.EncodeToPNG();
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			FileStream fileStream = File.Open(path + "/" + pngName + ".png", FileMode.Create);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			binaryWriter.Write(buffer);
			fileStream.Close();
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x0600BEEF RID: 48879 RVA: 0x00355D3C File Offset: 0x00353F3C
		// (set) Token: 0x0600BEF0 RID: 48880 RVA: 0x00355D5C File Offset: 0x00353F5C
		[DoNotToLua]
		public new ARShowUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ARShowUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BEF1 RID: 48881 RVA: 0x00355D68 File Offset: 0x00353F68
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600BEF2 RID: 48882 RVA: 0x00355D74 File Offset: 0x00353F74
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600BEF3 RID: 48883 RVA: 0x00355D7C File Offset: 0x00353F7C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600BEF4 RID: 48884 RVA: 0x00355D84 File Offset: 0x00353F84
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600BEF5 RID: 48885 RVA: 0x00355D98 File Offset: 0x00353F98
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600BEF6 RID: 48886 RVA: 0x00355DA0 File Offset: 0x00353FA0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600BEF7 RID: 48887 RVA: 0x00355DAC File Offset: 0x00353FAC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x00355DB8 File Offset: 0x00353FB8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600BEF9 RID: 48889 RVA: 0x00355DC4 File Offset: 0x00353FC4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600BEFA RID: 48890 RVA: 0x00355DD0 File Offset: 0x00353FD0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600BEFB RID: 48891 RVA: 0x00355DDC File Offset: 0x00353FDC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600BEFC RID: 48892 RVA: 0x00355DE8 File Offset: 0x00353FE8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600BEFD RID: 48893 RVA: 0x00355DF4 File Offset: 0x00353FF4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600BEFE RID: 48894 RVA: 0x00355E00 File Offset: 0x00354000
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600BEFF RID: 48895 RVA: 0x00355E0C File Offset: 0x0035400C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600BF0B RID: 48907 RVA: 0x00355F50 File Offset: 0x00354150
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
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_Refresh_hotfix = (luaObj.RawGet("Refresh") as LuaFunction);
					this.m_UpdateDeveloperMode_hotfix = (luaObj.RawGet("UpdateDeveloperMode") as LuaFunction);
					this.m_SetUITaskARUITask_hotfix = (luaObj.RawGet("SetUITask") as LuaFunction);
					this.m_LoadData_hotfix = (luaObj.RawGet("LoadData") as LuaFunction);
					this.m_SetARShowSceneControllerARShowSceneController_hotfix = (luaObj.RawGet("SetARShowSceneController") as LuaFunction);
					this.m_OnPhotographClick_hotfix = (luaObj.RawGet("OnPhotographClick") as LuaFunction);
					this.m_OnReturnClick_hotfix = (luaObj.RawGet("OnReturnClick") as LuaFunction);
					this.m_OnSummonClick_hotfix = (luaObj.RawGet("OnSummonClick") as LuaFunction);
					this.m_OnExitClick_hotfix = (luaObj.RawGet("OnExitClick") as LuaFunction);
					this.m_OnCharActionClickGameObject_hotfix = (luaObj.RawGet("OnCharActionClick") as LuaFunction);
					this.m_OnCharDirectionClickGameObject_hotfix = (luaObj.RawGet("OnCharDirectionClick") as LuaFunction);
					this.m_OnShareReturnClick_hotfix = (luaObj.RawGet("OnShareReturnClick") as LuaFunction);
					this.m_OnWeiBoClick_hotfix = (luaObj.RawGet("OnWeiBoClick") as LuaFunction);
					this.m_OnWeChatClick_hotfix = (luaObj.RawGet("OnWeChatClick") as LuaFunction);
					this.m_OnShareBackgroundClick_hotfix = (luaObj.RawGet("OnShareBackgroundClick") as LuaFunction);
					this.m_OnScaleScrollBarValueChangeSingle_hotfix = (luaObj.RawGet("OnScaleScrollBarValueChange") as LuaFunction);
					this.m_OnDistanceScrollBarValueChangeSingle_hotfix = (luaObj.RawGet("OnDistanceScrollBarValueChange") as LuaFunction);
					this.m_Photograph_hotfix = (luaObj.RawGet("Photograph") as LuaFunction);
					this.m_ShareImageInt32_hotfix = (luaObj.RawGet("ShareImage") as LuaFunction);
					this.m_CopyTexture2DTexture2D_hotfix = (luaObj.RawGet("CopyTexture2D") as LuaFunction);
					this.m_SaveTextureToPNGTexture2DStringString_hotfix = (luaObj.RawGet("SaveTextureToPNG") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BF0C RID: 48908 RVA: 0x00356244 File Offset: 0x00354444
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ARShowUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007A16 RID: 31254
		private ARShowUIController.UIState uiState;

		// Token: 0x04007A17 RID: 31255
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private PrefabResourceContainer m_resourceContainer;

		// Token: 0x04007A18 RID: 31256
		[AutoBind("./PhotographButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_photographButton;

		// Token: 0x04007A19 RID: 31257
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04007A1A RID: 31258
		[AutoBind("./SummonButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_summonButton;

		// Token: 0x04007A1B RID: 31259
		[AutoBind("./ExitButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_exitButton;

		// Token: 0x04007A1C RID: 31260
		[AutoBind("./PhotographPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_roleControlPanel;

		// Token: 0x04007A1D RID: 31261
		[AutoBind("./PhotographPanel/Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04007A1E RID: 31262
		[AutoBind("./PhotographPanel/Margin/ActionChoosenPanel/SideInToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charActionChoose;

		// Token: 0x04007A1F RID: 31263
		[AutoBind("./PhotographPanel/Margin/ActionChoosenPanel/Content/Idle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charIdleToggle;

		// Token: 0x04007A20 RID: 31264
		[AutoBind("./PhotographPanel/Margin/ActionChoosenPanel/Content/Attack", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charAttackToggle;

		// Token: 0x04007A21 RID: 31265
		[AutoBind("./PhotographPanel/Margin/ActionChoosenPanel/Content/SuperAttack", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charSuperAttackToggle;

		// Token: 0x04007A22 RID: 31266
		[AutoBind("./PhotographPanel/Margin/ActionChoosenPanel/Content/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charMagicToggle;

		// Token: 0x04007A23 RID: 31267
		[AutoBind("./PhotographPanel/Margin/ActionChoosenPanel/Content/Death", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charDeathToggle;

		// Token: 0x04007A24 RID: 31268
		[AutoBind("./PhotographPanel/Margin/ActionChoosenPanel/Content/Sing", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charSingToggle;

		// Token: 0x04007A25 RID: 31269
		[AutoBind("./PhotographPanel/Margin/ActionChoosenPanel/Content/Faint", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charFaintToggle;

		// Token: 0x04007A26 RID: 31270
		[AutoBind("./PhotographPanel/Margin/ActionChoosenPanel/Content/Run", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charRunToggle;

		// Token: 0x04007A27 RID: 31271
		[AutoBind("./PhotographPanel/DirectionToggleGroup/TureLeftButton", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_turnLeftToggle;

		// Token: 0x04007A28 RID: 31272
		[AutoBind("./PhotographPanel/DirectionToggleGroup/TureRightButton", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_turnRightToggle;

		// Token: 0x04007A29 RID: 31273
		[AutoBind("./SharePanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_sharePanel;

		// Token: 0x04007A2A RID: 31274
		[AutoBind("./SharePanel/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_shareBackgroundButton;

		// Token: 0x04007A2B RID: 31275
		[AutoBind("./SharePanel/ShareImage", AutoBindAttribute.InitState.NotInit, false)]
		private RawImage m_shareImage;

		// Token: 0x04007A2C RID: 31276
		[AutoBind("./SharePanel/ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_shareReturnButton;

		// Token: 0x04007A2D RID: 31277
		[AutoBind("./SharePanel/ShareButtonDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_shareButtonDummy;

		// Token: 0x04007A2E RID: 31278
		[AutoBind("./SharePanel/SharePhotoDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_sharePhotoDummy;

		// Token: 0x04007A2F RID: 31279
		[AutoBind("./DevelopPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_developPanel;

		// Token: 0x04007A30 RID: 31280
		[AutoBind("./DevelopPanel/ScrollbarScale", AutoBindAttribute.InitState.NotInit, false)]
		private Scrollbar m_scaleScrollbar;

		// Token: 0x04007A31 RID: 31281
		[AutoBind("./DevelopPanel/ScrollbarDistance", AutoBindAttribute.InitState.NotInit, false)]
		private Scrollbar m_distanceScrollbar;

		// Token: 0x04007A32 RID: 31282
		[AutoBind("./DevelopPanel/TextScale", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_scaleText;

		// Token: 0x04007A33 RID: 31283
		[AutoBind("./DevelopPanel/TextDistance", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_distanceText;

		// Token: 0x04007A34 RID: 31284
		private GameObject m_sharePhotoUIPanel;

		// Token: 0x04007A35 RID: 31285
		private Text m_playerNameText;

		// Token: 0x04007A36 RID: 31286
		private Text m_playerLvText;

		// Token: 0x04007A37 RID: 31287
		private Text m_serverNameText;

		// Token: 0x04007A38 RID: 31288
		private GameObject m_shareSubPanel;

		// Token: 0x04007A39 RID: 31289
		private Button m_weiBoButton;

		// Token: 0x04007A3A RID: 31290
		private Button m_weChatButton;

		// Token: 0x04007A3B RID: 31291
		private ARUITask m_task;

		// Token: 0x04007A3C RID: 31292
		private ARShowSceneController m_arShowSceneController;

		// Token: 0x04007A3D RID: 31293
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04007A3E RID: 31294
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04007A3F RID: 31295
		private Texture2D m_captureTexture;

		// Token: 0x04007A40 RID: 31296
		private int m_arShowType;

		// Token: 0x04007A41 RID: 31297
		private int m_selectHeroID;

		// Token: 0x04007A42 RID: 31298
		public const int BattleShow = 1;

		// Token: 0x04007A43 RID: 31299
		public const int HeroDrawShow = 2;

		// Token: 0x04007A44 RID: 31300
		public const int TeamShow = 3;

		// Token: 0x04007A45 RID: 31301
		[DoNotToLua]
		private ARShowUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007A46 RID: 31302
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007A47 RID: 31303
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007A48 RID: 31304
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007A49 RID: 31305
		private LuaFunction m_Update_hotfix;

		// Token: 0x04007A4A RID: 31306
		private LuaFunction m_Refresh_hotfix;

		// Token: 0x04007A4B RID: 31307
		private LuaFunction m_UpdateDeveloperMode_hotfix;

		// Token: 0x04007A4C RID: 31308
		private LuaFunction m_SetUITaskARUITask_hotfix;

		// Token: 0x04007A4D RID: 31309
		private LuaFunction m_LoadData_hotfix;

		// Token: 0x04007A4E RID: 31310
		private LuaFunction m_SetARShowSceneControllerARShowSceneController_hotfix;

		// Token: 0x04007A4F RID: 31311
		private LuaFunction m_OnPhotographClick_hotfix;

		// Token: 0x04007A50 RID: 31312
		private LuaFunction m_OnReturnClick_hotfix;

		// Token: 0x04007A51 RID: 31313
		private LuaFunction m_OnSummonClick_hotfix;

		// Token: 0x04007A52 RID: 31314
		private LuaFunction m_OnExitClick_hotfix;

		// Token: 0x04007A53 RID: 31315
		private LuaFunction m_OnCharActionClickGameObject_hotfix;

		// Token: 0x04007A54 RID: 31316
		private LuaFunction m_OnCharDirectionClickGameObject_hotfix;

		// Token: 0x04007A55 RID: 31317
		private LuaFunction m_OnShareReturnClick_hotfix;

		// Token: 0x04007A56 RID: 31318
		private LuaFunction m_OnWeiBoClick_hotfix;

		// Token: 0x04007A57 RID: 31319
		private LuaFunction m_OnWeChatClick_hotfix;

		// Token: 0x04007A58 RID: 31320
		private LuaFunction m_OnShareBackgroundClick_hotfix;

		// Token: 0x04007A59 RID: 31321
		private LuaFunction m_OnScaleScrollBarValueChangeSingle_hotfix;

		// Token: 0x04007A5A RID: 31322
		private LuaFunction m_OnDistanceScrollBarValueChangeSingle_hotfix;

		// Token: 0x04007A5B RID: 31323
		private LuaFunction m_Photograph_hotfix;

		// Token: 0x04007A5C RID: 31324
		private LuaFunction m_ShareImageInt32_hotfix;

		// Token: 0x04007A5D RID: 31325
		private LuaFunction m_CopyTexture2DTexture2D_hotfix;

		// Token: 0x04007A5E RID: 31326
		private LuaFunction m_SaveTextureToPNGTexture2DStringString_hotfix;

		// Token: 0x02000B16 RID: 2838
		public enum UIState
		{
			// Token: 0x04007A60 RID: 31328
			RecognizePanel,
			// Token: 0x04007A61 RID: 31329
			Summon,
			// Token: 0x04007A62 RID: 31330
			Show,
			// Token: 0x04007A63 RID: 31331
			Photo
		}

		// Token: 0x02000B17 RID: 2839
		public new class LuaExportHelper
		{
			// Token: 0x0600BF0D RID: 48909 RVA: 0x003562AC File Offset: 0x003544AC
			public LuaExportHelper(ARShowUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BF0E RID: 48910 RVA: 0x003562BC File Offset: 0x003544BC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600BF0F RID: 48911 RVA: 0x003562CC File Offset: 0x003544CC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600BF10 RID: 48912 RVA: 0x003562DC File Offset: 0x003544DC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600BF11 RID: 48913 RVA: 0x003562EC File Offset: 0x003544EC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600BF12 RID: 48914 RVA: 0x00356304 File Offset: 0x00354504
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600BF13 RID: 48915 RVA: 0x00356314 File Offset: 0x00354514
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600BF14 RID: 48916 RVA: 0x00356324 File Offset: 0x00354524
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600BF15 RID: 48917 RVA: 0x00356334 File Offset: 0x00354534
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600BF16 RID: 48918 RVA: 0x00356344 File Offset: 0x00354544
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600BF17 RID: 48919 RVA: 0x00356354 File Offset: 0x00354554
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600BF18 RID: 48920 RVA: 0x00356364 File Offset: 0x00354564
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600BF19 RID: 48921 RVA: 0x00356374 File Offset: 0x00354574
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600BF1A RID: 48922 RVA: 0x00356384 File Offset: 0x00354584
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600BF1B RID: 48923 RVA: 0x00356394 File Offset: 0x00354594
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600BF1C RID: 48924 RVA: 0x003563A4 File Offset: 0x003545A4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700264A RID: 9802
			// (get) Token: 0x0600BF1D RID: 48925 RVA: 0x003563B4 File Offset: 0x003545B4
			// (set) Token: 0x0600BF1E RID: 48926 RVA: 0x003563C4 File Offset: 0x003545C4
			public ARShowUIController.UIState uiState
			{
				get
				{
					return this.m_owner.uiState;
				}
				set
				{
					this.m_owner.uiState = value;
				}
			}

			// Token: 0x1700264B RID: 9803
			// (get) Token: 0x0600BF1F RID: 48927 RVA: 0x003563D4 File Offset: 0x003545D4
			// (set) Token: 0x0600BF20 RID: 48928 RVA: 0x003563E4 File Offset: 0x003545E4
			public PrefabResourceContainer m_resourceContainer
			{
				get
				{
					return this.m_owner.m_resourceContainer;
				}
				set
				{
					this.m_owner.m_resourceContainer = value;
				}
			}

			// Token: 0x1700264C RID: 9804
			// (get) Token: 0x0600BF21 RID: 48929 RVA: 0x003563F4 File Offset: 0x003545F4
			// (set) Token: 0x0600BF22 RID: 48930 RVA: 0x00356404 File Offset: 0x00354604
			public Button m_photographButton
			{
				get
				{
					return this.m_owner.m_photographButton;
				}
				set
				{
					this.m_owner.m_photographButton = value;
				}
			}

			// Token: 0x1700264D RID: 9805
			// (get) Token: 0x0600BF23 RID: 48931 RVA: 0x00356414 File Offset: 0x00354614
			// (set) Token: 0x0600BF24 RID: 48932 RVA: 0x00356424 File Offset: 0x00354624
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x1700264E RID: 9806
			// (get) Token: 0x0600BF25 RID: 48933 RVA: 0x00356434 File Offset: 0x00354634
			// (set) Token: 0x0600BF26 RID: 48934 RVA: 0x00356444 File Offset: 0x00354644
			public Button m_summonButton
			{
				get
				{
					return this.m_owner.m_summonButton;
				}
				set
				{
					this.m_owner.m_summonButton = value;
				}
			}

			// Token: 0x1700264F RID: 9807
			// (get) Token: 0x0600BF27 RID: 48935 RVA: 0x00356454 File Offset: 0x00354654
			// (set) Token: 0x0600BF28 RID: 48936 RVA: 0x00356464 File Offset: 0x00354664
			public Button m_exitButton
			{
				get
				{
					return this.m_owner.m_exitButton;
				}
				set
				{
					this.m_owner.m_exitButton = value;
				}
			}

			// Token: 0x17002650 RID: 9808
			// (get) Token: 0x0600BF29 RID: 48937 RVA: 0x00356474 File Offset: 0x00354674
			// (set) Token: 0x0600BF2A RID: 48938 RVA: 0x00356484 File Offset: 0x00354684
			public GameObject m_roleControlPanel
			{
				get
				{
					return this.m_owner.m_roleControlPanel;
				}
				set
				{
					this.m_owner.m_roleControlPanel = value;
				}
			}

			// Token: 0x17002651 RID: 9809
			// (get) Token: 0x0600BF2B RID: 48939 RVA: 0x00356494 File Offset: 0x00354694
			// (set) Token: 0x0600BF2C RID: 48940 RVA: 0x003564A4 File Offset: 0x003546A4
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x17002652 RID: 9810
			// (get) Token: 0x0600BF2D RID: 48941 RVA: 0x003564B4 File Offset: 0x003546B4
			// (set) Token: 0x0600BF2E RID: 48942 RVA: 0x003564C4 File Offset: 0x003546C4
			public Toggle m_charActionChoose
			{
				get
				{
					return this.m_owner.m_charActionChoose;
				}
				set
				{
					this.m_owner.m_charActionChoose = value;
				}
			}

			// Token: 0x17002653 RID: 9811
			// (get) Token: 0x0600BF2F RID: 48943 RVA: 0x003564D4 File Offset: 0x003546D4
			// (set) Token: 0x0600BF30 RID: 48944 RVA: 0x003564E4 File Offset: 0x003546E4
			public Toggle m_charIdleToggle
			{
				get
				{
					return this.m_owner.m_charIdleToggle;
				}
				set
				{
					this.m_owner.m_charIdleToggle = value;
				}
			}

			// Token: 0x17002654 RID: 9812
			// (get) Token: 0x0600BF31 RID: 48945 RVA: 0x003564F4 File Offset: 0x003546F4
			// (set) Token: 0x0600BF32 RID: 48946 RVA: 0x00356504 File Offset: 0x00354704
			public Toggle m_charAttackToggle
			{
				get
				{
					return this.m_owner.m_charAttackToggle;
				}
				set
				{
					this.m_owner.m_charAttackToggle = value;
				}
			}

			// Token: 0x17002655 RID: 9813
			// (get) Token: 0x0600BF33 RID: 48947 RVA: 0x00356514 File Offset: 0x00354714
			// (set) Token: 0x0600BF34 RID: 48948 RVA: 0x00356524 File Offset: 0x00354724
			public Toggle m_charSuperAttackToggle
			{
				get
				{
					return this.m_owner.m_charSuperAttackToggle;
				}
				set
				{
					this.m_owner.m_charSuperAttackToggle = value;
				}
			}

			// Token: 0x17002656 RID: 9814
			// (get) Token: 0x0600BF35 RID: 48949 RVA: 0x00356534 File Offset: 0x00354734
			// (set) Token: 0x0600BF36 RID: 48950 RVA: 0x00356544 File Offset: 0x00354744
			public Toggle m_charMagicToggle
			{
				get
				{
					return this.m_owner.m_charMagicToggle;
				}
				set
				{
					this.m_owner.m_charMagicToggle = value;
				}
			}

			// Token: 0x17002657 RID: 9815
			// (get) Token: 0x0600BF37 RID: 48951 RVA: 0x00356554 File Offset: 0x00354754
			// (set) Token: 0x0600BF38 RID: 48952 RVA: 0x00356564 File Offset: 0x00354764
			public Toggle m_charDeathToggle
			{
				get
				{
					return this.m_owner.m_charDeathToggle;
				}
				set
				{
					this.m_owner.m_charDeathToggle = value;
				}
			}

			// Token: 0x17002658 RID: 9816
			// (get) Token: 0x0600BF39 RID: 48953 RVA: 0x00356574 File Offset: 0x00354774
			// (set) Token: 0x0600BF3A RID: 48954 RVA: 0x00356584 File Offset: 0x00354784
			public Toggle m_charSingToggle
			{
				get
				{
					return this.m_owner.m_charSingToggle;
				}
				set
				{
					this.m_owner.m_charSingToggle = value;
				}
			}

			// Token: 0x17002659 RID: 9817
			// (get) Token: 0x0600BF3B RID: 48955 RVA: 0x00356594 File Offset: 0x00354794
			// (set) Token: 0x0600BF3C RID: 48956 RVA: 0x003565A4 File Offset: 0x003547A4
			public Toggle m_charFaintToggle
			{
				get
				{
					return this.m_owner.m_charFaintToggle;
				}
				set
				{
					this.m_owner.m_charFaintToggle = value;
				}
			}

			// Token: 0x1700265A RID: 9818
			// (get) Token: 0x0600BF3D RID: 48957 RVA: 0x003565B4 File Offset: 0x003547B4
			// (set) Token: 0x0600BF3E RID: 48958 RVA: 0x003565C4 File Offset: 0x003547C4
			public Toggle m_charRunToggle
			{
				get
				{
					return this.m_owner.m_charRunToggle;
				}
				set
				{
					this.m_owner.m_charRunToggle = value;
				}
			}

			// Token: 0x1700265B RID: 9819
			// (get) Token: 0x0600BF3F RID: 48959 RVA: 0x003565D4 File Offset: 0x003547D4
			// (set) Token: 0x0600BF40 RID: 48960 RVA: 0x003565E4 File Offset: 0x003547E4
			public Toggle m_turnLeftToggle
			{
				get
				{
					return this.m_owner.m_turnLeftToggle;
				}
				set
				{
					this.m_owner.m_turnLeftToggle = value;
				}
			}

			// Token: 0x1700265C RID: 9820
			// (get) Token: 0x0600BF41 RID: 48961 RVA: 0x003565F4 File Offset: 0x003547F4
			// (set) Token: 0x0600BF42 RID: 48962 RVA: 0x00356604 File Offset: 0x00354804
			public Toggle m_turnRightToggle
			{
				get
				{
					return this.m_owner.m_turnRightToggle;
				}
				set
				{
					this.m_owner.m_turnRightToggle = value;
				}
			}

			// Token: 0x1700265D RID: 9821
			// (get) Token: 0x0600BF43 RID: 48963 RVA: 0x00356614 File Offset: 0x00354814
			// (set) Token: 0x0600BF44 RID: 48964 RVA: 0x00356624 File Offset: 0x00354824
			public GameObject m_sharePanel
			{
				get
				{
					return this.m_owner.m_sharePanel;
				}
				set
				{
					this.m_owner.m_sharePanel = value;
				}
			}

			// Token: 0x1700265E RID: 9822
			// (get) Token: 0x0600BF45 RID: 48965 RVA: 0x00356634 File Offset: 0x00354834
			// (set) Token: 0x0600BF46 RID: 48966 RVA: 0x00356644 File Offset: 0x00354844
			public Button m_shareBackgroundButton
			{
				get
				{
					return this.m_owner.m_shareBackgroundButton;
				}
				set
				{
					this.m_owner.m_shareBackgroundButton = value;
				}
			}

			// Token: 0x1700265F RID: 9823
			// (get) Token: 0x0600BF47 RID: 48967 RVA: 0x00356654 File Offset: 0x00354854
			// (set) Token: 0x0600BF48 RID: 48968 RVA: 0x00356664 File Offset: 0x00354864
			public RawImage m_shareImage
			{
				get
				{
					return this.m_owner.m_shareImage;
				}
				set
				{
					this.m_owner.m_shareImage = value;
				}
			}

			// Token: 0x17002660 RID: 9824
			// (get) Token: 0x0600BF49 RID: 48969 RVA: 0x00356674 File Offset: 0x00354874
			// (set) Token: 0x0600BF4A RID: 48970 RVA: 0x00356684 File Offset: 0x00354884
			public Button m_shareReturnButton
			{
				get
				{
					return this.m_owner.m_shareReturnButton;
				}
				set
				{
					this.m_owner.m_shareReturnButton = value;
				}
			}

			// Token: 0x17002661 RID: 9825
			// (get) Token: 0x0600BF4B RID: 48971 RVA: 0x00356694 File Offset: 0x00354894
			// (set) Token: 0x0600BF4C RID: 48972 RVA: 0x003566A4 File Offset: 0x003548A4
			public GameObject m_shareButtonDummy
			{
				get
				{
					return this.m_owner.m_shareButtonDummy;
				}
				set
				{
					this.m_owner.m_shareButtonDummy = value;
				}
			}

			// Token: 0x17002662 RID: 9826
			// (get) Token: 0x0600BF4D RID: 48973 RVA: 0x003566B4 File Offset: 0x003548B4
			// (set) Token: 0x0600BF4E RID: 48974 RVA: 0x003566C4 File Offset: 0x003548C4
			public GameObject m_sharePhotoDummy
			{
				get
				{
					return this.m_owner.m_sharePhotoDummy;
				}
				set
				{
					this.m_owner.m_sharePhotoDummy = value;
				}
			}

			// Token: 0x17002663 RID: 9827
			// (get) Token: 0x0600BF4F RID: 48975 RVA: 0x003566D4 File Offset: 0x003548D4
			// (set) Token: 0x0600BF50 RID: 48976 RVA: 0x003566E4 File Offset: 0x003548E4
			public GameObject m_developPanel
			{
				get
				{
					return this.m_owner.m_developPanel;
				}
				set
				{
					this.m_owner.m_developPanel = value;
				}
			}

			// Token: 0x17002664 RID: 9828
			// (get) Token: 0x0600BF51 RID: 48977 RVA: 0x003566F4 File Offset: 0x003548F4
			// (set) Token: 0x0600BF52 RID: 48978 RVA: 0x00356704 File Offset: 0x00354904
			public Scrollbar m_scaleScrollbar
			{
				get
				{
					return this.m_owner.m_scaleScrollbar;
				}
				set
				{
					this.m_owner.m_scaleScrollbar = value;
				}
			}

			// Token: 0x17002665 RID: 9829
			// (get) Token: 0x0600BF53 RID: 48979 RVA: 0x00356714 File Offset: 0x00354914
			// (set) Token: 0x0600BF54 RID: 48980 RVA: 0x00356724 File Offset: 0x00354924
			public Scrollbar m_distanceScrollbar
			{
				get
				{
					return this.m_owner.m_distanceScrollbar;
				}
				set
				{
					this.m_owner.m_distanceScrollbar = value;
				}
			}

			// Token: 0x17002666 RID: 9830
			// (get) Token: 0x0600BF55 RID: 48981 RVA: 0x00356734 File Offset: 0x00354934
			// (set) Token: 0x0600BF56 RID: 48982 RVA: 0x00356744 File Offset: 0x00354944
			public Text m_scaleText
			{
				get
				{
					return this.m_owner.m_scaleText;
				}
				set
				{
					this.m_owner.m_scaleText = value;
				}
			}

			// Token: 0x17002667 RID: 9831
			// (get) Token: 0x0600BF57 RID: 48983 RVA: 0x00356754 File Offset: 0x00354954
			// (set) Token: 0x0600BF58 RID: 48984 RVA: 0x00356764 File Offset: 0x00354964
			public Text m_distanceText
			{
				get
				{
					return this.m_owner.m_distanceText;
				}
				set
				{
					this.m_owner.m_distanceText = value;
				}
			}

			// Token: 0x17002668 RID: 9832
			// (get) Token: 0x0600BF59 RID: 48985 RVA: 0x00356774 File Offset: 0x00354974
			// (set) Token: 0x0600BF5A RID: 48986 RVA: 0x00356784 File Offset: 0x00354984
			public GameObject m_sharePhotoUIPanel
			{
				get
				{
					return this.m_owner.m_sharePhotoUIPanel;
				}
				set
				{
					this.m_owner.m_sharePhotoUIPanel = value;
				}
			}

			// Token: 0x17002669 RID: 9833
			// (get) Token: 0x0600BF5B RID: 48987 RVA: 0x00356794 File Offset: 0x00354994
			// (set) Token: 0x0600BF5C RID: 48988 RVA: 0x003567A4 File Offset: 0x003549A4
			public Text m_playerNameText
			{
				get
				{
					return this.m_owner.m_playerNameText;
				}
				set
				{
					this.m_owner.m_playerNameText = value;
				}
			}

			// Token: 0x1700266A RID: 9834
			// (get) Token: 0x0600BF5D RID: 48989 RVA: 0x003567B4 File Offset: 0x003549B4
			// (set) Token: 0x0600BF5E RID: 48990 RVA: 0x003567C4 File Offset: 0x003549C4
			public Text m_playerLvText
			{
				get
				{
					return this.m_owner.m_playerLvText;
				}
				set
				{
					this.m_owner.m_playerLvText = value;
				}
			}

			// Token: 0x1700266B RID: 9835
			// (get) Token: 0x0600BF5F RID: 48991 RVA: 0x003567D4 File Offset: 0x003549D4
			// (set) Token: 0x0600BF60 RID: 48992 RVA: 0x003567E4 File Offset: 0x003549E4
			public Text m_serverNameText
			{
				get
				{
					return this.m_owner.m_serverNameText;
				}
				set
				{
					this.m_owner.m_serverNameText = value;
				}
			}

			// Token: 0x1700266C RID: 9836
			// (get) Token: 0x0600BF61 RID: 48993 RVA: 0x003567F4 File Offset: 0x003549F4
			// (set) Token: 0x0600BF62 RID: 48994 RVA: 0x00356804 File Offset: 0x00354A04
			public GameObject m_shareSubPanel
			{
				get
				{
					return this.m_owner.m_shareSubPanel;
				}
				set
				{
					this.m_owner.m_shareSubPanel = value;
				}
			}

			// Token: 0x1700266D RID: 9837
			// (get) Token: 0x0600BF63 RID: 48995 RVA: 0x00356814 File Offset: 0x00354A14
			// (set) Token: 0x0600BF64 RID: 48996 RVA: 0x00356824 File Offset: 0x00354A24
			public Button m_weiBoButton
			{
				get
				{
					return this.m_owner.m_weiBoButton;
				}
				set
				{
					this.m_owner.m_weiBoButton = value;
				}
			}

			// Token: 0x1700266E RID: 9838
			// (get) Token: 0x0600BF65 RID: 48997 RVA: 0x00356834 File Offset: 0x00354A34
			// (set) Token: 0x0600BF66 RID: 48998 RVA: 0x00356844 File Offset: 0x00354A44
			public Button m_weChatButton
			{
				get
				{
					return this.m_owner.m_weChatButton;
				}
				set
				{
					this.m_owner.m_weChatButton = value;
				}
			}

			// Token: 0x1700266F RID: 9839
			// (get) Token: 0x0600BF67 RID: 48999 RVA: 0x00356854 File Offset: 0x00354A54
			// (set) Token: 0x0600BF68 RID: 49000 RVA: 0x00356864 File Offset: 0x00354A64
			public ARUITask m_task
			{
				get
				{
					return this.m_owner.m_task;
				}
				set
				{
					this.m_owner.m_task = value;
				}
			}

			// Token: 0x17002670 RID: 9840
			// (get) Token: 0x0600BF69 RID: 49001 RVA: 0x00356874 File Offset: 0x00354A74
			// (set) Token: 0x0600BF6A RID: 49002 RVA: 0x00356884 File Offset: 0x00354A84
			public ARShowSceneController m_arShowSceneController
			{
				get
				{
					return this.m_owner.m_arShowSceneController;
				}
				set
				{
					this.m_owner.m_arShowSceneController = value;
				}
			}

			// Token: 0x17002671 RID: 9841
			// (get) Token: 0x0600BF6B RID: 49003 RVA: 0x00356894 File Offset: 0x00354A94
			// (set) Token: 0x0600BF6C RID: 49004 RVA: 0x003568A4 File Offset: 0x00354AA4
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

			// Token: 0x17002672 RID: 9842
			// (get) Token: 0x0600BF6D RID: 49005 RVA: 0x003568B4 File Offset: 0x00354AB4
			// (set) Token: 0x0600BF6E RID: 49006 RVA: 0x003568C4 File Offset: 0x00354AC4
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17002673 RID: 9843
			// (get) Token: 0x0600BF6F RID: 49007 RVA: 0x003568D4 File Offset: 0x00354AD4
			// (set) Token: 0x0600BF70 RID: 49008 RVA: 0x003568E4 File Offset: 0x00354AE4
			public Texture2D m_captureTexture
			{
				get
				{
					return this.m_owner.m_captureTexture;
				}
				set
				{
					this.m_owner.m_captureTexture = value;
				}
			}

			// Token: 0x17002674 RID: 9844
			// (get) Token: 0x0600BF71 RID: 49009 RVA: 0x003568F4 File Offset: 0x00354AF4
			// (set) Token: 0x0600BF72 RID: 49010 RVA: 0x00356904 File Offset: 0x00354B04
			public int m_arShowType
			{
				get
				{
					return this.m_owner.m_arShowType;
				}
				set
				{
					this.m_owner.m_arShowType = value;
				}
			}

			// Token: 0x17002675 RID: 9845
			// (get) Token: 0x0600BF73 RID: 49011 RVA: 0x00356914 File Offset: 0x00354B14
			// (set) Token: 0x0600BF74 RID: 49012 RVA: 0x00356924 File Offset: 0x00354B24
			public int m_selectHeroID
			{
				get
				{
					return this.m_owner.m_selectHeroID;
				}
				set
				{
					this.m_owner.m_selectHeroID = value;
				}
			}

			// Token: 0x0600BF75 RID: 49013 RVA: 0x00356934 File Offset: 0x00354B34
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600BF76 RID: 49014 RVA: 0x00356944 File Offset: 0x00354B44
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600BF77 RID: 49015 RVA: 0x00356954 File Offset: 0x00354B54
			public void UpdateDeveloperMode()
			{
				this.m_owner.UpdateDeveloperMode();
			}

			// Token: 0x0600BF78 RID: 49016 RVA: 0x00356964 File Offset: 0x00354B64
			public void OnPhotographClick()
			{
				this.m_owner.OnPhotographClick();
			}

			// Token: 0x0600BF79 RID: 49017 RVA: 0x00356974 File Offset: 0x00354B74
			public void OnReturnClick()
			{
				this.m_owner.OnReturnClick();
			}

			// Token: 0x0600BF7A RID: 49018 RVA: 0x00356984 File Offset: 0x00354B84
			public void OnSummonClick()
			{
				this.m_owner.OnSummonClick();
			}

			// Token: 0x0600BF7B RID: 49019 RVA: 0x00356994 File Offset: 0x00354B94
			public void OnExitClick()
			{
				this.m_owner.OnExitClick();
			}

			// Token: 0x0600BF7C RID: 49020 RVA: 0x003569A4 File Offset: 0x00354BA4
			public void OnCharActionClick(GameObject obj)
			{
				this.m_owner.OnCharActionClick(obj);
			}

			// Token: 0x0600BF7D RID: 49021 RVA: 0x003569B4 File Offset: 0x00354BB4
			public void OnCharDirectionClick(GameObject obj)
			{
				this.m_owner.OnCharDirectionClick(obj);
			}

			// Token: 0x0600BF7E RID: 49022 RVA: 0x003569C4 File Offset: 0x00354BC4
			public void OnShareReturnClick()
			{
				this.m_owner.OnShareReturnClick();
			}

			// Token: 0x0600BF7F RID: 49023 RVA: 0x003569D4 File Offset: 0x00354BD4
			public void OnWeiBoClick()
			{
				this.m_owner.OnWeiBoClick();
			}

			// Token: 0x0600BF80 RID: 49024 RVA: 0x003569E4 File Offset: 0x00354BE4
			public void OnWeChatClick()
			{
				this.m_owner.OnWeChatClick();
			}

			// Token: 0x0600BF81 RID: 49025 RVA: 0x003569F4 File Offset: 0x00354BF4
			public void OnShareBackgroundClick()
			{
				this.m_owner.OnShareBackgroundClick();
			}

			// Token: 0x0600BF82 RID: 49026 RVA: 0x00356A04 File Offset: 0x00354C04
			public void OnScaleScrollBarValueChange(float value)
			{
				this.m_owner.OnScaleScrollBarValueChange(value);
			}

			// Token: 0x0600BF83 RID: 49027 RVA: 0x00356A14 File Offset: 0x00354C14
			public void OnDistanceScrollBarValueChange(float value)
			{
				this.m_owner.OnDistanceScrollBarValueChange(value);
			}

			// Token: 0x0600BF84 RID: 49028 RVA: 0x00356A24 File Offset: 0x00354C24
			public IEnumerator Photograph()
			{
				return this.m_owner.Photograph();
			}

			// Token: 0x0600BF85 RID: 49029 RVA: 0x00356A34 File Offset: 0x00354C34
			public IEnumerator ShareImage(int sharePlatform)
			{
				return this.m_owner.ShareImage(sharePlatform);
			}

			// Token: 0x0600BF86 RID: 49030 RVA: 0x00356A44 File Offset: 0x00354C44
			public Texture2D CopyTexture2D(Texture2D texture)
			{
				return this.m_owner.CopyTexture2D(texture);
			}

			// Token: 0x0600BF87 RID: 49031 RVA: 0x00356A54 File Offset: 0x00354C54
			public void SaveTextureToPNG(Texture2D texture, string path, string pngName)
			{
				this.m_owner.SaveTextureToPNG(texture, path, pngName);
			}

			// Token: 0x04007A64 RID: 31332
			private ARShowUIController m_owner;
		}
	}
}
