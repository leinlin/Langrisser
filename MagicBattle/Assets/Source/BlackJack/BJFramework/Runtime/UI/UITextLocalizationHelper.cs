using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000F1 RID: 241
	[AddComponentMenu("UI/BlackJack/TextLocalizationHelper")]
	public class UITextLocalizationHelper : MonoBehaviour
	{
		// Token: 0x060008D7 RID: 2263 RVA: 0x000274A0 File Offset: 0x000256A0
		public void LoadLocatizedString()
		{
			if (GameManager.Instance == null)
			{
				return;
			}
			if (this.m_uiText != null)
			{
				this.TranslateText();
			}
			if (this.m_uiDropdown != null)
			{
				this.TranslateDropdownList();
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x000274DC File Offset: 0x000256DC
		private string GetTranslateResult(string srcText)
		{
			string text = (UITextLocalizationHelper.m_translateFunc != null) ? UITextLocalizationHelper.m_translateFunc(srcText) : GameManager.Instance.StringTableManager.GetStringInDefaultStringTable(this.m_textLocalizationKey);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return srcText;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00027528 File Offset: 0x00025728
		private void TranslateText()
		{
			if (this.m_uiText != null)
			{
				this.m_uiText.text = this.GetTranslateResult(this.m_uiText.text);
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00027558 File Offset: 0x00025758
		private void TranslateDropdownList()
		{
			if (this.m_uiDropdown != null && this.m_uiDropdown.options != null && this.m_uiDropdown.options.Count > 0)
			{
				foreach (Dropdown.OptionData optionData in this.m_uiDropdown.options)
				{
					optionData.text = this.GetTranslateResult(optionData.text);
				}
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000275FC File Offset: 0x000257FC
		public string GetTextOriginalContent()
		{
			if (this.m_uiText != null)
			{
				return this.m_uiText.text;
			}
			return string.Empty;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00027620 File Offset: 0x00025820
		public List<string> GetDropdownOriginalContents()
		{
			if (this.m_uiDropdown != null && this.m_uiDropdown.options != null && this.m_uiDropdown.options.Count > 0)
			{
				List<string> list = new List<string>();
				foreach (Dropdown.OptionData optionData in this.m_uiDropdown.options)
				{
					list.Add(optionData.text);
				}
				return list;
			}
			return null;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x000276C8 File Offset: 0x000258C8
		private Text m_uiText
		{
			get
			{
				if (this._uiText == null)
				{
					this._uiText = base.GetComponent<Text>();
				}
				return this._uiText;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x000276F0 File Offset: 0x000258F0
		private Dropdown m_uiDropdown
		{
			get
			{
				if (this._uiDropdown == null)
				{
					this._uiDropdown = base.GetComponent<Dropdown>();
				}
				return this._uiDropdown;
			}
		}

		// Token: 0x040005A6 RID: 1446
		private Text _uiText;

		// Token: 0x040005A7 RID: 1447
		private Dropdown _uiDropdown;

		// Token: 0x040005A8 RID: 1448
		public string m_textLocalizationKey;

		// Token: 0x040005A9 RID: 1449
		public static Func<string, string> m_translateFunc;
	}
}
