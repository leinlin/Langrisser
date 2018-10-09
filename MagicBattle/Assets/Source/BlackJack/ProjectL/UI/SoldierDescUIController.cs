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
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C07 RID: 3079
	[HotFix]
	public class SoldierDescUIController : UIControllerBase
	{
		// Token: 0x0600D7A0 RID: 55200 RVA: 0x003AAD30 File Offset: 0x003A8F30
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
			PointDescComponent pointDescComponent = GameObjectUtility.AddControllerToGameObject<PointDescComponent>(base.gameObject);
			pointDescComponent.SetGameObject(base.gameObject, true, null, null);
			pointDescComponent.EventOnClose += delegate()
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
				this.ClosePanel();
			};
		}

		// Token: 0x0600D7A1 RID: 55201 RVA: 0x003AADC4 File Offset: 0x003A8FC4
		public void InitSoldierDesc(ConfigDataSoldierInfo soldierInfo, Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSoldierDescConfigDataSoldierInfoHero_hotfix != null)
			{
				this.m_InitSoldierDescConfigDataSoldierInfoHero_hotfix.call(new object[]
				{
					this,
					soldierInfo,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (soldierInfo == null || hero == null)
			{
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(configDataLoader);
			heroPropertyComputer.ComputeSoldierCommandProperties(hero, soldierInfo);
			this.ShowPanel();
			string text = string.Empty;
			ConfigDataModelSkinResourceInfo soldierModelSkinResourceInfo = BattleUtility.GetSoldierModelSkinResourceInfo(configDataLoader, hero.GetSoldierSkinId(hero.SelectedSoldierId), hero.SelectedSoldierId);
			if (soldierModelSkinResourceInfo != null)
			{
				text = soldierModelSkinResourceInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = soldierInfo.Model;
			}
			this.SetSoldierDetailPanel(soldierInfo, heroPropertyComputer, text);
		}

		// Token: 0x0600D7A2 RID: 55202 RVA: 0x003AAEC4 File Offset: 0x003A90C4
		public void InitSoldierDesc(ConfigDataSoldierInfo soldierInfo, BattleHero hero, List<TrainingTech> techs, ConfigDataModelSkinResourceInfo soldierSkinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSoldierDescConfigDataSoldierInfoBattleHeroList`1ConfigDataModelSkinResourceInfo_hotfix != null)
			{
				this.m_InitSoldierDescConfigDataSoldierInfoBattleHeroList`1ConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					soldierInfo,
					hero,
					techs,
					soldierSkinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (soldierInfo == null || hero == null)
			{
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(configDataLoader);
			heroPropertyComputer.ComputeSoldierCommandProperties(hero, soldierInfo, techs, soldierSkinResInfo);
			this.ShowPanel();
			string text = string.Empty;
			if (soldierSkinResInfo != null)
			{
				text = soldierSkinResInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = soldierInfo.Model;
			}
			this.SetSoldierDetailPanel(soldierInfo, heroPropertyComputer, text);
		}

		// Token: 0x0600D7A3 RID: 55203 RVA: 0x003AAFD0 File Offset: 0x003A91D0
		private void SetSoldierDetailPanel(ConfigDataSoldierInfo soldierInfo, HeroPropertyComputer computer, string assetName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierDetailPanelConfigDataSoldierInfoHeroPropertyComputerString_hotfix != null)
			{
				this.m_SetSoldierDetailPanelConfigDataSoldierInfoHeroPropertyComputerString_hotfix.call(new object[]
				{
					this,
					soldierInfo,
					computer,
					assetName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_soldierTitleText.text = soldierInfo.Name;
			this.m_soldierIconImg.sprite = AssetUtility.Instance.GetSprite(soldierInfo.m_armyInfo.Icon);
			float scale = (float)soldierInfo.UI_ModelScale * 0.01f;
			Vector2 offset = new Vector2((float)soldierInfo.UI_ModelOffsetX, (float)soldierInfo.UI_ModelOffsetY);
			this.DestroySpineGraphic(this.m_soldierGraphic);
			this.m_soldierGraphic = this.CreateSpineGraphic(assetName, scale, offset, 0, this.m_soldierDetailGraphic, soldierInfo.ReplaceAnims);
			this.m_soldierRangeText.text = soldierInfo.BF_AttackDistance.ToString();
			this.m_soldierMoveText.text = soldierInfo.BF_MovePoint.ToString();
			this.m_typeBgImg.gameObject.SetActive(soldierInfo.IsMelee);
			this.m_typeBgImg2.gameObject.SetActive(!soldierInfo.IsMelee);
			this.m_soldierPropHPValueText.text = this.CalcPropValue(computer.Property0.HealthPointMax, 0, false);
			this.m_soldierPropDFValueText.text = this.CalcPropValue(computer.Property0.Defense, 0, false);
			this.m_soldierPropATValueText.text = this.CalcPropValue(computer.Property0.Attack, 0, false);
			this.m_soldierPropMagicDFValueText.text = this.CalcPropValue(computer.Property0.MagicDefense, 0, false);
			this.m_soldierPropHPAddText.text = this.CalcPropValue(computer.Property0.HealthPointMax, computer.Property1.HealthPointMax, true);
			this.m_soldierPropDFAddText.text = this.CalcPropValue(computer.Property0.Defense, computer.Property1.Defense, true);
			this.m_soldierPropATAddText.text = this.CalcPropValue(computer.Property0.Attack, computer.Property1.Attack, true);
			this.m_soldierPropMagicDFAddText.text = this.CalcPropValue(computer.Property0.MagicDefense, computer.Property1.MagicDefense, true);
			this.m_soldierDescText.text = UIUtility.GetSoldierCurSkillDesc(soldierInfo);
			this.m_soldierWeakText.text = soldierInfo.Weak;
			this.m_soldierStrongText.text = soldierInfo.Strong;
		}

		// Token: 0x0600D7A4 RID: 55204 RVA: 0x003AB294 File Offset: 0x003A9494
		private string CalcPropValue(int v0, int v1, bool isAdd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcPropValueInt32Int32Boolean_hotfix != null)
			{
				return (string)this.m_CalcPropValueInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					v0,
					v1,
					isAdd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!isAdd)
			{
				return v0.ToString();
			}
			return (v1 - v0 != 0) ? ("+" + (v1 - v0)) : string.Empty;
		}

		// Token: 0x0600D7A5 RID: 55205 RVA: 0x003AB368 File Offset: 0x003A9568
		private void ShowPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPanel_hotfix != null)
			{
				this.m_ShowPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			if (component != null)
			{
				component.SetToUIState("Show", false, true);
			}
		}

		// Token: 0x0600D7A6 RID: 55206 RVA: 0x003AB3FC File Offset: 0x003A95FC
		private void ClosePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClosePanel_hotfix != null)
			{
				this.m_ClosePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			if (component != null)
			{
				component.SetActionForUIStateFinshed("Close", delegate
				{
					base.gameObject.SetActive(false);
				});
				component.SetToUIState("Close", false, true);
			}
			else
			{
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x0600D7A7 RID: 55207 RVA: 0x003AB4AC File Offset: 0x003A96AC
		private UISpineGraphic CreateSpineGraphic(string assetName, float scale, Vector2 offset, int team, GameObject parent, List<ReplaceAnim> replaceAnims)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicStringSingleVector2Int32GameObjectList`1_hotfix != null)
			{
				return (UISpineGraphic)this.m_CreateSpineGraphicStringSingleVector2Int32GameObjectList`1_hotfix.call(new object[]
				{
					this,
					assetName,
					scale,
					offset,
					team,
					parent,
					replaceAnims
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UISpineGraphic uispineGraphic = new UISpineGraphic();
			uispineGraphic.Create(assetName);
			uispineGraphic.SetParent(parent);
			uispineGraphic.SetDirection((team != 0) ? -1 : 1);
			uispineGraphic.SetPosition(offset);
			uispineGraphic.SetScale(scale);
			uispineGraphic.SetReplaceAnimations(replaceAnims);
			uispineGraphic.PlayAnimation("idle", true, 0);
			uispineGraphic.ForceUpdate();
			return uispineGraphic;
		}

		// Token: 0x0600D7A8 RID: 55208 RVA: 0x003AB5CC File Offset: 0x003A97CC
		private void DestroySpineGraphic(UISpineGraphic g)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphicUISpineGraphic_hotfix != null)
			{
				this.m_DestroySpineGraphicUISpineGraphic_hotfix.call(new object[]
				{
					this,
					g
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (g != null)
			{
				g.Destroy();
			}
		}

		// Token: 0x140002AD RID: 685
		// (add) Token: 0x0600D7A9 RID: 55209 RVA: 0x003AB648 File Offset: 0x003A9848
		// (remove) Token: 0x0600D7AA RID: 55210 RVA: 0x003AB6E4 File Offset: 0x003A98E4
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x0600D7AB RID: 55211 RVA: 0x003AB780 File Offset: 0x003A9980
		// (set) Token: 0x0600D7AC RID: 55212 RVA: 0x003AB7A0 File Offset: 0x003A99A0
		[DoNotToLua]
		public new SoldierDescUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SoldierDescUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D7AD RID: 55213 RVA: 0x003AB7AC File Offset: 0x003A99AC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D7AE RID: 55214 RVA: 0x003AB7B8 File Offset: 0x003A99B8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D7AF RID: 55215 RVA: 0x003AB7C0 File Offset: 0x003A99C0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D7B0 RID: 55216 RVA: 0x003AB7C8 File Offset: 0x003A99C8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D7B1 RID: 55217 RVA: 0x003AB7DC File Offset: 0x003A99DC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D7B2 RID: 55218 RVA: 0x003AB7E4 File Offset: 0x003A99E4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D7B3 RID: 55219 RVA: 0x003AB7F0 File Offset: 0x003A99F0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D7B4 RID: 55220 RVA: 0x003AB7FC File Offset: 0x003A99FC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D7B5 RID: 55221 RVA: 0x003AB808 File Offset: 0x003A9A08
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D7B6 RID: 55222 RVA: 0x003AB814 File Offset: 0x003A9A14
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D7B7 RID: 55223 RVA: 0x003AB820 File Offset: 0x003A9A20
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D7B8 RID: 55224 RVA: 0x003AB82C File Offset: 0x003A9A2C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D7B9 RID: 55225 RVA: 0x003AB838 File Offset: 0x003A9A38
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D7BA RID: 55226 RVA: 0x003AB844 File Offset: 0x003A9A44
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D7BB RID: 55227 RVA: 0x003AB850 File Offset: 0x003A9A50
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D7BC RID: 55228 RVA: 0x003AB858 File Offset: 0x003A9A58
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D7BD RID: 55229 RVA: 0x003AB878 File Offset: 0x003A9A78
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D7C0 RID: 55232 RVA: 0x003AB8B4 File Offset: 0x003A9AB4
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
					this.m_InitSoldierDescConfigDataSoldierInfoHero_hotfix = (luaObj.RawGet("InitSoldierDesc") as LuaFunction);
					this.m_InitSoldierDescConfigDataSoldierInfoBattleHeroList`1ConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("InitSoldierDesc") as LuaFunction);
					this.m_SetSoldierDetailPanelConfigDataSoldierInfoHeroPropertyComputerString_hotfix = (luaObj.RawGet("SetSoldierDetailPanel") as LuaFunction);
					this.m_CalcPropValueInt32Int32Boolean_hotfix = (luaObj.RawGet("CalcPropValue") as LuaFunction);
					this.m_ShowPanel_hotfix = (luaObj.RawGet("ShowPanel") as LuaFunction);
					this.m_ClosePanel_hotfix = (luaObj.RawGet("ClosePanel") as LuaFunction);
					this.m_CreateSpineGraphicStringSingleVector2Int32GameObjectList`1_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphicUISpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D7C1 RID: 55233 RVA: 0x003ABA7C File Offset: 0x003A9C7C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SoldierDescUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040084A7 RID: 33959
		[AutoBind("./Faction/JobImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierIconImg;

		// Token: 0x040084A8 RID: 33960
		[AutoBind("./Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierDetailGraphic;

		// Token: 0x040084A9 RID: 33961
		[AutoBind("./Faction/RangeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierRangeText;

		// Token: 0x040084AA RID: 33962
		[AutoBind("./Faction/MoveValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMoveText;

		// Token: 0x040084AB RID: 33963
		[AutoBind("./Faction/TypeBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_typeBgImg;

		// Token: 0x040084AC RID: 33964
		[AutoBind("./Faction/TypeBgImage2", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_typeBgImg2;

		// Token: 0x040084AD RID: 33965
		[AutoBind("./TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierTitleText;

		// Token: 0x040084AE RID: 33966
		[AutoBind("./Desc/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDescText;

		// Token: 0x040084AF RID: 33967
		[AutoBind("./Desc/Weak/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierWeakText;

		// Token: 0x040084B0 RID: 33968
		[AutoBind("./Desc/Restrain/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierStrongText;

		// Token: 0x040084B1 RID: 33969
		[AutoBind("./HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropHPValueText;

		// Token: 0x040084B2 RID: 33970
		[AutoBind("./DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropDFValueText;

		// Token: 0x040084B3 RID: 33971
		[AutoBind("./AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropATValueText;

		// Token: 0x040084B4 RID: 33972
		[AutoBind("./MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropMagicDFValueText;

		// Token: 0x040084B5 RID: 33973
		[AutoBind("./HP/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropHPAddText;

		// Token: 0x040084B6 RID: 33974
		[AutoBind("./DF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropDFAddText;

		// Token: 0x040084B7 RID: 33975
		[AutoBind("./AT/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropATAddText;

		// Token: 0x040084B8 RID: 33976
		[AutoBind("./MagicDF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropMagicDFAddText;

		// Token: 0x040084B9 RID: 33977
		private UISpineGraphic m_soldierGraphic;

		// Token: 0x040084BA RID: 33978
		[DoNotToLua]
		private SoldierDescUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040084BB RID: 33979
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040084BC RID: 33980
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040084BD RID: 33981
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040084BE RID: 33982
		private LuaFunction m_InitSoldierDescConfigDataSoldierInfoHero_hotfix;

		// Token: 0x040084BF RID: 33983
		private LuaFunction m_InitSoldierDescConfigDataSoldierInfoBattleHeroList;

		// Token: 0x040084C0 RID: 33984
		private LuaFunction m_SetSoldierDetailPanelConfigDataSoldierInfoHeroPropertyComputerString_hotfix;

		// Token: 0x040084C1 RID: 33985
		private LuaFunction m_CalcPropValueInt32Int32Boolean_hotfix;

		// Token: 0x040084C2 RID: 33986
		private LuaFunction m_ShowPanel_hotfix;

		// Token: 0x040084C3 RID: 33987
		private LuaFunction m_ClosePanel_hotfix;

		// Token: 0x040084C4 RID: 33988
		private LuaFunction m_CreateSpineGraphicStringSingleVector2Int32GameObjectList;

		// Token: 0x040084C5 RID: 33989
		private LuaFunction m_DestroySpineGraphicUISpineGraphic_hotfix;

		// Token: 0x040084C6 RID: 33990
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040084C7 RID: 33991
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000C08 RID: 3080
		public new class LuaExportHelper
		{
			// Token: 0x0600D7C2 RID: 55234 RVA: 0x003ABAE4 File Offset: 0x003A9CE4
			public LuaExportHelper(SoldierDescUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D7C3 RID: 55235 RVA: 0x003ABAF4 File Offset: 0x003A9CF4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D7C4 RID: 55236 RVA: 0x003ABB04 File Offset: 0x003A9D04
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D7C5 RID: 55237 RVA: 0x003ABB14 File Offset: 0x003A9D14
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D7C6 RID: 55238 RVA: 0x003ABB24 File Offset: 0x003A9D24
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D7C7 RID: 55239 RVA: 0x003ABB3C File Offset: 0x003A9D3C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D7C8 RID: 55240 RVA: 0x003ABB4C File Offset: 0x003A9D4C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D7C9 RID: 55241 RVA: 0x003ABB5C File Offset: 0x003A9D5C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D7CA RID: 55242 RVA: 0x003ABB6C File Offset: 0x003A9D6C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D7CB RID: 55243 RVA: 0x003ABB7C File Offset: 0x003A9D7C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D7CC RID: 55244 RVA: 0x003ABB8C File Offset: 0x003A9D8C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D7CD RID: 55245 RVA: 0x003ABB9C File Offset: 0x003A9D9C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D7CE RID: 55246 RVA: 0x003ABBAC File Offset: 0x003A9DAC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D7CF RID: 55247 RVA: 0x003ABBBC File Offset: 0x003A9DBC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D7D0 RID: 55248 RVA: 0x003ABBCC File Offset: 0x003A9DCC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D7D1 RID: 55249 RVA: 0x003ABBDC File Offset: 0x003A9DDC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D7D2 RID: 55250 RVA: 0x003ABBEC File Offset: 0x003A9DEC
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D7D3 RID: 55251 RVA: 0x003ABBFC File Offset: 0x003A9DFC
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002A03 RID: 10755
			// (get) Token: 0x0600D7D4 RID: 55252 RVA: 0x003ABC0C File Offset: 0x003A9E0C
			// (set) Token: 0x0600D7D5 RID: 55253 RVA: 0x003ABC1C File Offset: 0x003A9E1C
			public Image m_soldierIconImg
			{
				get
				{
					return this.m_owner.m_soldierIconImg;
				}
				set
				{
					this.m_owner.m_soldierIconImg = value;
				}
			}

			// Token: 0x17002A04 RID: 10756
			// (get) Token: 0x0600D7D6 RID: 55254 RVA: 0x003ABC2C File Offset: 0x003A9E2C
			// (set) Token: 0x0600D7D7 RID: 55255 RVA: 0x003ABC3C File Offset: 0x003A9E3C
			public GameObject m_soldierDetailGraphic
			{
				get
				{
					return this.m_owner.m_soldierDetailGraphic;
				}
				set
				{
					this.m_owner.m_soldierDetailGraphic = value;
				}
			}

			// Token: 0x17002A05 RID: 10757
			// (get) Token: 0x0600D7D8 RID: 55256 RVA: 0x003ABC4C File Offset: 0x003A9E4C
			// (set) Token: 0x0600D7D9 RID: 55257 RVA: 0x003ABC5C File Offset: 0x003A9E5C
			public Text m_soldierRangeText
			{
				get
				{
					return this.m_owner.m_soldierRangeText;
				}
				set
				{
					this.m_owner.m_soldierRangeText = value;
				}
			}

			// Token: 0x17002A06 RID: 10758
			// (get) Token: 0x0600D7DA RID: 55258 RVA: 0x003ABC6C File Offset: 0x003A9E6C
			// (set) Token: 0x0600D7DB RID: 55259 RVA: 0x003ABC7C File Offset: 0x003A9E7C
			public Text m_soldierMoveText
			{
				get
				{
					return this.m_owner.m_soldierMoveText;
				}
				set
				{
					this.m_owner.m_soldierMoveText = value;
				}
			}

			// Token: 0x17002A07 RID: 10759
			// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x003ABC8C File Offset: 0x003A9E8C
			// (set) Token: 0x0600D7DD RID: 55261 RVA: 0x003ABC9C File Offset: 0x003A9E9C
			public Image m_typeBgImg
			{
				get
				{
					return this.m_owner.m_typeBgImg;
				}
				set
				{
					this.m_owner.m_typeBgImg = value;
				}
			}

			// Token: 0x17002A08 RID: 10760
			// (get) Token: 0x0600D7DE RID: 55262 RVA: 0x003ABCAC File Offset: 0x003A9EAC
			// (set) Token: 0x0600D7DF RID: 55263 RVA: 0x003ABCBC File Offset: 0x003A9EBC
			public Image m_typeBgImg2
			{
				get
				{
					return this.m_owner.m_typeBgImg2;
				}
				set
				{
					this.m_owner.m_typeBgImg2 = value;
				}
			}

			// Token: 0x17002A09 RID: 10761
			// (get) Token: 0x0600D7E0 RID: 55264 RVA: 0x003ABCCC File Offset: 0x003A9ECC
			// (set) Token: 0x0600D7E1 RID: 55265 RVA: 0x003ABCDC File Offset: 0x003A9EDC
			public Text m_soldierTitleText
			{
				get
				{
					return this.m_owner.m_soldierTitleText;
				}
				set
				{
					this.m_owner.m_soldierTitleText = value;
				}
			}

			// Token: 0x17002A0A RID: 10762
			// (get) Token: 0x0600D7E2 RID: 55266 RVA: 0x003ABCEC File Offset: 0x003A9EEC
			// (set) Token: 0x0600D7E3 RID: 55267 RVA: 0x003ABCFC File Offset: 0x003A9EFC
			public Text m_soldierDescText
			{
				get
				{
					return this.m_owner.m_soldierDescText;
				}
				set
				{
					this.m_owner.m_soldierDescText = value;
				}
			}

			// Token: 0x17002A0B RID: 10763
			// (get) Token: 0x0600D7E4 RID: 55268 RVA: 0x003ABD0C File Offset: 0x003A9F0C
			// (set) Token: 0x0600D7E5 RID: 55269 RVA: 0x003ABD1C File Offset: 0x003A9F1C
			public Text m_soldierWeakText
			{
				get
				{
					return this.m_owner.m_soldierWeakText;
				}
				set
				{
					this.m_owner.m_soldierWeakText = value;
				}
			}

			// Token: 0x17002A0C RID: 10764
			// (get) Token: 0x0600D7E6 RID: 55270 RVA: 0x003ABD2C File Offset: 0x003A9F2C
			// (set) Token: 0x0600D7E7 RID: 55271 RVA: 0x003ABD3C File Offset: 0x003A9F3C
			public Text m_soldierStrongText
			{
				get
				{
					return this.m_owner.m_soldierStrongText;
				}
				set
				{
					this.m_owner.m_soldierStrongText = value;
				}
			}

			// Token: 0x17002A0D RID: 10765
			// (get) Token: 0x0600D7E8 RID: 55272 RVA: 0x003ABD4C File Offset: 0x003A9F4C
			// (set) Token: 0x0600D7E9 RID: 55273 RVA: 0x003ABD5C File Offset: 0x003A9F5C
			public Text m_soldierPropHPValueText
			{
				get
				{
					return this.m_owner.m_soldierPropHPValueText;
				}
				set
				{
					this.m_owner.m_soldierPropHPValueText = value;
				}
			}

			// Token: 0x17002A0E RID: 10766
			// (get) Token: 0x0600D7EA RID: 55274 RVA: 0x003ABD6C File Offset: 0x003A9F6C
			// (set) Token: 0x0600D7EB RID: 55275 RVA: 0x003ABD7C File Offset: 0x003A9F7C
			public Text m_soldierPropDFValueText
			{
				get
				{
					return this.m_owner.m_soldierPropDFValueText;
				}
				set
				{
					this.m_owner.m_soldierPropDFValueText = value;
				}
			}

			// Token: 0x17002A0F RID: 10767
			// (get) Token: 0x0600D7EC RID: 55276 RVA: 0x003ABD8C File Offset: 0x003A9F8C
			// (set) Token: 0x0600D7ED RID: 55277 RVA: 0x003ABD9C File Offset: 0x003A9F9C
			public Text m_soldierPropATValueText
			{
				get
				{
					return this.m_owner.m_soldierPropATValueText;
				}
				set
				{
					this.m_owner.m_soldierPropATValueText = value;
				}
			}

			// Token: 0x17002A10 RID: 10768
			// (get) Token: 0x0600D7EE RID: 55278 RVA: 0x003ABDAC File Offset: 0x003A9FAC
			// (set) Token: 0x0600D7EF RID: 55279 RVA: 0x003ABDBC File Offset: 0x003A9FBC
			public Text m_soldierPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_soldierPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_soldierPropMagicDFValueText = value;
				}
			}

			// Token: 0x17002A11 RID: 10769
			// (get) Token: 0x0600D7F0 RID: 55280 RVA: 0x003ABDCC File Offset: 0x003A9FCC
			// (set) Token: 0x0600D7F1 RID: 55281 RVA: 0x003ABDDC File Offset: 0x003A9FDC
			public Text m_soldierPropHPAddText
			{
				get
				{
					return this.m_owner.m_soldierPropHPAddText;
				}
				set
				{
					this.m_owner.m_soldierPropHPAddText = value;
				}
			}

			// Token: 0x17002A12 RID: 10770
			// (get) Token: 0x0600D7F2 RID: 55282 RVA: 0x003ABDEC File Offset: 0x003A9FEC
			// (set) Token: 0x0600D7F3 RID: 55283 RVA: 0x003ABDFC File Offset: 0x003A9FFC
			public Text m_soldierPropDFAddText
			{
				get
				{
					return this.m_owner.m_soldierPropDFAddText;
				}
				set
				{
					this.m_owner.m_soldierPropDFAddText = value;
				}
			}

			// Token: 0x17002A13 RID: 10771
			// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x003ABE0C File Offset: 0x003AA00C
			// (set) Token: 0x0600D7F5 RID: 55285 RVA: 0x003ABE1C File Offset: 0x003AA01C
			public Text m_soldierPropATAddText
			{
				get
				{
					return this.m_owner.m_soldierPropATAddText;
				}
				set
				{
					this.m_owner.m_soldierPropATAddText = value;
				}
			}

			// Token: 0x17002A14 RID: 10772
			// (get) Token: 0x0600D7F6 RID: 55286 RVA: 0x003ABE2C File Offset: 0x003AA02C
			// (set) Token: 0x0600D7F7 RID: 55287 RVA: 0x003ABE3C File Offset: 0x003AA03C
			public Text m_soldierPropMagicDFAddText
			{
				get
				{
					return this.m_owner.m_soldierPropMagicDFAddText;
				}
				set
				{
					this.m_owner.m_soldierPropMagicDFAddText = value;
				}
			}

			// Token: 0x17002A15 RID: 10773
			// (get) Token: 0x0600D7F8 RID: 55288 RVA: 0x003ABE4C File Offset: 0x003AA04C
			// (set) Token: 0x0600D7F9 RID: 55289 RVA: 0x003ABE5C File Offset: 0x003AA05C
			public UISpineGraphic m_soldierGraphic
			{
				get
				{
					return this.m_owner.m_soldierGraphic;
				}
				set
				{
					this.m_owner.m_soldierGraphic = value;
				}
			}

			// Token: 0x0600D7FA RID: 55290 RVA: 0x003ABE6C File Offset: 0x003AA06C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D7FB RID: 55291 RVA: 0x003ABE7C File Offset: 0x003AA07C
			public void SetSoldierDetailPanel(ConfigDataSoldierInfo soldierInfo, HeroPropertyComputer computer, string assetName)
			{
				this.m_owner.SetSoldierDetailPanel(soldierInfo, computer, assetName);
			}

			// Token: 0x0600D7FC RID: 55292 RVA: 0x003ABE8C File Offset: 0x003AA08C
			public string CalcPropValue(int v0, int v1, bool isAdd)
			{
				return this.m_owner.CalcPropValue(v0, v1, isAdd);
			}

			// Token: 0x0600D7FD RID: 55293 RVA: 0x003ABE9C File Offset: 0x003AA09C
			public void ShowPanel()
			{
				this.m_owner.ShowPanel();
			}

			// Token: 0x0600D7FE RID: 55294 RVA: 0x003ABEAC File Offset: 0x003AA0AC
			public void ClosePanel()
			{
				this.m_owner.ClosePanel();
			}

			// Token: 0x0600D7FF RID: 55295 RVA: 0x003ABEBC File Offset: 0x003AA0BC
			public UISpineGraphic CreateSpineGraphic(string assetName, float scale, Vector2 offset, int team, GameObject parent, List<ReplaceAnim> replaceAnims)
			{
				return this.m_owner.CreateSpineGraphic(assetName, scale, offset, team, parent, replaceAnims);
			}

			// Token: 0x0600D800 RID: 55296 RVA: 0x003ABED4 File Offset: 0x003AA0D4
			public void DestroySpineGraphic(UISpineGraphic g)
			{
				this.m_owner.DestroySpineGraphic(g);
			}

			// Token: 0x040084C8 RID: 33992
			private SoldierDescUIController m_owner;
		}
	}
}
