using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B71 RID: 2929
public class EmojiText : Text
{
	// Token: 0x0600C769 RID: 51049 RVA: 0x00373DE8 File Offset: 0x00371FE8
	public void Init(int fontSize, Image image)
	{
		this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		this.m_imageToClone = image;
		int num = 0;
		IEnumerable<KeyValuePair<int, ConfigDataSmallExpressionPathInfo>> allConfigDataSmallExpressionPathInfo = this.m_configDataLoader.GetAllConfigDataSmallExpressionPathInfo();
		foreach (KeyValuePair<int, ConfigDataSmallExpressionPathInfo> keyValuePair in allConfigDataSmallExpressionPathInfo)
		{
			num++;
		}
		this.m_emSpace = string.Format("<size={0}>\u2001</size>", fontSize);
		this.m_richTextIndexOffSet = "</size>".Length;
		this.m_regexParamStr = string.Format("{0}[0-9]{1}{2}{3}", new object[]
		{
			"#",
			"{1,",
			num.ToString().Length,
			"}"
		});
		this.m_fontSize = (float)fontSize;
	}

	// Token: 0x0600C76A RID: 51050 RVA: 0x00373EDC File Offset: 0x003720DC
	public void SetContent(string content)
	{
		string empty = string.Empty;
		List<EmojiText.PosStringTuple> list = this.ParseEmoji(content, out empty);
		this.text = empty;
		this.m_content = content;
	}

	// Token: 0x0600C76B RID: 51051 RVA: 0x00373F08 File Offset: 0x00372108
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
		base.OnPopulateMesh(toFill);
		if (string.IsNullOrEmpty(this.m_content))
		{
			return;
		}
		toFill.GetUIVertexStream(this.m_listUIVertex);
		base.StartCoroutine(this.SetUITextWithSmallExpression(this, this.m_content));
	}

	// Token: 0x0600C76C RID: 51052 RVA: 0x00373F44 File Offset: 0x00372144
	private IEnumerator SetUITextWithSmallExpression(Text textToEdit, string inputString)
	{
		yield return null;
		string changedStr = string.Empty;
		List<EmojiText.PosStringTuple> emojiReplacements = this.ParseEmoji(inputString, out changedStr);
		textToEdit.text = changedStr;
		List<Image> childImageList = new List<Image>();
		IEnumerator enumerator = textToEdit.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform transform = (Transform)obj;
				if (!(transform == textToEdit.transform))
				{
					transform.gameObject.SetActive(false);
					Image component = transform.GetComponent<Image>();
					if (component != null)
					{
						childImageList.Add(component);
					}
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		if (textToEdit.transform.childCount < emojiReplacements.Count)
		{
			for (int i = emojiReplacements.Count - textToEdit.transform.childCount; i > 0; i--)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_imageToClone.gameObject);
				gameObject.SetActive(false);
				gameObject.transform.SetParent(textToEdit.transform, false);
				gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(this.m_fontSize, this.m_fontSize);
				childImageList.Add(gameObject.GetComponent<Image>());
			}
		}
		TextGenerator textGen = textToEdit.cachedTextGeneratorForLayout;
		if (textGen == null || textGen.vertexCount == 0)
		{
			textGen = textToEdit.cachedTextGenerator;
		}
		for (int j = 0; j < emojiReplacements.Count; j++)
		{
			int pos = emojiReplacements[j].pos;
			Image image = childImageList[j];
			Vector3 localPosition = new Vector3(this.m_listUIVertex[pos * 6 + 4].position.x, this.m_listUIVertex[pos * 6 + 4].position.y, 0f);
			image.GetComponent<RectTransform>().localPosition = localPosition;
			ConfigDataSmallExpressionPathInfo configDataSmallExpressionPathInfo = this.m_configDataLoader.GetConfigDataSmallExpressionPathInfo(emojiReplacements[j].expressionKey);
			image.sprite = AssetUtility.Instance.GetSprite(configDataSmallExpressionPathInfo.SmallExpressionIconPath);
			image.gameObject.SetActive(true);
		}
		yield break;
	}

	// Token: 0x0600C76D RID: 51053 RVA: 0x00373F70 File Offset: 0x00372170
	private List<EmojiText.PosStringTuple> ParseEmoji(string inputString, out string changedStr)
	{
		List<EmojiText.PosStringTuple> list = new List<EmojiText.PosStringTuple>();
		Regex regex = new Regex(this.m_regexParamStr);
		MatchCollection matchCollection = regex.Matches(inputString);
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		IEnumerator enumerator = matchCollection.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Match match = (Match)obj;
				int index = match.Index;
				stringBuilder.Append(inputString.Substring(num, index - num));
				stringBuilder.Append(this.m_emSpace);
				string s = inputString.Substring(index + 1, match.Length - 1);
				int key = 0;
				if (!int.TryParse(s, out key))
				{
					key = 1;
				}
				list.Add(new EmojiText.PosStringTuple(stringBuilder.Length - 1 - this.m_richTextIndexOffSet, key));
				num = index + match.Length;
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		if (num < inputString.Length)
		{
			stringBuilder.Append(inputString.Substring(num, inputString.Length - num));
		}
		changedStr = stringBuilder.ToString();
		return list;
	}

	// Token: 0x04007E25 RID: 32293
	private string m_content;

	// Token: 0x04007E26 RID: 32294
	private string m_emSpace;

	// Token: 0x04007E27 RID: 32295
	private string m_regexParamStr;

	// Token: 0x04007E28 RID: 32296
	private int m_richTextIndexOffSet;

	// Token: 0x04007E29 RID: 32297
	private float m_fontSize;

	// Token: 0x04007E2A RID: 32298
	private IConfigDataLoader m_configDataLoader;

	// Token: 0x04007E2B RID: 32299
	private Image m_imageToClone;

	// Token: 0x04007E2C RID: 32300
	private List<UIVertex> m_listUIVertex = new List<UIVertex>();

	// Token: 0x02000B72 RID: 2930
	[HotFix]
	public class PosStringTuple
	{
		// Token: 0x0600C76E RID: 51054 RVA: 0x003740A0 File Offset: 0x003722A0
		public PosStringTuple(int p, int key)
		{
			this.pos = p;
			this.expressionKey = key;
		}

		// Token: 0x04007E2D RID: 32301
		public int pos;

		// Token: 0x04007E2E RID: 32302
		public int expressionKey;
	}
}
