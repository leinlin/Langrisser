using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000EF RID: 239
	[AddComponentMenu("UI/BlackJack/TextTypeWriterUIController")]
	public class TextTypeWriterUIController : MonoBehaviour
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0002709C File Offset: 0x0002529C
		public bool isActive
		{
			get
			{
				return this.mActive;
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000270A4 File Offset: 0x000252A4
		public void ResetToBeginning()
		{
			this.Finish();
			this.mReset = true;
			this.mActive = true;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000270BC File Offset: 0x000252BC
		public void Finish()
		{
			if (this.mActive)
			{
				this.mActive = false;
				if (!this.mReset)
				{
					this.mCurrentOffset = this.mFullText.Length;
					this.mFade.Clear();
					this.mText.text = this.mFullText;
				}
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00027114 File Offset: 0x00025314
		public void StartTypeWriter()
		{
			this.mReset = true;
			this.mActive = true;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00027124 File Offset: 0x00025324
		private void OnEnable()
		{
			if (this.AutoStart)
			{
				this.mReset = true;
				this.mActive = true;
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00027140 File Offset: 0x00025340
		protected string GetAlphaColor(float alpha)
		{
			if (alpha > 1f)
			{
				alpha = 1f;
			}
			Color color = new Color(this.mTextColor.r, this.mTextColor.g, this.mTextColor.b, alpha);
			return ColorUtility.ToHtmlStringRGBA(color);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00027190 File Offset: 0x00025390
		private void Update()
		{
			if (!this.mActive)
			{
				return;
			}
			if (this.mReset)
			{
				this.mCurrentOffset = 0;
				this.mReset = false;
				this.mText = base.GetComponent<Text>();
				this.mFullText = this.mText.text;
				this.mTextColor = this.mText.color;
				this.mFade.Clear();
				this.mNextChar = 0f;
			}
			while (this.mCurrentOffset < this.mFullText.Length && this.mNextChar <= Time.realtimeSinceStartup)
			{
				int num = this.mCurrentOffset;
				this.charsPerSecond = Mathf.Max(1, this.charsPerSecond);
				this.mCurrentOffset++;
				float num2 = 1f / (float)this.charsPerSecond;
				if (this.mNextChar == 0f)
				{
					this.mNextChar = Time.realtimeSinceStartup + num2;
				}
				else
				{
					this.mNextChar += num2;
				}
				if (this.fadeInTime != 0f)
				{
					TextTypeWriterUIController.FadeEntry item = default(TextTypeWriterUIController.FadeEntry);
					item.index = num;
					item.alpha = 0f;
					item.text = this.mFullText.Substring(num, this.mCurrentOffset - num);
					this.mFade.Add(item);
				}
				else
				{
					this.mText.text = this.mFullText.Substring(0, this.mCurrentOffset);
				}
			}
			if (this.mFade.Count != 0)
			{
				int i = 0;
				while (i < this.mFade.Count)
				{
					TextTypeWriterUIController.FadeEntry value = this.mFade[i];
					value.alpha += Time.deltaTime / this.fadeInTime;
					if (value.alpha < 1f)
					{
						this.mFade[i] = value;
						i++;
					}
					else
					{
						this.mFade.RemoveAt(i);
					}
				}
				if (this.mFade.Count == 0)
				{
					this.mText.text = this.mFullText.Substring(0, this.mCurrentOffset);
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder();
					for (int j = 0; j < this.mFade.Count; j++)
					{
						TextTypeWriterUIController.FadeEntry fadeEntry = this.mFade[j];
						if (j == 0)
						{
							stringBuilder.Append(this.mFullText.Substring(0, fadeEntry.index));
						}
						stringBuilder.Append("<color=#");
						stringBuilder.Append(this.GetAlphaColor(fadeEntry.alpha));
						stringBuilder.Append(">");
						stringBuilder.Append(fadeEntry.text);
						stringBuilder.Append("</color>");
					}
					this.mText.text = stringBuilder.ToString();
				}
			}
			else if (this.mCurrentOffset == this.mFullText.Length)
			{
				this.mActive = false;
			}
		}

		// Token: 0x04000598 RID: 1432
		public int charsPerSecond = 20;

		// Token: 0x04000599 RID: 1433
		public float fadeInTime;

		// Token: 0x0400059A RID: 1434
		public bool AutoStart = true;

		// Token: 0x0400059B RID: 1435
		private Text mText;

		// Token: 0x0400059C RID: 1436
		protected Color mTextColor;

		// Token: 0x0400059D RID: 1437
		private string mFullText = string.Empty;

		// Token: 0x0400059E RID: 1438
		private int mCurrentOffset;

		// Token: 0x0400059F RID: 1439
		private float mNextChar;

		// Token: 0x040005A0 RID: 1440
		private bool mReset = true;

		// Token: 0x040005A1 RID: 1441
		private bool mActive;

		// Token: 0x040005A2 RID: 1442
		private List<TextTypeWriterUIController.FadeEntry> mFade = new List<TextTypeWriterUIController.FadeEntry>();

		// Token: 0x020000F0 RID: 240
		private struct FadeEntry
		{
			// Token: 0x040005A3 RID: 1443
			public int index;

			// Token: 0x040005A4 RID: 1444
			public string text;

			// Token: 0x040005A5 RID: 1445
			public float alpha;
		}
	}
}
