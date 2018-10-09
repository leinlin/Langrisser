using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B74 RID: 2932
	[HotFix]
	public class ExpressionParseController : MonoBehaviour
	{
		// Token: 0x0600C776 RID: 51062 RVA: 0x00374448 File Offset: 0x00372648
		public void Init(GameObject image, int gap, float offsetX = 0f, float offsetY = 0f, float fontSize = 25f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGameObjectInt32SingleSingleSingle_hotfix != null)
			{
				this.m_InitGameObjectInt32SingleSingleSingle_hotfix.call(new object[]
				{
					this,
					image,
					gap,
					offsetX,
					offsetY,
					fontSize
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			IEnumerable<KeyValuePair<int, ConfigDataSmallExpressionPathInfo>> allConfigDataSmallExpressionPathInfo = this.m_configDataLoader.GetAllConfigDataSmallExpressionPathInfo();
			foreach (KeyValuePair<int, ConfigDataSmallExpressionPathInfo> keyValuePair in allConfigDataSmallExpressionPathInfo)
			{
				num++;
			}
			this.m_regexParamStr = string.Format("{0}[0-9]{1}{2}{3}", new object[]
			{
				"#",
				"{1,",
				num.ToString().Length,
				"}"
			});
			this.m_imageToClone = UnityEngine.Object.Instantiate<GameObject>(image).GetComponent<Image>();
			this.m_imageToClone.gameObject.SetActive(false);
			this.m_imageToClone.transform.SetParent(base.transform, false);
			this.m_gapSize = (float)gap;
			this.m_offsetX = offsetX;
			this.m_offsetY = offsetY;
			this.m_fontSize = ((fontSize != 0f) ? fontSize : 25f);
			this.emSpace = string.Format("<size={0}>\u2001</size>", this.m_fontSize);
			this.m_richTextIndexOffSet = "</size>".Length;
			this.m_isInited = true;
		}

		// Token: 0x0600C777 RID: 51063 RVA: 0x00374634 File Offset: 0x00372834
		public void SetChatItemWithTextAndSmallExpression(Text text, string inputString)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChatItemWithTextAndSmallExpressionTextString_hotfix != null)
			{
				this.m_SetChatItemWithTextAndSmallExpressionTextString_hotfix.call(new object[]
				{
					this,
					text,
					inputString
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isInited)
			{
				base.StartCoroutine(this.SetUITextWithSmallExpression(text, inputString));
			}
			else
			{
				global::Debug.LogError("ExpressionParseController::Please Init the Parse Controller");
			}
		}

		// Token: 0x0600C778 RID: 51064 RVA: 0x003746E0 File Offset: 0x003728E0
		[DebuggerHidden]
		private IEnumerator SetUITextWithSmallExpression(Text textToEdit, string inputString)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUITextWithSmallExpressionTextString_hotfix != null)
			{
				return (IEnumerator)this.m_SetUITextWithSmallExpressionTextString_hotfix.call(new object[]
				{
					this,
					textToEdit,
					inputString
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ExpressionParseController.<SetUITextWithSmallExpression>c__Iterator0 <SetUITextWithSmallExpression>c__Iterator = new ExpressionParseController.<SetUITextWithSmallExpression>c__Iterator0();
			<SetUITextWithSmallExpression>c__Iterator.inputString = inputString;
			<SetUITextWithSmallExpression>c__Iterator.textToEdit = textToEdit;
			<SetUITextWithSmallExpression>c__Iterator.$this = this;
			return <SetUITextWithSmallExpression>c__Iterator;
		}

		// Token: 0x0600C779 RID: 51065 RVA: 0x00374788 File Offset: 0x00372988
		private List<ExpressionParseController.PosStringTuple> ParseEmoji(string inputString, out string changedStr)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ParseEmojiStringString__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_UI_ExpressionParseController_ParseEmoji_String_String(this, this.m_ParseEmojiStringString__hotfix, inputString, out changedStr);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ExpressionParseController.PosStringTuple> list = new List<ExpressionParseController.PosStringTuple>();
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
					stringBuilder.Append(this.emSpace);
					string s = inputString.Substring(index + 1, match.Length - 1);
					int key = 0;
					if (!int.TryParse(s, out key))
					{
						key = 1;
					}
					list.Add(new ExpressionParseController.PosStringTuple(stringBuilder.Length - 1 - this.m_richTextIndexOffSet, key));
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

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0600C77A RID: 51066 RVA: 0x00374908 File Offset: 0x00372B08
		// (set) Token: 0x0600C77B RID: 51067 RVA: 0x00374928 File Offset: 0x00372B28
		[DoNotToLua]
		public ExpressionParseController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ExpressionParseController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C77C RID: 51068 RVA: 0x00374934 File Offset: 0x00372B34
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
					this.m_InitGameObjectInt32SingleSingleSingle_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_SetChatItemWithTextAndSmallExpressionTextString_hotfix = (luaObj.RawGet("SetChatItemWithTextAndSmallExpression") as LuaFunction);
					this.m_SetUITextWithSmallExpressionTextString_hotfix = (luaObj.RawGet("SetUITextWithSmallExpression") as LuaFunction);
					this.m_ParseEmojiStringString__hotfix = (luaObj.RawGet("ParseEmoji") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C77D RID: 51069 RVA: 0x00374A4C File Offset: 0x00372C4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ExpressionParseController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007E3B RID: 32315
		private Image m_imageToClone;

		// Token: 0x04007E3C RID: 32316
		private string m_regexParamStr;

		// Token: 0x04007E3D RID: 32317
		private float m_offsetX;

		// Token: 0x04007E3E RID: 32318
		private float m_offsetY;

		// Token: 0x04007E3F RID: 32319
		private float m_fontSize;

		// Token: 0x04007E40 RID: 32320
		private int m_richTextIndexOffSet;

		// Token: 0x04007E41 RID: 32321
		private float m_gapSize;

		// Token: 0x04007E42 RID: 32322
		private string emSpace;

		// Token: 0x04007E43 RID: 32323
		private bool m_isInited;

		// Token: 0x04007E44 RID: 32324
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04007E45 RID: 32325
		[DoNotToLua]
		private ExpressionParseController.LuaExportHelper luaExportHelper;

		// Token: 0x04007E46 RID: 32326
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007E47 RID: 32327
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007E48 RID: 32328
		private LuaFunction m_InitGameObjectInt32SingleSingleSingle_hotfix;

		// Token: 0x04007E49 RID: 32329
		private LuaFunction m_SetChatItemWithTextAndSmallExpressionTextString_hotfix;

		// Token: 0x04007E4A RID: 32330
		private LuaFunction m_SetUITextWithSmallExpressionTextString_hotfix;

		// Token: 0x04007E4B RID: 32331
		private LuaFunction m_ParseEmojiStringString__hotfix;

		// Token: 0x02000B75 RID: 2933
		[HotFix]
		public class PosStringTuple
		{
			// Token: 0x0600C77E RID: 51070 RVA: 0x00374AB4 File Offset: 0x00372CB4
			public PosStringTuple(int p, int key)
			{
				this.pos = p;
				this.expressionKey = key;
			}

			// Token: 0x04007E4C RID: 32332
			public int pos;

			// Token: 0x04007E4D RID: 32333
			public int expressionKey;
		}

		// Token: 0x02000B76 RID: 2934
		public class LuaExportHelper
		{
			// Token: 0x0600C77F RID: 51071 RVA: 0x00374ACC File Offset: 0x00372CCC
			public LuaExportHelper(ExpressionParseController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170027B9 RID: 10169
			// (get) Token: 0x0600C780 RID: 51072 RVA: 0x00374ADC File Offset: 0x00372CDC
			// (set) Token: 0x0600C781 RID: 51073 RVA: 0x00374AEC File Offset: 0x00372CEC
			public Image m_imageToClone
			{
				get
				{
					return this.m_owner.m_imageToClone;
				}
				set
				{
					this.m_owner.m_imageToClone = value;
				}
			}

			// Token: 0x170027BA RID: 10170
			// (get) Token: 0x0600C782 RID: 51074 RVA: 0x00374AFC File Offset: 0x00372CFC
			// (set) Token: 0x0600C783 RID: 51075 RVA: 0x00374B0C File Offset: 0x00372D0C
			public string m_regexParamStr
			{
				get
				{
					return this.m_owner.m_regexParamStr;
				}
				set
				{
					this.m_owner.m_regexParamStr = value;
				}
			}

			// Token: 0x170027BB RID: 10171
			// (get) Token: 0x0600C784 RID: 51076 RVA: 0x00374B1C File Offset: 0x00372D1C
			// (set) Token: 0x0600C785 RID: 51077 RVA: 0x00374B2C File Offset: 0x00372D2C
			public float m_offsetX
			{
				get
				{
					return this.m_owner.m_offsetX;
				}
				set
				{
					this.m_owner.m_offsetX = value;
				}
			}

			// Token: 0x170027BC RID: 10172
			// (get) Token: 0x0600C786 RID: 51078 RVA: 0x00374B3C File Offset: 0x00372D3C
			// (set) Token: 0x0600C787 RID: 51079 RVA: 0x00374B4C File Offset: 0x00372D4C
			public float m_offsetY
			{
				get
				{
					return this.m_owner.m_offsetY;
				}
				set
				{
					this.m_owner.m_offsetY = value;
				}
			}

			// Token: 0x170027BD RID: 10173
			// (get) Token: 0x0600C788 RID: 51080 RVA: 0x00374B5C File Offset: 0x00372D5C
			// (set) Token: 0x0600C789 RID: 51081 RVA: 0x00374B6C File Offset: 0x00372D6C
			public float m_fontSize
			{
				get
				{
					return this.m_owner.m_fontSize;
				}
				set
				{
					this.m_owner.m_fontSize = value;
				}
			}

			// Token: 0x170027BE RID: 10174
			// (get) Token: 0x0600C78A RID: 51082 RVA: 0x00374B7C File Offset: 0x00372D7C
			// (set) Token: 0x0600C78B RID: 51083 RVA: 0x00374B8C File Offset: 0x00372D8C
			public int m_richTextIndexOffSet
			{
				get
				{
					return this.m_owner.m_richTextIndexOffSet;
				}
				set
				{
					this.m_owner.m_richTextIndexOffSet = value;
				}
			}

			// Token: 0x170027BF RID: 10175
			// (get) Token: 0x0600C78C RID: 51084 RVA: 0x00374B9C File Offset: 0x00372D9C
			// (set) Token: 0x0600C78D RID: 51085 RVA: 0x00374BAC File Offset: 0x00372DAC
			public float m_gapSize
			{
				get
				{
					return this.m_owner.m_gapSize;
				}
				set
				{
					this.m_owner.m_gapSize = value;
				}
			}

			// Token: 0x170027C0 RID: 10176
			// (get) Token: 0x0600C78E RID: 51086 RVA: 0x00374BBC File Offset: 0x00372DBC
			// (set) Token: 0x0600C78F RID: 51087 RVA: 0x00374BCC File Offset: 0x00372DCC
			public string emSpace
			{
				get
				{
					return this.m_owner.emSpace;
				}
				set
				{
					this.m_owner.emSpace = value;
				}
			}

			// Token: 0x170027C1 RID: 10177
			// (get) Token: 0x0600C790 RID: 51088 RVA: 0x00374BDC File Offset: 0x00372DDC
			// (set) Token: 0x0600C791 RID: 51089 RVA: 0x00374BEC File Offset: 0x00372DEC
			public bool m_isInited
			{
				get
				{
					return this.m_owner.m_isInited;
				}
				set
				{
					this.m_owner.m_isInited = value;
				}
			}

			// Token: 0x170027C2 RID: 10178
			// (get) Token: 0x0600C792 RID: 51090 RVA: 0x00374BFC File Offset: 0x00372DFC
			// (set) Token: 0x0600C793 RID: 51091 RVA: 0x00374C0C File Offset: 0x00372E0C
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

			// Token: 0x0600C794 RID: 51092 RVA: 0x00374C1C File Offset: 0x00372E1C
			public IEnumerator SetUITextWithSmallExpression(Text textToEdit, string inputString)
			{
				return this.m_owner.SetUITextWithSmallExpression(textToEdit, inputString);
			}

			// Token: 0x0600C795 RID: 51093 RVA: 0x00374C2C File Offset: 0x00372E2C
			public List<ExpressionParseController.PosStringTuple> ParseEmoji(string inputString, out string changedStr)
			{
				return this.m_owner.ParseEmoji(inputString, out changedStr);
			}

			// Token: 0x04007E4E RID: 32334
			private ExpressionParseController m_owner;
		}
	}
}
