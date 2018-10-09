using System;
using System.Runtime.CompilerServices;
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
	// Token: 0x02000F03 RID: 3843
	[HotFix]
	public class SummonToggleUIController : UIControllerBase
	{
		// Token: 0x0601305D RID: 77917 RVA: 0x004DB168 File Offset: 0x004D9368
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
			this.m_toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleValueChanged));
		}

		// Token: 0x0601305E RID: 77918 RVA: 0x004DB1F8 File Offset: 0x004D93F8
		public void SetSummonToggleInfo(int cardPoolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSummonToggleInfoInt32_hotfix != null)
			{
				this.m_SetSummonToggleInfoInt32_hotfix.call(new object[]
				{
					this,
					cardPoolId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.CardPool = projectLPlayerContext.GetCardPoolById(cardPoolId);
			if (this.CardPool.Config.PoolType == CardPoolType.CardPoolType_ActivityCardPool)
			{
				this.m_clickIconImage.sprite = AssetUtility.Instance.GetSprite(this.CardPool.Config.ToggleClickImage);
				this.m_unClickIconImage.sprite = AssetUtility.Instance.GetSprite(this.CardPool.Config.ToggleUnClickImage);
				Text nameClickText = this.m_nameClickText;
				string text = this.CardPool.Config.Name;
				this.m_nameUnClickText.text = text;
				nameClickText.text = text;
				int activityCardPoolLastDays = projectLPlayerContext.GetActivityCardPoolLastDays(this.CardPool);
				string text2 = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Summon_LastDays), activityCardPoolLastDays);
				Text timeClickText = this.m_timeClickText;
				text = text2;
				this.m_timeUnClickText.text = text;
				timeClickText.text = text;
			}
		}

		// Token: 0x0601305F RID: 77919 RVA: 0x004DB360 File Offset: 0x004D9560
		private void OnToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn && this.EventOnToggleClick != null)
			{
				this.EventOnToggleClick(this);
			}
		}

		// Token: 0x06013060 RID: 77920 RVA: 0x004DB3F0 File Offset: 0x004D95F0
		public void SetToggleIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToggleIsOnBoolean_hotfix != null)
			{
				this.m_SetToggleIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_toggle.isOn = isOn;
		}

		// Token: 0x14000422 RID: 1058
		// (add) Token: 0x06013061 RID: 77921 RVA: 0x004DB46C File Offset: 0x004D966C
		// (remove) Token: 0x06013062 RID: 77922 RVA: 0x004DB508 File Offset: 0x004D9708
		public event Action<SummonToggleUIController> EventOnToggleClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnToggleClickAction`1_hotfix != null)
				{
					this.m_add_EventOnToggleClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SummonToggleUIController> action = this.EventOnToggleClick;
				Action<SummonToggleUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SummonToggleUIController>>(ref this.EventOnToggleClick, (Action<SummonToggleUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnToggleClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnToggleClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SummonToggleUIController> action = this.EventOnToggleClick;
				Action<SummonToggleUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SummonToggleUIController>>(ref this.EventOnToggleClick, (Action<SummonToggleUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x06013063 RID: 77923 RVA: 0x004DB5A4 File Offset: 0x004D97A4
		// (set) Token: 0x06013064 RID: 77924 RVA: 0x004DB618 File Offset: 0x004D9818
		public CardPool CardPool
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CardPool_hotfix != null)
				{
					return (CardPool)this.m_get_CardPool_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<CardPool>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_CardPoolCardPool_hotfix != null)
				{
					this.m_set_CardPoolCardPool_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<CardPool>k__BackingField = value;
			}
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x06013065 RID: 77925 RVA: 0x004DB690 File Offset: 0x004D9890
		// (set) Token: 0x06013066 RID: 77926 RVA: 0x004DB6B0 File Offset: 0x004D98B0
		[DoNotToLua]
		public new SummonToggleUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SummonToggleUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013067 RID: 77927 RVA: 0x004DB6BC File Offset: 0x004D98BC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013068 RID: 77928 RVA: 0x004DB6C8 File Offset: 0x004D98C8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013069 RID: 77929 RVA: 0x004DB6D0 File Offset: 0x004D98D0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601306A RID: 77930 RVA: 0x004DB6D8 File Offset: 0x004D98D8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601306B RID: 77931 RVA: 0x004DB6EC File Offset: 0x004D98EC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601306C RID: 77932 RVA: 0x004DB6F4 File Offset: 0x004D98F4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601306D RID: 77933 RVA: 0x004DB700 File Offset: 0x004D9900
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601306E RID: 77934 RVA: 0x004DB70C File Offset: 0x004D990C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601306F RID: 77935 RVA: 0x004DB718 File Offset: 0x004D9918
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013070 RID: 77936 RVA: 0x004DB724 File Offset: 0x004D9924
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013071 RID: 77937 RVA: 0x004DB730 File Offset: 0x004D9930
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013072 RID: 77938 RVA: 0x004DB73C File Offset: 0x004D993C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013073 RID: 77939 RVA: 0x004DB748 File Offset: 0x004D9948
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013074 RID: 77940 RVA: 0x004DB754 File Offset: 0x004D9954
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013075 RID: 77941 RVA: 0x004DB760 File Offset: 0x004D9960
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013076 RID: 77942 RVA: 0x004DB768 File Offset: 0x004D9968
		private void __callDele_EventOnToggleClick(SummonToggleUIController obj)
		{
			Action<SummonToggleUIController> eventOnToggleClick = this.EventOnToggleClick;
			if (eventOnToggleClick != null)
			{
				eventOnToggleClick(obj);
			}
		}

		// Token: 0x06013077 RID: 77943 RVA: 0x004DB78C File Offset: 0x004D998C
		private void __clearDele_EventOnToggleClick(SummonToggleUIController obj)
		{
			this.EventOnToggleClick = null;
		}

		// Token: 0x06013078 RID: 77944 RVA: 0x004DB798 File Offset: 0x004D9998
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
					this.m_SetSummonToggleInfoInt32_hotfix = (luaObj.RawGet("SetSummonToggleInfo") as LuaFunction);
					this.m_OnToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnToggleValueChanged") as LuaFunction);
					this.m_SetToggleIsOnBoolean_hotfix = (luaObj.RawGet("SetToggleIsOn") as LuaFunction);
					this.m_add_EventOnToggleClickAction`1_hotfix = (luaObj.RawGet("add_EventOnToggleClick") as LuaFunction);
					this.m_remove_EventOnToggleClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnToggleClick") as LuaFunction);
					this.m_get_CardPool_hotfix = (luaObj.RawGet("get_CardPool") as LuaFunction);
					this.m_set_CardPoolCardPool_hotfix = (luaObj.RawGet("set_CardPool") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013079 RID: 77945 RVA: 0x004DB914 File Offset: 0x004D9B14
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SummonToggleUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A9CE RID: 43470
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_toggle;

		// Token: 0x0400A9CF RID: 43471
		[AutoBind("./ClickIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_clickIconImage;

		// Token: 0x0400A9D0 RID: 43472
		[AutoBind("./UnClickIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_unClickIconImage;

		// Token: 0x0400A9D1 RID: 43473
		[AutoBind("./MainClickText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameClickText;

		// Token: 0x0400A9D2 RID: 43474
		[AutoBind("./MainUnClickText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameUnClickText;

		// Token: 0x0400A9D3 RID: 43475
		[AutoBind("./SecondClickText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeClickText;

		// Token: 0x0400A9D4 RID: 43476
		[AutoBind("./SecondUnClickText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeUnClickText;

		// Token: 0x0400A9D6 RID: 43478
		[DoNotToLua]
		private SummonToggleUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A9D7 RID: 43479
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A9D8 RID: 43480
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A9D9 RID: 43481
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A9DA RID: 43482
		private LuaFunction m_SetSummonToggleInfoInt32_hotfix;

		// Token: 0x0400A9DB RID: 43483
		private LuaFunction m_OnToggleValueChangedBoolean_hotfix;

		// Token: 0x0400A9DC RID: 43484
		private LuaFunction m_SetToggleIsOnBoolean_hotfix;

		// Token: 0x0400A9DD RID: 43485
		private LuaFunction m_add_EventOnToggleClickAction;

		// Token: 0x0400A9DE RID: 43486
		private LuaFunction m_remove_EventOnToggleClickAction;

		// Token: 0x0400A9DF RID: 43487
		private LuaFunction m_get_CardPool_hotfix;

		// Token: 0x0400A9E0 RID: 43488
		private LuaFunction m_set_CardPoolCardPool_hotfix;

		// Token: 0x02000F04 RID: 3844
		public new class LuaExportHelper
		{
			// Token: 0x0601307A RID: 77946 RVA: 0x004DB97C File Offset: 0x004D9B7C
			public LuaExportHelper(SummonToggleUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601307B RID: 77947 RVA: 0x004DB98C File Offset: 0x004D9B8C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601307C RID: 77948 RVA: 0x004DB99C File Offset: 0x004D9B9C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601307D RID: 77949 RVA: 0x004DB9AC File Offset: 0x004D9BAC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601307E RID: 77950 RVA: 0x004DB9BC File Offset: 0x004D9BBC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601307F RID: 77951 RVA: 0x004DB9D4 File Offset: 0x004D9BD4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013080 RID: 77952 RVA: 0x004DB9E4 File Offset: 0x004D9BE4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013081 RID: 77953 RVA: 0x004DB9F4 File Offset: 0x004D9BF4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013082 RID: 77954 RVA: 0x004DBA04 File Offset: 0x004D9C04
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013083 RID: 77955 RVA: 0x004DBA14 File Offset: 0x004D9C14
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013084 RID: 77956 RVA: 0x004DBA24 File Offset: 0x004D9C24
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013085 RID: 77957 RVA: 0x004DBA34 File Offset: 0x004D9C34
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013086 RID: 77958 RVA: 0x004DBA44 File Offset: 0x004D9C44
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013087 RID: 77959 RVA: 0x004DBA54 File Offset: 0x004D9C54
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013088 RID: 77960 RVA: 0x004DBA64 File Offset: 0x004D9C64
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013089 RID: 77961 RVA: 0x004DBA74 File Offset: 0x004D9C74
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601308A RID: 77962 RVA: 0x004DBA84 File Offset: 0x004D9C84
			public void __callDele_EventOnToggleClick(SummonToggleUIController obj)
			{
				this.m_owner.__callDele_EventOnToggleClick(obj);
			}

			// Token: 0x0601308B RID: 77963 RVA: 0x004DBA94 File Offset: 0x004D9C94
			public void __clearDele_EventOnToggleClick(SummonToggleUIController obj)
			{
				this.m_owner.__clearDele_EventOnToggleClick(obj);
			}

			// Token: 0x17003972 RID: 14706
			// (get) Token: 0x0601308C RID: 77964 RVA: 0x004DBAA4 File Offset: 0x004D9CA4
			// (set) Token: 0x0601308D RID: 77965 RVA: 0x004DBAB4 File Offset: 0x004D9CB4
			public Toggle m_toggle
			{
				get
				{
					return this.m_owner.m_toggle;
				}
				set
				{
					this.m_owner.m_toggle = value;
				}
			}

			// Token: 0x17003973 RID: 14707
			// (get) Token: 0x0601308E RID: 77966 RVA: 0x004DBAC4 File Offset: 0x004D9CC4
			// (set) Token: 0x0601308F RID: 77967 RVA: 0x004DBAD4 File Offset: 0x004D9CD4
			public Image m_clickIconImage
			{
				get
				{
					return this.m_owner.m_clickIconImage;
				}
				set
				{
					this.m_owner.m_clickIconImage = value;
				}
			}

			// Token: 0x17003974 RID: 14708
			// (get) Token: 0x06013090 RID: 77968 RVA: 0x004DBAE4 File Offset: 0x004D9CE4
			// (set) Token: 0x06013091 RID: 77969 RVA: 0x004DBAF4 File Offset: 0x004D9CF4
			public Image m_unClickIconImage
			{
				get
				{
					return this.m_owner.m_unClickIconImage;
				}
				set
				{
					this.m_owner.m_unClickIconImage = value;
				}
			}

			// Token: 0x17003975 RID: 14709
			// (get) Token: 0x06013092 RID: 77970 RVA: 0x004DBB04 File Offset: 0x004D9D04
			// (set) Token: 0x06013093 RID: 77971 RVA: 0x004DBB14 File Offset: 0x004D9D14
			public Text m_nameClickText
			{
				get
				{
					return this.m_owner.m_nameClickText;
				}
				set
				{
					this.m_owner.m_nameClickText = value;
				}
			}

			// Token: 0x17003976 RID: 14710
			// (get) Token: 0x06013094 RID: 77972 RVA: 0x004DBB24 File Offset: 0x004D9D24
			// (set) Token: 0x06013095 RID: 77973 RVA: 0x004DBB34 File Offset: 0x004D9D34
			public Text m_nameUnClickText
			{
				get
				{
					return this.m_owner.m_nameUnClickText;
				}
				set
				{
					this.m_owner.m_nameUnClickText = value;
				}
			}

			// Token: 0x17003977 RID: 14711
			// (get) Token: 0x06013096 RID: 77974 RVA: 0x004DBB44 File Offset: 0x004D9D44
			// (set) Token: 0x06013097 RID: 77975 RVA: 0x004DBB54 File Offset: 0x004D9D54
			public Text m_timeClickText
			{
				get
				{
					return this.m_owner.m_timeClickText;
				}
				set
				{
					this.m_owner.m_timeClickText = value;
				}
			}

			// Token: 0x17003978 RID: 14712
			// (get) Token: 0x06013098 RID: 77976 RVA: 0x004DBB64 File Offset: 0x004D9D64
			// (set) Token: 0x06013099 RID: 77977 RVA: 0x004DBB74 File Offset: 0x004D9D74
			public Text m_timeUnClickText
			{
				get
				{
					return this.m_owner.m_timeUnClickText;
				}
				set
				{
					this.m_owner.m_timeUnClickText = value;
				}
			}

			// Token: 0x17003979 RID: 14713
			// (set) Token: 0x0601309A RID: 77978 RVA: 0x004DBB84 File Offset: 0x004D9D84
			public CardPool CardPool
			{
				set
				{
					this.m_owner.CardPool = value;
				}
			}

			// Token: 0x0601309B RID: 77979 RVA: 0x004DBB94 File Offset: 0x004D9D94
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601309C RID: 77980 RVA: 0x004DBBA4 File Offset: 0x004D9DA4
			public void OnToggleValueChanged(bool isOn)
			{
				this.m_owner.OnToggleValueChanged(isOn);
			}

			// Token: 0x0400A9E1 RID: 43489
			private SummonToggleUIController m_owner;
		}
	}
}
