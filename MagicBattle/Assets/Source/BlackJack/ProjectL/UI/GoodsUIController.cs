using System;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F18 RID: 3864
	public class GoodsUIController : UIControllerBase
	{
		// Token: 0x060132B2 RID: 78514 RVA: 0x004E23A8 File Offset: 0x004E05A8
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_nameText = Utility.FindChildComponent<Text>(base.gameObject, "NameText", false);
			this.m_countText = Utility.FindChildComponent<Text>(base.gameObject, "CountText", false);
			this.m_crystalEffectGameObject = Utility.FindChildGameObject(this.m_iconImage.gameObject, "U_crystal", false);
			this.m_ssrEffectGameObject = Utility.FindChildGameObject(base.gameObject, "SSREffect", false);
			this.m_ssrPieceEffectGameObject = Utility.FindChildGameObject(base.gameObject, "SSRPieceEffect", false);
			this.m_haveGetGroupRoot = Utility.FindChildGameObject(base.gameObject, "GotGroup", false);
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x060132B3 RID: 78515 RVA: 0x004E2468 File Offset: 0x004E0668
		public void SetReward(Goods r)
		{
			this.m_goods = r;
			this.m_goodsType = r.GoodsType;
			this.m_goodsId = r.Id;
			this.m_goodsCount = r.Count;
			this.m_iconImage.gameObject.SetActive(true);
			this.m_iconImage.transform.localScale = Vector3.one;
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(this.m_goodsType, this.m_goodsId));
			this.m_iconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(this.m_goodsType, this.m_goodsId));
			bool flag = UIUtility.IsGoodsHeroFragment(this.m_goodsType, this.m_goodsId);
			bool flag2 = UIUtility.IsGoodsGoblin(this.m_goodsType, this.m_goodsId);
			if (flag)
			{
				this.m_iconImage.transform.localScale = Vector3.one;
			}
			else if (flag2)
			{
				this.m_iconImage.transform.localScale = Vector3.one;
			}
			else if (this.m_goodsType == GoodsType.GoodsType_HeroSkin || this.m_goodsType == GoodsType.GoodsType_SoldierSkin)
			{
				this.m_iconImage.transform.localScale = Vector3.one;
			}
			else
			{
				this.m_iconImage.transform.localScale = Vector3.one * 0.7f;
			}
			int goodsRank = UIUtility.GetGoodsRank(this.m_goodsType, this.m_goodsId);
			if (this.m_crystalEffectGameObject != null)
			{
				this.m_crystalEffectGameObject.SetActive(this.m_goodsType == GoodsType.GoodsType_Crystal);
			}
			string goodsFrameName = UIUtility.GetGoodsFrameName(this.m_goodsType, this.m_goodsId);
			if (!string.IsNullOrEmpty(goodsFrameName))
			{
				this.m_frameImage.gameObject.SetActive(true);
				this.m_frameImage.sprite = AssetUtility.Instance.GetSprite(goodsFrameName);
				if (this.m_ssrEffectGameObject != null)
				{
					this.m_ssrEffectGameObject.SetActive(UIUtility.IsRankSSR(goodsRank));
				}
				if (this.m_ssrPieceEffectGameObject != null)
				{
					this.m_ssrPieceEffectGameObject.SetActive(false);
				}
			}
			else
			{
				this.m_frameImage.gameObject.SetActive(false);
				if (this.m_ssrEffectGameObject != null)
				{
					this.m_ssrEffectGameObject.SetActive(false);
				}
				if (this.m_ssrPieceEffectGameObject != null)
				{
					this.m_ssrPieceEffectGameObject.SetActive(flag && UIUtility.IsRankSSR(goodsRank));
				}
			}
			if (this.m_countText != null)
			{
				this.m_countText.text = r.Count.ToString();
			}
			if (this.m_nameText != null)
			{
				this.m_nameText.text = UIUtility.GetGoodsName(this.m_goodsType, this.m_goodsId);
			}
			if (this.m_haveGetGroupRoot != null)
			{
				this.m_haveGetGroupRoot.SetActive(false);
			}
		}

		// Token: 0x060132B4 RID: 78516 RVA: 0x004E275C File Offset: 0x004E095C
		public void ShowCount(bool show)
		{
			if (this.m_countText != null)
			{
				if (this.m_goodsCount <= 1)
				{
					this.m_countText.gameObject.SetActive(false);
				}
				else
				{
					this.m_countText.gameObject.SetActive(show);
				}
			}
		}

		// Token: 0x060132B5 RID: 78517 RVA: 0x004E27B0 File Offset: 0x004E09B0
		public void ShowTag(string tagName, bool show)
		{
			Transform transform = base.transform.Find(tagName);
			if (transform != null)
			{
				transform.gameObject.SetActive(show);
			}
		}

		// Token: 0x060132B6 RID: 78518 RVA: 0x004E27E4 File Offset: 0x004E09E4
		public void ShowHaveGot(bool isGot)
		{
			if (this.m_haveGetGroupRoot != null)
			{
				this.m_haveGetGroupRoot.SetActive(isGot);
			}
		}

		// Token: 0x060132B7 RID: 78519 RVA: 0x004E2804 File Offset: 0x004E0A04
		public static GoodsUIController CreateRewardGoods(Goods g, Transform parent, GameObject prefab, bool showCount = true, Action<GoodsUIController> onGoodsClick = null)
		{
			if (prefab == null)
			{
				return null;
			}
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(prefab, parent, false);
			GoodsUIController goodsUIController = GameObjectUtility.AddControllerToGameObject<GoodsUIController>(go);
			goodsUIController.SetReward(g);
			goodsUIController.ShowCount(showCount);
			goodsUIController.OnClickEvent = onGoodsClick;
			return goodsUIController;
		}

		// Token: 0x060132B8 RID: 78520 RVA: 0x004E2848 File Offset: 0x004E0A48
		public static void CreateRewardGoodsList(List<Goods> goods, Transform parent, GameObject prefab, List<GoodsUIController> ctrlList = null, bool showCount = true)
		{
			if (prefab == null)
			{
				return;
			}
			prefab.SetActive(true);
			foreach (Goods g in goods)
			{
				GoodsUIController goodsUIController = GoodsUIController.CreateRewardGoods(g, parent, prefab, showCount, null);
				if (goodsUIController != null && ctrlList != null)
				{
					ctrlList.Add(goodsUIController);
				}
			}
		}

		// Token: 0x060132B9 RID: 78521 RVA: 0x004E28D4 File Offset: 0x004E0AD4
		private void OnClick()
		{
			if (this.OnClickEvent != null)
			{
				this.OnClickEvent(this);
			}
		}

		// Token: 0x1400042A RID: 1066
		// (add) Token: 0x060132BA RID: 78522 RVA: 0x004E28F0 File Offset: 0x004E0AF0
		// (remove) Token: 0x060132BB RID: 78523 RVA: 0x004E2928 File Offset: 0x004E0B28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<GoodsUIController> OnClickEvent;

		// Token: 0x0400AA98 RID: 43672
		public GoodsType m_goodsType;

		// Token: 0x0400AA99 RID: 43673
		public int m_goodsId;

		// Token: 0x0400AA9A RID: 43674
		public int m_goodsCount;

		// Token: 0x0400AA9B RID: 43675
		public Goods m_goods;

		// Token: 0x0400AA9C RID: 43676
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400AA9D RID: 43677
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400AA9E RID: 43678
		[AutoBind("./FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_frameImage;

		// Token: 0x0400AAA0 RID: 43680
		private GameObject m_haveGetGroupRoot;

		// Token: 0x0400AAA1 RID: 43681
		private Text m_nameText;

		// Token: 0x0400AAA2 RID: 43682
		private Text m_countText;

		// Token: 0x0400AAA3 RID: 43683
		private GameObject m_crystalEffectGameObject;

		// Token: 0x0400AAA4 RID: 43684
		private GameObject m_ssrEffectGameObject;

		// Token: 0x0400AAA5 RID: 43685
		private GameObject m_ssrPieceEffectGameObject;
	}
}
