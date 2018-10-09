using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000FD RID: 253
	[HotFixManually]
	public class UIControllerBase : PrefabControllerBase
	{
		// Token: 0x06000A21 RID: 2593 RVA: 0x0002B524 File Offset: 0x00029724
		public override void Initlize(string ctrlName, bool bindNow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_InitlizeStringBoolean_hotfix != null)
			{
				this.m_InitlizeStringBoolean_hotfix.call(new object[]
				{
					this,
					ctrlName,
					bindNow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0002B59C File Offset: 0x0002979C
		public override void BindFields()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_BindFields_hotfix != null)
			{
				this.m_BindFields_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.BindFields();
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0002B5F4 File Offset: 0x000297F4
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			if (this.AutoInitLocalizedString)
			{
				UIControllerBase.InitLocalizedString(base.gameObject);
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0002B660 File Offset: 0x00029860
		protected override UnityEngine.Object BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName = null, bool optional = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_BindFieldImplTypeStringInitStateStringStringBoolean_hotfix != null)
			{
				return (UnityEngine.Object)this.m_BindFieldImplTypeStringInitStateStringStringBoolean_hotfix.call(new object[]
				{
					this,
					fieldType,
					path,
					initState,
					fieldName2,
					ctrlName,
					optional
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string fieldName = fieldName2;
			UIControllerBase $this = this;
			GameObject childByPath = base.GetChildByPath(path);
			if (childByPath == null)
			{
				global::Debug.LogError(string.Format("BindFields fail can not found child {0}", path));
				return null;
			}
			UnityEngine.Object result;
			if (fieldType.IsSubclassOf(typeof(Selectable)))
			{
				Component component = childByPath.GetComponent(fieldType);
				if (component == null)
				{
					global::Debug.LogError(string.Format("BindFields fail can not found comp in child {0} {1}", path, fieldType.Name));
					return null;
				}
				result = component;
				string name = fieldType.Name;
				if (name != null)
				{
					if (!(name == "Button"))
					{
						if (!(name == "ButtonEx"))
						{
							if (!(name == "Toggle"))
							{
								if (name == "ToggleEx")
								{
									ToggleEx toggle = component as ToggleEx;
									if (toggle != null)
									{
										toggle.onValueChanged.AddListener(delegate(bool value)
										{
											$this.OnToggleValueChanged(toggle, fieldName, value);
										});
									}
								}
							}
							else
							{
								Toggle toggle = component as Toggle;
								if (toggle != null)
								{
									toggle.onValueChanged.AddListener(delegate(bool value)
									{
										$this.OnToggleValueChanged(toggle, fieldName, value);
									});
								}
							}
						}
						else
						{
							ButtonEx button = component as ButtonEx;
							if (button != null)
							{
								button.onClick.AddListener(delegate()
								{
									$this.OnButtonClick(button, fieldName);
								});
								button.onDoubleClick.AddListener(delegate()
								{
									$this.OnButtonDoubleClick(button, fieldName);
								});
								button.onLongPressStart.AddListener(delegate()
								{
									$this.OnButtonLongPressStart(button, fieldName);
								});
								button.onLongPressing.AddListener(delegate()
								{
									$this.OnButtonLongPressing(button, fieldName);
								});
								button.onLongPressEnd.AddListener(delegate()
								{
									$this.OnButtonLongPressEnd(button, fieldName);
								});
							}
						}
					}
					else
					{
						Button button = component as Button;
						if (button != null)
						{
							button.onClick.AddListener(delegate()
							{
								$this.OnButtonClick(button, fieldName);
							});
						}
					}
				}
			}
			else
			{
				result = base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}
			if (initState == AutoBindAttribute.InitState.Active)
			{
				childByPath.SetActive(true);
			}
			else if (initState == AutoBindAttribute.InitState.Inactive)
			{
				childByPath.SetActive(false);
			}
			return result;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0002B9F0 File Offset: 0x00029BF0
		public virtual void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_buttonClickListenerDict = null;
			this.m_toggleValueChangedListenerDict = null;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0002BA50 File Offset: 0x00029C50
		protected void OnButtonClick(Button button, string fieldName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnButtonClickButtonString_hotfix != null)
			{
				this.m_OnButtonClickButtonString_hotfix.call(new object[]
				{
					this,
					button,
					fieldName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonClickListenerDict == null)
			{
				return;
			}
			if (!UIControllerBase.CheckAndUpdateCurrFrameButtonClickStateInfo())
			{
				return;
			}
			Action<UIControllerBase> action;
			if (this.m_buttonClickListenerDict.TryGetValue(fieldName, out action) && action != null)
			{
				action(this);
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0002BAF8 File Offset: 0x00029CF8
		public static bool CheckAndUpdateCurrFrameButtonClickStateInfo()
		{
			int currFrameCount = Timer.GetCurrFrameCount();
			if (currFrameCount == UIControllerBase.m_lastButtonClickFrameCount)
			{
				return false;
			}
			UIControllerBase.m_lastButtonClickFrameCount = currFrameCount;
			return true;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0002BB20 File Offset: 0x00029D20
		private void OnButtonDoubleClick(Button button, string fieldName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnButtonDoubleClickButtonString_hotfix != null)
			{
				this.m_OnButtonDoubleClickButtonString_hotfix.call(new object[]
				{
					this,
					button,
					fieldName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonDoubleClickListenerDict == null)
			{
				return;
			}
			Action<UIControllerBase> action;
			if (this.m_buttonDoubleClickListenerDict.TryGetValue(fieldName, out action) && action != null)
			{
				action(this);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002BBBC File Offset: 0x00029DBC
		private void OnButtonLongPressStart(Button button, string fieldName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnButtonLongPressStartButtonString_hotfix != null)
			{
				this.m_OnButtonLongPressStartButtonString_hotfix.call(new object[]
				{
					this,
					button,
					fieldName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonLongPressStartListenerDict == null)
			{
				return;
			}
			Action<UIControllerBase> action;
			if (this.m_buttonLongPressStartListenerDict.TryGetValue(fieldName, out action) && action != null)
			{
				action(this);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0002BC58 File Offset: 0x00029E58
		private void OnButtonLongPressing(Button button, string fieldName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnButtonLongPressingButtonString_hotfix != null)
			{
				this.m_OnButtonLongPressingButtonString_hotfix.call(new object[]
				{
					this,
					button,
					fieldName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonLongPressingListenerDict == null)
			{
				return;
			}
			Action<UIControllerBase> action;
			if (this.m_buttonLongPressingListenerDict.TryGetValue(fieldName, out action) && action != null)
			{
				action(this);
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0002BCF4 File Offset: 0x00029EF4
		private void OnButtonLongPressEnd(Button button, string fieldName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnButtonLongPressEndButtonString_hotfix != null)
			{
				this.m_OnButtonLongPressEndButtonString_hotfix.call(new object[]
				{
					this,
					button,
					fieldName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonLongPressEndListenerDict == null)
			{
				return;
			}
			Action<UIControllerBase> action;
			if (this.m_buttonLongPressEndListenerDict.TryGetValue(fieldName, out action) && action != null)
			{
				action(this);
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0002BD90 File Offset: 0x00029F90
		public void SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetButtonClickListenerStringAction`1_hotfix != null)
			{
				this.m_SetButtonClickListenerStringAction`1_hotfix.call(new object[]
				{
					this,
					fieldName,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonClickListenerDict == null)
			{
				this.m_buttonClickListenerDict = new Dictionary<string, Action<UIControllerBase>>();
			}
			this.m_buttonClickListenerDict[fieldName] = action;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0002BE24 File Offset: 0x0002A024
		public void SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetButtonClickListenerStringbeAction`1_hotfix != null)
			{
				this.m_SetButtonClickListenerStringbeAction`1_hotfix.call(new object[]
				{
					this,
					fieldNames,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (string key in fieldNames)
			{
				if (this.m_buttonClickListenerDict == null)
				{
					this.m_buttonClickListenerDict = new Dictionary<string, Action<UIControllerBase>>();
				}
				this.m_buttonClickListenerDict[key] = action;
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0002BED4 File Offset: 0x0002A0D4
		public void SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetButtonDoubleClickListenerStringAction`1_hotfix != null)
			{
				this.m_SetButtonDoubleClickListenerStringAction`1_hotfix.call(new object[]
				{
					this,
					fieldName,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonDoubleClickListenerDict == null)
			{
				this.m_buttonDoubleClickListenerDict = new Dictionary<string, Action<UIControllerBase>>();
			}
			this.m_buttonDoubleClickListenerDict[fieldName] = action;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0002BF68 File Offset: 0x0002A168
		public void SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetButtonLongPressStartListenerStringAction`1_hotfix != null)
			{
				this.m_SetButtonLongPressStartListenerStringAction`1_hotfix.call(new object[]
				{
					this,
					fieldName,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonLongPressStartListenerDict == null)
			{
				this.m_buttonLongPressStartListenerDict = new Dictionary<string, Action<UIControllerBase>>();
			}
			this.m_buttonLongPressStartListenerDict[fieldName] = action;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0002BFFC File Offset: 0x0002A1FC
		public void SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetButtonLongPressingListenerStringAction`1_hotfix != null)
			{
				this.m_SetButtonLongPressingListenerStringAction`1_hotfix.call(new object[]
				{
					this,
					fieldName,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonLongPressingListenerDict == null)
			{
				this.m_buttonLongPressingListenerDict = new Dictionary<string, Action<UIControllerBase>>();
			}
			this.m_buttonLongPressingListenerDict[fieldName] = action;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0002C090 File Offset: 0x0002A290
		public void SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetButtonLongPressEndListenerStringAction`1_hotfix != null)
			{
				this.m_SetButtonLongPressEndListenerStringAction`1_hotfix.call(new object[]
				{
					this,
					fieldName,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buttonLongPressEndListenerDict == null)
			{
				this.m_buttonLongPressEndListenerDict = new Dictionary<string, Action<UIControllerBase>>();
			}
			this.m_buttonLongPressEndListenerDict[fieldName] = action;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0002C124 File Offset: 0x0002A324
		private void OnToggleValueChanged(Toggle toggle, string fieldName, bool value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_OnToggleValueChangedToggleStringBoolean_hotfix != null)
			{
				this.m_OnToggleValueChangedToggleStringBoolean_hotfix.call(new object[]
				{
					this,
					toggle,
					fieldName,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_toggleValueChangedListenerDict == null)
			{
				return;
			}
			Action<UIControllerBase, bool> action;
			if (this.m_toggleValueChangedListenerDict.TryGetValue(fieldName, out action) && action != null)
			{
				action(this, value);
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0002C1D4 File Offset: 0x0002A3D4
		public void SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetToggleValueChangedListenerStringAction`2_hotfix != null)
			{
				this.m_SetToggleValueChangedListenerStringAction`2_hotfix.call(new object[]
				{
					this,
					fieldName,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_toggleValueChangedListenerDict == null)
			{
				this.m_toggleValueChangedListenerDict = new Dictionary<string, Action<UIControllerBase, bool>>();
			}
			this.m_toggleValueChangedListenerDict[fieldName] = action;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0002C268 File Offset: 0x0002A468
		public void SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_SetToggleValueChangedListenerStringbeAction`2_hotfix != null)
			{
				this.m_SetToggleValueChangedListenerStringbeAction`2_hotfix.call(new object[]
				{
					this,
					fieldNames,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (string key in fieldNames)
			{
				if (this.m_toggleValueChangedListenerDict == null)
				{
					this.m_toggleValueChangedListenerDict = new Dictionary<string, Action<UIControllerBase, bool>>();
				}
				this.m_toggleValueChangedListenerDict[key] = action;
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0002C318 File Offset: 0x0002A518
		public override string ToString()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.m_ToString_hotfix != null)
			{
				return (string)this.m_ToString_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return string.Format("{0}:{1}", base.ToString(), this.m_ctrlName);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0002C38C File Offset: 0x0002A58C
		public static void InitLocalizedString(GameObject goRoot)
		{
			UITextLocalizationHelper[] componentsInChildren = goRoot.GetComponentsInChildren<UITextLocalizationHelper>(true);
			foreach (UITextLocalizationHelper uitextLocalizationHelper in componentsInChildren)
			{
				uitextLocalizationHelper.LoadLocatizedString();
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0002C3C4 File Offset: 0x0002A5C4
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0002C3E4 File Offset: 0x0002A5E4
		[DoNotToLua]
		public UIControllerBase.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UIControllerBase.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002C3F0 File Offset: 0x0002A5F0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002C3FC File Offset: 0x0002A5FC
		private UnityEngine.Object __callBase_GetAssetInContainer(string resName)
		{
			return base.GetAssetInContainer(resName);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0002C408 File Offset: 0x0002A608
		private void __callBase_BindResContainer()
		{
			base.BindResContainer();
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0002C410 File Offset: 0x0002A610
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0002C418 File Offset: 0x0002A618
		private PrefabControllerNextUpdateExecutor __callBase_GetNextUpdateExecutor()
		{
			return base.GetNextUpdateExecutor();
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0002C420 File Offset: 0x0002A620
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0002C428 File Offset: 0x0002A628
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0002C43C File Offset: 0x0002A63C
		private GameObject __callBase_GetChildByPath(string path)
		{
			return base.GetChildByPath(path);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002C450 File Offset: 0x0002A650
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
					this.m_InitlizeStringBoolean_hotfix = (luaObj.RawGet("Initlize") as LuaFunction);
					this.m_BindFields_hotfix = (luaObj.RawGet("BindFields") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_BindFieldImplTypeStringInitStateStringStringBoolean_hotfix = (luaObj.RawGet("BindFieldImpl") as LuaFunction);
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_OnButtonClickButtonString_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					this.m_OnButtonDoubleClickButtonString_hotfix = (luaObj.RawGet("OnButtonDoubleClick") as LuaFunction);
					this.m_OnButtonLongPressStartButtonString_hotfix = (luaObj.RawGet("OnButtonLongPressStart") as LuaFunction);
					this.m_OnButtonLongPressingButtonString_hotfix = (luaObj.RawGet("OnButtonLongPressing") as LuaFunction);
					this.m_OnButtonLongPressEndButtonString_hotfix = (luaObj.RawGet("OnButtonLongPressEnd") as LuaFunction);
					this.m_SetButtonClickListenerStringAction`1_hotfix = (luaObj.RawGet("SetButtonClickListener") as LuaFunction);
					this.m_SetButtonClickListenerStringbeAction`1_hotfix = (luaObj.RawGet("SetButtonClickListener") as LuaFunction);
					this.m_SetButtonDoubleClickListenerStringAction`1_hotfix = (luaObj.RawGet("SetButtonDoubleClickListener") as LuaFunction);
					this.m_SetButtonLongPressStartListenerStringAction`1_hotfix = (luaObj.RawGet("SetButtonLongPressStartListener") as LuaFunction);
					this.m_SetButtonLongPressingListenerStringAction`1_hotfix = (luaObj.RawGet("SetButtonLongPressingListener") as LuaFunction);
					this.m_SetButtonLongPressEndListenerStringAction`1_hotfix = (luaObj.RawGet("SetButtonLongPressEndListener") as LuaFunction);
					this.m_OnToggleValueChangedToggleStringBoolean_hotfix = (luaObj.RawGet("OnToggleValueChanged") as LuaFunction);
					this.m_SetToggleValueChangedListenerStringAction`2_hotfix = (luaObj.RawGet("SetToggleValueChangedListener") as LuaFunction);
					this.m_SetToggleValueChangedListenerStringbeAction`2_hotfix = (luaObj.RawGet("SetToggleValueChangedListener") as LuaFunction);
					this.m_ToString_hotfix = (luaObj.RawGet("ToString") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002C6F8 File Offset: 0x0002A8F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UIControllerBase));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04000613 RID: 1555
		public bool AutoInitLocalizedString = true;

		// Token: 0x04000614 RID: 1556
		protected Dictionary<string, Action<UIControllerBase>> m_buttonClickListenerDict;

		// Token: 0x04000615 RID: 1557
		protected Dictionary<string, Action<UIControllerBase>> m_buttonDoubleClickListenerDict;

		// Token: 0x04000616 RID: 1558
		protected Dictionary<string, Action<UIControllerBase>> m_buttonLongPressStartListenerDict;

		// Token: 0x04000617 RID: 1559
		protected Dictionary<string, Action<UIControllerBase>> m_buttonLongPressingListenerDict;

		// Token: 0x04000618 RID: 1560
		protected Dictionary<string, Action<UIControllerBase>> m_buttonLongPressEndListenerDict;

		// Token: 0x04000619 RID: 1561
		protected Dictionary<string, Action<UIControllerBase, bool>> m_toggleValueChangedListenerDict;

		// Token: 0x0400061A RID: 1562
		private static int m_lastButtonClickFrameCount = -1;

		// Token: 0x0400061B RID: 1563
		[DoNotToLua]
		private UIControllerBase.LuaExportHelper luaExportHelper;

		// Token: 0x0400061C RID: 1564
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400061D RID: 1565
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400061E RID: 1566
		private LuaFunction m_InitlizeStringBoolean_hotfix;

		// Token: 0x0400061F RID: 1567
		private LuaFunction m_BindFields_hotfix;

		// Token: 0x04000620 RID: 1568
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04000621 RID: 1569
		private LuaFunction m_BindFieldImplTypeStringInitStateStringStringBoolean_hotfix;

		// Token: 0x04000622 RID: 1570
		private LuaFunction m_Clear_hotfix;

		// Token: 0x04000623 RID: 1571
		private LuaFunction m_OnButtonClickButtonString_hotfix;

		// Token: 0x04000624 RID: 1572
		private LuaFunction m_OnButtonDoubleClickButtonString_hotfix;

		// Token: 0x04000625 RID: 1573
		private LuaFunction m_OnButtonLongPressStartButtonString_hotfix;

		// Token: 0x04000626 RID: 1574
		private LuaFunction m_OnButtonLongPressingButtonString_hotfix;

		// Token: 0x04000627 RID: 1575
		private LuaFunction m_OnButtonLongPressEndButtonString_hotfix;

		// Token: 0x04000628 RID: 1576
		private LuaFunction m_SetButtonClickListenerStringAction;

		// Token: 0x04000629 RID: 1577
		private LuaFunction m_SetButtonClickListenerStringbeAction;

		// Token: 0x0400062A RID: 1578
		private LuaFunction m_SetButtonDoubleClickListenerStringAction;

		// Token: 0x0400062B RID: 1579
		private LuaFunction m_SetButtonLongPressStartListenerStringAction;

		// Token: 0x0400062C RID: 1580
		private LuaFunction m_SetButtonLongPressingListenerStringAction;

		// Token: 0x0400062D RID: 1581
		private LuaFunction m_SetButtonLongPressEndListenerStringAction;

		// Token: 0x0400062E RID: 1582
		private LuaFunction m_OnToggleValueChangedToggleStringBoolean_hotfix;

		// Token: 0x0400062F RID: 1583
		private LuaFunction m_SetToggleValueChangedListenerStringAction;

		// Token: 0x04000630 RID: 1584
		private LuaFunction m_SetToggleValueChangedListenerStringbeAction;

		// Token: 0x04000631 RID: 1585
		private LuaFunction m_ToString_hotfix;

		// Token: 0x020000FE RID: 254
		public class LuaExportHelper
		{
			// Token: 0x06000A44 RID: 2628 RVA: 0x0002C760 File Offset: 0x0002A960
			public LuaExportHelper(UIControllerBase owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06000A45 RID: 2629 RVA: 0x0002C770 File Offset: 0x0002A970
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06000A46 RID: 2630 RVA: 0x0002C780 File Offset: 0x0002A980
			public UnityEngine.Object __callBase_GetAssetInContainer(string resName)
			{
				return this.m_owner.__callBase_GetAssetInContainer(resName);
			}

			// Token: 0x06000A47 RID: 2631 RVA: 0x0002C790 File Offset: 0x0002A990
			public void __callBase_BindResContainer()
			{
				this.m_owner.__callBase_BindResContainer();
			}

			// Token: 0x06000A48 RID: 2632 RVA: 0x0002C7A0 File Offset: 0x0002A9A0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06000A49 RID: 2633 RVA: 0x0002C7B0 File Offset: 0x0002A9B0
			public PrefabControllerNextUpdateExecutor __callBase_GetNextUpdateExecutor()
			{
				return this.m_owner.__callBase_GetNextUpdateExecutor();
			}

			// Token: 0x06000A4A RID: 2634 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06000A4B RID: 2635 RVA: 0x0002C7D0 File Offset: 0x0002A9D0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06000A4C RID: 2636 RVA: 0x0002C7E8 File Offset: 0x0002A9E8
			public GameObject __callBase_GetChildByPath(string path)
			{
				return this.m_owner.__callBase_GetChildByPath(path);
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0002C7F8 File Offset: 0x0002A9F8
			// (set) Token: 0x06000A4E RID: 2638 RVA: 0x0002C808 File Offset: 0x0002AA08
			public Dictionary<string, Action<UIControllerBase>> m_buttonClickListenerDict
			{
				get
				{
					return this.m_owner.m_buttonClickListenerDict;
				}
				set
				{
					this.m_owner.m_buttonClickListenerDict = value;
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0002C818 File Offset: 0x0002AA18
			// (set) Token: 0x06000A50 RID: 2640 RVA: 0x0002C828 File Offset: 0x0002AA28
			public Dictionary<string, Action<UIControllerBase>> m_buttonDoubleClickListenerDict
			{
				get
				{
					return this.m_owner.m_buttonDoubleClickListenerDict;
				}
				set
				{
					this.m_owner.m_buttonDoubleClickListenerDict = value;
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0002C838 File Offset: 0x0002AA38
			// (set) Token: 0x06000A52 RID: 2642 RVA: 0x0002C848 File Offset: 0x0002AA48
			public Dictionary<string, Action<UIControllerBase>> m_buttonLongPressStartListenerDict
			{
				get
				{
					return this.m_owner.m_buttonLongPressStartListenerDict;
				}
				set
				{
					this.m_owner.m_buttonLongPressStartListenerDict = value;
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0002C858 File Offset: 0x0002AA58
			// (set) Token: 0x06000A54 RID: 2644 RVA: 0x0002C868 File Offset: 0x0002AA68
			public Dictionary<string, Action<UIControllerBase>> m_buttonLongPressingListenerDict
			{
				get
				{
					return this.m_owner.m_buttonLongPressingListenerDict;
				}
				set
				{
					this.m_owner.m_buttonLongPressingListenerDict = value;
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0002C878 File Offset: 0x0002AA78
			// (set) Token: 0x06000A56 RID: 2646 RVA: 0x0002C888 File Offset: 0x0002AA88
			public Dictionary<string, Action<UIControllerBase>> m_buttonLongPressEndListenerDict
			{
				get
				{
					return this.m_owner.m_buttonLongPressEndListenerDict;
				}
				set
				{
					this.m_owner.m_buttonLongPressEndListenerDict = value;
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0002C898 File Offset: 0x0002AA98
			// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
			public Dictionary<string, Action<UIControllerBase, bool>> m_toggleValueChangedListenerDict
			{
				get
				{
					return this.m_owner.m_toggleValueChangedListenerDict;
				}
				set
				{
					this.m_owner.m_toggleValueChangedListenerDict = value;
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002C8B8 File Offset: 0x0002AAB8
			// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0002C8C0 File Offset: 0x0002AAC0
			public static int m_lastButtonClickFrameCount
			{
				get
				{
					return UIControllerBase.m_lastButtonClickFrameCount;
				}
				set
				{
					UIControllerBase.m_lastButtonClickFrameCount = value;
				}
			}

			// Token: 0x06000A5B RID: 2651 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06000A5C RID: 2652 RVA: 0x0002C8D8 File Offset: 0x0002AAD8
			public UnityEngine.Object BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06000A5D RID: 2653 RVA: 0x0002C8F0 File Offset: 0x0002AAF0
			public void OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.OnButtonClick(button, fieldName);
			}

			// Token: 0x06000A5E RID: 2654 RVA: 0x0002C900 File Offset: 0x0002AB00
			public void OnButtonDoubleClick(Button button, string fieldName)
			{
				this.m_owner.OnButtonDoubleClick(button, fieldName);
			}

			// Token: 0x06000A5F RID: 2655 RVA: 0x0002C910 File Offset: 0x0002AB10
			public void OnButtonLongPressStart(Button button, string fieldName)
			{
				this.m_owner.OnButtonLongPressStart(button, fieldName);
			}

			// Token: 0x06000A60 RID: 2656 RVA: 0x0002C920 File Offset: 0x0002AB20
			public void OnButtonLongPressing(Button button, string fieldName)
			{
				this.m_owner.OnButtonLongPressing(button, fieldName);
			}

			// Token: 0x06000A61 RID: 2657 RVA: 0x0002C930 File Offset: 0x0002AB30
			public void OnButtonLongPressEnd(Button button, string fieldName)
			{
				this.m_owner.OnButtonLongPressEnd(button, fieldName);
			}

			// Token: 0x06000A62 RID: 2658 RVA: 0x0002C940 File Offset: 0x0002AB40
			public void OnToggleValueChanged(Toggle toggle, string fieldName, bool value)
			{
				this.m_owner.OnToggleValueChanged(toggle, fieldName, value);
			}

			// Token: 0x04000632 RID: 1586
			private UIControllerBase m_owner;
		}
	}
}
