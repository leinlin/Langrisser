using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FF7 RID: 4087
	[HotFix]
	public class UnchartedScoreRewardListItemUIController : UIControllerBase
	{
		// Token: 0x060148BA RID: 84154 RVA: 0x00536DE4 File Offset: 0x00534FE4
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
		}

		// Token: 0x060148BB RID: 84155 RVA: 0x00536E4C File Offset: 0x0053504C
		public void SetUnchartedScoreRewardGroupInfo(ConfigDataUnchartedScoreRewardGroupInfo rewardInfo, string scoreName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnchartedScoreRewardGroupInfoConfigDataUnchartedScoreRewardGroupInfoString_hotfix != null)
			{
				this.m_SetUnchartedScoreRewardGroupInfoConfigDataUnchartedScoreRewardGroupInfoString_hotfix.call(new object[]
				{
					this,
					rewardInfo,
					scoreName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = rewardInfo.Name;
			this.m_scoreNameText.text = scoreName;
			this.m_scoreText.text = rewardInfo.Score.ToString();
			GameObjectUtility.DestroyChildren(this.m_rewardGroupTransform.gameObject);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			List<Goods> list = new List<Goods>(rewardInfo.RewardList);
			if (list.Count > rewardInfo.RewardDisplayCount)
			{
				list.RemoveRange(rewardInfo.RewardDisplayCount, list.Count - rewardInfo.RewardDisplayCount);
			}
			RewardGoodsUIController.CreateRewardGoodsList(list, this.m_rewardGroupTransform, assetInContainer, null, true, 0, true);
		}

		// Token: 0x060148BC RID: 84156 RVA: 0x00536F6C File Offset: 0x0053516C
		public void SetGot(bool got)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGotBoolean_hotfix != null)
			{
				this.m_SetGotBoolean_hotfix.call(new object[]
				{
					this,
					got
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_uiStateController.SetToUIState((!got) ? "Normal" : "Get", false, true);
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x060148BD RID: 84157 RVA: 0x00537000 File Offset: 0x00535200
		// (set) Token: 0x060148BE RID: 84158 RVA: 0x00537020 File Offset: 0x00535220
		[DoNotToLua]
		public new UnchartedScoreRewardListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedScoreRewardListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060148BF RID: 84159 RVA: 0x0053702C File Offset: 0x0053522C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060148C0 RID: 84160 RVA: 0x00537038 File Offset: 0x00535238
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060148C1 RID: 84161 RVA: 0x00537040 File Offset: 0x00535240
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060148C2 RID: 84162 RVA: 0x00537048 File Offset: 0x00535248
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060148C3 RID: 84163 RVA: 0x0053705C File Offset: 0x0053525C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060148C4 RID: 84164 RVA: 0x00537064 File Offset: 0x00535264
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060148C5 RID: 84165 RVA: 0x00537070 File Offset: 0x00535270
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060148C6 RID: 84166 RVA: 0x0053707C File Offset: 0x0053527C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060148C7 RID: 84167 RVA: 0x00537088 File Offset: 0x00535288
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060148C8 RID: 84168 RVA: 0x00537094 File Offset: 0x00535294
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060148C9 RID: 84169 RVA: 0x005370A0 File Offset: 0x005352A0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060148CA RID: 84170 RVA: 0x005370AC File Offset: 0x005352AC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060148CB RID: 84171 RVA: 0x005370B8 File Offset: 0x005352B8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060148CC RID: 84172 RVA: 0x005370C4 File Offset: 0x005352C4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060148CD RID: 84173 RVA: 0x005370D0 File Offset: 0x005352D0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060148CE RID: 84174 RVA: 0x005370D8 File Offset: 0x005352D8
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
					this.m_SetUnchartedScoreRewardGroupInfoConfigDataUnchartedScoreRewardGroupInfoString_hotfix = (luaObj.RawGet("SetUnchartedScoreRewardGroupInfo") as LuaFunction);
					this.m_SetGotBoolean_hotfix = (luaObj.RawGet("SetGot") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060148CF RID: 84175 RVA: 0x005371D8 File Offset: 0x005353D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreRewardListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B4AF RID: 46255
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B4B0 RID: 46256
		[AutoBind("./TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400B4B1 RID: 46257
		[AutoBind("./DetailTextGroup/ValueGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_scoreNameText;

		// Token: 0x0400B4B2 RID: 46258
		[AutoBind("./DetailTextGroup/ValueGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_scoreText;

		// Token: 0x0400B4B3 RID: 46259
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_rewardGroupTransform;

		// Token: 0x0400B4B4 RID: 46260
		[DoNotToLua]
		private UnchartedScoreRewardListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B4B5 RID: 46261
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B4B6 RID: 46262
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B4B7 RID: 46263
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B4B8 RID: 46264
		private LuaFunction m_SetUnchartedScoreRewardGroupInfoConfigDataUnchartedScoreRewardGroupInfoString_hotfix;

		// Token: 0x0400B4B9 RID: 46265
		private LuaFunction m_SetGotBoolean_hotfix;

		// Token: 0x02000FF8 RID: 4088
		public new class LuaExportHelper
		{
			// Token: 0x060148D0 RID: 84176 RVA: 0x00537240 File Offset: 0x00535440
			public LuaExportHelper(UnchartedScoreRewardListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060148D1 RID: 84177 RVA: 0x00537250 File Offset: 0x00535450
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060148D2 RID: 84178 RVA: 0x00537260 File Offset: 0x00535460
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060148D3 RID: 84179 RVA: 0x00537270 File Offset: 0x00535470
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060148D4 RID: 84180 RVA: 0x00537280 File Offset: 0x00535480
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060148D5 RID: 84181 RVA: 0x00537298 File Offset: 0x00535498
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060148D6 RID: 84182 RVA: 0x005372A8 File Offset: 0x005354A8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060148D7 RID: 84183 RVA: 0x005372B8 File Offset: 0x005354B8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060148D8 RID: 84184 RVA: 0x005372C8 File Offset: 0x005354C8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060148D9 RID: 84185 RVA: 0x005372D8 File Offset: 0x005354D8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060148DA RID: 84186 RVA: 0x005372E8 File Offset: 0x005354E8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060148DB RID: 84187 RVA: 0x005372F8 File Offset: 0x005354F8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060148DC RID: 84188 RVA: 0x00537308 File Offset: 0x00535508
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060148DD RID: 84189 RVA: 0x00537318 File Offset: 0x00535518
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060148DE RID: 84190 RVA: 0x00537328 File Offset: 0x00535528
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060148DF RID: 84191 RVA: 0x00537338 File Offset: 0x00535538
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003CE0 RID: 15584
			// (get) Token: 0x060148E0 RID: 84192 RVA: 0x00537348 File Offset: 0x00535548
			// (set) Token: 0x060148E1 RID: 84193 RVA: 0x00537358 File Offset: 0x00535558
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x17003CE1 RID: 15585
			// (get) Token: 0x060148E2 RID: 84194 RVA: 0x00537368 File Offset: 0x00535568
			// (set) Token: 0x060148E3 RID: 84195 RVA: 0x00537378 File Offset: 0x00535578
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x17003CE2 RID: 15586
			// (get) Token: 0x060148E4 RID: 84196 RVA: 0x00537388 File Offset: 0x00535588
			// (set) Token: 0x060148E5 RID: 84197 RVA: 0x00537398 File Offset: 0x00535598
			public Text m_scoreNameText
			{
				get
				{
					return this.m_owner.m_scoreNameText;
				}
				set
				{
					this.m_owner.m_scoreNameText = value;
				}
			}

			// Token: 0x17003CE3 RID: 15587
			// (get) Token: 0x060148E6 RID: 84198 RVA: 0x005373A8 File Offset: 0x005355A8
			// (set) Token: 0x060148E7 RID: 84199 RVA: 0x005373B8 File Offset: 0x005355B8
			public Text m_scoreText
			{
				get
				{
					return this.m_owner.m_scoreText;
				}
				set
				{
					this.m_owner.m_scoreText = value;
				}
			}

			// Token: 0x17003CE4 RID: 15588
			// (get) Token: 0x060148E8 RID: 84200 RVA: 0x005373C8 File Offset: 0x005355C8
			// (set) Token: 0x060148E9 RID: 84201 RVA: 0x005373D8 File Offset: 0x005355D8
			public Transform m_rewardGroupTransform
			{
				get
				{
					return this.m_owner.m_rewardGroupTransform;
				}
				set
				{
					this.m_owner.m_rewardGroupTransform = value;
				}
			}

			// Token: 0x060148EA RID: 84202 RVA: 0x005373E8 File Offset: 0x005355E8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400B4BA RID: 46266
			private UnchartedScoreRewardListItemUIController m_owner;
		}
	}
}
