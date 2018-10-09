using System;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CE7 RID: 3303
	public class CurrencyUIController : UIControllerBase
	{
		// Token: 0x0600F1B1 RID: 61873 RVA: 0x00403398 File Offset: 0x00401598
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.SetDefaultState();
		}

		// Token: 0x0600F1B2 RID: 61874 RVA: 0x004033D0 File Offset: 0x004015D0
		public void SetDefaultState()
		{
			this.m_currency1Icon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_Gold.png");
			this.m_currency1CountText.text = this.m_playerContext.GetGold().ToString();
			this.m_currency1AddButton.onClick.RemoveAllListeners();
			this.m_currency1AddButton.onClick.AddListener(delegate()
			{
				if (this.EventOnAddButtonClick != null)
				{
					this.EventOnAddButtonClick(GoodsType.GoodsType_Gold);
				}
			});
			this.m_currency1AddButton.gameObject.SetActive(true);
			this.m_currency1Obj.SetActive(true);
			this.m_currency2Icon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_MagicCrystal.png");
			this.m_currency2CountText.text = this.m_playerContext.GetCrystal().ToString();
			this.m_currency2AddButton.onClick.RemoveAllListeners();
			this.m_currency2AddButton.onClick.AddListener(delegate()
			{
				if (this.EventOnAddButtonClick != null)
				{
					this.EventOnAddButtonClick(GoodsType.GoodsType_Crystal);
				}
			});
			this.m_currency2AddButton.gameObject.SetActive(true);
			this.m_currency2Obj.SetActive(true);
			this.m_currency3Obj.SetActive(false);
			this.m_currency3AddButton.onClick.RemoveAllListeners();
			this.m_currency3AddButton.gameObject.SetActive(false);
		}

		// Token: 0x0600F1B3 RID: 61875 RVA: 0x00403518 File Offset: 0x00401718
		public void RefreshCurrencyDisplay(int position, GoodsType currencyType)
		{
			if (position != 0)
			{
				if (position != 1)
				{
					if (position == 2)
					{
						this.m_currency3Icon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(currencyType, -1));
						this.m_currency3CountText.text = UIUtility.GetCurrencyCount(currencyType).ToString();
						this.m_currency3AddButton.onClick.RemoveAllListeners();
						this.m_currency3AddButton.onClick.AddListener(delegate()
						{
							if (this.EventOnAddButtonClick != null)
							{
								this.EventOnAddButtonClick(currencyType);
							}
						});
						this.m_currency3AddButton.gameObject.SetActive(false);
						this.m_currency3Obj.SetActive(true);
					}
				}
				else
				{
					this.m_currency2Icon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(currencyType, -1));
					this.m_currency2CountText.text = UIUtility.GetCurrencyCount(currencyType).ToString();
					this.m_currency2AddButton.onClick.RemoveAllListeners();
					this.m_currency2AddButton.onClick.AddListener(delegate()
					{
						if (this.EventOnAddButtonClick != null)
						{
							this.EventOnAddButtonClick(currencyType);
						}
					});
					this.m_currency2AddButton.gameObject.SetActive(false);
					this.m_currency2Obj.SetActive(true);
				}
			}
			else
			{
				this.m_currency1Icon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(currencyType, -1));
				this.m_currency1CountText.text = UIUtility.GetCurrencyCount(currencyType).ToString();
				this.m_currency1AddButton.onClick.RemoveAllListeners();
				this.m_currency1AddButton.onClick.AddListener(delegate()
				{
					if (this.EventOnAddButtonClick != null)
					{
						this.EventOnAddButtonClick(currencyType);
					}
				});
				this.m_currency1AddButton.gameObject.SetActive(false);
				this.m_currency1Obj.SetActive(true);
			}
		}

		// Token: 0x1400032B RID: 811
		// (add) Token: 0x0600F1B4 RID: 61876 RVA: 0x0040370C File Offset: 0x0040190C
		// (remove) Token: 0x0600F1B5 RID: 61877 RVA: 0x00403744 File Offset: 0x00401944
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<GoodsType> EventOnAddButtonClick;

		// Token: 0x04008F81 RID: 36737
		[AutoBind("./Currency1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_currency1Obj;

		// Token: 0x04008F82 RID: 36738
		[AutoBind("./Currency1/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_currency1Icon;

		// Token: 0x04008F83 RID: 36739
		[AutoBind("./Currency1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_currency1CountText;

		// Token: 0x04008F84 RID: 36740
		[AutoBind("./Currency1/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currency1AddButton;

		// Token: 0x04008F85 RID: 36741
		[AutoBind("./Currency2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_currency2Obj;

		// Token: 0x04008F86 RID: 36742
		[AutoBind("./Currency2/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_currency2Icon;

		// Token: 0x04008F87 RID: 36743
		[AutoBind("./Currency2/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_currency2CountText;

		// Token: 0x04008F88 RID: 36744
		[AutoBind("./Currency2/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currency2AddButton;

		// Token: 0x04008F89 RID: 36745
		[AutoBind("./Currency3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_currency3Obj;

		// Token: 0x04008F8A RID: 36746
		[AutoBind("./Currency3/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_currency3Icon;

		// Token: 0x04008F8B RID: 36747
		[AutoBind("./Currency3/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_currency3CountText;

		// Token: 0x04008F8C RID: 36748
		[AutoBind("./Currency3/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currency3AddButton;

		// Token: 0x04008F8D RID: 36749
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008F8E RID: 36750
		private IConfigDataLoader m_configDataLoader;
	}
}
