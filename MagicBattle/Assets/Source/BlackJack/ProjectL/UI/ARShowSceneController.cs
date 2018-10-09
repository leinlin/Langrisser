using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.AR;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B11 RID: 2833
	[HotFix]
	public class ARShowSceneController : UIControllerBase
	{
		// Token: 0x0600BE7C RID: 48764 RVA: 0x003532BC File Offset: 0x003514BC
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
			this.arPlaneTrace.Init(this.m_camera);
			this.isPlaneTrace = true;
		}

		// Token: 0x0600BE7D RID: 48765 RVA: 0x00353364 File Offset: 0x00351564
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
			if (!this.isPlaneTrace)
			{
				return;
			}
			global::Debug.Log(new object[]
			{
				this.arPlaneTrace.SquareState
			});
			if (this.arPlaneTrace.SquareState == ARPlaneTrace.FocusState.Finding)
			{
				this.m_focusSquareRenderer.material.SetColor("_TintColor", Color.grey);
			}
			else if (this.arPlaneTrace.SquareState == ARPlaneTrace.FocusState.Found)
			{
				this.m_focusSquareRenderer.material.SetColor("_TintColor", Color.green);
			}
			this.arPlaneTrace.Update();
			this.m_focusSquare.transform.position = this.arPlaneTrace.centerPos;
			this.m_focusSquare.transform.rotation = this.arPlaneTrace.centerRotation;
		}

		// Token: 0x0600BE7E RID: 48766 RVA: 0x0035348C File Offset: 0x0035168C
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
		}

		// Token: 0x0600BE7F RID: 48767 RVA: 0x00353504 File Offset: 0x00351704
		public void SummonHeroBattleShow(int selectHeroID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SummonHeroBattleShowInt32_hotfix != null)
			{
				this.m_SummonHeroBattleShowInt32_hotfix.call(new object[]
				{
					this,
					selectHeroID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_playerContext.GetHero(selectHeroID);
			string modelResPath = UIUtility.GetHeroModelAssetPath(hero);
			this.m_task.CustomLoadAsset(delegate
			{
				this.m_task.CollectAssetWrap(modelResPath);
			}, delegate
			{
				GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(modelResPath);
				GameObject gameObject = GameObjectUtility.CloneGameObject(asset, this.m_charNode.transform);
				EventTriggerListener eventTriggerListener = gameObject.AddComponent<EventTriggerListener>();
				eventTriggerListener.onClick = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener.onClick, new EventTriggerListener.VoidDelegate(this.OnCharClick));
				gameObject.AddComponent<BoxCollider>();
				this.m_roleSkeleton = gameObject.GetComponent<SkeletonAnimation>();
				this.PlayAnimation(this.m_roleSkeleton, "idle", true);
				this.m_charNode.transform.position = this.arPlaneTrace.centerPos;
				this.m_charNode.transform.rotation = this.arPlaneTrace.centerRotation;
			});
		}

		// Token: 0x0600BE80 RID: 48768 RVA: 0x003535C0 File Offset: 0x003517C0
		public void SummonHeroDrawShow(int selectHeroID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SummonHeroDrawShowInt32_hotfix != null)
			{
				this.m_SummonHeroDrawShowInt32_hotfix.call(new object[]
				{
					this,
					selectHeroID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_playerContext.GetHero(selectHeroID);
			string modelResPath = UIUtility.GetHeroCharAssetPath(hero);
			this.m_task.CustomLoadAsset(delegate
			{
				this.m_task.CollectAssetWrap(modelResPath);
			}, delegate
			{
				GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(modelResPath);
				GameObject gameObject = GameObjectUtility.CloneGameObject(asset, this.m_charDrawNode.transform);
				this.m_roleSkeleton = gameObject.GetComponent<SkeletonAnimation>();
				this.PlayAnimation(this.m_roleSkeleton, "idle_Normal", true);
				this.m_charDrawNode.transform.position = this.arPlaneTrace.centerPos;
				this.m_charDrawNode.transform.rotation = this.arPlaneTrace.centerRotation;
			});
		}

		// Token: 0x0600BE81 RID: 48769 RVA: 0x0035367C File Offset: 0x0035187C
		public void SummonHeroTeamShow()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SummonHeroTeamShow_hotfix != null)
			{
				this.m_SummonHeroTeamShow_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_task.CustomLoadAsset(delegate
			{
				foreach (BusinessCardHeroSet businessCardHeroSet in this.m_playerContext.BusinessCard.SetInfo.Heroes)
				{
					Hero hero = this.m_playerContext.GetHero(businessCardHeroSet.HeroId);
					string heroModelAssetPath = UIUtility.GetHeroModelAssetPath(hero);
					this.m_task.CollectAssetWrap(heroModelAssetPath);
				}
			}, delegate
			{
				int num = 0;
				while (num < this.m_playerContext.BusinessCard.SetInfo.Heroes.Count && num < this.m_charGroupNode.transform.childCount)
				{
					BusinessCardHeroSet businessCardHeroSet = this.m_playerContext.BusinessCard.SetInfo.Heroes[num];
					Hero hero = this.m_playerContext.GetHero(businessCardHeroSet.HeroId);
					string heroModelAssetPath = UIUtility.GetHeroModelAssetPath(hero);
					GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(heroModelAssetPath);
					Transform child = this.m_charGroupNode.transform.GetChild(num);
					GameObject gameObject = GameObjectUtility.CloneGameObject(asset, child);
					EventTriggerListener eventTriggerListener = gameObject.AddComponent<EventTriggerListener>();
					eventTriggerListener.onClick = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener.onClick, new EventTriggerListener.VoidDelegate(this.OnCharClick));
					SkeletonAnimation component = gameObject.GetComponent<SkeletonAnimation>();
					this.PlayAnimation(component, businessCardHeroSet.Action, true);
					this.SetCharDirection(child.gameObject, businessCardHeroSet.Direction == HeroDirectionType.Right);
					this.m_roleSkeletonList.Add(gameObject.GetComponent<SkeletonAnimation>());
					num++;
				}
				this.m_charGroupNode.transform.position = this.arPlaneTrace.centerPos;
				this.m_charGroupNode.transform.rotation = this.arPlaneTrace.centerRotation;
			});
		}

		// Token: 0x0600BE82 RID: 48770 RVA: 0x00353700 File Offset: 0x00351900
		protected void OnCharClick(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCharClickGameObject_hotfix != null)
			{
				this.m_OnCharClickGameObject_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = UnityEngine.Random.Range(0, this.m_roleAnimationList.Length);
			this.PlayAnimation(this.m_roleSkeleton, this.m_roleAnimationList[num], true);
			global::Debug.Log("Click");
		}

		// Token: 0x0600BE83 RID: 48771 RVA: 0x003537A0 File Offset: 0x003519A0
		public void PlaySingleCharAnimation(string animationName, bool isLoop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySingleCharAnimationStringBoolean_hotfix != null)
			{
				this.m_PlaySingleCharAnimationStringBoolean_hotfix.call(new object[]
				{
					this,
					animationName,
					isLoop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.PlayAnimation(this.m_roleSkeleton, animationName, isLoop);
		}

		// Token: 0x0600BE84 RID: 48772 RVA: 0x00353830 File Offset: 0x00351A30
		public void PlayAnimation(SkeletonAnimation skeletonAnimation, string animationName, bool isLoop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationSkeletonAnimationStringBoolean_hotfix != null)
			{
				this.m_PlayAnimationSkeletonAnimationStringBoolean_hotfix.call(new object[]
				{
					this,
					skeletonAnimation,
					animationName,
					isLoop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			skeletonAnimation.AnimationName = string.Empty;
			skeletonAnimation.loop = isLoop;
			skeletonAnimation.AnimationName = animationName;
		}

		// Token: 0x0600BE85 RID: 48773 RVA: 0x003538DC File Offset: 0x00351ADC
		public void PlayAnimation(SkeletonAnimation skeletonAnimation, HeroActionType actionType, bool isLoop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationSkeletonAnimationHeroActionTypeBoolean_hotfix != null)
			{
				this.m_PlayAnimationSkeletonAnimationHeroActionTypeBoolean_hotfix.call(new object[]
				{
					this,
					skeletonAnimation,
					actionType,
					isLoop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			skeletonAnimation.loop = isLoop;
			string animationName = string.Empty;
			switch (actionType)
			{
			case HeroActionType.Idle:
				animationName = "idle";
				break;
			case HeroActionType.Attack:
				animationName = "attack1";
				break;
			case HeroActionType.SuperAttack:
				animationName = "superattack";
				break;
			case HeroActionType.Cast:
				animationName = "cast";
				break;
			case HeroActionType.Dead:
				animationName = "death";
				break;
			case HeroActionType.Sing:
				animationName = "sing";
				break;
			case HeroActionType.Stun:
				animationName = "stun";
				break;
			case HeroActionType.Run:
				animationName = "run";
				break;
			}
			skeletonAnimation.AnimationName = string.Empty;
			skeletonAnimation.AnimationName = animationName;
		}

		// Token: 0x0600BE86 RID: 48774 RVA: 0x00353A10 File Offset: 0x00351C10
		public void SetCharDirection(bool isLookRight)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCharDirectionBoolean_hotfix != null)
			{
				this.m_SetCharDirectionBoolean_hotfix.call(new object[]
				{
					this,
					isLookRight
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetCharDirection(this.m_charNode, isLookRight);
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x00353A90 File Offset: 0x00351C90
		public void SetCharDirection(GameObject charObj, bool isLookRight)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCharDirectionGameObjectBoolean_hotfix != null)
			{
				this.m_SetCharDirectionGameObjectBoolean_hotfix.call(new object[]
				{
					this,
					charObj,
					isLookRight
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isLookRight)
			{
				if (charObj.transform.localScale.x < 0f)
				{
					Vector3 localScale = charObj.transform.localScale;
					localScale.x = -localScale.x;
					charObj.transform.localScale = localScale;
				}
			}
			else if (charObj.transform.localScale.x > 0f)
			{
				Vector3 localScale2 = charObj.transform.localScale;
				localScale2.x = -localScale2.x;
				charObj.transform.localScale = localScale2;
			}
		}

		// Token: 0x0600BE88 RID: 48776 RVA: 0x00353BA4 File Offset: 0x00351DA4
		public void SetCharScale(float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCharScaleSingle_hotfix != null)
			{
				this.m_SetCharScaleSingle_hotfix.call(new object[]
				{
					this,
					scale
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3 localScale = new Vector3(scale, scale, scale);
			this.m_charNode.transform.localScale = localScale;
			this.m_charDrawNode.transform.localScale = localScale;
			for (int i = 0; i < this.m_charGroupNode.transform.childCount; i++)
			{
				Transform child = this.m_charGroupNode.transform.GetChild(i);
				child.localScale = localScale;
			}
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x00353C7C File Offset: 0x00351E7C
		public void SetTeamDistance(float distance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamDistanceSingle_hotfix != null)
			{
				this.m_SetTeamDistanceSingle_hotfix.call(new object[]
				{
					this,
					distance
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < 5; i++)
			{
				Transform child = this.m_charGroupNode.transform.GetChild(i);
				Vector3 localPosition = child.transform.localPosition;
				localPosition.x = (float)(2 - i) * distance;
				child.transform.localPosition = localPosition;
			}
		}

		// Token: 0x0600BE8A RID: 48778 RVA: 0x00353D38 File Offset: 0x00351F38
		public void DestroyChar()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyChar_hotfix != null)
			{
				this.m_DestroyChar_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_roleSkeleton != null)
			{
				UnityEngine.Object.Destroy(this.m_roleSkeleton.gameObject);
			}
			foreach (SkeletonAnimation skeletonAnimation in this.m_roleSkeletonList)
			{
				UnityEngine.Object.Destroy(skeletonAnimation.gameObject);
			}
			this.m_roleSkeletonList.Clear();
		}

		// Token: 0x0600BE8B RID: 48779 RVA: 0x00353E18 File Offset: 0x00352018
		public bool IsFindPlane()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFindPlane_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFindPlane_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.arPlaneTrace.SquareState == ARPlaneTrace.FocusState.Found || this.arPlaneTrace.SquareState == ARPlaneTrace.FocusState.Finding;
		}

		// Token: 0x0600BE8C RID: 48780 RVA: 0x00353EAC File Offset: 0x003520AC
		public void PlaneTraceEnable(bool isActive)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaneTraceEnableBoolean_hotfix != null)
			{
				this.m_PlaneTraceEnableBoolean_hotfix.call(new object[]
				{
					this,
					isActive
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.isPlaneTrace = isActive;
			this.m_focusSquare.SetActive(isActive);
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x0600BE8D RID: 48781 RVA: 0x00353F30 File Offset: 0x00352130
		// (set) Token: 0x0600BE8E RID: 48782 RVA: 0x00353F50 File Offset: 0x00352150
		[DoNotToLua]
		public new ARShowSceneController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ARShowSceneController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BE8F RID: 48783 RVA: 0x00353F5C File Offset: 0x0035215C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600BE90 RID: 48784 RVA: 0x00353F68 File Offset: 0x00352168
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600BE91 RID: 48785 RVA: 0x00353F70 File Offset: 0x00352170
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600BE92 RID: 48786 RVA: 0x00353F78 File Offset: 0x00352178
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600BE93 RID: 48787 RVA: 0x00353F8C File Offset: 0x0035218C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600BE94 RID: 48788 RVA: 0x00353F94 File Offset: 0x00352194
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600BE95 RID: 48789 RVA: 0x00353FA0 File Offset: 0x003521A0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600BE96 RID: 48790 RVA: 0x00353FAC File Offset: 0x003521AC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600BE97 RID: 48791 RVA: 0x00353FB8 File Offset: 0x003521B8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600BE98 RID: 48792 RVA: 0x00353FC4 File Offset: 0x003521C4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600BE99 RID: 48793 RVA: 0x00353FD0 File Offset: 0x003521D0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600BE9A RID: 48794 RVA: 0x00353FDC File Offset: 0x003521DC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600BE9B RID: 48795 RVA: 0x00353FE8 File Offset: 0x003521E8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600BE9C RID: 48796 RVA: 0x00353FF4 File Offset: 0x003521F4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600BE9D RID: 48797 RVA: 0x00354000 File Offset: 0x00352200
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x003541EC File Offset: 0x003523EC
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
					this.m_SetUITaskARUITask_hotfix = (luaObj.RawGet("SetUITask") as LuaFunction);
					this.m_SummonHeroBattleShowInt32_hotfix = (luaObj.RawGet("SummonHeroBattleShow") as LuaFunction);
					this.m_SummonHeroDrawShowInt32_hotfix = (luaObj.RawGet("SummonHeroDrawShow") as LuaFunction);
					this.m_SummonHeroTeamShow_hotfix = (luaObj.RawGet("SummonHeroTeamShow") as LuaFunction);
					this.m_OnCharClickGameObject_hotfix = (luaObj.RawGet("OnCharClick") as LuaFunction);
					this.m_PlaySingleCharAnimationStringBoolean_hotfix = (luaObj.RawGet("PlaySingleCharAnimation") as LuaFunction);
					this.m_PlayAnimationSkeletonAnimationStringBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_PlayAnimationSkeletonAnimationHeroActionTypeBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_SetCharDirectionBoolean_hotfix = (luaObj.RawGet("SetCharDirection") as LuaFunction);
					this.m_SetCharDirectionGameObjectBoolean_hotfix = (luaObj.RawGet("SetCharDirection") as LuaFunction);
					this.m_SetCharScaleSingle_hotfix = (luaObj.RawGet("SetCharScale") as LuaFunction);
					this.m_SetTeamDistanceSingle_hotfix = (luaObj.RawGet("SetTeamDistance") as LuaFunction);
					this.m_DestroyChar_hotfix = (luaObj.RawGet("DestroyChar") as LuaFunction);
					this.m_IsFindPlane_hotfix = (luaObj.RawGet("IsFindPlane") as LuaFunction);
					this.m_PlaneTraceEnableBoolean_hotfix = (luaObj.RawGet("PlaneTraceEnable") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BEA1 RID: 48801 RVA: 0x00354448 File Offset: 0x00352648
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ARShowSceneController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040079EF RID: 31215
		[AutoBind("./ARCamera", AutoBindAttribute.InitState.NotInit, false)]
		private Camera m_camera;

		// Token: 0x040079F0 RID: 31216
		[AutoBind("./FocusSquare/FocusSquare", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_focusSquare;

		// Token: 0x040079F1 RID: 31217
		[AutoBind("./FocusSquare/FocusSquare/Quad", AutoBindAttribute.InitState.NotInit, false)]
		private Renderer m_focusSquareRenderer;

		// Token: 0x040079F2 RID: 31218
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charNode;

		// Token: 0x040079F3 RID: 31219
		[AutoBind("./CharDraw", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charDrawNode;

		// Token: 0x040079F4 RID: 31220
		[AutoBind("./CharGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGroupNode;

		// Token: 0x040079F5 RID: 31221
		private ARPlaneTrace arPlaneTrace = new ARPlaneTrace();

		// Token: 0x040079F6 RID: 31222
		private SkeletonAnimation m_roleSkeleton;

		// Token: 0x040079F7 RID: 31223
		private List<SkeletonAnimation> m_roleSkeletonList = new List<SkeletonAnimation>();

		// Token: 0x040079F8 RID: 31224
		private ARUITask m_task;

		// Token: 0x040079F9 RID: 31225
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040079FA RID: 31226
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040079FB RID: 31227
		private string[] m_roleAnimationList = new string[]
		{
			"idle",
			"attack1",
			"superattack",
			"cast",
			"death",
			"sing",
			"stun",
			"run"
		};

		// Token: 0x040079FC RID: 31228
		private bool isPlaneTrace;

		// Token: 0x040079FD RID: 31229
		[DoNotToLua]
		private ARShowSceneController.LuaExportHelper luaExportHelper;

		// Token: 0x040079FE RID: 31230
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040079FF RID: 31231
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007A00 RID: 31232
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007A01 RID: 31233
		private LuaFunction m_Update_hotfix;

		// Token: 0x04007A02 RID: 31234
		private LuaFunction m_SetUITaskARUITask_hotfix;

		// Token: 0x04007A03 RID: 31235
		private LuaFunction m_SummonHeroBattleShowInt32_hotfix;

		// Token: 0x04007A04 RID: 31236
		private LuaFunction m_SummonHeroDrawShowInt32_hotfix;

		// Token: 0x04007A05 RID: 31237
		private LuaFunction m_SummonHeroTeamShow_hotfix;

		// Token: 0x04007A06 RID: 31238
		private LuaFunction m_OnCharClickGameObject_hotfix;

		// Token: 0x04007A07 RID: 31239
		private LuaFunction m_PlaySingleCharAnimationStringBoolean_hotfix;

		// Token: 0x04007A08 RID: 31240
		private LuaFunction m_PlayAnimationSkeletonAnimationStringBoolean_hotfix;

		// Token: 0x04007A09 RID: 31241
		private LuaFunction m_PlayAnimationSkeletonAnimationHeroActionTypeBoolean_hotfix;

		// Token: 0x04007A0A RID: 31242
		private LuaFunction m_SetCharDirectionBoolean_hotfix;

		// Token: 0x04007A0B RID: 31243
		private LuaFunction m_SetCharDirectionGameObjectBoolean_hotfix;

		// Token: 0x04007A0C RID: 31244
		private LuaFunction m_SetCharScaleSingle_hotfix;

		// Token: 0x04007A0D RID: 31245
		private LuaFunction m_SetTeamDistanceSingle_hotfix;

		// Token: 0x04007A0E RID: 31246
		private LuaFunction m_DestroyChar_hotfix;

		// Token: 0x04007A0F RID: 31247
		private LuaFunction m_IsFindPlane_hotfix;

		// Token: 0x04007A10 RID: 31248
		private LuaFunction m_PlaneTraceEnableBoolean_hotfix;

		// Token: 0x02000B12 RID: 2834
		public new class LuaExportHelper
		{
			// Token: 0x0600BEA2 RID: 48802 RVA: 0x003544B0 File Offset: 0x003526B0
			public LuaExportHelper(ARShowSceneController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BEA3 RID: 48803 RVA: 0x003544C0 File Offset: 0x003526C0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600BEA4 RID: 48804 RVA: 0x003544D0 File Offset: 0x003526D0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600BEA5 RID: 48805 RVA: 0x003544E0 File Offset: 0x003526E0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600BEA6 RID: 48806 RVA: 0x003544F0 File Offset: 0x003526F0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600BEA7 RID: 48807 RVA: 0x00354508 File Offset: 0x00352708
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600BEA8 RID: 48808 RVA: 0x00354518 File Offset: 0x00352718
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600BEA9 RID: 48809 RVA: 0x00354528 File Offset: 0x00352728
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600BEAA RID: 48810 RVA: 0x00354538 File Offset: 0x00352738
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600BEAB RID: 48811 RVA: 0x00354548 File Offset: 0x00352748
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600BEAC RID: 48812 RVA: 0x00354558 File Offset: 0x00352758
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600BEAD RID: 48813 RVA: 0x00354568 File Offset: 0x00352768
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600BEAE RID: 48814 RVA: 0x00354578 File Offset: 0x00352778
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600BEAF RID: 48815 RVA: 0x00354588 File Offset: 0x00352788
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600BEB0 RID: 48816 RVA: 0x00354598 File Offset: 0x00352798
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600BEB1 RID: 48817 RVA: 0x003545A8 File Offset: 0x003527A8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700263B RID: 9787
			// (get) Token: 0x0600BEB2 RID: 48818 RVA: 0x003545B8 File Offset: 0x003527B8
			// (set) Token: 0x0600BEB3 RID: 48819 RVA: 0x003545C8 File Offset: 0x003527C8
			public Camera m_camera
			{
				get
				{
					return this.m_owner.m_camera;
				}
				set
				{
					this.m_owner.m_camera = value;
				}
			}

			// Token: 0x1700263C RID: 9788
			// (get) Token: 0x0600BEB4 RID: 48820 RVA: 0x003545D8 File Offset: 0x003527D8
			// (set) Token: 0x0600BEB5 RID: 48821 RVA: 0x003545E8 File Offset: 0x003527E8
			public GameObject m_focusSquare
			{
				get
				{
					return this.m_owner.m_focusSquare;
				}
				set
				{
					this.m_owner.m_focusSquare = value;
				}
			}

			// Token: 0x1700263D RID: 9789
			// (get) Token: 0x0600BEB6 RID: 48822 RVA: 0x003545F8 File Offset: 0x003527F8
			// (set) Token: 0x0600BEB7 RID: 48823 RVA: 0x00354608 File Offset: 0x00352808
			public Renderer m_focusSquareRenderer
			{
				get
				{
					return this.m_owner.m_focusSquareRenderer;
				}
				set
				{
					this.m_owner.m_focusSquareRenderer = value;
				}
			}

			// Token: 0x1700263E RID: 9790
			// (get) Token: 0x0600BEB8 RID: 48824 RVA: 0x00354618 File Offset: 0x00352818
			// (set) Token: 0x0600BEB9 RID: 48825 RVA: 0x00354628 File Offset: 0x00352828
			public GameObject m_charNode
			{
				get
				{
					return this.m_owner.m_charNode;
				}
				set
				{
					this.m_owner.m_charNode = value;
				}
			}

			// Token: 0x1700263F RID: 9791
			// (get) Token: 0x0600BEBA RID: 48826 RVA: 0x00354638 File Offset: 0x00352838
			// (set) Token: 0x0600BEBB RID: 48827 RVA: 0x00354648 File Offset: 0x00352848
			public GameObject m_charDrawNode
			{
				get
				{
					return this.m_owner.m_charDrawNode;
				}
				set
				{
					this.m_owner.m_charDrawNode = value;
				}
			}

			// Token: 0x17002640 RID: 9792
			// (get) Token: 0x0600BEBC RID: 48828 RVA: 0x00354658 File Offset: 0x00352858
			// (set) Token: 0x0600BEBD RID: 48829 RVA: 0x00354668 File Offset: 0x00352868
			public GameObject m_charGroupNode
			{
				get
				{
					return this.m_owner.m_charGroupNode;
				}
				set
				{
					this.m_owner.m_charGroupNode = value;
				}
			}

			// Token: 0x17002641 RID: 9793
			// (get) Token: 0x0600BEBE RID: 48830 RVA: 0x00354678 File Offset: 0x00352878
			// (set) Token: 0x0600BEBF RID: 48831 RVA: 0x00354688 File Offset: 0x00352888
			public ARPlaneTrace arPlaneTrace
			{
				get
				{
					return this.m_owner.arPlaneTrace;
				}
				set
				{
					this.m_owner.arPlaneTrace = value;
				}
			}

			// Token: 0x17002642 RID: 9794
			// (get) Token: 0x0600BEC0 RID: 48832 RVA: 0x00354698 File Offset: 0x00352898
			// (set) Token: 0x0600BEC1 RID: 48833 RVA: 0x003546A8 File Offset: 0x003528A8
			public SkeletonAnimation m_roleSkeleton
			{
				get
				{
					return this.m_owner.m_roleSkeleton;
				}
				set
				{
					this.m_owner.m_roleSkeleton = value;
				}
			}

			// Token: 0x17002643 RID: 9795
			// (get) Token: 0x0600BEC2 RID: 48834 RVA: 0x003546B8 File Offset: 0x003528B8
			// (set) Token: 0x0600BEC3 RID: 48835 RVA: 0x003546C8 File Offset: 0x003528C8
			public List<SkeletonAnimation> m_roleSkeletonList
			{
				get
				{
					return this.m_owner.m_roleSkeletonList;
				}
				set
				{
					this.m_owner.m_roleSkeletonList = value;
				}
			}

			// Token: 0x17002644 RID: 9796
			// (get) Token: 0x0600BEC4 RID: 48836 RVA: 0x003546D8 File Offset: 0x003528D8
			// (set) Token: 0x0600BEC5 RID: 48837 RVA: 0x003546E8 File Offset: 0x003528E8
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

			// Token: 0x17002645 RID: 9797
			// (get) Token: 0x0600BEC6 RID: 48838 RVA: 0x003546F8 File Offset: 0x003528F8
			// (set) Token: 0x0600BEC7 RID: 48839 RVA: 0x00354708 File Offset: 0x00352908
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

			// Token: 0x17002646 RID: 9798
			// (get) Token: 0x0600BEC8 RID: 48840 RVA: 0x00354718 File Offset: 0x00352918
			// (set) Token: 0x0600BEC9 RID: 48841 RVA: 0x00354728 File Offset: 0x00352928
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

			// Token: 0x17002647 RID: 9799
			// (get) Token: 0x0600BECA RID: 48842 RVA: 0x00354738 File Offset: 0x00352938
			// (set) Token: 0x0600BECB RID: 48843 RVA: 0x00354748 File Offset: 0x00352948
			public string[] m_roleAnimationList
			{
				get
				{
					return this.m_owner.m_roleAnimationList;
				}
				set
				{
					this.m_owner.m_roleAnimationList = value;
				}
			}

			// Token: 0x17002648 RID: 9800
			// (get) Token: 0x0600BECC RID: 48844 RVA: 0x00354758 File Offset: 0x00352958
			// (set) Token: 0x0600BECD RID: 48845 RVA: 0x00354768 File Offset: 0x00352968
			public bool isPlaneTrace
			{
				get
				{
					return this.m_owner.isPlaneTrace;
				}
				set
				{
					this.m_owner.isPlaneTrace = value;
				}
			}

			// Token: 0x0600BECE RID: 48846 RVA: 0x00354778 File Offset: 0x00352978
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600BECF RID: 48847 RVA: 0x00354788 File Offset: 0x00352988
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600BED0 RID: 48848 RVA: 0x00354798 File Offset: 0x00352998
			public void OnCharClick(GameObject obj)
			{
				this.m_owner.OnCharClick(obj);
			}

			// Token: 0x04007A11 RID: 31249
			private ARShowSceneController m_owner;
		}
	}
}
