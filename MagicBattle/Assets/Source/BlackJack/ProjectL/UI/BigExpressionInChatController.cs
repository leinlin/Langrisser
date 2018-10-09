using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B3C RID: 2876
	[ControllerDescription("UI/Chat_ABS/Prefab/ExpressionGroupInChatPrefab.prefab", "ExpressionGroupInChatPrefab")]
	[HotFix]
	public class BigExpressionInChatController : UIControllerBase
	{
		// Token: 0x0600C34B RID: 49995 RVA: 0x00362364 File Offset: 0x00360564
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
			this.ScrollView.onValueChanged.AddListener(new UnityAction<Vector2>(this.OnValueChange));
		}

		// Token: 0x0600C34C RID: 49996 RVA: 0x003623E8 File Offset: 0x003605E8
		public void SetChannel(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChannelChatChannel_hotfix != null)
			{
				this.m_SetChannelChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatChannel = channel;
		}

		// Token: 0x0600C34D RID: 49997 RVA: 0x00362460 File Offset: 0x00360660
		[DebuggerHidden]
		public IEnumerator DelayInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DelayInit_hotfix != null)
			{
				return (IEnumerator)this.m_DelayInit_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BigExpressionInChatController.<DelayInit>c__Iterator0 <DelayInit>c__Iterator = new BigExpressionInChatController.<DelayInit>c__Iterator0();
			<DelayInit>c__Iterator.$this = this;
			return <DelayInit>c__Iterator;
		}

		// Token: 0x0600C34E RID: 49998 RVA: 0x003624DC File Offset: 0x003606DC
		private List<ConfigDataBigExpressionInfo> GetChatExpressionInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChatExpressionInfo_hotfix != null)
			{
				return (List<ConfigDataBigExpressionInfo>)this.m_GetChatExpressionInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<ConfigDataBigExpressionInfo> list = new List<ConfigDataBigExpressionInfo>();
			foreach (KeyValuePair<int, ConfigDataBigExpressionInfo> keyValuePair in configDataLoader.GetAllConfigDataBigExpressionInfo())
			{
				if (keyValuePair.Value.ExpressionPurposeType == ExpressionPurposeType.ExpressionPurposeType_Chat)
				{
					list.Add(keyValuePair.Value);
				}
			}
			list.Sort(delegate(ConfigDataBigExpressionInfo left, ConfigDataBigExpressionInfo right)
			{
				if (left.ID > right.ID)
				{
					return 1;
				}
				if (left.ID < right.ID)
				{
					return -1;
				}
				return 0;
			});
			return list;
		}

		// Token: 0x0600C34F RID: 49999 RVA: 0x003625E8 File Offset: 0x003607E8
		private void OnExpressionClick(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExpressionClickInt32_hotfix != null)
			{
				this.m_OnExpressionClickInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnExpressionClick != null)
			{
				this.EventOnExpressionClick(id);
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanSendChatMessage((int)this.m_chatChannel);
			if (num == 0)
			{
				ChatExpressionMessageSendNetTask chatExpressionMessageSendNetTask = new ChatExpressionMessageSendNetTask(this.m_chatChannel, id.ToString());
				chatExpressionMessageSendNetTask.Start(null);
				chatExpressionMessageSendNetTask.EventOnStop += delegate(Task task)
				{
					ChatExpressionMessageSendNetTask chatExpressionMessageSendNetTask2 = task as ChatExpressionMessageSendNetTask;
					if (chatExpressionMessageSendNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(chatExpressionMessageSendNetTask2.Result, 2f, null, true);
					}
				};
			}
			else
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataErrorCodeStringTable configDataErrorCodeStringTable = configDataLoader.GetConfigDataErrorCodeStringTable(num);
				if (configDataErrorCodeStringTable != null && configDataErrorCodeStringTable.Text != null)
				{
					CommonUIController.Instance.ShowMessage(configDataErrorCodeStringTable.Text, 2f, null, true);
				}
			}
		}

		// Token: 0x0600C350 RID: 50000 RVA: 0x00362720 File Offset: 0x00360920
		private void OnEndDrag(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndDragGameObject_hotfix != null)
			{
				this.m_OnEndDragGameObject_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_pageList.Count <= 1)
			{
				return;
			}
			float num = 1f / (float)(this.m_pageList.Count - 1);
			int num2 = (int)(this.ScrollView.horizontalNormalizedPosition / num);
			float num3 = this.ScrollView.horizontalNormalizedPosition / num - (float)num2;
			if (this.m_scrollRectLastPos < this.ScrollView.horizontalNormalizedPosition)
			{
				if (num3 >= 0.2f)
				{
					num2++;
				}
			}
			else if (num3 > 0.8f)
			{
				num2++;
			}
			num2 = Mathf.Clamp(num2, 0, this.m_pageList.Count - 1);
			base.StartCoroutine(UIUtility.TweenHorizontalScrollRecPosition(this.ScrollView, this.ScrollView.horizontalNormalizedPosition, num * (float)num2, 0.3f));
			this.m_scrollRectLastPos = this.ScrollView.horizontalNormalizedPosition;
		}

		// Token: 0x0600C351 RID: 50001 RVA: 0x0036285C File Offset: 0x00360A5C
		private void OnValueChange(Vector2 rectEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnValueChangeVector2_hotfix != null)
			{
				this.m_OnValueChangeVector2_hotfix.call(new object[]
				{
					this,
					rectEvent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = 1f / (float)(this.m_pageList.Count - 1);
			int num2 = (int)(this.ScrollView.horizontalNormalizedPosition / num);
			float num3 = this.ScrollView.horizontalNormalizedPosition / num - (float)num2;
			if ((double)num3 > 0.8)
			{
				num2++;
			}
			this.SetPagePointActivity(num2);
		}

		// Token: 0x0600C352 RID: 50002 RVA: 0x0036291C File Offset: 0x00360B1C
		private void SetPagePointActivity(int page)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPagePointActivityInt32_hotfix != null)
			{
				this.m_SetPagePointActivityInt32_hotfix.call(new object[]
				{
					this,
					page
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_pagePointStateControllerList.Count; i++)
			{
				if (i == page)
				{
					this.m_pagePointStateControllerList[i].SetToUIState("Normal", false, true);
				}
				else
				{
					this.m_pagePointStateControllerList[i].SetToUIState("Grey", false, true);
				}
			}
		}

		// Token: 0x14000254 RID: 596
		// (add) Token: 0x0600C353 RID: 50003 RVA: 0x003629E4 File Offset: 0x00360BE4
		// (remove) Token: 0x0600C354 RID: 50004 RVA: 0x00362A80 File Offset: 0x00360C80
		public event Action<int> EventOnExpressionClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExpressionClickAction`1_hotfix != null)
				{
					this.m_add_EventOnExpressionClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnExpressionClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnExpressionClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExpressionClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnExpressionClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnExpressionClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnExpressionClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x0600C355 RID: 50005 RVA: 0x00362B1C File Offset: 0x00360D1C
		// (set) Token: 0x0600C356 RID: 50006 RVA: 0x00362B3C File Offset: 0x00360D3C
		[DoNotToLua]
		public new BigExpressionInChatController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BigExpressionInChatController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C357 RID: 50007 RVA: 0x00362B48 File Offset: 0x00360D48
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C358 RID: 50008 RVA: 0x00362B54 File Offset: 0x00360D54
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C359 RID: 50009 RVA: 0x00362B5C File Offset: 0x00360D5C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C35A RID: 50010 RVA: 0x00362B64 File Offset: 0x00360D64
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C35B RID: 50011 RVA: 0x00362B78 File Offset: 0x00360D78
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C35C RID: 50012 RVA: 0x00362B80 File Offset: 0x00360D80
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C35D RID: 50013 RVA: 0x00362B8C File Offset: 0x00360D8C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C35E RID: 50014 RVA: 0x00362B98 File Offset: 0x00360D98
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C35F RID: 50015 RVA: 0x00362BA4 File Offset: 0x00360DA4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x00362BB0 File Offset: 0x00360DB0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C361 RID: 50017 RVA: 0x00362BBC File Offset: 0x00360DBC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x00362BC8 File Offset: 0x00360DC8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C363 RID: 50019 RVA: 0x00362BD4 File Offset: 0x00360DD4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C364 RID: 50020 RVA: 0x00362BE0 File Offset: 0x00360DE0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C365 RID: 50021 RVA: 0x00362BEC File Offset: 0x00360DEC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C366 RID: 50022 RVA: 0x00362BF4 File Offset: 0x00360DF4
		private void __callDele_EventOnExpressionClick(int obj)
		{
			Action<int> eventOnExpressionClick = this.EventOnExpressionClick;
			if (eventOnExpressionClick != null)
			{
				eventOnExpressionClick(obj);
			}
		}

		// Token: 0x0600C367 RID: 50023 RVA: 0x00362C18 File Offset: 0x00360E18
		private void __clearDele_EventOnExpressionClick(int obj)
		{
			this.EventOnExpressionClick = null;
		}

		// Token: 0x0600C36A RID: 50026 RVA: 0x00362C8C File Offset: 0x00360E8C
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
					this.m_SetChannelChatChannel_hotfix = (luaObj.RawGet("SetChannel") as LuaFunction);
					this.m_DelayInit_hotfix = (luaObj.RawGet("DelayInit") as LuaFunction);
					this.m_GetChatExpressionInfo_hotfix = (luaObj.RawGet("GetChatExpressionInfo") as LuaFunction);
					this.m_OnExpressionClickInt32_hotfix = (luaObj.RawGet("OnExpressionClick") as LuaFunction);
					this.m_OnEndDragGameObject_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_OnValueChangeVector2_hotfix = (luaObj.RawGet("OnValueChange") as LuaFunction);
					this.m_SetPagePointActivityInt32_hotfix = (luaObj.RawGet("SetPagePointActivity") as LuaFunction);
					this.m_add_EventOnExpressionClickAction`1_hotfix = (luaObj.RawGet("add_EventOnExpressionClick") as LuaFunction);
					this.m_remove_EventOnExpressionClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnExpressionClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C36B RID: 50027 RVA: 0x00362E38 File Offset: 0x00361038
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BigExpressionInChatController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007BDF RID: 31711
		private float m_scrollRectLastPos;

		// Token: 0x04007BE0 RID: 31712
		private ChatChannel m_chatChannel = ChatChannel.Team;

		// Token: 0x04007BE1 RID: 31713
		private int m_pageCapacity = 10;

		// Token: 0x04007BE2 RID: 31714
		private List<BigExpressionItem> m_bigExpressionItemList = new List<BigExpressionItem>();

		// Token: 0x04007BE3 RID: 31715
		private List<GameObject> m_pageList = new List<GameObject>();

		// Token: 0x04007BE4 RID: 31716
		private List<CommonUIStateController> m_pagePointStateControllerList = new List<CommonUIStateController>();

		// Token: 0x04007BE5 RID: 31717
		[AutoBind("./Scroll View/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject Content;

		// Token: 0x04007BE6 RID: 31718
		[AutoBind("./Scroll View/Viewport/Expression", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject Expression;

		// Token: 0x04007BE7 RID: 31719
		[AutoBind("./Scroll View/Viewport/Page", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject Page;

		// Token: 0x04007BE8 RID: 31720
		[AutoBind("./PagePoint", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject PagePointNode;

		// Token: 0x04007BE9 RID: 31721
		[AutoBind("./PagePoint/PagePoint", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject PagePoint;

		// Token: 0x04007BEA RID: 31722
		[AutoBind("./Scroll View", AutoBindAttribute.InitState.NotInit, false)]
		public ScrollRect ScrollView;

		// Token: 0x04007BEB RID: 31723
		[DoNotToLua]
		private BigExpressionInChatController.LuaExportHelper luaExportHelper;

		// Token: 0x04007BEE RID: 31726
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007BEF RID: 31727
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007BF0 RID: 31728
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007BF1 RID: 31729
		private LuaFunction m_SetChannelChatChannel_hotfix;

		// Token: 0x04007BF2 RID: 31730
		private LuaFunction m_DelayInit_hotfix;

		// Token: 0x04007BF3 RID: 31731
		private LuaFunction m_GetChatExpressionInfo_hotfix;

		// Token: 0x04007BF4 RID: 31732
		private LuaFunction m_OnExpressionClickInt32_hotfix;

		// Token: 0x04007BF5 RID: 31733
		private LuaFunction m_OnEndDragGameObject_hotfix;

		// Token: 0x04007BF6 RID: 31734
		private LuaFunction m_OnValueChangeVector2_hotfix;

		// Token: 0x04007BF7 RID: 31735
		private LuaFunction m_SetPagePointActivityInt32_hotfix;

		// Token: 0x04007BF8 RID: 31736
		private LuaFunction m_add_EventOnExpressionClickAction;

		// Token: 0x04007BF9 RID: 31737
		private LuaFunction m_remove_EventOnExpressionClickAction;

		// Token: 0x02000B3D RID: 2877
		public new class LuaExportHelper
		{
			// Token: 0x0600C36C RID: 50028 RVA: 0x00362EA0 File Offset: 0x003610A0
			public LuaExportHelper(BigExpressionInChatController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C36D RID: 50029 RVA: 0x00362EB0 File Offset: 0x003610B0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C36E RID: 50030 RVA: 0x00362EC0 File Offset: 0x003610C0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C36F RID: 50031 RVA: 0x00362ED0 File Offset: 0x003610D0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C370 RID: 50032 RVA: 0x00362EE0 File Offset: 0x003610E0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C371 RID: 50033 RVA: 0x00362EF8 File Offset: 0x003610F8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C372 RID: 50034 RVA: 0x00362F08 File Offset: 0x00361108
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C373 RID: 50035 RVA: 0x00362F18 File Offset: 0x00361118
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C374 RID: 50036 RVA: 0x00362F28 File Offset: 0x00361128
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C375 RID: 50037 RVA: 0x00362F38 File Offset: 0x00361138
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C376 RID: 50038 RVA: 0x00362F48 File Offset: 0x00361148
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C377 RID: 50039 RVA: 0x00362F58 File Offset: 0x00361158
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C378 RID: 50040 RVA: 0x00362F68 File Offset: 0x00361168
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C379 RID: 50041 RVA: 0x00362F78 File Offset: 0x00361178
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C37A RID: 50042 RVA: 0x00362F88 File Offset: 0x00361188
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C37B RID: 50043 RVA: 0x00362F98 File Offset: 0x00361198
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C37C RID: 50044 RVA: 0x00362FA8 File Offset: 0x003611A8
			public void __callDele_EventOnExpressionClick(int obj)
			{
				this.m_owner.__callDele_EventOnExpressionClick(obj);
			}

			// Token: 0x0600C37D RID: 50045 RVA: 0x00362FB8 File Offset: 0x003611B8
			public void __clearDele_EventOnExpressionClick(int obj)
			{
				this.m_owner.__clearDele_EventOnExpressionClick(obj);
			}

			// Token: 0x17002731 RID: 10033
			// (get) Token: 0x0600C37E RID: 50046 RVA: 0x00362FC8 File Offset: 0x003611C8
			// (set) Token: 0x0600C37F RID: 50047 RVA: 0x00362FD8 File Offset: 0x003611D8
			public float m_scrollRectLastPos
			{
				get
				{
					return this.m_owner.m_scrollRectLastPos;
				}
				set
				{
					this.m_owner.m_scrollRectLastPos = value;
				}
			}

			// Token: 0x17002732 RID: 10034
			// (get) Token: 0x0600C380 RID: 50048 RVA: 0x00362FE8 File Offset: 0x003611E8
			// (set) Token: 0x0600C381 RID: 50049 RVA: 0x00362FF8 File Offset: 0x003611F8
			public ChatChannel m_chatChannel
			{
				get
				{
					return this.m_owner.m_chatChannel;
				}
				set
				{
					this.m_owner.m_chatChannel = value;
				}
			}

			// Token: 0x17002733 RID: 10035
			// (get) Token: 0x0600C382 RID: 50050 RVA: 0x00363008 File Offset: 0x00361208
			// (set) Token: 0x0600C383 RID: 50051 RVA: 0x00363018 File Offset: 0x00361218
			public int m_pageCapacity
			{
				get
				{
					return this.m_owner.m_pageCapacity;
				}
				set
				{
					this.m_owner.m_pageCapacity = value;
				}
			}

			// Token: 0x17002734 RID: 10036
			// (get) Token: 0x0600C384 RID: 50052 RVA: 0x00363028 File Offset: 0x00361228
			// (set) Token: 0x0600C385 RID: 50053 RVA: 0x00363038 File Offset: 0x00361238
			public List<BigExpressionItem> m_bigExpressionItemList
			{
				get
				{
					return this.m_owner.m_bigExpressionItemList;
				}
				set
				{
					this.m_owner.m_bigExpressionItemList = value;
				}
			}

			// Token: 0x17002735 RID: 10037
			// (get) Token: 0x0600C386 RID: 50054 RVA: 0x00363048 File Offset: 0x00361248
			// (set) Token: 0x0600C387 RID: 50055 RVA: 0x00363058 File Offset: 0x00361258
			public List<GameObject> m_pageList
			{
				get
				{
					return this.m_owner.m_pageList;
				}
				set
				{
					this.m_owner.m_pageList = value;
				}
			}

			// Token: 0x17002736 RID: 10038
			// (get) Token: 0x0600C388 RID: 50056 RVA: 0x00363068 File Offset: 0x00361268
			// (set) Token: 0x0600C389 RID: 50057 RVA: 0x00363078 File Offset: 0x00361278
			public List<CommonUIStateController> m_pagePointStateControllerList
			{
				get
				{
					return this.m_owner.m_pagePointStateControllerList;
				}
				set
				{
					this.m_owner.m_pagePointStateControllerList = value;
				}
			}

			// Token: 0x0600C38A RID: 50058 RVA: 0x00363088 File Offset: 0x00361288
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C38B RID: 50059 RVA: 0x00363098 File Offset: 0x00361298
			public List<ConfigDataBigExpressionInfo> GetChatExpressionInfo()
			{
				return this.m_owner.GetChatExpressionInfo();
			}

			// Token: 0x0600C38C RID: 50060 RVA: 0x003630A8 File Offset: 0x003612A8
			public void OnExpressionClick(int id)
			{
				this.m_owner.OnExpressionClick(id);
			}

			// Token: 0x0600C38D RID: 50061 RVA: 0x003630B8 File Offset: 0x003612B8
			public void OnEndDrag(GameObject obj)
			{
				this.m_owner.OnEndDrag(obj);
			}

			// Token: 0x0600C38E RID: 50062 RVA: 0x003630C8 File Offset: 0x003612C8
			public void OnValueChange(Vector2 rectEvent)
			{
				this.m_owner.OnValueChange(rectEvent);
			}

			// Token: 0x0600C38F RID: 50063 RVA: 0x003630D8 File Offset: 0x003612D8
			public void SetPagePointActivity(int page)
			{
				this.m_owner.SetPagePointActivity(page);
			}

			// Token: 0x04007BFA RID: 31738
			private BigExpressionInChatController m_owner;
		}
	}
}
