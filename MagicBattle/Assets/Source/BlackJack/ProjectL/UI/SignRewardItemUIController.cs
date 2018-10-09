using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F0C RID: 3852
	[HotFix]
	public class SignRewardItemUIController : UIControllerBase, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06013164 RID: 78180 RVA: 0x004DE464 File Offset: 0x004DC664
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

		// Token: 0x06013165 RID: 78181 RVA: 0x004DE4D8 File Offset: 0x004DC6D8
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_signItemGoodsDummy.GetComponentInChildren<Button>().IsActive() && this.m_signState != SignRewardItemUIController.SignState.NeedSign && this.m_itemInfo != null && this.m_itemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataStaticBoxInfo configDataStaticBoxInfo = configDataLoader.GetConfigDataStaticBoxInfo(this.m_itemInfo.FuncTypeParam1);
				if (this.EventOnShowBoxRewards != null && configDataStaticBoxInfo != null)
				{
					this.EventOnShowBoxRewards(configDataStaticBoxInfo.Reward, this);
				}
			}
		}

		// Token: 0x06013166 RID: 78182 RVA: 0x004DE5CC File Offset: 0x004DC7CC
		public void SetReward(Goods goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardGoods_hotfix != null)
			{
				this.m_SetRewardGoods_hotfix.call(new object[]
				{
					this,
					goods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_goodsType = goods.GoodsType;
			this.m_goodsId = goods.Id;
			this.m_goodsCount = goods.Count;
			this.m_itemInfo = null;
			if (goods.GoodsType == GoodsType.GoodsType_Item)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				this.m_itemInfo = configDataLoader.GetConfigDataItemInfo(goods.Id);
			}
			GameObjectUtility.DestroyChildren(this.m_signItemGoodsDummy);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoods(goods, this.m_signItemGoodsDummy.transform, assetInContainer, true, 0);
		}

		// Token: 0x06013167 RID: 78183 RVA: 0x004DE6C4 File Offset: 0x004DC8C4
		public void SetDay(int day)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDayInt32_hotfix != null)
			{
				this.m_SetDayInt32_hotfix.call(new object[]
				{
					this,
					day
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (day <= projectLPlayerContext.GetSignDaysMonth())
			{
				this.m_signState = SignRewardItemUIController.SignState.Signed;
				this.m_signItemUIStateCtrl.SetToUIState("Signed", false, true);
			}
			else if (day == projectLPlayerContext.GetSignDaysMonth() + 1 && !projectLPlayerContext.TodayIsSigned())
			{
				this.m_signState = SignRewardItemUIController.SignState.NeedSign;
			}
			else
			{
				this.m_signState = SignRewardItemUIController.SignState.NotSign;
				this.m_signItemUIStateCtrl.SetToUIState("NotSign", false, true);
			}
			if (this.m_signState != SignRewardItemUIController.SignState.NeedSign && this.m_itemInfo != null && this.m_itemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox)
			{
				this.m_signItemGoodsDummy.GetComponentInChildren<Button>().enabled = false;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_dayText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Sign_NDay), day);
		}

		// Token: 0x06013168 RID: 78184 RVA: 0x004DE818 File Offset: 0x004DCA18
		public void PlaySignAnimation(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySignAnimationAction_hotfix != null)
			{
				this.m_PlaySignAnimationAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ChangeStateToSigning(onEnd));
		}

		// Token: 0x06013169 RID: 78185 RVA: 0x004DE898 File Offset: 0x004DCA98
		[DebuggerHidden]
		private IEnumerator Co_ChangeStateToSigning(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ChangeStateToSigningAction_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ChangeStateToSigningAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SignRewardItemUIController.<Co_ChangeStateToSigning>c__Iterator0 <Co_ChangeStateToSigning>c__Iterator = new SignRewardItemUIController.<Co_ChangeStateToSigning>c__Iterator0();
			<Co_ChangeStateToSigning>c__Iterator.onEnd = onEnd;
			<Co_ChangeStateToSigning>c__Iterator.$this = this;
			return <Co_ChangeStateToSigning>c__Iterator;
		}

		// Token: 0x0601316A RID: 78186 RVA: 0x004DE92C File Offset: 0x004DCB2C
		public void TodayAutoSign()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TodayAutoSign_hotfix != null)
			{
				this.m_TodayAutoSign_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_itemInfo != null && (this.m_itemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox || this.m_itemInfo.FuncType == ItemFuncType.ItemFuncType_RandomBox))
			{
				if (this.EventOnSignTodayBoxOpenClick != null)
				{
					this.EventOnSignTodayBoxOpenClick(this.m_goodsType, this.m_goodsId, this.m_goodsCount);
				}
			}
			else if (this.EventOnSignTodayItemClick != null)
			{
				this.EventOnSignTodayItemClick();
			}
		}

		// Token: 0x0601316B RID: 78187 RVA: 0x004DEA00 File Offset: 0x004DCC00
		public GoodsType GetGoodsType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGoodsType_hotfix != null)
			{
				return (GoodsType)this.m_GetGoodsType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_goodsType;
		}

		// Token: 0x0601316C RID: 78188 RVA: 0x004DEA74 File Offset: 0x004DCC74
		public int GetGoodsId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGoodsId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetGoodsId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_goodsId;
		}

		// Token: 0x0601316D RID: 78189 RVA: 0x004DEAE8 File Offset: 0x004DCCE8
		public int GetGoodsCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGoodsCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetGoodsCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_goodsCount;
		}

		// Token: 0x14000423 RID: 1059
		// (add) Token: 0x0601316E RID: 78190 RVA: 0x004DEB5C File Offset: 0x004DCD5C
		// (remove) Token: 0x0601316F RID: 78191 RVA: 0x004DEBF8 File Offset: 0x004DCDF8
		public event Action EventOnSignTodayItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSignTodayItemClickAction_hotfix != null)
				{
					this.m_add_EventOnSignTodayItemClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSignTodayItemClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSignTodayItemClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSignTodayItemClickAction_hotfix != null)
				{
					this.m_remove_EventOnSignTodayItemClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSignTodayItemClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSignTodayItemClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000424 RID: 1060
		// (add) Token: 0x06013170 RID: 78192 RVA: 0x004DEC94 File Offset: 0x004DCE94
		// (remove) Token: 0x06013171 RID: 78193 RVA: 0x004DED30 File Offset: 0x004DCF30
		public event Action<GoodsType, int, int> EventOnSignTodayBoxOpenClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSignTodayBoxOpenClickAction`3_hotfix != null)
				{
					this.m_add_EventOnSignTodayBoxOpenClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnSignTodayBoxOpenClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnSignTodayBoxOpenClick, (Action<GoodsType, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSignTodayBoxOpenClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnSignTodayBoxOpenClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnSignTodayBoxOpenClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnSignTodayBoxOpenClick, (Action<GoodsType, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000425 RID: 1061
		// (add) Token: 0x06013172 RID: 78194 RVA: 0x004DEDCC File Offset: 0x004DCFCC
		// (remove) Token: 0x06013173 RID: 78195 RVA: 0x004DEE68 File Offset: 0x004DD068
		public event Action<List<Goods>, SignRewardItemUIController> EventOnShowBoxRewards
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowBoxRewardsAction`2_hotfix != null)
				{
					this.m_add_EventOnShowBoxRewardsAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<Goods>, SignRewardItemUIController> action = this.EventOnShowBoxRewards;
				Action<List<Goods>, SignRewardItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<Goods>, SignRewardItemUIController>>(ref this.EventOnShowBoxRewards, (Action<List<Goods>, SignRewardItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowBoxRewardsAction`2_hotfix != null)
				{
					this.m_remove_EventOnShowBoxRewardsAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<Goods>, SignRewardItemUIController> action = this.EventOnShowBoxRewards;
				Action<List<Goods>, SignRewardItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<Goods>, SignRewardItemUIController>>(ref this.EventOnShowBoxRewards, (Action<List<Goods>, SignRewardItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x06013174 RID: 78196 RVA: 0x004DEF04 File Offset: 0x004DD104
		// (set) Token: 0x06013175 RID: 78197 RVA: 0x004DEF24 File Offset: 0x004DD124
		[DoNotToLua]
		public new SignRewardItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SignRewardItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013176 RID: 78198 RVA: 0x004DEF30 File Offset: 0x004DD130
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013177 RID: 78199 RVA: 0x004DEF3C File Offset: 0x004DD13C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013178 RID: 78200 RVA: 0x004DEF44 File Offset: 0x004DD144
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013179 RID: 78201 RVA: 0x004DEF4C File Offset: 0x004DD14C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601317A RID: 78202 RVA: 0x004DEF60 File Offset: 0x004DD160
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601317B RID: 78203 RVA: 0x004DEF68 File Offset: 0x004DD168
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601317C RID: 78204 RVA: 0x004DEF74 File Offset: 0x004DD174
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601317D RID: 78205 RVA: 0x004DEF80 File Offset: 0x004DD180
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601317E RID: 78206 RVA: 0x004DEF8C File Offset: 0x004DD18C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601317F RID: 78207 RVA: 0x004DEF98 File Offset: 0x004DD198
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013180 RID: 78208 RVA: 0x004DEFA4 File Offset: 0x004DD1A4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013181 RID: 78209 RVA: 0x004DEFB0 File Offset: 0x004DD1B0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013182 RID: 78210 RVA: 0x004DEFBC File Offset: 0x004DD1BC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013183 RID: 78211 RVA: 0x004DEFC8 File Offset: 0x004DD1C8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013184 RID: 78212 RVA: 0x004DEFD4 File Offset: 0x004DD1D4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013185 RID: 78213 RVA: 0x004DEFDC File Offset: 0x004DD1DC
		private void __callDele_EventOnSignTodayItemClick()
		{
			Action eventOnSignTodayItemClick = this.EventOnSignTodayItemClick;
			if (eventOnSignTodayItemClick != null)
			{
				eventOnSignTodayItemClick();
			}
		}

		// Token: 0x06013186 RID: 78214 RVA: 0x004DEFFC File Offset: 0x004DD1FC
		private void __clearDele_EventOnSignTodayItemClick()
		{
			this.EventOnSignTodayItemClick = null;
		}

		// Token: 0x06013187 RID: 78215 RVA: 0x004DF008 File Offset: 0x004DD208
		private void __callDele_EventOnSignTodayBoxOpenClick(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnSignTodayBoxOpenClick = this.EventOnSignTodayBoxOpenClick;
			if (eventOnSignTodayBoxOpenClick != null)
			{
				eventOnSignTodayBoxOpenClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x06013188 RID: 78216 RVA: 0x004DF02C File Offset: 0x004DD22C
		private void __clearDele_EventOnSignTodayBoxOpenClick(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnSignTodayBoxOpenClick = null;
		}

		// Token: 0x06013189 RID: 78217 RVA: 0x004DF038 File Offset: 0x004DD238
		private void __callDele_EventOnShowBoxRewards(List<Goods> arg1, SignRewardItemUIController arg2)
		{
			Action<List<Goods>, SignRewardItemUIController> eventOnShowBoxRewards = this.EventOnShowBoxRewards;
			if (eventOnShowBoxRewards != null)
			{
				eventOnShowBoxRewards(arg1, arg2);
			}
		}

		// Token: 0x0601318A RID: 78218 RVA: 0x004DF05C File Offset: 0x004DD25C
		private void __clearDele_EventOnShowBoxRewards(List<Goods> arg1, SignRewardItemUIController arg2)
		{
			this.EventOnShowBoxRewards = null;
		}

		// Token: 0x0601318B RID: 78219 RVA: 0x004DF068 File Offset: 0x004DD268
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
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_SetRewardGoods_hotfix = (luaObj.RawGet("SetReward") as LuaFunction);
					this.m_SetDayInt32_hotfix = (luaObj.RawGet("SetDay") as LuaFunction);
					this.m_PlaySignAnimationAction_hotfix = (luaObj.RawGet("PlaySignAnimation") as LuaFunction);
					this.m_Co_ChangeStateToSigningAction_hotfix = (luaObj.RawGet("Co_ChangeStateToSigning") as LuaFunction);
					this.m_TodayAutoSign_hotfix = (luaObj.RawGet("TodayAutoSign") as LuaFunction);
					this.m_GetGoodsType_hotfix = (luaObj.RawGet("GetGoodsType") as LuaFunction);
					this.m_GetGoodsId_hotfix = (luaObj.RawGet("GetGoodsId") as LuaFunction);
					this.m_GetGoodsCount_hotfix = (luaObj.RawGet("GetGoodsCount") as LuaFunction);
					this.m_add_EventOnSignTodayItemClickAction_hotfix = (luaObj.RawGet("add_EventOnSignTodayItemClick") as LuaFunction);
					this.m_remove_EventOnSignTodayItemClickAction_hotfix = (luaObj.RawGet("remove_EventOnSignTodayItemClick") as LuaFunction);
					this.m_add_EventOnSignTodayBoxOpenClickAction`3_hotfix = (luaObj.RawGet("add_EventOnSignTodayBoxOpenClick") as LuaFunction);
					this.m_remove_EventOnSignTodayBoxOpenClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnSignTodayBoxOpenClick") as LuaFunction);
					this.m_add_EventOnShowBoxRewardsAction`2_hotfix = (luaObj.RawGet("add_EventOnShowBoxRewards") as LuaFunction);
					this.m_remove_EventOnShowBoxRewardsAction`2_hotfix = (luaObj.RawGet("remove_EventOnShowBoxRewards") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601318C RID: 78220 RVA: 0x004DF2AC File Offset: 0x004DD4AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SignRewardItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AA21 RID: 43553
		[AutoBind("./ItemGroup/RewardGoodsDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_signItemGoodsDummy;

		// Token: 0x0400AA22 RID: 43554
		[AutoBind("./FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_itemFrameImage;

		// Token: 0x0400AA23 RID: 43555
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_signItemUIStateCtrl;

		// Token: 0x0400AA24 RID: 43556
		[AutoBind("./DayText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dayText;

		// Token: 0x0400AA25 RID: 43557
		private SignRewardItemUIController.SignState m_signState;

		// Token: 0x0400AA26 RID: 43558
		private GoodsType m_goodsType;

		// Token: 0x0400AA27 RID: 43559
		private int m_goodsId;

		// Token: 0x0400AA28 RID: 43560
		private int m_goodsCount;

		// Token: 0x0400AA29 RID: 43561
		private ConfigDataItemInfo m_itemInfo;

		// Token: 0x0400AA2A RID: 43562
		[DoNotToLua]
		private SignRewardItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AA2B RID: 43563
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AA2C RID: 43564
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AA2D RID: 43565
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AA2E RID: 43566
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x0400AA2F RID: 43567
		private LuaFunction m_SetRewardGoods_hotfix;

		// Token: 0x0400AA30 RID: 43568
		private LuaFunction m_SetDayInt32_hotfix;

		// Token: 0x0400AA31 RID: 43569
		private LuaFunction m_PlaySignAnimationAction_hotfix;

		// Token: 0x0400AA32 RID: 43570
		private LuaFunction m_Co_ChangeStateToSigningAction_hotfix;

		// Token: 0x0400AA33 RID: 43571
		private LuaFunction m_TodayAutoSign_hotfix;

		// Token: 0x0400AA34 RID: 43572
		private LuaFunction m_GetGoodsType_hotfix;

		// Token: 0x0400AA35 RID: 43573
		private LuaFunction m_GetGoodsId_hotfix;

		// Token: 0x0400AA36 RID: 43574
		private LuaFunction m_GetGoodsCount_hotfix;

		// Token: 0x0400AA37 RID: 43575
		private LuaFunction m_add_EventOnSignTodayItemClickAction_hotfix;

		// Token: 0x0400AA38 RID: 43576
		private LuaFunction m_remove_EventOnSignTodayItemClickAction_hotfix;

		// Token: 0x0400AA39 RID: 43577
		private LuaFunction m_add_EventOnSignTodayBoxOpenClickAction;

		// Token: 0x0400AA3A RID: 43578
		private LuaFunction m_remove_EventOnSignTodayBoxOpenClickAction;

		// Token: 0x0400AA3B RID: 43579
		private LuaFunction m_add_EventOnShowBoxRewardsAction;

		// Token: 0x0400AA3C RID: 43580
		private LuaFunction m_remove_EventOnShowBoxRewardsAction;

		// Token: 0x02000F0D RID: 3853
		public enum SignState
		{
			// Token: 0x0400AA3E RID: 43582
			Signed,
			// Token: 0x0400AA3F RID: 43583
			NeedSign,
			// Token: 0x0400AA40 RID: 43584
			NotSign
		}

		// Token: 0x02000F0E RID: 3854
		public new class LuaExportHelper
		{
			// Token: 0x0601318D RID: 78221 RVA: 0x004DF314 File Offset: 0x004DD514
			public LuaExportHelper(SignRewardItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601318E RID: 78222 RVA: 0x004DF324 File Offset: 0x004DD524
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601318F RID: 78223 RVA: 0x004DF334 File Offset: 0x004DD534
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013190 RID: 78224 RVA: 0x004DF344 File Offset: 0x004DD544
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013191 RID: 78225 RVA: 0x004DF354 File Offset: 0x004DD554
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013192 RID: 78226 RVA: 0x004DF36C File Offset: 0x004DD56C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013193 RID: 78227 RVA: 0x004DF37C File Offset: 0x004DD57C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013194 RID: 78228 RVA: 0x004DF38C File Offset: 0x004DD58C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013195 RID: 78229 RVA: 0x004DF39C File Offset: 0x004DD59C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013196 RID: 78230 RVA: 0x004DF3AC File Offset: 0x004DD5AC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013197 RID: 78231 RVA: 0x004DF3BC File Offset: 0x004DD5BC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013198 RID: 78232 RVA: 0x004DF3CC File Offset: 0x004DD5CC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013199 RID: 78233 RVA: 0x004DF3DC File Offset: 0x004DD5DC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601319A RID: 78234 RVA: 0x004DF3EC File Offset: 0x004DD5EC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601319B RID: 78235 RVA: 0x004DF3FC File Offset: 0x004DD5FC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601319C RID: 78236 RVA: 0x004DF40C File Offset: 0x004DD60C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601319D RID: 78237 RVA: 0x004DF41C File Offset: 0x004DD61C
			public void __callDele_EventOnSignTodayItemClick()
			{
				this.m_owner.__callDele_EventOnSignTodayItemClick();
			}

			// Token: 0x0601319E RID: 78238 RVA: 0x004DF42C File Offset: 0x004DD62C
			public void __clearDele_EventOnSignTodayItemClick()
			{
				this.m_owner.__clearDele_EventOnSignTodayItemClick();
			}

			// Token: 0x0601319F RID: 78239 RVA: 0x004DF43C File Offset: 0x004DD63C
			public void __callDele_EventOnSignTodayBoxOpenClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnSignTodayBoxOpenClick(arg1, arg2, arg3);
			}

			// Token: 0x060131A0 RID: 78240 RVA: 0x004DF44C File Offset: 0x004DD64C
			public void __clearDele_EventOnSignTodayBoxOpenClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnSignTodayBoxOpenClick(arg1, arg2, arg3);
			}

			// Token: 0x060131A1 RID: 78241 RVA: 0x004DF45C File Offset: 0x004DD65C
			public void __callDele_EventOnShowBoxRewards(List<Goods> arg1, SignRewardItemUIController arg2)
			{
				this.m_owner.__callDele_EventOnShowBoxRewards(arg1, arg2);
			}

			// Token: 0x060131A2 RID: 78242 RVA: 0x004DF46C File Offset: 0x004DD66C
			public void __clearDele_EventOnShowBoxRewards(List<Goods> arg1, SignRewardItemUIController arg2)
			{
				this.m_owner.__clearDele_EventOnShowBoxRewards(arg1, arg2);
			}

			// Token: 0x17003993 RID: 14739
			// (get) Token: 0x060131A3 RID: 78243 RVA: 0x004DF47C File Offset: 0x004DD67C
			// (set) Token: 0x060131A4 RID: 78244 RVA: 0x004DF48C File Offset: 0x004DD68C
			public GameObject m_signItemGoodsDummy
			{
				get
				{
					return this.m_owner.m_signItemGoodsDummy;
				}
				set
				{
					this.m_owner.m_signItemGoodsDummy = value;
				}
			}

			// Token: 0x17003994 RID: 14740
			// (get) Token: 0x060131A5 RID: 78245 RVA: 0x004DF49C File Offset: 0x004DD69C
			// (set) Token: 0x060131A6 RID: 78246 RVA: 0x004DF4AC File Offset: 0x004DD6AC
			public CommonUIStateController m_signItemUIStateCtrl
			{
				get
				{
					return this.m_owner.m_signItemUIStateCtrl;
				}
				set
				{
					this.m_owner.m_signItemUIStateCtrl = value;
				}
			}

			// Token: 0x17003995 RID: 14741
			// (get) Token: 0x060131A7 RID: 78247 RVA: 0x004DF4BC File Offset: 0x004DD6BC
			// (set) Token: 0x060131A8 RID: 78248 RVA: 0x004DF4CC File Offset: 0x004DD6CC
			public Text m_dayText
			{
				get
				{
					return this.m_owner.m_dayText;
				}
				set
				{
					this.m_owner.m_dayText = value;
				}
			}

			// Token: 0x17003996 RID: 14742
			// (get) Token: 0x060131A9 RID: 78249 RVA: 0x004DF4DC File Offset: 0x004DD6DC
			// (set) Token: 0x060131AA RID: 78250 RVA: 0x004DF4EC File Offset: 0x004DD6EC
			public SignRewardItemUIController.SignState m_signState
			{
				get
				{
					return this.m_owner.m_signState;
				}
				set
				{
					this.m_owner.m_signState = value;
				}
			}

			// Token: 0x17003997 RID: 14743
			// (get) Token: 0x060131AB RID: 78251 RVA: 0x004DF4FC File Offset: 0x004DD6FC
			// (set) Token: 0x060131AC RID: 78252 RVA: 0x004DF50C File Offset: 0x004DD70C
			public GoodsType m_goodsType
			{
				get
				{
					return this.m_owner.m_goodsType;
				}
				set
				{
					this.m_owner.m_goodsType = value;
				}
			}

			// Token: 0x17003998 RID: 14744
			// (get) Token: 0x060131AD RID: 78253 RVA: 0x004DF51C File Offset: 0x004DD71C
			// (set) Token: 0x060131AE RID: 78254 RVA: 0x004DF52C File Offset: 0x004DD72C
			public int m_goodsId
			{
				get
				{
					return this.m_owner.m_goodsId;
				}
				set
				{
					this.m_owner.m_goodsId = value;
				}
			}

			// Token: 0x17003999 RID: 14745
			// (get) Token: 0x060131AF RID: 78255 RVA: 0x004DF53C File Offset: 0x004DD73C
			// (set) Token: 0x060131B0 RID: 78256 RVA: 0x004DF54C File Offset: 0x004DD74C
			public int m_goodsCount
			{
				get
				{
					return this.m_owner.m_goodsCount;
				}
				set
				{
					this.m_owner.m_goodsCount = value;
				}
			}

			// Token: 0x1700399A RID: 14746
			// (get) Token: 0x060131B1 RID: 78257 RVA: 0x004DF55C File Offset: 0x004DD75C
			// (set) Token: 0x060131B2 RID: 78258 RVA: 0x004DF56C File Offset: 0x004DD76C
			public ConfigDataItemInfo m_itemInfo
			{
				get
				{
					return this.m_owner.m_itemInfo;
				}
				set
				{
					this.m_owner.m_itemInfo = value;
				}
			}

			// Token: 0x060131B3 RID: 78259 RVA: 0x004DF57C File Offset: 0x004DD77C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060131B4 RID: 78260 RVA: 0x004DF58C File Offset: 0x004DD78C
			public IEnumerator Co_ChangeStateToSigning(Action onEnd)
			{
				return this.m_owner.Co_ChangeStateToSigning(onEnd);
			}

			// Token: 0x0400AA41 RID: 43585
			private SignRewardItemUIController m_owner;
		}
	}
}
