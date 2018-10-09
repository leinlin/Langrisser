using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CD2 RID: 3282
	[HotFix]
	public class GoddessDialogJobButton : UIControllerBase
	{
		// Token: 0x0600EEB4 RID: 61108 RVA: 0x003FAFAC File Offset: 0x003F91AC
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
		}

		// Token: 0x0600EEB5 RID: 61109 RVA: 0x003FB014 File Offset: 0x003F9214
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
			this.m_buton.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x0600EEB6 RID: 61110 RVA: 0x003FB098 File Offset: 0x003F9298
		public void SetJobConnectionInfo(ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetJobConnectionInfoConfigDataJobConnectionInfo_hotfix != null)
			{
				this.m_SetJobConnectionInfoConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_jobConnectionInfo = jobConnectionInfo;
			this.m_nameTex.text = jobConnectionInfo.m_jobInfo.Name;
			this.m_descTex.text = jobConnectionInfo.m_jobInfo.Desc;
			this.m_armyIconImage.sprite = AssetUtility.Instance.GetSprite(jobConnectionInfo.m_jobInfo.m_armyInfo.Icon_NoBack);
			float scale = (float)jobConnectionInfo.UI_ModelScale * 0.012f;
			Vector2 offset = new Vector2((float)jobConnectionInfo.UI_ModelOffsetX, (float)jobConnectionInfo.UI_ModelOffsetY) * 1.2f;
			this.CreateSpineGraphic(jobConnectionInfo.Model, scale, offset, this.m_graphicGameObject, jobConnectionInfo.ReplaceAnims);
		}

		// Token: 0x0600EEB7 RID: 61111 RVA: 0x003FB1A8 File Offset: 0x003F93A8
		public ConfigDataJobConnectionInfo GetJobConnectionInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetJobConnectionInfo_hotfix != null)
			{
				return (ConfigDataJobConnectionInfo)this.m_GetJobConnectionInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_jobConnectionInfo;
		}

		// Token: 0x0600EEB8 RID: 61112 RVA: 0x003FB21C File Offset: 0x003F941C
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x0600EEB9 RID: 61113 RVA: 0x003FB294 File Offset: 0x003F9494
		private void CreateSpineGraphic(string assetName, float scale, Vector2 offset, GameObject parent, List<ReplaceAnim> replaceAnims)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicStringSingleVector2GameObjectList`1_hotfix != null)
			{
				this.m_CreateSpineGraphicStringSingleVector2GameObjectList`1_hotfix.call(new object[]
				{
					this,
					assetName,
					scale,
					offset,
					parent,
					replaceAnims
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
			this.m_graphic = new UISpineGraphic();
			this.m_graphic.Create(assetName);
			this.m_graphic.SetParent(parent);
			this.m_graphic.SetDirection(-1);
			this.m_graphic.SetPosition(offset);
			this.m_graphic.SetScale(scale);
			this.m_graphic.SetReplaceAnimations(replaceAnims);
			this.m_graphic.PlayAnimation("idle", true, 0);
			this.m_graphic.ForceUpdate();
		}

		// Token: 0x0600EEBA RID: 61114 RVA: 0x003FB3C0 File Offset: 0x003F95C0
		private void DestroySpineGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphic_hotfix != null)
			{
				this.m_DestroySpineGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.Destroy();
				this.m_graphic = null;
			}
		}

		// Token: 0x14000328 RID: 808
		// (add) Token: 0x0600EEBB RID: 61115 RVA: 0x003FB440 File Offset: 0x003F9640
		// (remove) Token: 0x0600EEBC RID: 61116 RVA: 0x003FB4DC File Offset: 0x003F96DC
		public event Action<GoddessDialogJobButton> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoddessDialogJobButton> action = this.EventOnClick;
				Action<GoddessDialogJobButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoddessDialogJobButton>>(ref this.EventOnClick, (Action<GoddessDialogJobButton>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoddessDialogJobButton> action = this.EventOnClick;
				Action<GoddessDialogJobButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoddessDialogJobButton>>(ref this.EventOnClick, (Action<GoddessDialogJobButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0600EEBD RID: 61117 RVA: 0x003FB578 File Offset: 0x003F9778
		// (set) Token: 0x0600EEBE RID: 61118 RVA: 0x003FB598 File Offset: 0x003F9798
		[DoNotToLua]
		public new GoddessDialogJobButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GoddessDialogJobButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600EEBF RID: 61119 RVA: 0x003FB5A4 File Offset: 0x003F97A4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600EEC0 RID: 61120 RVA: 0x003FB5B0 File Offset: 0x003F97B0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600EEC1 RID: 61121 RVA: 0x003FB5B8 File Offset: 0x003F97B8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600EEC2 RID: 61122 RVA: 0x003FB5C0 File Offset: 0x003F97C0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600EEC3 RID: 61123 RVA: 0x003FB5D4 File Offset: 0x003F97D4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600EEC4 RID: 61124 RVA: 0x003FB5DC File Offset: 0x003F97DC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600EEC5 RID: 61125 RVA: 0x003FB5E8 File Offset: 0x003F97E8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600EEC6 RID: 61126 RVA: 0x003FB5F4 File Offset: 0x003F97F4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600EEC7 RID: 61127 RVA: 0x003FB600 File Offset: 0x003F9800
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600EEC8 RID: 61128 RVA: 0x003FB60C File Offset: 0x003F980C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600EEC9 RID: 61129 RVA: 0x003FB618 File Offset: 0x003F9818
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600EECA RID: 61130 RVA: 0x003FB624 File Offset: 0x003F9824
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600EECB RID: 61131 RVA: 0x003FB630 File Offset: 0x003F9830
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600EECC RID: 61132 RVA: 0x003FB63C File Offset: 0x003F983C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600EECD RID: 61133 RVA: 0x003FB648 File Offset: 0x003F9848
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600EECE RID: 61134 RVA: 0x003FB650 File Offset: 0x003F9850
		private void __callDele_EventOnClick(GoddessDialogJobButton obj)
		{
			Action<GoddessDialogJobButton> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600EECF RID: 61135 RVA: 0x003FB674 File Offset: 0x003F9874
		private void __clearDele_EventOnClick(GoddessDialogJobButton obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600EED0 RID: 61136 RVA: 0x003FB680 File Offset: 0x003F9880
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
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_SetJobConnectionInfoConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("SetJobConnectionInfo") as LuaFunction);
					this.m_GetJobConnectionInfo_hotfix = (luaObj.RawGet("GetJobConnectionInfo") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_CreateSpineGraphicStringSingleVector2GameObjectList`1_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EED1 RID: 61137 RVA: 0x003FB814 File Offset: 0x003F9A14
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GoddessDialogJobButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008E7C RID: 36476
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_buton;

		// Token: 0x04008E7D RID: 36477
		[AutoBind("./ArmyIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_armyIconImage;

		// Token: 0x04008E7E RID: 36478
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameTex;

		// Token: 0x04008E7F RID: 36479
		[AutoBind("./DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descTex;

		// Token: 0x04008E80 RID: 36480
		[AutoBind("./Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_graphicGameObject;

		// Token: 0x04008E81 RID: 36481
		private ConfigDataJobConnectionInfo m_jobConnectionInfo;

		// Token: 0x04008E82 RID: 36482
		private UISpineGraphic m_graphic;

		// Token: 0x04008E83 RID: 36483
		[DoNotToLua]
		private GoddessDialogJobButton.LuaExportHelper luaExportHelper;

		// Token: 0x04008E84 RID: 36484
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008E85 RID: 36485
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008E86 RID: 36486
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04008E87 RID: 36487
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008E88 RID: 36488
		private LuaFunction m_SetJobConnectionInfoConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04008E89 RID: 36489
		private LuaFunction m_GetJobConnectionInfo_hotfix;

		// Token: 0x04008E8A RID: 36490
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x04008E8B RID: 36491
		private LuaFunction m_CreateSpineGraphicStringSingleVector2GameObjectList;

		// Token: 0x04008E8C RID: 36492
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x04008E8D RID: 36493
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04008E8E RID: 36494
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000CD3 RID: 3283
		public new class LuaExportHelper
		{
			// Token: 0x0600EED2 RID: 61138 RVA: 0x003FB87C File Offset: 0x003F9A7C
			public LuaExportHelper(GoddessDialogJobButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EED3 RID: 61139 RVA: 0x003FB88C File Offset: 0x003F9A8C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600EED4 RID: 61140 RVA: 0x003FB89C File Offset: 0x003F9A9C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600EED5 RID: 61141 RVA: 0x003FB8AC File Offset: 0x003F9AAC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600EED6 RID: 61142 RVA: 0x003FB8BC File Offset: 0x003F9ABC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600EED7 RID: 61143 RVA: 0x003FB8D4 File Offset: 0x003F9AD4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600EED8 RID: 61144 RVA: 0x003FB8E4 File Offset: 0x003F9AE4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600EED9 RID: 61145 RVA: 0x003FB8F4 File Offset: 0x003F9AF4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600EEDA RID: 61146 RVA: 0x003FB904 File Offset: 0x003F9B04
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600EEDB RID: 61147 RVA: 0x003FB914 File Offset: 0x003F9B14
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600EEDC RID: 61148 RVA: 0x003FB924 File Offset: 0x003F9B24
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600EEDD RID: 61149 RVA: 0x003FB934 File Offset: 0x003F9B34
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600EEDE RID: 61150 RVA: 0x003FB944 File Offset: 0x003F9B44
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600EEDF RID: 61151 RVA: 0x003FB954 File Offset: 0x003F9B54
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600EEE0 RID: 61152 RVA: 0x003FB964 File Offset: 0x003F9B64
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600EEE1 RID: 61153 RVA: 0x003FB974 File Offset: 0x003F9B74
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600EEE2 RID: 61154 RVA: 0x003FB984 File Offset: 0x003F9B84
			public void __callDele_EventOnClick(GoddessDialogJobButton obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600EEE3 RID: 61155 RVA: 0x003FB994 File Offset: 0x003F9B94
			public void __clearDele_EventOnClick(GoddessDialogJobButton obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002DFF RID: 11775
			// (get) Token: 0x0600EEE4 RID: 61156 RVA: 0x003FB9A4 File Offset: 0x003F9BA4
			// (set) Token: 0x0600EEE5 RID: 61157 RVA: 0x003FB9B4 File Offset: 0x003F9BB4
			public Button m_buton
			{
				get
				{
					return this.m_owner.m_buton;
				}
				set
				{
					this.m_owner.m_buton = value;
				}
			}

			// Token: 0x17002E00 RID: 11776
			// (get) Token: 0x0600EEE6 RID: 61158 RVA: 0x003FB9C4 File Offset: 0x003F9BC4
			// (set) Token: 0x0600EEE7 RID: 61159 RVA: 0x003FB9D4 File Offset: 0x003F9BD4
			public Image m_armyIconImage
			{
				get
				{
					return this.m_owner.m_armyIconImage;
				}
				set
				{
					this.m_owner.m_armyIconImage = value;
				}
			}

			// Token: 0x17002E01 RID: 11777
			// (get) Token: 0x0600EEE8 RID: 61160 RVA: 0x003FB9E4 File Offset: 0x003F9BE4
			// (set) Token: 0x0600EEE9 RID: 61161 RVA: 0x003FB9F4 File Offset: 0x003F9BF4
			public Text m_nameTex
			{
				get
				{
					return this.m_owner.m_nameTex;
				}
				set
				{
					this.m_owner.m_nameTex = value;
				}
			}

			// Token: 0x17002E02 RID: 11778
			// (get) Token: 0x0600EEEA RID: 61162 RVA: 0x003FBA04 File Offset: 0x003F9C04
			// (set) Token: 0x0600EEEB RID: 61163 RVA: 0x003FBA14 File Offset: 0x003F9C14
			public Text m_descTex
			{
				get
				{
					return this.m_owner.m_descTex;
				}
				set
				{
					this.m_owner.m_descTex = value;
				}
			}

			// Token: 0x17002E03 RID: 11779
			// (get) Token: 0x0600EEEC RID: 61164 RVA: 0x003FBA24 File Offset: 0x003F9C24
			// (set) Token: 0x0600EEED RID: 61165 RVA: 0x003FBA34 File Offset: 0x003F9C34
			public GameObject m_graphicGameObject
			{
				get
				{
					return this.m_owner.m_graphicGameObject;
				}
				set
				{
					this.m_owner.m_graphicGameObject = value;
				}
			}

			// Token: 0x17002E04 RID: 11780
			// (get) Token: 0x0600EEEE RID: 61166 RVA: 0x003FBA44 File Offset: 0x003F9C44
			// (set) Token: 0x0600EEEF RID: 61167 RVA: 0x003FBA54 File Offset: 0x003F9C54
			public ConfigDataJobConnectionInfo m_jobConnectionInfo
			{
				get
				{
					return this.m_owner.m_jobConnectionInfo;
				}
				set
				{
					this.m_owner.m_jobConnectionInfo = value;
				}
			}

			// Token: 0x17002E05 RID: 11781
			// (get) Token: 0x0600EEF0 RID: 61168 RVA: 0x003FBA64 File Offset: 0x003F9C64
			// (set) Token: 0x0600EEF1 RID: 61169 RVA: 0x003FBA74 File Offset: 0x003F9C74
			public UISpineGraphic m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x0600EEF2 RID: 61170 RVA: 0x003FBA84 File Offset: 0x003F9C84
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600EEF3 RID: 61171 RVA: 0x003FBA94 File Offset: 0x003F9C94
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600EEF4 RID: 61172 RVA: 0x003FBAA4 File Offset: 0x003F9CA4
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0600EEF5 RID: 61173 RVA: 0x003FBAB4 File Offset: 0x003F9CB4
			public void CreateSpineGraphic(string assetName, float scale, Vector2 offset, GameObject parent, List<ReplaceAnim> replaceAnims)
			{
				this.m_owner.CreateSpineGraphic(assetName, scale, offset, parent, replaceAnims);
			}

			// Token: 0x0600EEF6 RID: 61174 RVA: 0x003FBAC8 File Offset: 0x003F9CC8
			public void DestroySpineGraphic()
			{
				this.m_owner.DestroySpineGraphic();
			}

			// Token: 0x04008E8F RID: 36495
			private GoddessDialogJobButton m_owner;
		}
	}
}
