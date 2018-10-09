using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A91 RID: 2705
	[HotFix]
	public class DanmakuItemUIController : UIControllerBase
	{
		// Token: 0x0600AAF0 RID: 43760 RVA: 0x002F95D8 File Offset: 0x002F77D8
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
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600AAF1 RID: 43761 RVA: 0x002F964C File Offset: 0x002F784C
		public void InitDanmakuItem(string content, int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDanmakuItemStringInt32_hotfix != null)
			{
				this.m_InitDanmakuItemStringInt32_hotfix.call(new object[]
				{
					this,
					content,
					turn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_turnText.text = turn.ToString();
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_contentText.text = configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(content, '*');
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x002F9710 File Offset: 0x002F7910
		public void PlayTextTweenPos()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayTextTweenPos_hotfix != null)
			{
				this.m_PlayTextTweenPos_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_contentText.rectTransform.sizeDelta.x <= this.m_textMaskRectTransform.sizeDelta.x)
			{
				return;
			}
			this.m_contentTextTweenPos.from = new Vector3(0f, 0f, 0f);
			float x = 0f - (this.m_contentText.rectTransform.sizeDelta.x - this.m_textMaskRectTransform.sizeDelta.x);
			this.m_contentTextTweenPos.to = new Vector3(x, 0f, 0f);
			UIUtility.ReplayTween(this.m_contentText.gameObject, null);
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600AAF3 RID: 43763 RVA: 0x002F9820 File Offset: 0x002F7A20
		// (set) Token: 0x0600AAF4 RID: 43764 RVA: 0x002F9840 File Offset: 0x002F7A40
		[DoNotToLua]
		public new DanmakuItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DanmakuItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x002F984C File Offset: 0x002F7A4C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x002F9858 File Offset: 0x002F7A58
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600AAF7 RID: 43767 RVA: 0x002F9860 File Offset: 0x002F7A60
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600AAF8 RID: 43768 RVA: 0x002F9868 File Offset: 0x002F7A68
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600AAF9 RID: 43769 RVA: 0x002F987C File Offset: 0x002F7A7C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600AAFA RID: 43770 RVA: 0x002F9884 File Offset: 0x002F7A84
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600AAFB RID: 43771 RVA: 0x002F9890 File Offset: 0x002F7A90
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600AAFC RID: 43772 RVA: 0x002F989C File Offset: 0x002F7A9C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600AAFD RID: 43773 RVA: 0x002F98A8 File Offset: 0x002F7AA8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600AAFE RID: 43774 RVA: 0x002F98B4 File Offset: 0x002F7AB4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x002F98C0 File Offset: 0x002F7AC0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600AB00 RID: 43776 RVA: 0x002F98CC File Offset: 0x002F7ACC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600AB01 RID: 43777 RVA: 0x002F98D8 File Offset: 0x002F7AD8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600AB02 RID: 43778 RVA: 0x002F98E4 File Offset: 0x002F7AE4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600AB03 RID: 43779 RVA: 0x002F98F0 File Offset: 0x002F7AF0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600AB04 RID: 43780 RVA: 0x002F98F8 File Offset: 0x002F7AF8
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
					this.m_InitDanmakuItemStringInt32_hotfix = (luaObj.RawGet("InitDanmakuItem") as LuaFunction);
					this.m_PlayTextTweenPos_hotfix = (luaObj.RawGet("PlayTextTweenPos") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x002F99F8 File Offset: 0x002F7BF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DanmakuItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007035 RID: 28725
		[AutoBind("./TurnText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_turnText;

		// Token: 0x04007036 RID: 28726
		[AutoBind("./TextMask/ContentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_contentText;

		// Token: 0x04007037 RID: 28727
		[AutoBind("./TextMask/ContentText", AutoBindAttribute.InitState.NotInit, false)]
		private TweenPos m_contentTextTweenPos;

		// Token: 0x04007038 RID: 28728
		[AutoBind("./TextMask", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_textMaskRectTransform;

		// Token: 0x04007039 RID: 28729
		[DoNotToLua]
		private DanmakuItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400703A RID: 28730
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400703B RID: 28731
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400703C RID: 28732
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400703D RID: 28733
		private LuaFunction m_InitDanmakuItemStringInt32_hotfix;

		// Token: 0x0400703E RID: 28734
		private LuaFunction m_PlayTextTweenPos_hotfix;

		// Token: 0x02000A92 RID: 2706
		public new class LuaExportHelper
		{
			// Token: 0x0600AB06 RID: 43782 RVA: 0x002F9A60 File Offset: 0x002F7C60
			public LuaExportHelper(DanmakuItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600AB07 RID: 43783 RVA: 0x002F9A70 File Offset: 0x002F7C70
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600AB08 RID: 43784 RVA: 0x002F9A80 File Offset: 0x002F7C80
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600AB09 RID: 43785 RVA: 0x002F9A90 File Offset: 0x002F7C90
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600AB0A RID: 43786 RVA: 0x002F9AA0 File Offset: 0x002F7CA0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600AB0B RID: 43787 RVA: 0x002F9AB8 File Offset: 0x002F7CB8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600AB0C RID: 43788 RVA: 0x002F9AC8 File Offset: 0x002F7CC8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600AB0D RID: 43789 RVA: 0x002F9AD8 File Offset: 0x002F7CD8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600AB0E RID: 43790 RVA: 0x002F9AE8 File Offset: 0x002F7CE8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600AB0F RID: 43791 RVA: 0x002F9AF8 File Offset: 0x002F7CF8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600AB10 RID: 43792 RVA: 0x002F9B08 File Offset: 0x002F7D08
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600AB11 RID: 43793 RVA: 0x002F9B18 File Offset: 0x002F7D18
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600AB12 RID: 43794 RVA: 0x002F9B28 File Offset: 0x002F7D28
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600AB13 RID: 43795 RVA: 0x002F9B38 File Offset: 0x002F7D38
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600AB14 RID: 43796 RVA: 0x002F9B48 File Offset: 0x002F7D48
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600AB15 RID: 43797 RVA: 0x002F9B58 File Offset: 0x002F7D58
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170022A2 RID: 8866
			// (get) Token: 0x0600AB16 RID: 43798 RVA: 0x002F9B68 File Offset: 0x002F7D68
			// (set) Token: 0x0600AB17 RID: 43799 RVA: 0x002F9B78 File Offset: 0x002F7D78
			public Text m_turnText
			{
				get
				{
					return this.m_owner.m_turnText;
				}
				set
				{
					this.m_owner.m_turnText = value;
				}
			}

			// Token: 0x170022A3 RID: 8867
			// (get) Token: 0x0600AB18 RID: 43800 RVA: 0x002F9B88 File Offset: 0x002F7D88
			// (set) Token: 0x0600AB19 RID: 43801 RVA: 0x002F9B98 File Offset: 0x002F7D98
			public Text m_contentText
			{
				get
				{
					return this.m_owner.m_contentText;
				}
				set
				{
					this.m_owner.m_contentText = value;
				}
			}

			// Token: 0x170022A4 RID: 8868
			// (get) Token: 0x0600AB1A RID: 43802 RVA: 0x002F9BA8 File Offset: 0x002F7DA8
			// (set) Token: 0x0600AB1B RID: 43803 RVA: 0x002F9BB8 File Offset: 0x002F7DB8
			public TweenPos m_contentTextTweenPos
			{
				get
				{
					return this.m_owner.m_contentTextTweenPos;
				}
				set
				{
					this.m_owner.m_contentTextTweenPos = value;
				}
			}

			// Token: 0x170022A5 RID: 8869
			// (get) Token: 0x0600AB1C RID: 43804 RVA: 0x002F9BC8 File Offset: 0x002F7DC8
			// (set) Token: 0x0600AB1D RID: 43805 RVA: 0x002F9BD8 File Offset: 0x002F7DD8
			public RectTransform m_textMaskRectTransform
			{
				get
				{
					return this.m_owner.m_textMaskRectTransform;
				}
				set
				{
					this.m_owner.m_textMaskRectTransform = value;
				}
			}

			// Token: 0x0600AB1E RID: 43806 RVA: 0x002F9BE8 File Offset: 0x002F7DE8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400703F RID: 28735
			private DanmakuItemUIController m_owner;
		}
	}
}
