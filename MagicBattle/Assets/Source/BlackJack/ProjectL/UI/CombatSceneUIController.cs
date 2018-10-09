using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AF6 RID: 2806
	[HotFix]
	public class CombatSceneUIController : UIControllerBase
	{
		// Token: 0x0600BB20 RID: 47904 RVA: 0x003486F8 File Offset: 0x003468F8
		private CombatSceneUIController()
		{
		}

		// Token: 0x0600BB21 RID: 47905 RVA: 0x00348764 File Offset: 0x00346964
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
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600BB22 RID: 47906 RVA: 0x003487D8 File Offset: 0x003469D8
		public void Initialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Initialize_hotfix != null)
			{
				this.m_Initialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_damageNumber0Pool.Setup(this.m_damageNumber0Prefab, base.gameObject);
			this.m_damageNumber1Pool.Setup(this.m_damageNumber1Prefab, base.gameObject);
			this.m_damageNumberWeak0Pool.Setup(this.m_damageNumberWeak0Prefab, base.gameObject);
			this.m_damageNumberWeak1Pool.Setup(this.m_damageNumberWeak1Prefab, base.gameObject);
			this.m_damageNumberStrong0Pool.Setup(this.m_damageNumberStrong0Prefab, base.gameObject);
			this.m_damageNumberStrong1Pool.Setup(this.m_damageNumberStrong1Prefab, base.gameObject);
			this.m_damageNumberCritical0Pool.Setup(this.m_damageNumberCritical0Prefab, base.gameObject);
			this.m_damageNumberCritical1Pool.Setup(this.m_damageNumberCritical1Prefab, base.gameObject);
			GameObject gameObject = base.transform.parent.gameObject;
			this.m_background0GameObject = Utility.FindChildGameObject(gameObject, "Background/0", true);
			this.m_background1GameObject = Utility.FindChildGameObject(gameObject, "Background/1", true);
			this.m_background2GameObject = Utility.FindChildGameObject(gameObject, "Background/2", true);
			Vector3 localPosition = this.m_background1GameObject.transform.localPosition;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			float num = (float)configDataLoader.Const_CombatSplitScreenDistance * 0.5f * 0.02f;
			this.m_background1GameObject.transform.localPosition = new Vector3(-num, localPosition.y, localPosition.z);
			this.m_background2GameObject.transform.localPosition = new Vector3(num, localPosition.y, localPosition.z);
			this.m_fadeGameObject = Utility.FindChildGameObject(gameObject, "Fade", true);
			this.m_fadeGameObject.SetActive(false);
			this.m_fadeMaterial = this.m_fadeGameObject.GetComponent<Renderer>().material;
			this.m_fadeColor = this.m_fadeMaterial.color;
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x003489FC File Offset: 0x00346BFC
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float deltaTime = Time.deltaTime;
			this.UpdateFade(deltaTime);
		}

		// Token: 0x0600BB24 RID: 47908 RVA: 0x00348A6C File Offset: 0x00346C6C
		public void StartCombat(ConfigDataTerrainInfo terrain0, ConfigDataTerrainInfo terrain1, bool splitScreen, int attackerTeam, int myPlayerTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartCombatConfigDataTerrainInfoConfigDataTerrainInfoBooleanInt32Int32_hotfix != null)
			{
				this.m_StartCombatConfigDataTerrainInfoConfigDataTerrainInfoBooleanInt32Int32_hotfix.call(new object[]
				{
					this,
					terrain0,
					terrain1,
					splitScreen,
					attackerTeam,
					myPlayerTeam
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_background0GameObject.SetActive(!splitScreen);
			this.m_background1GameObject.SetActive(splitScreen);
			this.m_background2GameObject.SetActive(splitScreen);
			this.HideFade();
			this.m_myPlayerTeam = myPlayerTeam;
			if (splitScreen)
			{
				if (myPlayerTeam == 0)
				{
					this.SetBackgroundTexture(this.m_background1GameObject, terrain0);
					this.SetBackgroundTexture(this.m_background2GameObject, terrain1);
				}
				else
				{
					this.SetBackgroundTexture(this.m_background1GameObject, terrain1);
					this.SetBackgroundTexture(this.m_background2GameObject, terrain0);
				}
			}
			else if (attackerTeam == 0)
			{
				this.SetBackgroundTexture(this.m_background0GameObject, terrain1);
			}
			else
			{
				this.SetBackgroundTexture(this.m_background0GameObject, terrain0);
			}
		}

		// Token: 0x0600BB25 RID: 47909 RVA: 0x00348BC4 File Offset: 0x00346DC4
		public void PreStopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PreStopCombat_hotfix != null)
			{
				this.m_PreStopCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.PlayAnimation(base.transform.parent.gameObject, "CombatStop");
		}

		// Token: 0x0600BB26 RID: 47910 RVA: 0x00348C40 File Offset: 0x00346E40
		public void StopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopCombat_hotfix != null)
			{
				this.m_StopCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_damageNumber0Pool.Deactive();
			this.m_damageNumber1Pool.Deactive();
			this.m_damageNumberWeak0Pool.Deactive();
			this.m_damageNumberWeak1Pool.Deactive();
			this.m_damageNumberStrong0Pool.Deactive();
			this.m_damageNumberStrong1Pool.Deactive();
			this.m_damageNumberCritical0Pool.Deactive();
			this.m_damageNumberCritical1Pool.Deactive();
		}

		// Token: 0x0600BB27 RID: 47911 RVA: 0x00348CF8 File Offset: 0x00346EF8
		public void SkillFadeIn(float time, float alpha)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkillFadeInSingleSingle_hotfix != null)
			{
				this.m_SkillFadeInSingleSingle_hotfix.call(new object[]
				{
					this,
					time,
					alpha
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fadeGameObject.SetActive(true);
			this.m_isFadeIn = true;
			this.m_fadeCurTime = 0f;
			this.m_fadeDuration = time;
			this.m_fadeColor.a = alpha;
			this.UpdateFade(0f);
		}

		// Token: 0x0600BB28 RID: 47912 RVA: 0x00348DB4 File Offset: 0x00346FB4
		public void SkillFadeOut(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkillFadeOutSingle_hotfix != null)
			{
				this.m_SkillFadeOutSingle_hotfix.call(new object[]
				{
					this,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fadeGameObject.SetActive(true);
			this.m_isFadeIn = false;
			this.m_fadeCurTime = 0f;
			this.m_fadeDuration = time;
			this.UpdateFade(0f);
		}

		// Token: 0x0600BB29 RID: 47913 RVA: 0x00348E54 File Offset: 0x00347054
		private void HideFade()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideFade_hotfix != null)
			{
				this.m_HideFade_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fadeGameObject.SetActive(false);
			this.m_fadeCurTime = (this.m_fadeDuration = 0f);
		}

		// Token: 0x0600BB2A RID: 47914 RVA: 0x00348ED4 File Offset: 0x003470D4
		private void SetFade(float a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFadeSingle_hotfix != null)
			{
				this.m_SetFadeSingle_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_fadeMaterial != null)
			{
				this.m_fadeMaterial.color = new Color(this.m_fadeColor.r, this.m_fadeColor.g, this.m_fadeColor.b, Mathf.Lerp(0f, this.m_fadeColor.a, a));
			}
		}

		// Token: 0x0600BB2B RID: 47915 RVA: 0x00348F9C File Offset: 0x0034719C
		private void UpdateFade(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateFadeSingle_hotfix != null)
			{
				this.m_UpdateFadeSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_fadeDuration > 0f && this.m_fadeCurTime < this.m_fadeDuration)
			{
				this.m_fadeCurTime += dt;
				float num = Mathf.Clamp01(this.m_fadeCurTime / this.m_fadeDuration);
				if (this.m_isFadeIn)
				{
					this.SetFade(num);
				}
				else
				{
					this.SetFade(1f - num);
					if (num >= 1f)
					{
						this.HideFade();
					}
				}
			}
		}

		// Token: 0x0600BB2C RID: 47916 RVA: 0x00349084 File Offset: 0x00347284
		private void SetBackgroundTexture(GameObject go, ConfigDataTerrainInfo terrainInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBackgroundTextureGameObjectConfigDataTerrainInfo_hotfix != null)
			{
				this.m_SetBackgroundTextureGameObjectConfigDataTerrainInfo_hotfix.call(new object[]
				{
					this,
					go,
					terrainInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (terrainInfo == null)
			{
				return;
			}
			Texture asset = AssetUtility.Instance.GetAsset<Texture>(terrainInfo.Background);
			Texture asset2 = AssetUtility.Instance.GetAsset<Texture>(UIUtility.GetSepAlphaTextureName(terrainInfo.Background));
			foreach (Renderer renderer in go.GetComponentsInChildren<Renderer>())
			{
				renderer.material.mainTexture = asset;
				renderer.material.SetTexture("_AlphaTex", asset2);
			}
			AssetUtility.Instance.AddAssetToLruCache(6, asset);
			AssetUtility.Instance.AddAssetToLruCache(6, asset2);
		}

		// Token: 0x0600BB2D RID: 47917 RVA: 0x0034918C File Offset: 0x0034738C
		public void OnActorHit(CombatActor a, CombatActor attacker, ConfigDataSkillInfo skill, int hpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorHitCombatActorCombatActorConfigDataSkillInfoInt32DamageNumberType_hotfix != null)
			{
				this.m_OnActorHitCombatActorCombatActorConfigDataSkillInfoInt32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					attacker,
					skill,
					hpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null || attacker == null)
			{
				return;
			}
			if (skill == null)
			{
				return;
			}
			if (skill.Power == 0 && hpModify == 0)
			{
				return;
			}
			Vector3 localPosition;
			if (!this.GetActorGraphicPosition(a, out localPosition))
			{
				return;
			}
			localPosition.x += (float)UnityEngine.Random.Range(-50, 50) * 0.01f;
			localPosition.y += (float)UnityEngine.Random.Range(0, 50) * 0.01f + (float)(a.Height + a.FootHeight) * 0.01732f;
			DamageNumber damageNumber;
			if (a.TeamNumber == this.m_myPlayerTeam)
			{
				if (damageNumberType == DamageNumberType.Weak)
				{
					damageNumber = this.m_damageNumberWeak0Pool.Allocate();
				}
				else if (damageNumberType == DamageNumberType.Strong)
				{
					damageNumber = this.m_damageNumberStrong0Pool.Allocate();
				}
				else if (damageNumberType == DamageNumberType.Critical)
				{
					damageNumber = this.m_damageNumberCritical0Pool.Allocate();
				}
				else
				{
					damageNumber = this.m_damageNumber0Pool.Allocate();
				}
			}
			else if (damageNumberType == DamageNumberType.Weak)
			{
				damageNumber = this.m_damageNumberWeak1Pool.Allocate();
			}
			else if (damageNumberType == DamageNumberType.Strong)
			{
				damageNumber = this.m_damageNumberStrong1Pool.Allocate();
			}
			else if (damageNumberType == DamageNumberType.Critical)
			{
				damageNumber = this.m_damageNumberCritical1Pool.Allocate();
			}
			else
			{
				damageNumber = this.m_damageNumber1Pool.Allocate();
			}
			damageNumber.transform.localPosition = localPosition;
			damageNumber.transform.SetAsLastSibling();
			damageNumber.SetNumber(Math.Abs(hpModify));
		}

		// Token: 0x0600BB2E RID: 47918 RVA: 0x003493AC File Offset: 0x003475AC
		private bool GetActorGraphicPosition(CombatActor a, out Vector3 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActorGraphicPositionCombatActorVector3__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_UI_CombatSceneUIController_GetActorGraphicPosition_CombatActor_Vector3(this, this.m_GetActorGraphicPositionCombatActorVector3__hotfix, a, out p);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			p = Vector3.zero;
			if (a == null)
			{
				return false;
			}
			GenericGraphic genericGraphic = a.GetGraphic() as GenericGraphic;
			if (genericGraphic == null)
			{
				return false;
			}
			p = genericGraphic.GetPosition();
			p.z = 0f;
			return true;
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x0600BB2F RID: 47919 RVA: 0x00349448 File Offset: 0x00347648
		// (set) Token: 0x0600BB30 RID: 47920 RVA: 0x00349468 File Offset: 0x00347668
		[DoNotToLua]
		public new CombatSceneUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CombatSceneUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BB31 RID: 47921 RVA: 0x00349474 File Offset: 0x00347674
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600BB32 RID: 47922 RVA: 0x00349480 File Offset: 0x00347680
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600BB33 RID: 47923 RVA: 0x00349488 File Offset: 0x00347688
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600BB34 RID: 47924 RVA: 0x00349490 File Offset: 0x00347690
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600BB35 RID: 47925 RVA: 0x003494A4 File Offset: 0x003476A4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600BB36 RID: 47926 RVA: 0x003494AC File Offset: 0x003476AC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600BB37 RID: 47927 RVA: 0x003494B8 File Offset: 0x003476B8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600BB38 RID: 47928 RVA: 0x003494C4 File Offset: 0x003476C4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600BB39 RID: 47929 RVA: 0x003494D0 File Offset: 0x003476D0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600BB3A RID: 47930 RVA: 0x003494DC File Offset: 0x003476DC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600BB3B RID: 47931 RVA: 0x003494E8 File Offset: 0x003476E8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600BB3C RID: 47932 RVA: 0x003494F4 File Offset: 0x003476F4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600BB3D RID: 47933 RVA: 0x00349500 File Offset: 0x00347700
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600BB3E RID: 47934 RVA: 0x0034950C File Offset: 0x0034770C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x00349518 File Offset: 0x00347718
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600BB40 RID: 47936 RVA: 0x00349520 File Offset: 0x00347720
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
					this.m_Initialize_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_StartCombatConfigDataTerrainInfoConfigDataTerrainInfoBooleanInt32Int32_hotfix = (luaObj.RawGet("StartCombat") as LuaFunction);
					this.m_PreStopCombat_hotfix = (luaObj.RawGet("PreStopCombat") as LuaFunction);
					this.m_StopCombat_hotfix = (luaObj.RawGet("StopCombat") as LuaFunction);
					this.m_SkillFadeInSingleSingle_hotfix = (luaObj.RawGet("SkillFadeIn") as LuaFunction);
					this.m_SkillFadeOutSingle_hotfix = (luaObj.RawGet("SkillFadeOut") as LuaFunction);
					this.m_HideFade_hotfix = (luaObj.RawGet("HideFade") as LuaFunction);
					this.m_SetFadeSingle_hotfix = (luaObj.RawGet("SetFade") as LuaFunction);
					this.m_UpdateFadeSingle_hotfix = (luaObj.RawGet("UpdateFade") as LuaFunction);
					this.m_SetBackgroundTextureGameObjectConfigDataTerrainInfo_hotfix = (luaObj.RawGet("SetBackgroundTexture") as LuaFunction);
					this.m_OnActorHitCombatActorCombatActorConfigDataSkillInfoInt32DamageNumberType_hotfix = (luaObj.RawGet("OnActorHit") as LuaFunction);
					this.m_GetActorGraphicPositionCombatActorVector3__hotfix = (luaObj.RawGet("GetActorGraphicPosition") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BB41 RID: 47937 RVA: 0x00349730 File Offset: 0x00347930
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CombatSceneUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007856 RID: 30806
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04007857 RID: 30807
		[AutoBind("./Prefabs/DamageNumber0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumber0Prefab;

		// Token: 0x04007858 RID: 30808
		[AutoBind("./Prefabs/DamageNumber1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumber1Prefab;

		// Token: 0x04007859 RID: 30809
		[AutoBind("./Prefabs/DamageNumberWeak0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberWeak0Prefab;

		// Token: 0x0400785A RID: 30810
		[AutoBind("./Prefabs/DamageNumberWeak1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberWeak1Prefab;

		// Token: 0x0400785B RID: 30811
		[AutoBind("./Prefabs/DamageNumberStrong0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberStrong0Prefab;

		// Token: 0x0400785C RID: 30812
		[AutoBind("./Prefabs/DamageNumberStrong1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberStrong1Prefab;

		// Token: 0x0400785D RID: 30813
		[AutoBind("./Prefabs/DamageNumberCritical0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberCritical0Prefab;

		// Token: 0x0400785E RID: 30814
		[AutoBind("./Prefabs/DamageNumberCritical1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberCritical1Prefab;

		// Token: 0x0400785F RID: 30815
		private GameObjectPool<DamageNumber> m_damageNumber0Pool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007860 RID: 30816
		private GameObjectPool<DamageNumber> m_damageNumber1Pool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007861 RID: 30817
		private GameObjectPool<DamageNumber> m_damageNumberWeak0Pool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007862 RID: 30818
		private GameObjectPool<DamageNumber> m_damageNumberWeak1Pool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007863 RID: 30819
		private GameObjectPool<DamageNumber> m_damageNumberStrong0Pool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007864 RID: 30820
		private GameObjectPool<DamageNumber> m_damageNumberStrong1Pool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007865 RID: 30821
		private GameObjectPool<DamageNumber> m_damageNumberCritical0Pool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007866 RID: 30822
		private GameObjectPool<DamageNumber> m_damageNumberCritical1Pool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007867 RID: 30823
		private GameObject m_background0GameObject;

		// Token: 0x04007868 RID: 30824
		private GameObject m_background1GameObject;

		// Token: 0x04007869 RID: 30825
		private GameObject m_background2GameObject;

		// Token: 0x0400786A RID: 30826
		private GameObject m_fadeGameObject;

		// Token: 0x0400786B RID: 30827
		private bool m_isFadeIn;

		// Token: 0x0400786C RID: 30828
		private float m_fadeCurTime;

		// Token: 0x0400786D RID: 30829
		private float m_fadeDuration;

		// Token: 0x0400786E RID: 30830
		private Material m_fadeMaterial;

		// Token: 0x0400786F RID: 30831
		private Color m_fadeColor;

		// Token: 0x04007870 RID: 30832
		private int m_myPlayerTeam;

		// Token: 0x04007871 RID: 30833
		[DoNotToLua]
		private CombatSceneUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007872 RID: 30834
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007873 RID: 30835
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007874 RID: 30836
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007875 RID: 30837
		private LuaFunction m_Initialize_hotfix;

		// Token: 0x04007876 RID: 30838
		private LuaFunction m_Update_hotfix;

		// Token: 0x04007877 RID: 30839
		private LuaFunction m_StartCombatConfigDataTerrainInfoConfigDataTerrainInfoBooleanInt32Int32_hotfix;

		// Token: 0x04007878 RID: 30840
		private LuaFunction m_PreStopCombat_hotfix;

		// Token: 0x04007879 RID: 30841
		private LuaFunction m_StopCombat_hotfix;

		// Token: 0x0400787A RID: 30842
		private LuaFunction m_SkillFadeInSingleSingle_hotfix;

		// Token: 0x0400787B RID: 30843
		private LuaFunction m_SkillFadeOutSingle_hotfix;

		// Token: 0x0400787C RID: 30844
		private LuaFunction m_HideFade_hotfix;

		// Token: 0x0400787D RID: 30845
		private LuaFunction m_SetFadeSingle_hotfix;

		// Token: 0x0400787E RID: 30846
		private LuaFunction m_UpdateFadeSingle_hotfix;

		// Token: 0x0400787F RID: 30847
		private LuaFunction m_SetBackgroundTextureGameObjectConfigDataTerrainInfo_hotfix;

		// Token: 0x04007880 RID: 30848
		private LuaFunction m_OnActorHitCombatActorCombatActorConfigDataSkillInfoInt32DamageNumberType_hotfix;

		// Token: 0x04007881 RID: 30849
		private LuaFunction m_GetActorGraphicPositionCombatActorVector3__hotfix;

		// Token: 0x02000AF7 RID: 2807
		public new class LuaExportHelper
		{
			// Token: 0x0600BB42 RID: 47938 RVA: 0x00349798 File Offset: 0x00347998
			public LuaExportHelper(CombatSceneUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BB43 RID: 47939 RVA: 0x003497A8 File Offset: 0x003479A8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600BB44 RID: 47940 RVA: 0x003497B8 File Offset: 0x003479B8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600BB45 RID: 47941 RVA: 0x003497C8 File Offset: 0x003479C8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600BB46 RID: 47942 RVA: 0x003497D8 File Offset: 0x003479D8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600BB47 RID: 47943 RVA: 0x003497F0 File Offset: 0x003479F0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600BB48 RID: 47944 RVA: 0x00349800 File Offset: 0x00347A00
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600BB49 RID: 47945 RVA: 0x00349810 File Offset: 0x00347A10
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600BB4A RID: 47946 RVA: 0x00349820 File Offset: 0x00347A20
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600BB4B RID: 47947 RVA: 0x00349830 File Offset: 0x00347A30
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600BB4C RID: 47948 RVA: 0x00349840 File Offset: 0x00347A40
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600BB4D RID: 47949 RVA: 0x00349850 File Offset: 0x00347A50
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600BB4E RID: 47950 RVA: 0x00349860 File Offset: 0x00347A60
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600BB4F RID: 47951 RVA: 0x00349870 File Offset: 0x00347A70
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600BB50 RID: 47952 RVA: 0x00349880 File Offset: 0x00347A80
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600BB51 RID: 47953 RVA: 0x00349890 File Offset: 0x00347A90
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700256E RID: 9582
			// (get) Token: 0x0600BB52 RID: 47954 RVA: 0x003498A0 File Offset: 0x00347AA0
			// (set) Token: 0x0600BB53 RID: 47955 RVA: 0x003498B0 File Offset: 0x00347AB0
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x1700256F RID: 9583
			// (get) Token: 0x0600BB54 RID: 47956 RVA: 0x003498C0 File Offset: 0x00347AC0
			// (set) Token: 0x0600BB55 RID: 47957 RVA: 0x003498D0 File Offset: 0x00347AD0
			public GameObject m_damageNumber0Prefab
			{
				get
				{
					return this.m_owner.m_damageNumber0Prefab;
				}
				set
				{
					this.m_owner.m_damageNumber0Prefab = value;
				}
			}

			// Token: 0x17002570 RID: 9584
			// (get) Token: 0x0600BB56 RID: 47958 RVA: 0x003498E0 File Offset: 0x00347AE0
			// (set) Token: 0x0600BB57 RID: 47959 RVA: 0x003498F0 File Offset: 0x00347AF0
			public GameObject m_damageNumber1Prefab
			{
				get
				{
					return this.m_owner.m_damageNumber1Prefab;
				}
				set
				{
					this.m_owner.m_damageNumber1Prefab = value;
				}
			}

			// Token: 0x17002571 RID: 9585
			// (get) Token: 0x0600BB58 RID: 47960 RVA: 0x00349900 File Offset: 0x00347B00
			// (set) Token: 0x0600BB59 RID: 47961 RVA: 0x00349910 File Offset: 0x00347B10
			public GameObject m_damageNumberWeak0Prefab
			{
				get
				{
					return this.m_owner.m_damageNumberWeak0Prefab;
				}
				set
				{
					this.m_owner.m_damageNumberWeak0Prefab = value;
				}
			}

			// Token: 0x17002572 RID: 9586
			// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x00349920 File Offset: 0x00347B20
			// (set) Token: 0x0600BB5B RID: 47963 RVA: 0x00349930 File Offset: 0x00347B30
			public GameObject m_damageNumberWeak1Prefab
			{
				get
				{
					return this.m_owner.m_damageNumberWeak1Prefab;
				}
				set
				{
					this.m_owner.m_damageNumberWeak1Prefab = value;
				}
			}

			// Token: 0x17002573 RID: 9587
			// (get) Token: 0x0600BB5C RID: 47964 RVA: 0x00349940 File Offset: 0x00347B40
			// (set) Token: 0x0600BB5D RID: 47965 RVA: 0x00349950 File Offset: 0x00347B50
			public GameObject m_damageNumberStrong0Prefab
			{
				get
				{
					return this.m_owner.m_damageNumberStrong0Prefab;
				}
				set
				{
					this.m_owner.m_damageNumberStrong0Prefab = value;
				}
			}

			// Token: 0x17002574 RID: 9588
			// (get) Token: 0x0600BB5E RID: 47966 RVA: 0x00349960 File Offset: 0x00347B60
			// (set) Token: 0x0600BB5F RID: 47967 RVA: 0x00349970 File Offset: 0x00347B70
			public GameObject m_damageNumberStrong1Prefab
			{
				get
				{
					return this.m_owner.m_damageNumberStrong1Prefab;
				}
				set
				{
					this.m_owner.m_damageNumberStrong1Prefab = value;
				}
			}

			// Token: 0x17002575 RID: 9589
			// (get) Token: 0x0600BB60 RID: 47968 RVA: 0x00349980 File Offset: 0x00347B80
			// (set) Token: 0x0600BB61 RID: 47969 RVA: 0x00349990 File Offset: 0x00347B90
			public GameObject m_damageNumberCritical0Prefab
			{
				get
				{
					return this.m_owner.m_damageNumberCritical0Prefab;
				}
				set
				{
					this.m_owner.m_damageNumberCritical0Prefab = value;
				}
			}

			// Token: 0x17002576 RID: 9590
			// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x003499A0 File Offset: 0x00347BA0
			// (set) Token: 0x0600BB63 RID: 47971 RVA: 0x003499B0 File Offset: 0x00347BB0
			public GameObject m_damageNumberCritical1Prefab
			{
				get
				{
					return this.m_owner.m_damageNumberCritical1Prefab;
				}
				set
				{
					this.m_owner.m_damageNumberCritical1Prefab = value;
				}
			}

			// Token: 0x17002577 RID: 9591
			// (get) Token: 0x0600BB64 RID: 47972 RVA: 0x003499C0 File Offset: 0x00347BC0
			// (set) Token: 0x0600BB65 RID: 47973 RVA: 0x003499D0 File Offset: 0x00347BD0
			public GameObjectPool<DamageNumber> m_damageNumber0Pool
			{
				get
				{
					return this.m_owner.m_damageNumber0Pool;
				}
				set
				{
					this.m_owner.m_damageNumber0Pool = value;
				}
			}

			// Token: 0x17002578 RID: 9592
			// (get) Token: 0x0600BB66 RID: 47974 RVA: 0x003499E0 File Offset: 0x00347BE0
			// (set) Token: 0x0600BB67 RID: 47975 RVA: 0x003499F0 File Offset: 0x00347BF0
			public GameObjectPool<DamageNumber> m_damageNumber1Pool
			{
				get
				{
					return this.m_owner.m_damageNumber1Pool;
				}
				set
				{
					this.m_owner.m_damageNumber1Pool = value;
				}
			}

			// Token: 0x17002579 RID: 9593
			// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x00349A00 File Offset: 0x00347C00
			// (set) Token: 0x0600BB69 RID: 47977 RVA: 0x00349A10 File Offset: 0x00347C10
			public GameObjectPool<DamageNumber> m_damageNumberWeak0Pool
			{
				get
				{
					return this.m_owner.m_damageNumberWeak0Pool;
				}
				set
				{
					this.m_owner.m_damageNumberWeak0Pool = value;
				}
			}

			// Token: 0x1700257A RID: 9594
			// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x00349A20 File Offset: 0x00347C20
			// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x00349A30 File Offset: 0x00347C30
			public GameObjectPool<DamageNumber> m_damageNumberWeak1Pool
			{
				get
				{
					return this.m_owner.m_damageNumberWeak1Pool;
				}
				set
				{
					this.m_owner.m_damageNumberWeak1Pool = value;
				}
			}

			// Token: 0x1700257B RID: 9595
			// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x00349A40 File Offset: 0x00347C40
			// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x00349A50 File Offset: 0x00347C50
			public GameObjectPool<DamageNumber> m_damageNumberStrong0Pool
			{
				get
				{
					return this.m_owner.m_damageNumberStrong0Pool;
				}
				set
				{
					this.m_owner.m_damageNumberStrong0Pool = value;
				}
			}

			// Token: 0x1700257C RID: 9596
			// (get) Token: 0x0600BB6E RID: 47982 RVA: 0x00349A60 File Offset: 0x00347C60
			// (set) Token: 0x0600BB6F RID: 47983 RVA: 0x00349A70 File Offset: 0x00347C70
			public GameObjectPool<DamageNumber> m_damageNumberStrong1Pool
			{
				get
				{
					return this.m_owner.m_damageNumberStrong1Pool;
				}
				set
				{
					this.m_owner.m_damageNumberStrong1Pool = value;
				}
			}

			// Token: 0x1700257D RID: 9597
			// (get) Token: 0x0600BB70 RID: 47984 RVA: 0x00349A80 File Offset: 0x00347C80
			// (set) Token: 0x0600BB71 RID: 47985 RVA: 0x00349A90 File Offset: 0x00347C90
			public GameObjectPool<DamageNumber> m_damageNumberCritical0Pool
			{
				get
				{
					return this.m_owner.m_damageNumberCritical0Pool;
				}
				set
				{
					this.m_owner.m_damageNumberCritical0Pool = value;
				}
			}

			// Token: 0x1700257E RID: 9598
			// (get) Token: 0x0600BB72 RID: 47986 RVA: 0x00349AA0 File Offset: 0x00347CA0
			// (set) Token: 0x0600BB73 RID: 47987 RVA: 0x00349AB0 File Offset: 0x00347CB0
			public GameObjectPool<DamageNumber> m_damageNumberCritical1Pool
			{
				get
				{
					return this.m_owner.m_damageNumberCritical1Pool;
				}
				set
				{
					this.m_owner.m_damageNumberCritical1Pool = value;
				}
			}

			// Token: 0x1700257F RID: 9599
			// (get) Token: 0x0600BB74 RID: 47988 RVA: 0x00349AC0 File Offset: 0x00347CC0
			// (set) Token: 0x0600BB75 RID: 47989 RVA: 0x00349AD0 File Offset: 0x00347CD0
			public GameObject m_background0GameObject
			{
				get
				{
					return this.m_owner.m_background0GameObject;
				}
				set
				{
					this.m_owner.m_background0GameObject = value;
				}
			}

			// Token: 0x17002580 RID: 9600
			// (get) Token: 0x0600BB76 RID: 47990 RVA: 0x00349AE0 File Offset: 0x00347CE0
			// (set) Token: 0x0600BB77 RID: 47991 RVA: 0x00349AF0 File Offset: 0x00347CF0
			public GameObject m_background1GameObject
			{
				get
				{
					return this.m_owner.m_background1GameObject;
				}
				set
				{
					this.m_owner.m_background1GameObject = value;
				}
			}

			// Token: 0x17002581 RID: 9601
			// (get) Token: 0x0600BB78 RID: 47992 RVA: 0x00349B00 File Offset: 0x00347D00
			// (set) Token: 0x0600BB79 RID: 47993 RVA: 0x00349B10 File Offset: 0x00347D10
			public GameObject m_background2GameObject
			{
				get
				{
					return this.m_owner.m_background2GameObject;
				}
				set
				{
					this.m_owner.m_background2GameObject = value;
				}
			}

			// Token: 0x17002582 RID: 9602
			// (get) Token: 0x0600BB7A RID: 47994 RVA: 0x00349B20 File Offset: 0x00347D20
			// (set) Token: 0x0600BB7B RID: 47995 RVA: 0x00349B30 File Offset: 0x00347D30
			public GameObject m_fadeGameObject
			{
				get
				{
					return this.m_owner.m_fadeGameObject;
				}
				set
				{
					this.m_owner.m_fadeGameObject = value;
				}
			}

			// Token: 0x17002583 RID: 9603
			// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x00349B40 File Offset: 0x00347D40
			// (set) Token: 0x0600BB7D RID: 47997 RVA: 0x00349B50 File Offset: 0x00347D50
			public bool m_isFadeIn
			{
				get
				{
					return this.m_owner.m_isFadeIn;
				}
				set
				{
					this.m_owner.m_isFadeIn = value;
				}
			}

			// Token: 0x17002584 RID: 9604
			// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x00349B60 File Offset: 0x00347D60
			// (set) Token: 0x0600BB7F RID: 47999 RVA: 0x00349B70 File Offset: 0x00347D70
			public float m_fadeCurTime
			{
				get
				{
					return this.m_owner.m_fadeCurTime;
				}
				set
				{
					this.m_owner.m_fadeCurTime = value;
				}
			}

			// Token: 0x17002585 RID: 9605
			// (get) Token: 0x0600BB80 RID: 48000 RVA: 0x00349B80 File Offset: 0x00347D80
			// (set) Token: 0x0600BB81 RID: 48001 RVA: 0x00349B90 File Offset: 0x00347D90
			public float m_fadeDuration
			{
				get
				{
					return this.m_owner.m_fadeDuration;
				}
				set
				{
					this.m_owner.m_fadeDuration = value;
				}
			}

			// Token: 0x17002586 RID: 9606
			// (get) Token: 0x0600BB82 RID: 48002 RVA: 0x00349BA0 File Offset: 0x00347DA0
			// (set) Token: 0x0600BB83 RID: 48003 RVA: 0x00349BB0 File Offset: 0x00347DB0
			public Material m_fadeMaterial
			{
				get
				{
					return this.m_owner.m_fadeMaterial;
				}
				set
				{
					this.m_owner.m_fadeMaterial = value;
				}
			}

			// Token: 0x17002587 RID: 9607
			// (get) Token: 0x0600BB84 RID: 48004 RVA: 0x00349BC0 File Offset: 0x00347DC0
			// (set) Token: 0x0600BB85 RID: 48005 RVA: 0x00349BD0 File Offset: 0x00347DD0
			public Color m_fadeColor
			{
				get
				{
					return this.m_owner.m_fadeColor;
				}
				set
				{
					this.m_owner.m_fadeColor = value;
				}
			}

			// Token: 0x17002588 RID: 9608
			// (get) Token: 0x0600BB86 RID: 48006 RVA: 0x00349BE0 File Offset: 0x00347DE0
			// (set) Token: 0x0600BB87 RID: 48007 RVA: 0x00349BF0 File Offset: 0x00347DF0
			public int m_myPlayerTeam
			{
				get
				{
					return this.m_owner.m_myPlayerTeam;
				}
				set
				{
					this.m_owner.m_myPlayerTeam = value;
				}
			}

			// Token: 0x0600BB88 RID: 48008 RVA: 0x00349C00 File Offset: 0x00347E00
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600BB89 RID: 48009 RVA: 0x00349C10 File Offset: 0x00347E10
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600BB8A RID: 48010 RVA: 0x00349C20 File Offset: 0x00347E20
			public void HideFade()
			{
				this.m_owner.HideFade();
			}

			// Token: 0x0600BB8B RID: 48011 RVA: 0x00349C30 File Offset: 0x00347E30
			public void SetFade(float a)
			{
				this.m_owner.SetFade(a);
			}

			// Token: 0x0600BB8C RID: 48012 RVA: 0x00349C40 File Offset: 0x00347E40
			public void UpdateFade(float dt)
			{
				this.m_owner.UpdateFade(dt);
			}

			// Token: 0x0600BB8D RID: 48013 RVA: 0x00349C50 File Offset: 0x00347E50
			public void SetBackgroundTexture(GameObject go, ConfigDataTerrainInfo terrainInfo)
			{
				this.m_owner.SetBackgroundTexture(go, terrainInfo);
			}

			// Token: 0x0600BB8E RID: 48014 RVA: 0x00349C60 File Offset: 0x00347E60
			public bool GetActorGraphicPosition(CombatActor a, out Vector3 p)
			{
				return this.m_owner.GetActorGraphicPosition(a, out p);
			}

			// Token: 0x04007882 RID: 30850
			private CombatSceneUIController m_owner;
		}
	}
}
