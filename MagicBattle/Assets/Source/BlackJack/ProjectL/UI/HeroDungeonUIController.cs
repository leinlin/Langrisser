using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E16 RID: 3606
	[HotFix]
	public class HeroDungeonUIController : UIControllerBase
	{
		// Token: 0x06011504 RID: 70916 RVA: 0x0047D45C File Offset: 0x0047B65C
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
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_levelsScrollViewVerticalSnapCenter = this.m_levelsScrollRect.gameObject.AddComponent<ScrollSnapCenter>();
			this.m_levelsScrollViewVerticalSnapCenter.m_itemSize = 190f;
			this.m_levelsScrollViewVerticalSnapCenter.m_scrollSnapDir = ScrollSnapDirection.Vertical;
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_charGameObjectRoot);
			this.m_starRewardButtons = new GainRewardButton[3];
			this.m_starRewardButtons[0] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_starRewardButton1GameObject);
			this.m_starRewardButtons[0].SetId(1);
			this.m_starRewardButtons[0].EventOnClick += this.OnStarRewardButtonClick;
			this.m_starRewardButtons[1] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_starRewardButton2GameObject);
			this.m_starRewardButtons[1].SetId(2);
			this.m_starRewardButtons[1].EventOnClick += this.OnStarRewardButtonClick;
			this.m_starRewardButtons[2] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_starRewardButton3GameObject);
			this.m_starRewardButtons[2].SetId(3);
			this.m_starRewardButtons[2].EventOnClick += this.OnStarRewardButtonClick;
			this.m_starRewardPreviewUIStateController.gameObject.SetActive(false);
			this.m_starRewardPreviewBackgroundButton.onClick.AddListener(new UnityAction(this.OnStarRewardPreviewBackgroundButtonClick));
			base.gameObject.SetActive(true);
			this.m_prefabGameObject.SetActive(false);
		}

		// Token: 0x06011505 RID: 70917 RVA: 0x0047D63C File Offset: 0x0047B83C
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelsScrollRect.content.transform.position = new Vector3(this.m_levelsScrollRect.content.transform.position.x, this.m_levelsScrollRect.content.transform.position.y - 3000f, this.m_levelsScrollRect.content.transform.position.z);
			AudioUtility.PlaySound(SoundTableId.SoundTableId_HeroDungeonEnter);
		}

		// Token: 0x06011506 RID: 70918 RVA: 0x0047D71C File Offset: 0x0047B91C
		private void LateUpdate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LateUpdate_hotfix != null)
			{
				this.m_LateUpdate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Camera componentInParent = base.GetComponentInParent<Camera>();
			if (componentInParent == null)
			{
				return;
			}
			if (this.m_heroDungeonLevelListItems.Count <= 0)
			{
				return;
			}
			Vector2 center = this.m_levelsScrollRect.viewport.rect.center;
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = this.m_heroDungeonLevelListItems[this.m_levelsScrollViewVerticalSnapCenter.GetCenterItemIndex()];
			foreach (HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController2 in this.m_heroDungeonLevelListItems)
			{
				float num = Mathf.Abs(UIUtility.WorldToLocalPosition(heroDungeonLevelListItemUIController2.transform.position, componentInParent, this.m_levelsScrollRect.viewport, componentInParent).y - center.y);
				float num2 = Mathf.Clamp01((1000f - num) / 1000f);
				float num3 = num2 * 0.7f + 0.3f;
				if (heroDungeonLevelListItemUIController2.GetIndex() == 0)
				{
					float num4 = num - this.dy2;
					if (num4 != 0f)
					{
						this.m_rotationCount += num4;
						if (Math.Abs(this.m_rotationCount) > 20f)
						{
							AudioUtility.PlaySound(SoundTableId.SoundTableId_HeroDungeonGearRoll);
							this.m_rotationCount = 0f;
						}
						this.SetCircleRotation(num4);
					}
				}
				RectTransform rectTransform = heroDungeonLevelListItemUIController2.transform as RectTransform;
				rectTransform.localScale = new Vector3(num3, num3, num3);
				Rect rect = this.m_levelsScrollRect.viewport.rect;
				Vector2 vector = (!(this.m_ellipseImage != null)) ? Vector2.zero : new Vector2(this.m_ellipseImage.rectTransform.rect.width * 2f, this.m_ellipseImage.rectTransform.rect.height);
				Vector2 vector2 = new Vector2(317f, -rect.height / 2f);
				float y = rectTransform.parent.localPosition.y;
				List<Vector2> lineOnEllipseIntersection = this.GetLineOnEllipseIntersection(-10.0, (double)vector2.x, (double)(rectTransform.anchoredPosition.y + y), (double)(rectTransform.anchoredPosition.y + y), (double)vector2.x, (double)vector2.y, (double)(vector.x / 2f), (double)(vector.y / 2f));
				Vector2 anchoredPosition = rectTransform.anchoredPosition;
				if (lineOnEllipseIntersection.Count > 0)
				{
					anchoredPosition = lineOnEllipseIntersection[0];
					anchoredPosition.y -= y;
				}
				else if (anchoredPosition.y + y > vector2.y + vector.y / 2f)
				{
					Vector2 vector3 = new Vector2(vector2.x, vector2.y + vector.y / 2f);
					Vector2 vector4 = vector3 + new Vector2(100f, 0f);
					Vector2 p = new Vector2(vector4.x, vector4.y + (float)Math.Tan(0.17453292384743691) * 100f);
					Vector2 p2 = new Vector2(-10f, rectTransform.anchoredPosition.y + y);
					Vector2 p3 = new Vector2(100f, rectTransform.anchoredPosition.y + y);
					Vector2 lineLineIntersection = this.GetLineLineIntersection(vector3, p, p2, p3);
					if (lineLineIntersection != Vector2.zero)
					{
						anchoredPosition = lineLineIntersection;
						anchoredPosition.y -= y;
					}
				}
				else if (anchoredPosition.y + y < vector2.y - vector.y / 2f)
				{
					Vector2 vector5 = new Vector2(vector2.x, vector2.y - vector.y / 2f);
					Vector2 vector6 = vector5 + new Vector2(100f, 0f);
					Vector2 p4 = new Vector2(vector6.x, vector6.y - (float)Math.Tan(0.17453292384743691) * 100f);
					Vector2 p5 = new Vector2(-10f, rectTransform.anchoredPosition.y + y);
					Vector2 p6 = new Vector2(100f, rectTransform.anchoredPosition.y + y);
					Vector2 lineLineIntersection2 = this.GetLineLineIntersection(vector5, p4, p5, p6);
					if (lineLineIntersection2 != Vector2.zero)
					{
						anchoredPosition = lineLineIntersection2;
						anchoredPosition.y -= y;
					}
				}
				rectTransform.anchoredPosition = anchoredPosition;
			}
			if (this.m_curLevelIndex != heroDungeonLevelListItemUIController.GetIndex())
			{
				this.m_curLevelIndex = heroDungeonLevelListItemUIController.GetIndex();
			}
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController3 = this.m_heroDungeonLevelListItems[0];
			this.dy2 = Mathf.Abs(UIUtility.WorldToLocalPosition(heroDungeonLevelListItemUIController3.transform.position, componentInParent, this.m_levelsScrollRect.viewport, componentInParent).y - center.y);
		}

		// Token: 0x06011507 RID: 70919 RVA: 0x0047DCB0 File Offset: 0x0047BEB0
		private List<Vector2> GetLineOnEllipseIntersection(double x1, double x2, double y1, double y2, double midX, double midY, double h, double v)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLineOnEllipseIntersectionDoubleDoubleDoubleDoubleDoubleDoubleDoubleDouble_hotfix != null)
			{
				return (List<Vector2>)this.m_GetLineOnEllipseIntersectionDoubleDoubleDoubleDoubleDoubleDoubleDoubleDouble_hotfix.call(new object[]
				{
					this,
					x1,
					x2,
					y1,
					y2,
					midX,
					midY,
					h,
					v
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Vector2> list = new List<Vector2>();
			x1 -= midX;
			y1 -= midY;
			x2 -= midX;
			y2 -= midY;
			if (x1 == x2)
			{
				double num = v / h * Math.Sqrt(h * h - x1 * x1);
				if (Math.Min(y1, y2) <= num && num <= Math.Max(y1, y2))
				{
					list.Add(new Vector2((float)(x1 + midX), (float)(num + midY)));
				}
				if (Math.Min(y1, y2) <= -num && -num <= Math.Max(y1, y2))
				{
					list.Add(new Vector2((float)(x1 + midX), (float)(-(float)num + midY)));
				}
			}
			else
			{
				double num2 = (y2 - y1) / (x2 - x1);
				double num3 = y1 - num2 * x1;
				double num4 = num2 * num2 * h * h + v * v;
				double num5 = 2.0 * num2 * num3 * h * h;
				double num6 = h * h * num3 * num3 - h * h * v * v;
				double num7 = num5 * num5 - 4.0 * num4 * num6;
				if (num7 > 0.0)
				{
					double num8 = (-num5 + Math.Sqrt(num7)) / (2.0 * num4);
					double num9 = (-num5 - Math.Sqrt(num7)) / (2.0 * num4);
					double num10 = num2 * num8 + num3;
					double num11 = num2 * num9 + num3;
					if (this.isPointInLine(x1, x2, y1, y2, num8, num10))
					{
						list.Add(new Vector2((float)(num8 + midX), (float)(num10 + midY)));
					}
					if (this.isPointInLine(x1, x2, y1, y2, num9, num11))
					{
						list.Add(new Vector2((float)(num9 + midX), (float)(num11 + midY)));
					}
				}
				else if (num7 == 0.0)
				{
					double num12 = -num5 / (2.0 * num4);
					double num13 = num2 * num12 + num3;
					if (this.isPointInLine(x1, x2, y1, y2, num12, num13))
					{
						list.Add(new Vector2((float)(num12 + midX), (float)(num13 + midY)));
					}
				}
			}
			return list;
		}

		// Token: 0x06011508 RID: 70920 RVA: 0x0047DFAC File Offset: 0x0047C1AC
		private bool isPointInLine(double x1, double x2, double y1, double y2, double px, double py)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_isPointInLineDoubleDoubleDoubleDoubleDoubleDouble_hotfix != null)
			{
				return Convert.ToBoolean(this.m_isPointInLineDoubleDoubleDoubleDoubleDoubleDouble_hotfix.call(new object[]
				{
					this,
					x1,
					x2,
					y1,
					y2,
					px,
					py
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			double num = Math.Min(x1, x2);
			double num2 = Math.Max(x1, x2);
			double num3 = Math.Min(y1, y2);
			double num4 = Math.Max(y1, y2);
			return num <= px && px <= num2 && num3 <= py && py <= num4;
		}

		// Token: 0x06011509 RID: 70921 RVA: 0x0047E0C0 File Offset: 0x0047C2C0
		private Vector2 GetLineLineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLineLineIntersectionVector2Vector2Vector2Vector2_hotfix != null)
			{
				return (Vector2)this.m_GetLineLineIntersectionVector2Vector2Vector2Vector2_hotfix.call(new object[]
				{
					this,
					p1,
					p2,
					p3,
					p4
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = p4.x * p2.y - p4.x * p1.y - p3.x * p2.y + p3.x * p1.y - p2.x * p4.y + p2.x * p3.y + p1.x * p4.y - p1.x * p3.y;
			float num2 = p3.y * p4.x * p2.x - p4.y * p3.x * p2.x - p3.y * p4.x * p1.x + p4.y * p3.x * p1.x - p1.y * p2.x * p4.x + p2.y * p1.x * p4.x + p1.y * p2.x * p3.x - p2.y * p1.x * p3.x;
			Vector2 result;
			if (num == 0f)
			{
				result.x = 0f;
			}
			else
			{
				result.x = num2 / num;
			}
			float num3 = p4.y * p2.x - p4.y * p1.x - p3.y * p2.x + p1.x * p3.y - p2.y * p4.x + p2.y * p3.x + p1.y * p4.x - p1.y * p3.x;
			float num4 = -p3.y * p4.x * p2.y + p4.y * p3.x * p2.y + p3.y * p4.x * p1.y - p4.y * p3.x * p1.y + p1.y * p2.x * p4.y - p1.y * p2.x * p3.y - p2.y * p1.x * p4.y + p2.y * p1.x * p3.y;
			if (num3 == 0f)
			{
				result.y = 0f;
			}
			else
			{
				result.y = num4 / num3;
			}
			return result;
		}

		// Token: 0x0601150A RID: 70922 RVA: 0x0047E43C File Offset: 0x0047C63C
		private void SetCircleRotation(float deltaRotation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCircleRotationSingle_hotfix != null)
			{
				this.m_SetCircleRotationSingle_hotfix.call(new object[]
				{
					this,
					deltaRotation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3 eulerAngles = this.m_circle1GameObject.transform.rotation.eulerAngles;
			Vector3 eulerAngles2 = this.m_circle2GameObject.transform.rotation.eulerAngles;
			eulerAngles.z += deltaRotation;
			eulerAngles2.z -= deltaRotation;
			this.m_circle1GameObject.transform.rotation = Quaternion.Euler(eulerAngles);
			this.m_circle2GameObject.transform.rotation = Quaternion.Euler(eulerAngles2);
		}

		// Token: 0x0601150B RID: 70923 RVA: 0x0047E528 File Offset: 0x0047C728
		public void AddHeroDungeonLevelListItem(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroDungeonLevelListItemConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_AddHeroDungeonLevelListItemConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (levelInfo == null)
			{
				return;
			}
			int count = this.m_heroDungeonLevelListItems.Count;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_heroDungeonLevelListItemPrefab);
			gameObject.transform.SetParent(this.m_levelsScrollRect.content, false);
			gameObject.name = count.ToString();
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<HeroDungeonLevelListItemUIController>(gameObject);
			heroDungeonLevelListItemUIController.SetDungeonInfo(levelInfo);
			heroDungeonLevelListItemUIController.SetIndex(count);
			heroDungeonLevelListItemUIController.EventOnClick += this.OnHeroDungeonLevelButtonClick;
			this.m_heroDungeonLevelListItems.Add(heroDungeonLevelListItemUIController);
			this.m_levelsScrollViewVerticalSnapCenter.SetItemCount(this.m_heroDungeonLevelListItems.Count);
			RectTransform rectTransform = gameObject.transform as RectTransform;
			rectTransform.anchoredPosition = this.m_levelsScrollViewVerticalSnapCenter.ComputeItemPosition(count);
		}

		// Token: 0x0601150C RID: 70924 RVA: 0x0047E648 File Offset: 0x0047C848
		public void ClearHeroDungeonLevelListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearHeroDungeonLevelListItems_hotfix != null)
			{
				this.m_ClearHeroDungeonLevelListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<HeroDungeonLevelListItemUIController>(this.m_heroDungeonLevelListItems);
			this.m_heroDungeonLevelListItems.Clear();
			this.m_levelsScrollViewVerticalSnapCenter.SetItemCount(0);
		}

		// Token: 0x0601150D RID: 70925 RVA: 0x0047E6CC File Offset: 0x0047C8CC
		public void UpdateDungeonLevelListItem(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDungeonLevelListItemInt32_hotfix != null)
			{
				this.m_UpdateDungeonLevelListItemInt32_hotfix.call(new object[]
				{
					this,
					levelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController in this.m_heroDungeonLevelListItems)
			{
				ConfigDataHeroDungeonLevelInfo dungeonInfo = heroDungeonLevelListItemUIController.GetDungeonInfo();
				if (dungeonInfo.ID == levelId)
				{
					heroDungeonLevelListItemUIController.SetDungeonInfo(dungeonInfo);
				}
			}
		}

		// Token: 0x0601150E RID: 70926 RVA: 0x0047E7A0 File Offset: 0x0047C9A0
		public void SetCurrentDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_SetCurrentDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curLevelIndex = 0;
			foreach (HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController in this.m_heroDungeonLevelListItems)
			{
				if (heroDungeonLevelListItemUIController.GetDungeonInfo() == levelInfo)
				{
					this.m_curLevelIndex = heroDungeonLevelListItemUIController.GetIndex();
				}
			}
			this.m_levelsScrollViewVerticalSnapCenter.Snap(this.m_curLevelIndex, false);
		}

		// Token: 0x0601150F RID: 70927 RVA: 0x0047E88C File Offset: 0x0047CA8C
		public void SetHeroChar(int heroID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroCharInt32_hotfix != null)
			{
				this.m_SetHeroCharInt32_hotfix.call(new object[]
				{
					this,
					heroID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_playerContext.GetHero(heroID);
			if (hero != null)
			{
				this.m_heroCharUIController.CreateGraphic(hero, HeroCharUIController.PerformanceState.All, true, null);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
			}
		}

		// Token: 0x06011510 RID: 70928 RVA: 0x0047E930 File Offset: 0x0047CB30
		public void SetDungeonStarsProgress(ConfigDataHeroInformationInfo heroDungeonInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDungeonStarsProgressConfigDataHeroInformationInfo_hotfix != null)
			{
				this.m_SetDungeonStarsProgressConfigDataHeroInformationInfo_hotfix.call(new object[]
				{
					this,
					heroDungeonInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroDungeonInfo == null)
			{
				return;
			}
			this.m_starRewardButtons[0].SetNum(heroDungeonInfo.Reward1Star);
			this.m_starRewardButtons[0].SetStatus(this.m_playerContext.GetHeroDungeonStarRewardStatus(heroDungeonInfo.ID, 1));
			this.m_starRewardButtons[1].SetNum(heroDungeonInfo.Reward2Star);
			this.m_starRewardButtons[1].SetStatus(this.m_playerContext.GetHeroDungeonStarRewardStatus(heroDungeonInfo.ID, 2));
			this.m_starRewardButtons[2].SetNum(heroDungeonInfo.Reward3Star);
			this.m_starRewardButtons[2].SetStatus(this.m_playerContext.GetHeroDungeonStarRewardStatus(heroDungeonInfo.ID, 3));
			this.m_progressText.text = string.Concat(new object[]
			{
				this.m_playerContext.GetHeroDungeonChapterGainStars(heroDungeonInfo.ID),
				"/<color=white>",
				heroDungeonInfo.Reward3Star,
				"</color>"
			});
			this.m_progressImage.fillAmount = (float)this.m_playerContext.GetHeroDungeonChapterGainStars(heroDungeonInfo.ID) / (float)heroDungeonInfo.Reward3Star;
			this.m_heroDungeonInfo = heroDungeonInfo;
			this.m_progressGameObject.SetActive(true);
		}

		// Token: 0x06011511 RID: 70929 RVA: 0x0047EAC4 File Offset: 0x0047CCC4
		private void OnStarRewardButtonClick(GainRewardButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStarRewardButtonClickGainRewardButton_hotfix != null)
			{
				this.m_OnStarRewardButtonClickGainRewardButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (b.GetStatus() == GainRewardStatus.CanNotGet)
			{
				this.AddStarRewardPreviewGoods(this.m_heroDungeonInfo, b.GetId());
				UIUtility.SetUIStateOpen(this.m_starRewardPreviewUIStateController, "PanelOpen", null, false, true);
				return;
			}
			if (this.EventOnGetStarReward != null)
			{
				this.EventOnGetStarReward(b.GetId());
			}
		}

		// Token: 0x06011512 RID: 70930 RVA: 0x0047EB84 File Offset: 0x0047CD84
		private void AddStarRewardPreviewGoods(ConfigDataHeroInformationInfo heroDungeonInfo, int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddStarRewardPreviewGoodsConfigDataHeroInformationInfoInt32_hotfix != null)
			{
				this.m_AddStarRewardPreviewGoodsConfigDataHeroInformationInfoInt32_hotfix.call(new object[]
				{
					this,
					heroDungeonInfo,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroDungeonInfo == null)
			{
				return;
			}
			GameObjectUtility.DestroyChildren(this.m_starRewardPreviewScrollRect.content.gameObject);
			List<Goods> goods = null;
			if (idx == 1)
			{
				goods = heroDungeonInfo.Reward1;
			}
			else if (idx == 2)
			{
				goods = heroDungeonInfo.Reward2;
			}
			else if (idx == 3)
			{
				goods = heroDungeonInfo.Reward3;
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoodsList(goods, this.m_starRewardPreviewScrollRect.content, assetInContainer, null, true, 1, true);
		}

		// Token: 0x06011513 RID: 70931 RVA: 0x0047EC78 File Offset: 0x0047CE78
		public void SetChallengeCountValueText(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChallengeCountValueTextInt32_hotfix != null)
			{
				this.m_SetChallengeCountValueTextInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_challengeCountValueText.text = count.ToString();
		}

		// Token: 0x06011514 RID: 70932 RVA: 0x0047ED00 File Offset: 0x0047CF00
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x06011515 RID: 70933 RVA: 0x0047ED78 File Offset: 0x0047CF78
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x06011516 RID: 70934 RVA: 0x0047EDF0 File Offset: 0x0047CFF0
		private void OnHeroDungeonLevelButtonClick(HeroDungeonLevelListItemUIController b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroDungeonLevelButtonClickHeroDungeonLevelListItemUIController_hotfix != null)
			{
				this.m_OnHeroDungeonLevelButtonClickHeroDungeonLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (b.GetIndex() == this.m_curLevelIndex)
			{
				if (b.IsFavorLevelLock())
				{
					CommonUIController.Instance.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockCondition_HeroDungeonLevel), b.GetDungeonInfo().UnlockConditions[0].Param2), 2f, null, true);
				}
				else if (b.IsPreLevelLock())
				{
					CommonUIController.Instance.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_PreLevelCompleteOpen), new object[0]), 2f, null, true);
				}
				else if (this.EventOnSelectDungeonLevel != null)
				{
					this.EventOnSelectDungeonLevel(b.GetDungeonInfo());
				}
			}
			else
			{
				this.m_levelsScrollViewVerticalSnapCenter.Snap(b.GetIndex(), true);
			}
		}

		// Token: 0x06011517 RID: 70935 RVA: 0x0047EF34 File Offset: 0x0047D134
		private void OnStarRewardPreviewBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStarRewardPreviewBackgroundButtonClick_hotfix != null)
			{
				this.m_OnStarRewardPreviewBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_starRewardPreviewUIStateController, "PanelClose", null, false, true);
		}

		// Token: 0x140003B8 RID: 952
		// (add) Token: 0x06011518 RID: 70936 RVA: 0x0047EFA8 File Offset: 0x0047D1A8
		// (remove) Token: 0x06011519 RID: 70937 RVA: 0x0047F044 File Offset: 0x0047D244
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003B9 RID: 953
		// (add) Token: 0x0601151A RID: 70938 RVA: 0x0047F0E0 File Offset: 0x0047D2E0
		// (remove) Token: 0x0601151B RID: 70939 RVA: 0x0047F17C File Offset: 0x0047D37C
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003BA RID: 954
		// (add) Token: 0x0601151C RID: 70940 RVA: 0x0047F218 File Offset: 0x0047D418
		// (remove) Token: 0x0601151D RID: 70941 RVA: 0x0047F2B4 File Offset: 0x0047D4B4
		public event Action<int> EventOnGetStarReward
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetStarRewardAction`1_hotfix != null)
				{
					this.m_add_EventOnGetStarRewardAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGetStarReward;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGetStarReward, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetStarRewardAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetStarRewardAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGetStarReward;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGetStarReward, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003BB RID: 955
		// (add) Token: 0x0601151E RID: 70942 RVA: 0x0047F350 File Offset: 0x0047D550
		// (remove) Token: 0x0601151F RID: 70943 RVA: 0x0047F3EC File Offset: 0x0047D5EC
		public event Action<ConfigDataHeroDungeonLevelInfo> EventOnSelectDungeonLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectDungeonLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnSelectDungeonLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataHeroDungeonLevelInfo> action = this.EventOnSelectDungeonLevel;
				Action<ConfigDataHeroDungeonLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataHeroDungeonLevelInfo>>(ref this.EventOnSelectDungeonLevel, (Action<ConfigDataHeroDungeonLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectDungeonLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnSelectDungeonLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataHeroDungeonLevelInfo> action = this.EventOnSelectDungeonLevel;
				Action<ConfigDataHeroDungeonLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataHeroDungeonLevelInfo>>(ref this.EventOnSelectDungeonLevel, (Action<ConfigDataHeroDungeonLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x06011520 RID: 70944 RVA: 0x0047F488 File Offset: 0x0047D688
		// (set) Token: 0x06011521 RID: 70945 RVA: 0x0047F4A8 File Offset: 0x0047D6A8
		[DoNotToLua]
		public new HeroDungeonUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDungeonUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011522 RID: 70946 RVA: 0x0047F4B4 File Offset: 0x0047D6B4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011523 RID: 70947 RVA: 0x0047F4C0 File Offset: 0x0047D6C0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011524 RID: 70948 RVA: 0x0047F4C8 File Offset: 0x0047D6C8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011525 RID: 70949 RVA: 0x0047F4D0 File Offset: 0x0047D6D0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011526 RID: 70950 RVA: 0x0047F4E4 File Offset: 0x0047D6E4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011527 RID: 70951 RVA: 0x0047F4EC File Offset: 0x0047D6EC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011528 RID: 70952 RVA: 0x0047F4F8 File Offset: 0x0047D6F8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011529 RID: 70953 RVA: 0x0047F504 File Offset: 0x0047D704
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601152A RID: 70954 RVA: 0x0047F510 File Offset: 0x0047D710
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601152B RID: 70955 RVA: 0x0047F51C File Offset: 0x0047D71C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601152C RID: 70956 RVA: 0x0047F528 File Offset: 0x0047D728
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601152D RID: 70957 RVA: 0x0047F534 File Offset: 0x0047D734
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601152E RID: 70958 RVA: 0x0047F540 File Offset: 0x0047D740
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601152F RID: 70959 RVA: 0x0047F54C File Offset: 0x0047D74C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011530 RID: 70960 RVA: 0x0047F558 File Offset: 0x0047D758
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011531 RID: 70961 RVA: 0x0047F560 File Offset: 0x0047D760
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06011532 RID: 70962 RVA: 0x0047F580 File Offset: 0x0047D780
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06011533 RID: 70963 RVA: 0x0047F58C File Offset: 0x0047D78C
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x06011534 RID: 70964 RVA: 0x0047F5AC File Offset: 0x0047D7AC
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x06011535 RID: 70965 RVA: 0x0047F5B8 File Offset: 0x0047D7B8
		private void __callDele_EventOnGetStarReward(int obj)
		{
			Action<int> eventOnGetStarReward = this.EventOnGetStarReward;
			if (eventOnGetStarReward != null)
			{
				eventOnGetStarReward(obj);
			}
		}

		// Token: 0x06011536 RID: 70966 RVA: 0x0047F5DC File Offset: 0x0047D7DC
		private void __clearDele_EventOnGetStarReward(int obj)
		{
			this.EventOnGetStarReward = null;
		}

		// Token: 0x06011537 RID: 70967 RVA: 0x0047F5E8 File Offset: 0x0047D7E8
		private void __callDele_EventOnSelectDungeonLevel(ConfigDataHeroDungeonLevelInfo obj)
		{
			Action<ConfigDataHeroDungeonLevelInfo> eventOnSelectDungeonLevel = this.EventOnSelectDungeonLevel;
			if (eventOnSelectDungeonLevel != null)
			{
				eventOnSelectDungeonLevel(obj);
			}
		}

		// Token: 0x06011538 RID: 70968 RVA: 0x0047F60C File Offset: 0x0047D80C
		private void __clearDele_EventOnSelectDungeonLevel(ConfigDataHeroDungeonLevelInfo obj)
		{
			this.EventOnSelectDungeonLevel = null;
		}

		// Token: 0x06011539 RID: 70969 RVA: 0x0047F618 File Offset: 0x0047D818
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_LateUpdate_hotfix = (luaObj.RawGet("LateUpdate") as LuaFunction);
					this.m_GetLineOnEllipseIntersectionDoubleDoubleDoubleDoubleDoubleDoubleDoubleDouble_hotfix = (luaObj.RawGet("GetLineOnEllipseIntersection") as LuaFunction);
					this.m_isPointInLineDoubleDoubleDoubleDoubleDoubleDouble_hotfix = (luaObj.RawGet("isPointInLine") as LuaFunction);
					this.m_GetLineLineIntersectionVector2Vector2Vector2Vector2_hotfix = (luaObj.RawGet("GetLineLineIntersection") as LuaFunction);
					this.m_SetCircleRotationSingle_hotfix = (luaObj.RawGet("SetCircleRotation") as LuaFunction);
					this.m_AddHeroDungeonLevelListItemConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("AddHeroDungeonLevelListItem") as LuaFunction);
					this.m_ClearHeroDungeonLevelListItems_hotfix = (luaObj.RawGet("ClearHeroDungeonLevelListItems") as LuaFunction);
					this.m_UpdateDungeonLevelListItemInt32_hotfix = (luaObj.RawGet("UpdateDungeonLevelListItem") as LuaFunction);
					this.m_SetCurrentDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("SetCurrentDungeonLevel") as LuaFunction);
					this.m_SetHeroCharInt32_hotfix = (luaObj.RawGet("SetHeroChar") as LuaFunction);
					this.m_SetDungeonStarsProgressConfigDataHeroInformationInfo_hotfix = (luaObj.RawGet("SetDungeonStarsProgress") as LuaFunction);
					this.m_OnStarRewardButtonClickGainRewardButton_hotfix = (luaObj.RawGet("OnStarRewardButtonClick") as LuaFunction);
					this.m_AddStarRewardPreviewGoodsConfigDataHeroInformationInfoInt32_hotfix = (luaObj.RawGet("AddStarRewardPreviewGoods") as LuaFunction);
					this.m_SetChallengeCountValueTextInt32_hotfix = (luaObj.RawGet("SetChallengeCountValueText") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnHeroDungeonLevelButtonClickHeroDungeonLevelListItemUIController_hotfix = (luaObj.RawGet("OnHeroDungeonLevelButtonClick") as LuaFunction);
					this.m_OnStarRewardPreviewBackgroundButtonClick_hotfix = (luaObj.RawGet("OnStarRewardPreviewBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnGetStarRewardAction`1_hotfix = (luaObj.RawGet("add_EventOnGetStarReward") as LuaFunction);
					this.m_remove_EventOnGetStarRewardAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetStarReward") as LuaFunction);
					this.m_add_EventOnSelectDungeonLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnSelectDungeonLevel") as LuaFunction);
					this.m_remove_EventOnSelectDungeonLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnSelectDungeonLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601153A RID: 70970 RVA: 0x0047F988 File Offset: 0x0047DB88
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009EA5 RID: 40613
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04009EA6 RID: 40614
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04009EA7 RID: 40615
		[AutoBind("./HeroCharPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObjectRoot;

		// Token: 0x04009EA8 RID: 40616
		[AutoBind("./EventGroup/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_levelsScrollRect;

		// Token: 0x04009EA9 RID: 40617
		[AutoBind("./ChallengeCount/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_challengeCountValueText;

		// Token: 0x04009EAA RID: 40618
		[AutoBind("./Progress", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_progressGameObject;

		// Token: 0x04009EAB RID: 40619
		[AutoBind("./Progress/VictoryPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressText;

		// Token: 0x04009EAC RID: 40620
		[AutoBind("./Progress/VictoryPointsReward/BarFrame/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_progressImage;

		// Token: 0x04009EAD RID: 40621
		[AutoBind("./Progress/VictoryPointsReward/Button1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starRewardButton1GameObject;

		// Token: 0x04009EAE RID: 40622
		[AutoBind("./Progress/VictoryPointsReward/Button2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starRewardButton2GameObject;

		// Token: 0x04009EAF RID: 40623
		[AutoBind("./Progress/VictoryPointsReward/Button3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starRewardButton3GameObject;

		// Token: 0x04009EB0 RID: 40624
		[AutoBind("./StarRewardPreview", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_starRewardPreviewUIStateController;

		// Token: 0x04009EB1 RID: 40625
		[AutoBind("./StarRewardPreview/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_starRewardPreviewBackgroundButton;

		// Token: 0x04009EB2 RID: 40626
		[AutoBind("./StarRewardPreview/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_starRewardPreviewScrollRect;

		// Token: 0x04009EB3 RID: 40627
		[AutoBind("./EventGroup/TurntableImage/Circle1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_circle1GameObject;

		// Token: 0x04009EB4 RID: 40628
		[AutoBind("./EventGroup/TurntableImage/Circle2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_circle2GameObject;

		// Token: 0x04009EB5 RID: 40629
		[AutoBind("./Prefab", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_prefabGameObject;

		// Token: 0x04009EB6 RID: 40630
		[AutoBind("./Prefab/HeroDungeonLevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroDungeonLevelListItemPrefab;

		// Token: 0x04009EB7 RID: 40631
		[AutoBind("./EventGroup/TurntableImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_ellipseImage;

		// Token: 0x04009EB8 RID: 40632
		private List<HeroDungeonLevelListItemUIController> m_heroDungeonLevelListItems = new List<HeroDungeonLevelListItemUIController>();

		// Token: 0x04009EB9 RID: 40633
		private const int gearRollThreasholdValue = 20;

		// Token: 0x04009EBA RID: 40634
		private float m_rotationCount;

		// Token: 0x04009EBB RID: 40635
		private int m_curLevelIndex;

		// Token: 0x04009EBC RID: 40636
		private float dy2;

		// Token: 0x04009EBD RID: 40637
		private GainRewardButton[] m_starRewardButtons;

		// Token: 0x04009EBE RID: 40638
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x04009EBF RID: 40639
		private ConfigDataHeroInformationInfo m_heroDungeonInfo;

		// Token: 0x04009EC0 RID: 40640
		private ScrollSnapCenter m_levelsScrollViewVerticalSnapCenter;

		// Token: 0x04009EC1 RID: 40641
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04009EC2 RID: 40642
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04009EC3 RID: 40643
		[DoNotToLua]
		private HeroDungeonUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009EC4 RID: 40644
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009EC5 RID: 40645
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009EC6 RID: 40646
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009EC7 RID: 40647
		private LuaFunction m_Open_hotfix;

		// Token: 0x04009EC8 RID: 40648
		private LuaFunction m_LateUpdate_hotfix;

		// Token: 0x04009EC9 RID: 40649
		private LuaFunction m_GetLineOnEllipseIntersectionDoubleDoubleDoubleDoubleDoubleDoubleDoubleDouble_hotfix;

		// Token: 0x04009ECA RID: 40650
		private LuaFunction m_isPointInLineDoubleDoubleDoubleDoubleDoubleDouble_hotfix;

		// Token: 0x04009ECB RID: 40651
		private LuaFunction m_GetLineLineIntersectionVector2Vector2Vector2Vector2_hotfix;

		// Token: 0x04009ECC RID: 40652
		private LuaFunction m_SetCircleRotationSingle_hotfix;

		// Token: 0x04009ECD RID: 40653
		private LuaFunction m_AddHeroDungeonLevelListItemConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x04009ECE RID: 40654
		private LuaFunction m_ClearHeroDungeonLevelListItems_hotfix;

		// Token: 0x04009ECF RID: 40655
		private LuaFunction m_UpdateDungeonLevelListItemInt32_hotfix;

		// Token: 0x04009ED0 RID: 40656
		private LuaFunction m_SetCurrentDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x04009ED1 RID: 40657
		private LuaFunction m_SetHeroCharInt32_hotfix;

		// Token: 0x04009ED2 RID: 40658
		private LuaFunction m_SetDungeonStarsProgressConfigDataHeroInformationInfo_hotfix;

		// Token: 0x04009ED3 RID: 40659
		private LuaFunction m_OnStarRewardButtonClickGainRewardButton_hotfix;

		// Token: 0x04009ED4 RID: 40660
		private LuaFunction m_AddStarRewardPreviewGoodsConfigDataHeroInformationInfoInt32_hotfix;

		// Token: 0x04009ED5 RID: 40661
		private LuaFunction m_SetChallengeCountValueTextInt32_hotfix;

		// Token: 0x04009ED6 RID: 40662
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009ED7 RID: 40663
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04009ED8 RID: 40664
		private LuaFunction m_OnHeroDungeonLevelButtonClickHeroDungeonLevelListItemUIController_hotfix;

		// Token: 0x04009ED9 RID: 40665
		private LuaFunction m_OnStarRewardPreviewBackgroundButtonClick_hotfix;

		// Token: 0x04009EDA RID: 40666
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04009EDB RID: 40667
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009EDC RID: 40668
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04009EDD RID: 40669
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04009EDE RID: 40670
		private LuaFunction m_add_EventOnGetStarRewardAction;

		// Token: 0x04009EDF RID: 40671
		private LuaFunction m_remove_EventOnGetStarRewardAction;

		// Token: 0x04009EE0 RID: 40672
		private LuaFunction m_add_EventOnSelectDungeonLevelAction;

		// Token: 0x04009EE1 RID: 40673
		private LuaFunction m_remove_EventOnSelectDungeonLevelAction;

		// Token: 0x02000E17 RID: 3607
		public new class LuaExportHelper
		{
			// Token: 0x0601153B RID: 70971 RVA: 0x0047F9F0 File Offset: 0x0047DBF0
			public LuaExportHelper(HeroDungeonUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601153C RID: 70972 RVA: 0x0047FA00 File Offset: 0x0047DC00
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601153D RID: 70973 RVA: 0x0047FA10 File Offset: 0x0047DC10
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601153E RID: 70974 RVA: 0x0047FA20 File Offset: 0x0047DC20
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601153F RID: 70975 RVA: 0x0047FA30 File Offset: 0x0047DC30
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011540 RID: 70976 RVA: 0x0047FA48 File Offset: 0x0047DC48
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011541 RID: 70977 RVA: 0x0047FA58 File Offset: 0x0047DC58
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011542 RID: 70978 RVA: 0x0047FA68 File Offset: 0x0047DC68
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011543 RID: 70979 RVA: 0x0047FA78 File Offset: 0x0047DC78
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011544 RID: 70980 RVA: 0x0047FA88 File Offset: 0x0047DC88
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011545 RID: 70981 RVA: 0x0047FA98 File Offset: 0x0047DC98
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011546 RID: 70982 RVA: 0x0047FAA8 File Offset: 0x0047DCA8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011547 RID: 70983 RVA: 0x0047FAB8 File Offset: 0x0047DCB8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011548 RID: 70984 RVA: 0x0047FAC8 File Offset: 0x0047DCC8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011549 RID: 70985 RVA: 0x0047FAD8 File Offset: 0x0047DCD8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601154A RID: 70986 RVA: 0x0047FAE8 File Offset: 0x0047DCE8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601154B RID: 70987 RVA: 0x0047FAF8 File Offset: 0x0047DCF8
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0601154C RID: 70988 RVA: 0x0047FB08 File Offset: 0x0047DD08
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0601154D RID: 70989 RVA: 0x0047FB18 File Offset: 0x0047DD18
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0601154E RID: 70990 RVA: 0x0047FB28 File Offset: 0x0047DD28
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0601154F RID: 70991 RVA: 0x0047FB38 File Offset: 0x0047DD38
			public void __callDele_EventOnGetStarReward(int obj)
			{
				this.m_owner.__callDele_EventOnGetStarReward(obj);
			}

			// Token: 0x06011550 RID: 70992 RVA: 0x0047FB48 File Offset: 0x0047DD48
			public void __clearDele_EventOnGetStarReward(int obj)
			{
				this.m_owner.__clearDele_EventOnGetStarReward(obj);
			}

			// Token: 0x06011551 RID: 70993 RVA: 0x0047FB58 File Offset: 0x0047DD58
			public void __callDele_EventOnSelectDungeonLevel(ConfigDataHeroDungeonLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnSelectDungeonLevel(obj);
			}

			// Token: 0x06011552 RID: 70994 RVA: 0x0047FB68 File Offset: 0x0047DD68
			public void __clearDele_EventOnSelectDungeonLevel(ConfigDataHeroDungeonLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnSelectDungeonLevel(obj);
			}

			// Token: 0x17003557 RID: 13655
			// (get) Token: 0x06011553 RID: 70995 RVA: 0x0047FB78 File Offset: 0x0047DD78
			// (set) Token: 0x06011554 RID: 70996 RVA: 0x0047FB88 File Offset: 0x0047DD88
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

			// Token: 0x17003558 RID: 13656
			// (get) Token: 0x06011555 RID: 70997 RVA: 0x0047FB98 File Offset: 0x0047DD98
			// (set) Token: 0x06011556 RID: 70998 RVA: 0x0047FBA8 File Offset: 0x0047DDA8
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x17003559 RID: 13657
			// (get) Token: 0x06011557 RID: 70999 RVA: 0x0047FBB8 File Offset: 0x0047DDB8
			// (set) Token: 0x06011558 RID: 71000 RVA: 0x0047FBC8 File Offset: 0x0047DDC8
			public GameObject m_charGameObjectRoot
			{
				get
				{
					return this.m_owner.m_charGameObjectRoot;
				}
				set
				{
					this.m_owner.m_charGameObjectRoot = value;
				}
			}

			// Token: 0x1700355A RID: 13658
			// (get) Token: 0x06011559 RID: 71001 RVA: 0x0047FBD8 File Offset: 0x0047DDD8
			// (set) Token: 0x0601155A RID: 71002 RVA: 0x0047FBE8 File Offset: 0x0047DDE8
			public ScrollRect m_levelsScrollRect
			{
				get
				{
					return this.m_owner.m_levelsScrollRect;
				}
				set
				{
					this.m_owner.m_levelsScrollRect = value;
				}
			}

			// Token: 0x1700355B RID: 13659
			// (get) Token: 0x0601155B RID: 71003 RVA: 0x0047FBF8 File Offset: 0x0047DDF8
			// (set) Token: 0x0601155C RID: 71004 RVA: 0x0047FC08 File Offset: 0x0047DE08
			public Text m_challengeCountValueText
			{
				get
				{
					return this.m_owner.m_challengeCountValueText;
				}
				set
				{
					this.m_owner.m_challengeCountValueText = value;
				}
			}

			// Token: 0x1700355C RID: 13660
			// (get) Token: 0x0601155D RID: 71005 RVA: 0x0047FC18 File Offset: 0x0047DE18
			// (set) Token: 0x0601155E RID: 71006 RVA: 0x0047FC28 File Offset: 0x0047DE28
			public GameObject m_progressGameObject
			{
				get
				{
					return this.m_owner.m_progressGameObject;
				}
				set
				{
					this.m_owner.m_progressGameObject = value;
				}
			}

			// Token: 0x1700355D RID: 13661
			// (get) Token: 0x0601155F RID: 71007 RVA: 0x0047FC38 File Offset: 0x0047DE38
			// (set) Token: 0x06011560 RID: 71008 RVA: 0x0047FC48 File Offset: 0x0047DE48
			public Text m_progressText
			{
				get
				{
					return this.m_owner.m_progressText;
				}
				set
				{
					this.m_owner.m_progressText = value;
				}
			}

			// Token: 0x1700355E RID: 13662
			// (get) Token: 0x06011561 RID: 71009 RVA: 0x0047FC58 File Offset: 0x0047DE58
			// (set) Token: 0x06011562 RID: 71010 RVA: 0x0047FC68 File Offset: 0x0047DE68
			public Image m_progressImage
			{
				get
				{
					return this.m_owner.m_progressImage;
				}
				set
				{
					this.m_owner.m_progressImage = value;
				}
			}

			// Token: 0x1700355F RID: 13663
			// (get) Token: 0x06011563 RID: 71011 RVA: 0x0047FC78 File Offset: 0x0047DE78
			// (set) Token: 0x06011564 RID: 71012 RVA: 0x0047FC88 File Offset: 0x0047DE88
			public GameObject m_starRewardButton1GameObject
			{
				get
				{
					return this.m_owner.m_starRewardButton1GameObject;
				}
				set
				{
					this.m_owner.m_starRewardButton1GameObject = value;
				}
			}

			// Token: 0x17003560 RID: 13664
			// (get) Token: 0x06011565 RID: 71013 RVA: 0x0047FC98 File Offset: 0x0047DE98
			// (set) Token: 0x06011566 RID: 71014 RVA: 0x0047FCA8 File Offset: 0x0047DEA8
			public GameObject m_starRewardButton2GameObject
			{
				get
				{
					return this.m_owner.m_starRewardButton2GameObject;
				}
				set
				{
					this.m_owner.m_starRewardButton2GameObject = value;
				}
			}

			// Token: 0x17003561 RID: 13665
			// (get) Token: 0x06011567 RID: 71015 RVA: 0x0047FCB8 File Offset: 0x0047DEB8
			// (set) Token: 0x06011568 RID: 71016 RVA: 0x0047FCC8 File Offset: 0x0047DEC8
			public GameObject m_starRewardButton3GameObject
			{
				get
				{
					return this.m_owner.m_starRewardButton3GameObject;
				}
				set
				{
					this.m_owner.m_starRewardButton3GameObject = value;
				}
			}

			// Token: 0x17003562 RID: 13666
			// (get) Token: 0x06011569 RID: 71017 RVA: 0x0047FCD8 File Offset: 0x0047DED8
			// (set) Token: 0x0601156A RID: 71018 RVA: 0x0047FCE8 File Offset: 0x0047DEE8
			public CommonUIStateController m_starRewardPreviewUIStateController
			{
				get
				{
					return this.m_owner.m_starRewardPreviewUIStateController;
				}
				set
				{
					this.m_owner.m_starRewardPreviewUIStateController = value;
				}
			}

			// Token: 0x17003563 RID: 13667
			// (get) Token: 0x0601156B RID: 71019 RVA: 0x0047FCF8 File Offset: 0x0047DEF8
			// (set) Token: 0x0601156C RID: 71020 RVA: 0x0047FD08 File Offset: 0x0047DF08
			public Button m_starRewardPreviewBackgroundButton
			{
				get
				{
					return this.m_owner.m_starRewardPreviewBackgroundButton;
				}
				set
				{
					this.m_owner.m_starRewardPreviewBackgroundButton = value;
				}
			}

			// Token: 0x17003564 RID: 13668
			// (get) Token: 0x0601156D RID: 71021 RVA: 0x0047FD18 File Offset: 0x0047DF18
			// (set) Token: 0x0601156E RID: 71022 RVA: 0x0047FD28 File Offset: 0x0047DF28
			public ScrollRect m_starRewardPreviewScrollRect
			{
				get
				{
					return this.m_owner.m_starRewardPreviewScrollRect;
				}
				set
				{
					this.m_owner.m_starRewardPreviewScrollRect = value;
				}
			}

			// Token: 0x17003565 RID: 13669
			// (get) Token: 0x0601156F RID: 71023 RVA: 0x0047FD38 File Offset: 0x0047DF38
			// (set) Token: 0x06011570 RID: 71024 RVA: 0x0047FD48 File Offset: 0x0047DF48
			public GameObject m_circle1GameObject
			{
				get
				{
					return this.m_owner.m_circle1GameObject;
				}
				set
				{
					this.m_owner.m_circle1GameObject = value;
				}
			}

			// Token: 0x17003566 RID: 13670
			// (get) Token: 0x06011571 RID: 71025 RVA: 0x0047FD58 File Offset: 0x0047DF58
			// (set) Token: 0x06011572 RID: 71026 RVA: 0x0047FD68 File Offset: 0x0047DF68
			public GameObject m_circle2GameObject
			{
				get
				{
					return this.m_owner.m_circle2GameObject;
				}
				set
				{
					this.m_owner.m_circle2GameObject = value;
				}
			}

			// Token: 0x17003567 RID: 13671
			// (get) Token: 0x06011573 RID: 71027 RVA: 0x0047FD78 File Offset: 0x0047DF78
			// (set) Token: 0x06011574 RID: 71028 RVA: 0x0047FD88 File Offset: 0x0047DF88
			public GameObject m_prefabGameObject
			{
				get
				{
					return this.m_owner.m_prefabGameObject;
				}
				set
				{
					this.m_owner.m_prefabGameObject = value;
				}
			}

			// Token: 0x17003568 RID: 13672
			// (get) Token: 0x06011575 RID: 71029 RVA: 0x0047FD98 File Offset: 0x0047DF98
			// (set) Token: 0x06011576 RID: 71030 RVA: 0x0047FDA8 File Offset: 0x0047DFA8
			public GameObject m_heroDungeonLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_heroDungeonLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_heroDungeonLevelListItemPrefab = value;
				}
			}

			// Token: 0x17003569 RID: 13673
			// (get) Token: 0x06011577 RID: 71031 RVA: 0x0047FDB8 File Offset: 0x0047DFB8
			// (set) Token: 0x06011578 RID: 71032 RVA: 0x0047FDC8 File Offset: 0x0047DFC8
			public Image m_ellipseImage
			{
				get
				{
					return this.m_owner.m_ellipseImage;
				}
				set
				{
					this.m_owner.m_ellipseImage = value;
				}
			}

			// Token: 0x1700356A RID: 13674
			// (get) Token: 0x06011579 RID: 71033 RVA: 0x0047FDD8 File Offset: 0x0047DFD8
			// (set) Token: 0x0601157A RID: 71034 RVA: 0x0047FDE8 File Offset: 0x0047DFE8
			public List<HeroDungeonLevelListItemUIController> m_heroDungeonLevelListItems
			{
				get
				{
					return this.m_owner.m_heroDungeonLevelListItems;
				}
				set
				{
					this.m_owner.m_heroDungeonLevelListItems = value;
				}
			}

			// Token: 0x1700356B RID: 13675
			// (get) Token: 0x0601157B RID: 71035 RVA: 0x0047FDF8 File Offset: 0x0047DFF8
			public static int gearRollThreasholdValue
			{
				get
				{
					return 20;
				}
			}

			// Token: 0x1700356C RID: 13676
			// (get) Token: 0x0601157C RID: 71036 RVA: 0x0047FDFC File Offset: 0x0047DFFC
			// (set) Token: 0x0601157D RID: 71037 RVA: 0x0047FE0C File Offset: 0x0047E00C
			public float m_rotationCount
			{
				get
				{
					return this.m_owner.m_rotationCount;
				}
				set
				{
					this.m_owner.m_rotationCount = value;
				}
			}

			// Token: 0x1700356D RID: 13677
			// (get) Token: 0x0601157E RID: 71038 RVA: 0x0047FE1C File Offset: 0x0047E01C
			// (set) Token: 0x0601157F RID: 71039 RVA: 0x0047FE2C File Offset: 0x0047E02C
			public int m_curLevelIndex
			{
				get
				{
					return this.m_owner.m_curLevelIndex;
				}
				set
				{
					this.m_owner.m_curLevelIndex = value;
				}
			}

			// Token: 0x1700356E RID: 13678
			// (get) Token: 0x06011580 RID: 71040 RVA: 0x0047FE3C File Offset: 0x0047E03C
			// (set) Token: 0x06011581 RID: 71041 RVA: 0x0047FE4C File Offset: 0x0047E04C
			public float dy2
			{
				get
				{
					return this.m_owner.dy2;
				}
				set
				{
					this.m_owner.dy2 = value;
				}
			}

			// Token: 0x1700356F RID: 13679
			// (get) Token: 0x06011582 RID: 71042 RVA: 0x0047FE5C File Offset: 0x0047E05C
			// (set) Token: 0x06011583 RID: 71043 RVA: 0x0047FE6C File Offset: 0x0047E06C
			public GainRewardButton[] m_starRewardButtons
			{
				get
				{
					return this.m_owner.m_starRewardButtons;
				}
				set
				{
					this.m_owner.m_starRewardButtons = value;
				}
			}

			// Token: 0x17003570 RID: 13680
			// (get) Token: 0x06011584 RID: 71044 RVA: 0x0047FE7C File Offset: 0x0047E07C
			// (set) Token: 0x06011585 RID: 71045 RVA: 0x0047FE8C File Offset: 0x0047E08C
			public HeroCharUIController m_heroCharUIController
			{
				get
				{
					return this.m_owner.m_heroCharUIController;
				}
				set
				{
					this.m_owner.m_heroCharUIController = value;
				}
			}

			// Token: 0x17003571 RID: 13681
			// (get) Token: 0x06011586 RID: 71046 RVA: 0x0047FE9C File Offset: 0x0047E09C
			// (set) Token: 0x06011587 RID: 71047 RVA: 0x0047FEAC File Offset: 0x0047E0AC
			public ConfigDataHeroInformationInfo m_heroDungeonInfo
			{
				get
				{
					return this.m_owner.m_heroDungeonInfo;
				}
				set
				{
					this.m_owner.m_heroDungeonInfo = value;
				}
			}

			// Token: 0x17003572 RID: 13682
			// (get) Token: 0x06011588 RID: 71048 RVA: 0x0047FEBC File Offset: 0x0047E0BC
			// (set) Token: 0x06011589 RID: 71049 RVA: 0x0047FECC File Offset: 0x0047E0CC
			public ScrollSnapCenter m_levelsScrollViewVerticalSnapCenter
			{
				get
				{
					return this.m_owner.m_levelsScrollViewVerticalSnapCenter;
				}
				set
				{
					this.m_owner.m_levelsScrollViewVerticalSnapCenter = value;
				}
			}

			// Token: 0x17003573 RID: 13683
			// (get) Token: 0x0601158A RID: 71050 RVA: 0x0047FEDC File Offset: 0x0047E0DC
			// (set) Token: 0x0601158B RID: 71051 RVA: 0x0047FEEC File Offset: 0x0047E0EC
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

			// Token: 0x17003574 RID: 13684
			// (get) Token: 0x0601158C RID: 71052 RVA: 0x0047FEFC File Offset: 0x0047E0FC
			// (set) Token: 0x0601158D RID: 71053 RVA: 0x0047FF0C File Offset: 0x0047E10C
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

			// Token: 0x0601158E RID: 71054 RVA: 0x0047FF1C File Offset: 0x0047E11C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601158F RID: 71055 RVA: 0x0047FF2C File Offset: 0x0047E12C
			public void LateUpdate()
			{
				this.m_owner.LateUpdate();
			}

			// Token: 0x06011590 RID: 71056 RVA: 0x0047FF3C File Offset: 0x0047E13C
			public List<Vector2> GetLineOnEllipseIntersection(double x1, double x2, double y1, double y2, double midX, double midY, double h, double v)
			{
				return this.m_owner.GetLineOnEllipseIntersection(x1, x2, y1, y2, midX, midY, h, v);
			}

			// Token: 0x06011591 RID: 71057 RVA: 0x0047FF64 File Offset: 0x0047E164
			public bool isPointInLine(double x1, double x2, double y1, double y2, double px, double py)
			{
				return this.m_owner.isPointInLine(x1, x2, y1, y2, px, py);
			}

			// Token: 0x06011592 RID: 71058 RVA: 0x0047FF7C File Offset: 0x0047E17C
			public Vector2 GetLineLineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
			{
				return this.m_owner.GetLineLineIntersection(p1, p2, p3, p4);
			}

			// Token: 0x06011593 RID: 71059 RVA: 0x0047FF90 File Offset: 0x0047E190
			public void SetCircleRotation(float deltaRotation)
			{
				this.m_owner.SetCircleRotation(deltaRotation);
			}

			// Token: 0x06011594 RID: 71060 RVA: 0x0047FFA0 File Offset: 0x0047E1A0
			public void OnStarRewardButtonClick(GainRewardButton b)
			{
				this.m_owner.OnStarRewardButtonClick(b);
			}

			// Token: 0x06011595 RID: 71061 RVA: 0x0047FFB0 File Offset: 0x0047E1B0
			public void AddStarRewardPreviewGoods(ConfigDataHeroInformationInfo heroDungeonInfo, int idx)
			{
				this.m_owner.AddStarRewardPreviewGoods(heroDungeonInfo, idx);
			}

			// Token: 0x06011596 RID: 71062 RVA: 0x0047FFC0 File Offset: 0x0047E1C0
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06011597 RID: 71063 RVA: 0x0047FFD0 File Offset: 0x0047E1D0
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x06011598 RID: 71064 RVA: 0x0047FFE0 File Offset: 0x0047E1E0
			public void OnHeroDungeonLevelButtonClick(HeroDungeonLevelListItemUIController b)
			{
				this.m_owner.OnHeroDungeonLevelButtonClick(b);
			}

			// Token: 0x06011599 RID: 71065 RVA: 0x0047FFF0 File Offset: 0x0047E1F0
			public void OnStarRewardPreviewBackgroundButtonClick()
			{
				this.m_owner.OnStarRewardPreviewBackgroundButtonClick();
			}

			// Token: 0x04009EE2 RID: 40674
			private HeroDungeonUIController m_owner;
		}
	}
}
