using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B38 RID: 2872
	[HotFix]
	[ControllerDescription("UI/Battle_ABS/Prefab/ExpressionGroupPrefab.prefab", "ExpressionGroupPrefab")]
	public class BigExpressionController : UIControllerBase
	{
		// Token: 0x0600C2F7 RID: 49911 RVA: 0x00361188 File Offset: 0x0035F388
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
			this.Init();
		}

		// Token: 0x0600C2F8 RID: 49912 RVA: 0x00361210 File Offset: 0x0035F410
		public void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EventTriggerListener.Get(this.ScrollView.gameObject).onEndDrag = new EventTriggerListener.VoidDelegate(this.OnEndDrag);
			List<ConfigDataBigExpressionInfo> combatExpressionInfo = this.GetCombatExpressionInfo();
			int count = combatExpressionInfo.Count;
			int num = Mathf.CeilToInt((float)count / (float)this.m_pageCapacity);
			for (int i = 0; i < num; i++)
			{
				GameObject gameObject = GameObjectUtility.CloneGameObject(this.Page, this.Content.transform);
				this.m_pageList.Add(gameObject);
				gameObject = GameObjectUtility.CloneGameObject(this.PagePoint, this.PagePointNode.transform);
				this.m_pagePointStateControllerList.Add(gameObject.GetComponent<CommonUIStateController>());
			}
			for (int j = 0; j < count; j++)
			{
				int index = j / this.m_pageCapacity;
				GameObject expression = GameObjectUtility.CloneGameObject(this.Expression, this.m_pageList[index].transform);
				BigExpressionItem item = new BigExpressionItem(combatExpressionInfo[j], expression, new Action<int>(this.OnExpressionClick));
				this.bigExpressionItemList.Add(item);
			}
			this.ScrollView.horizontalNormalizedPosition = 0f;
			this.SetPagePointActivity(0);
		}

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x00361394 File Offset: 0x0035F594
		private List<ConfigDataBigExpressionInfo> GetCombatExpressionInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCombatExpressionInfo_hotfix != null)
			{
				return (List<ConfigDataBigExpressionInfo>)this.m_GetCombatExpressionInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<ConfigDataBigExpressionInfo> list = new List<ConfigDataBigExpressionInfo>();
			foreach (KeyValuePair<int, ConfigDataBigExpressionInfo> keyValuePair in configDataLoader.GetAllConfigDataBigExpressionInfo())
			{
				if (keyValuePair.Value.ExpressionPurposeType == ExpressionPurposeType.ExpressionPurposeType_Combat)
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

		// Token: 0x0600C2FA RID: 49914 RVA: 0x003614A0 File Offset: 0x0035F6A0
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
			global::Debug.Log(new object[]
			{
				id
			});
			if (this.EventOnExpressionClick != null)
			{
				this.EventOnExpressionClick(id);
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanSendChatMessage(2);
			if (num == 0)
			{
				ChatExpressionMessageSendNetTask chatExpressionMessageSendNetTask = new ChatExpressionMessageSendNetTask(ChatChannel.Team, id.ToString());
				chatExpressionMessageSendNetTask.Start(null);
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

		// Token: 0x0600C2FB RID: 49915 RVA: 0x003615C0 File Offset: 0x0035F7C0
		private void OnBGMaskClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBGMaskClick_hotfix != null)
			{
				this.m_OnBGMaskClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600C2FC RID: 49916 RVA: 0x00361620 File Offset: 0x0035F820
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
			if (this.scrollRectLastPos < this.ScrollView.horizontalNormalizedPosition)
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
			this.scrollRectLastPos = this.ScrollView.horizontalNormalizedPosition;
		}

		// Token: 0x0600C2FD RID: 49917 RVA: 0x0036175C File Offset: 0x0035F95C
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

		// Token: 0x0600C2FE RID: 49918 RVA: 0x0036181C File Offset: 0x0035FA1C
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

		// Token: 0x14000253 RID: 595
		// (add) Token: 0x0600C2FF RID: 49919 RVA: 0x003618E4 File Offset: 0x0035FAE4
		// (remove) Token: 0x0600C300 RID: 49920 RVA: 0x00361980 File Offset: 0x0035FB80
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

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x0600C301 RID: 49921 RVA: 0x00361A1C File Offset: 0x0035FC1C
		// (set) Token: 0x0600C302 RID: 49922 RVA: 0x00361A3C File Offset: 0x0035FC3C
		[DoNotToLua]
		public new BigExpressionController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BigExpressionController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C303 RID: 49923 RVA: 0x00361A48 File Offset: 0x0035FC48
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C304 RID: 49924 RVA: 0x00361A54 File Offset: 0x0035FC54
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C305 RID: 49925 RVA: 0x00361A5C File Offset: 0x0035FC5C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C306 RID: 49926 RVA: 0x00361A64 File Offset: 0x0035FC64
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C307 RID: 49927 RVA: 0x00361A78 File Offset: 0x0035FC78
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C308 RID: 49928 RVA: 0x00361A80 File Offset: 0x0035FC80
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C309 RID: 49929 RVA: 0x00361A8C File Offset: 0x0035FC8C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C30A RID: 49930 RVA: 0x00361A98 File Offset: 0x0035FC98
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C30B RID: 49931 RVA: 0x00361AA4 File Offset: 0x0035FCA4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C30C RID: 49932 RVA: 0x00361AB0 File Offset: 0x0035FCB0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C30D RID: 49933 RVA: 0x00361ABC File Offset: 0x0035FCBC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C30E RID: 49934 RVA: 0x00361AC8 File Offset: 0x0035FCC8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C30F RID: 49935 RVA: 0x00361AD4 File Offset: 0x0035FCD4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C310 RID: 49936 RVA: 0x00361AE0 File Offset: 0x0035FCE0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C311 RID: 49937 RVA: 0x00361AEC File Offset: 0x0035FCEC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x00361AF4 File Offset: 0x0035FCF4
		private void __callDele_EventOnExpressionClick(int obj)
		{
			Action<int> eventOnExpressionClick = this.EventOnExpressionClick;
			if (eventOnExpressionClick != null)
			{
				eventOnExpressionClick(obj);
			}
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x00361B18 File Offset: 0x0035FD18
		private void __clearDele_EventOnExpressionClick(int obj)
		{
			this.EventOnExpressionClick = null;
		}

		// Token: 0x0600C315 RID: 49941 RVA: 0x00361B50 File Offset: 0x0035FD50
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_GetCombatExpressionInfo_hotfix = (luaObj.RawGet("GetCombatExpressionInfo") as LuaFunction);
					this.m_OnExpressionClickInt32_hotfix = (luaObj.RawGet("OnExpressionClick") as LuaFunction);
					this.m_OnBGMaskClick_hotfix = (luaObj.RawGet("OnBGMaskClick") as LuaFunction);
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

		// Token: 0x0600C316 RID: 49942 RVA: 0x00361CFC File Offset: 0x0035FEFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BigExpressionController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007BBA RID: 31674
		private float scrollRectLastPos;

		// Token: 0x04007BBB RID: 31675
		private int m_pageCapacity = 8;

		// Token: 0x04007BBC RID: 31676
		private List<BigExpressionItem> bigExpressionItemList = new List<BigExpressionItem>();

		// Token: 0x04007BBD RID: 31677
		private List<GameObject> m_pageList = new List<GameObject>();

		// Token: 0x04007BBE RID: 31678
		private List<CommonUIStateController> m_pagePointStateControllerList = new List<CommonUIStateController>();

		// Token: 0x04007BBF RID: 31679
		[AutoBind("./Scroll View/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject Content;

		// Token: 0x04007BC0 RID: 31680
		[AutoBind("./Scroll View/Viewport/Expression", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject Expression;

		// Token: 0x04007BC1 RID: 31681
		[AutoBind("./Scroll View/Viewport/Page", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject Page;

		// Token: 0x04007BC2 RID: 31682
		[AutoBind("./PagePoint", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject PagePointNode;

		// Token: 0x04007BC3 RID: 31683
		[AutoBind("./PagePoint/PagePoint", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject PagePoint;

		// Token: 0x04007BC4 RID: 31684
		[AutoBind("./Scroll View", AutoBindAttribute.InitState.NotInit, false)]
		public ScrollRect ScrollView;

		// Token: 0x04007BC5 RID: 31685
		[DoNotToLua]
		private BigExpressionController.LuaExportHelper luaExportHelper;

		// Token: 0x04007BC7 RID: 31687
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007BC8 RID: 31688
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007BC9 RID: 31689
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007BCA RID: 31690
		private LuaFunction m_Init_hotfix;

		// Token: 0x04007BCB RID: 31691
		private LuaFunction m_GetCombatExpressionInfo_hotfix;

		// Token: 0x04007BCC RID: 31692
		private LuaFunction m_OnExpressionClickInt32_hotfix;

		// Token: 0x04007BCD RID: 31693
		private LuaFunction m_OnBGMaskClick_hotfix;

		// Token: 0x04007BCE RID: 31694
		private LuaFunction m_OnEndDragGameObject_hotfix;

		// Token: 0x04007BCF RID: 31695
		private LuaFunction m_OnValueChangeVector2_hotfix;

		// Token: 0x04007BD0 RID: 31696
		private LuaFunction m_SetPagePointActivityInt32_hotfix;

		// Token: 0x04007BD1 RID: 31697
		private LuaFunction m_add_EventOnExpressionClickAction;

		// Token: 0x04007BD2 RID: 31698
		private LuaFunction m_remove_EventOnExpressionClickAction;

		// Token: 0x02000B39 RID: 2873
		public new class LuaExportHelper
		{
			// Token: 0x0600C317 RID: 49943 RVA: 0x00361D64 File Offset: 0x0035FF64
			public LuaExportHelper(BigExpressionController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C318 RID: 49944 RVA: 0x00361D74 File Offset: 0x0035FF74
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C319 RID: 49945 RVA: 0x00361D84 File Offset: 0x0035FF84
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C31A RID: 49946 RVA: 0x00361D94 File Offset: 0x0035FF94
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C31B RID: 49947 RVA: 0x00361DA4 File Offset: 0x0035FFA4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C31C RID: 49948 RVA: 0x00361DBC File Offset: 0x0035FFBC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C31D RID: 49949 RVA: 0x00361DCC File Offset: 0x0035FFCC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C31E RID: 49950 RVA: 0x00361DDC File Offset: 0x0035FFDC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C31F RID: 49951 RVA: 0x00361DEC File Offset: 0x0035FFEC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C320 RID: 49952 RVA: 0x00361DFC File Offset: 0x0035FFFC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C321 RID: 49953 RVA: 0x00361E0C File Offset: 0x0036000C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C322 RID: 49954 RVA: 0x00361E1C File Offset: 0x0036001C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C323 RID: 49955 RVA: 0x00361E2C File Offset: 0x0036002C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C324 RID: 49956 RVA: 0x00361E3C File Offset: 0x0036003C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C325 RID: 49957 RVA: 0x00361E4C File Offset: 0x0036004C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C326 RID: 49958 RVA: 0x00361E5C File Offset: 0x0036005C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C327 RID: 49959 RVA: 0x00361E6C File Offset: 0x0036006C
			public void __callDele_EventOnExpressionClick(int obj)
			{
				this.m_owner.__callDele_EventOnExpressionClick(obj);
			}

			// Token: 0x0600C328 RID: 49960 RVA: 0x00361E7C File Offset: 0x0036007C
			public void __clearDele_EventOnExpressionClick(int obj)
			{
				this.m_owner.__clearDele_EventOnExpressionClick(obj);
			}

			// Token: 0x17002728 RID: 10024
			// (get) Token: 0x0600C329 RID: 49961 RVA: 0x00361E8C File Offset: 0x0036008C
			// (set) Token: 0x0600C32A RID: 49962 RVA: 0x00361E9C File Offset: 0x0036009C
			public float scrollRectLastPos
			{
				get
				{
					return this.m_owner.scrollRectLastPos;
				}
				set
				{
					this.m_owner.scrollRectLastPos = value;
				}
			}

			// Token: 0x17002729 RID: 10025
			// (get) Token: 0x0600C32B RID: 49963 RVA: 0x00361EAC File Offset: 0x003600AC
			// (set) Token: 0x0600C32C RID: 49964 RVA: 0x00361EBC File Offset: 0x003600BC
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

			// Token: 0x1700272A RID: 10026
			// (get) Token: 0x0600C32D RID: 49965 RVA: 0x00361ECC File Offset: 0x003600CC
			// (set) Token: 0x0600C32E RID: 49966 RVA: 0x00361EDC File Offset: 0x003600DC
			public List<BigExpressionItem> bigExpressionItemList
			{
				get
				{
					return this.m_owner.bigExpressionItemList;
				}
				set
				{
					this.m_owner.bigExpressionItemList = value;
				}
			}

			// Token: 0x1700272B RID: 10027
			// (get) Token: 0x0600C32F RID: 49967 RVA: 0x00361EEC File Offset: 0x003600EC
			// (set) Token: 0x0600C330 RID: 49968 RVA: 0x00361EFC File Offset: 0x003600FC
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

			// Token: 0x1700272C RID: 10028
			// (get) Token: 0x0600C331 RID: 49969 RVA: 0x00361F0C File Offset: 0x0036010C
			// (set) Token: 0x0600C332 RID: 49970 RVA: 0x00361F1C File Offset: 0x0036011C
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

			// Token: 0x0600C333 RID: 49971 RVA: 0x00361F2C File Offset: 0x0036012C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C334 RID: 49972 RVA: 0x00361F3C File Offset: 0x0036013C
			public List<ConfigDataBigExpressionInfo> GetCombatExpressionInfo()
			{
				return this.m_owner.GetCombatExpressionInfo();
			}

			// Token: 0x0600C335 RID: 49973 RVA: 0x00361F4C File Offset: 0x0036014C
			public void OnExpressionClick(int id)
			{
				this.m_owner.OnExpressionClick(id);
			}

			// Token: 0x0600C336 RID: 49974 RVA: 0x00361F5C File Offset: 0x0036015C
			public void OnBGMaskClick()
			{
				this.m_owner.OnBGMaskClick();
			}

			// Token: 0x0600C337 RID: 49975 RVA: 0x00361F6C File Offset: 0x0036016C
			public void OnEndDrag(GameObject obj)
			{
				this.m_owner.OnEndDrag(obj);
			}

			// Token: 0x0600C338 RID: 49976 RVA: 0x00361F7C File Offset: 0x0036017C
			public void OnValueChange(Vector2 rectEvent)
			{
				this.m_owner.OnValueChange(rectEvent);
			}

			// Token: 0x0600C339 RID: 49977 RVA: 0x00361F8C File Offset: 0x0036018C
			public void SetPagePointActivity(int page)
			{
				this.m_owner.SetPagePointActivity(page);
			}

			// Token: 0x04007BD3 RID: 31699
			private BigExpressionController m_owner;
		}
	}
}
