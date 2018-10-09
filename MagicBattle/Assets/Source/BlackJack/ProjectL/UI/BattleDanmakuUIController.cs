using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A68 RID: 2664
	[HotFix]
	public class BattleDanmakuUIController : UIControllerBase
	{
		// Token: 0x0600A718 RID: 42776 RVA: 0x002ECD0C File Offset: 0x002EAF0C
		private BattleDanmakuUIController()
		{
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x002ECD4C File Offset: 0x002EAF4C
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

		// Token: 0x0600A71A RID: 42778 RVA: 0x002ECDC0 File Offset: 0x002EAFC0
		public void ShowCurTurnDanmaku(int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCurTurnDanmakuInt32_hotfix != null)
			{
				this.m_ShowCurTurnDanmakuInt32_hotfix.call(new object[]
				{
					this,
					turn2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int turn = turn2;
			LevelDanmaku levelDanmaku = this.m_playerContext.GetLevelDanmaku();
			if (levelDanmaku != null)
			{
				TurnDanmaku turnDanmaku = levelDanmaku.Turns.Find((TurnDanmaku danmakuTurn) => danmakuTurn.Turn == turn);
				if (turnDanmaku != null)
				{
					List<DanmakuEntry> entries = turnDanmaku.Entries;
					if (entries == null || entries.Count == 0)
					{
						return;
					}
					List<DanmakuEntry> list = new List<DanmakuEntry>();
					list.AddRange(entries);
					list.Reverse();
					base.StartCoroutine(this.Co_ShowDanmakus(list));
				}
			}
		}

		// Token: 0x0600A71B RID: 42779 RVA: 0x002ECEAC File Offset: 0x002EB0AC
		[DebuggerHidden]
		private IEnumerator Co_ShowDanmakus(List<DanmakuEntry> danmakus)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowDanmakusList`1_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowDanmakusList`1_hotfix.call(new object[]
				{
					this,
					danmakus
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleDanmakuUIController.<Co_ShowDanmakus>c__Iterator0 <Co_ShowDanmakus>c__Iterator = new BattleDanmakuUIController.<Co_ShowDanmakus>c__Iterator0();
			<Co_ShowDanmakus>c__Iterator.danmakus = danmakus;
			<Co_ShowDanmakus>c__Iterator.$this = this;
			return <Co_ShowDanmakus>c__Iterator;
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x002ECF40 File Offset: 0x002EB140
		public void ShowOneDanmaku(DanmakuEntry danmaku)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOneDanmakuDanmakuEntry_hotfix != null)
			{
				this.m_ShowOneDanmakuDanmakuEntry_hotfix.call(new object[]
				{
					this,
					danmaku
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text newTxt = null;
			if (this.m_playerContext.IsMe(danmaku.UserId))
			{
				newTxt = UnityEngine.Object.Instantiate<Text>(this.m_danmakuMyText);
			}
			else
			{
				newTxt = UnityEngine.Object.Instantiate<Text>(this.m_danmakuCommonText);
			}
			newTxt.text = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(danmaku.Content, '*');
			newTxt.gameObject.SetActive(true);
			newTxt.transform.SetParent(this.m_danmakuContent.transform, false);
			TweenPos2 component = newTxt.GetComponent<TweenPos2>();
			int y = this.GetRandomYPOsition();
			component.from = new Vector3(component.from.x, (float)y, 0f);
			component.to = new Vector3(component.to.x, (float)y, 0f);
			int num = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_DanmakuMoveSpeedMax);
			int num2 = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_DanmakuMoveSpeedMin);
			System.Random random = new System.Random();
			float duration = (float)random.Next((num - num2) * 10) / 10f + (float)num2;
			component.duration = duration;
			UIUtility.ReplayTween(newTxt.gameObject, delegate
			{
				UnityEngine.Object.DestroyImmediate(newTxt.gameObject);
				this.m_danmakuYPosList.Remove(y);
			});
		}

		// Token: 0x0600A71D RID: 42781 RVA: 0x002ED114 File Offset: 0x002EB314
		private int GetRandomYPOsition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRandomYPOsition_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRandomYPOsition_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			System.Random random = new System.Random();
			int num = (random.Next(60) - 30) * 10;
			int count = this.m_danmakuYPosList.Count;
			int num2 = 0;
			while (!this.IsYPositonAvailable(num, count))
			{
				num = (random.Next(60) - 30) * 10;
				if (num2++ > 50)
				{
					break;
				}
			}
			if (!this.m_danmakuYPosList.Contains(num))
			{
				this.m_danmakuYPosList.Add(num);
			}
			return num;
		}

		// Token: 0x0600A71E RID: 42782 RVA: 0x002ED1F4 File Offset: 0x002EB3F4
		private bool IsYPositonAvailable(int y, int listCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsYPositonAvailableInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsYPositonAvailableInt32Int32_hotfix.call(new object[]
				{
					this,
					y,
					listCount
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (int num2 in this.m_danmakuYPosList)
			{
				if (Math.Abs(y - num2) < 50)
				{
					num++;
				}
			}
			return num == 0 || num >= listCount;
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x0600A71F RID: 42783 RVA: 0x002ED2F0 File Offset: 0x002EB4F0
		// (set) Token: 0x0600A720 RID: 42784 RVA: 0x002ED310 File Offset: 0x002EB510
		[DoNotToLua]
		public new BattleDanmakuUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleDanmakuUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x002ED31C File Offset: 0x002EB51C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x002ED328 File Offset: 0x002EB528
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x002ED330 File Offset: 0x002EB530
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A724 RID: 42788 RVA: 0x002ED338 File Offset: 0x002EB538
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A725 RID: 42789 RVA: 0x002ED34C File Offset: 0x002EB54C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A726 RID: 42790 RVA: 0x002ED354 File Offset: 0x002EB554
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A727 RID: 42791 RVA: 0x002ED360 File Offset: 0x002EB560
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A728 RID: 42792 RVA: 0x002ED36C File Offset: 0x002EB56C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A729 RID: 42793 RVA: 0x002ED378 File Offset: 0x002EB578
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A72A RID: 42794 RVA: 0x002ED384 File Offset: 0x002EB584
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x002ED390 File Offset: 0x002EB590
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x002ED39C File Offset: 0x002EB59C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A72D RID: 42797 RVA: 0x002ED3A8 File Offset: 0x002EB5A8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A72E RID: 42798 RVA: 0x002ED3B4 File Offset: 0x002EB5B4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A72F RID: 42799 RVA: 0x002ED3C0 File Offset: 0x002EB5C0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x002ED3C8 File Offset: 0x002EB5C8
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
					this.m_ShowCurTurnDanmakuInt32_hotfix = (luaObj.RawGet("ShowCurTurnDanmaku") as LuaFunction);
					this.m_Co_ShowDanmakusList`1_hotfix = (luaObj.RawGet("Co_ShowDanmakus") as LuaFunction);
					this.m_ShowOneDanmakuDanmakuEntry_hotfix = (luaObj.RawGet("ShowOneDanmaku") as LuaFunction);
					this.m_GetRandomYPOsition_hotfix = (luaObj.RawGet("GetRandomYPOsition") as LuaFunction);
					this.m_IsYPositonAvailableInt32Int32_hotfix = (luaObj.RawGet("IsYPositonAvailable") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x002ED510 File Offset: 0x002EB710
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleDanmakuUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006EB5 RID: 28341
		[AutoBind("./Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_danmakuContent;

		// Token: 0x04006EB6 RID: 28342
		[AutoBind("./Prefab/CommonText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_danmakuCommonText;

		// Token: 0x04006EB7 RID: 28343
		[AutoBind("./Prefab/MyText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_danmakuMyText;

		// Token: 0x04006EB8 RID: 28344
		private List<int> m_danmakuYPosList = new List<int>();

		// Token: 0x04006EB9 RID: 28345
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04006EBA RID: 28346
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04006EBB RID: 28347
		[DoNotToLua]
		private BattleDanmakuUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006EBC RID: 28348
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006EBD RID: 28349
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006EBE RID: 28350
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006EBF RID: 28351
		private LuaFunction m_ShowCurTurnDanmakuInt32_hotfix;

		// Token: 0x04006EC0 RID: 28352
		private LuaFunction m_Co_ShowDanmakusList;

		// Token: 0x04006EC1 RID: 28353
		private LuaFunction m_ShowOneDanmakuDanmakuEntry_hotfix;

		// Token: 0x04006EC2 RID: 28354
		private LuaFunction m_GetRandomYPOsition_hotfix;

		// Token: 0x04006EC3 RID: 28355
		private LuaFunction m_IsYPositonAvailableInt32Int32_hotfix;

		// Token: 0x02000A69 RID: 2665
		public new class LuaExportHelper
		{
			// Token: 0x0600A732 RID: 42802 RVA: 0x002ED578 File Offset: 0x002EB778
			public LuaExportHelper(BattleDanmakuUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A733 RID: 42803 RVA: 0x002ED588 File Offset: 0x002EB788
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A734 RID: 42804 RVA: 0x002ED598 File Offset: 0x002EB798
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A735 RID: 42805 RVA: 0x002ED5A8 File Offset: 0x002EB7A8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A736 RID: 42806 RVA: 0x002ED5B8 File Offset: 0x002EB7B8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A737 RID: 42807 RVA: 0x002ED5D0 File Offset: 0x002EB7D0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A738 RID: 42808 RVA: 0x002ED5E0 File Offset: 0x002EB7E0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A739 RID: 42809 RVA: 0x002ED5F0 File Offset: 0x002EB7F0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A73A RID: 42810 RVA: 0x002ED600 File Offset: 0x002EB800
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A73B RID: 42811 RVA: 0x002ED610 File Offset: 0x002EB810
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A73C RID: 42812 RVA: 0x002ED620 File Offset: 0x002EB820
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A73D RID: 42813 RVA: 0x002ED630 File Offset: 0x002EB830
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A73E RID: 42814 RVA: 0x002ED640 File Offset: 0x002EB840
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A73F RID: 42815 RVA: 0x002ED650 File Offset: 0x002EB850
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A740 RID: 42816 RVA: 0x002ED660 File Offset: 0x002EB860
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A741 RID: 42817 RVA: 0x002ED670 File Offset: 0x002EB870
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170021F6 RID: 8694
			// (get) Token: 0x0600A742 RID: 42818 RVA: 0x002ED680 File Offset: 0x002EB880
			// (set) Token: 0x0600A743 RID: 42819 RVA: 0x002ED690 File Offset: 0x002EB890
			public GameObject m_danmakuContent
			{
				get
				{
					return this.m_owner.m_danmakuContent;
				}
				set
				{
					this.m_owner.m_danmakuContent = value;
				}
			}

			// Token: 0x170021F7 RID: 8695
			// (get) Token: 0x0600A744 RID: 42820 RVA: 0x002ED6A0 File Offset: 0x002EB8A0
			// (set) Token: 0x0600A745 RID: 42821 RVA: 0x002ED6B0 File Offset: 0x002EB8B0
			public Text m_danmakuCommonText
			{
				get
				{
					return this.m_owner.m_danmakuCommonText;
				}
				set
				{
					this.m_owner.m_danmakuCommonText = value;
				}
			}

			// Token: 0x170021F8 RID: 8696
			// (get) Token: 0x0600A746 RID: 42822 RVA: 0x002ED6C0 File Offset: 0x002EB8C0
			// (set) Token: 0x0600A747 RID: 42823 RVA: 0x002ED6D0 File Offset: 0x002EB8D0
			public Text m_danmakuMyText
			{
				get
				{
					return this.m_owner.m_danmakuMyText;
				}
				set
				{
					this.m_owner.m_danmakuMyText = value;
				}
			}

			// Token: 0x170021F9 RID: 8697
			// (get) Token: 0x0600A748 RID: 42824 RVA: 0x002ED6E0 File Offset: 0x002EB8E0
			// (set) Token: 0x0600A749 RID: 42825 RVA: 0x002ED6F0 File Offset: 0x002EB8F0
			public List<int> m_danmakuYPosList
			{
				get
				{
					return this.m_owner.m_danmakuYPosList;
				}
				set
				{
					this.m_owner.m_danmakuYPosList = value;
				}
			}

			// Token: 0x170021FA RID: 8698
			// (get) Token: 0x0600A74A RID: 42826 RVA: 0x002ED700 File Offset: 0x002EB900
			// (set) Token: 0x0600A74B RID: 42827 RVA: 0x002ED710 File Offset: 0x002EB910
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

			// Token: 0x170021FB RID: 8699
			// (get) Token: 0x0600A74C RID: 42828 RVA: 0x002ED720 File Offset: 0x002EB920
			// (set) Token: 0x0600A74D RID: 42829 RVA: 0x002ED730 File Offset: 0x002EB930
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

			// Token: 0x0600A74E RID: 42830 RVA: 0x002ED740 File Offset: 0x002EB940
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A74F RID: 42831 RVA: 0x002ED750 File Offset: 0x002EB950
			public IEnumerator Co_ShowDanmakus(List<DanmakuEntry> danmakus)
			{
				return this.m_owner.Co_ShowDanmakus(danmakus);
			}

			// Token: 0x0600A750 RID: 42832 RVA: 0x002ED760 File Offset: 0x002EB960
			public int GetRandomYPOsition()
			{
				return this.m_owner.GetRandomYPOsition();
			}

			// Token: 0x0600A751 RID: 42833 RVA: 0x002ED770 File Offset: 0x002EB970
			public bool IsYPositonAvailable(int y, int listCount)
			{
				return this.m_owner.IsYPositonAvailable(y, listCount);
			}

			// Token: 0x04006EC4 RID: 28356
			private BattleDanmakuUIController m_owner;
		}
	}
}
