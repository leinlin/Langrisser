using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AFC RID: 2812
	[HotFix]
	public class CombatCharUIController : UIControllerBase
	{
		// Token: 0x0600BC1D RID: 48157 RVA: 0x0034BAFC File Offset: 0x00349CFC
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

		// Token: 0x0600BC1E RID: 48158 RVA: 0x0034BB64 File Offset: 0x00349D64
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
			this.DestroyGraphic();
		}

		// Token: 0x0600BC1F RID: 48159 RVA: 0x0034BBCC File Offset: 0x00349DCC
		public void CreateGraphic(ConfigDataCharImageInfo charImageInfo, ConfigDataCharImageSkinResourceInfo skinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGraphicConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix != null)
			{
				this.m_CreateGraphicConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					charImageInfo,
					skinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic();
			if (charImageInfo == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(charImageInfo.Spine))
			{
				string text = string.Empty;
				if (skinResInfo != null)
				{
					text = skinResInfo.SpineAssetPath;
				}
				if (string.IsNullOrEmpty(text))
				{
					text = charImageInfo.Spine;
				}
				this.m_spineGraphic = new UISpineGraphic();
				this.m_spineGraphic.Create(text);
				this.m_spineGraphic.SetParent(base.gameObject);
				this.m_spineGraphic.SetScale((float)charImageInfo.CombatScale * 0.01f);
				this.m_spineGraphic.SetPosition(new Vector3(0f, (float)charImageInfo.CombatYOffset, 0f));
				this.m_image.gameObject.SetActive(false);
			}
			else if (!string.IsNullOrEmpty(charImageInfo.Image))
			{
				this.m_image.sprite = AssetUtility.Instance.GetSprite(charImageInfo.Image);
				this.m_image.gameObject.SetActive(this.m_image.sprite != null);
			}
			this.m_animationName = string.Empty;
		}

		// Token: 0x0600BC20 RID: 48160 RVA: 0x0034BD64 File Offset: 0x00349F64
		public void DestroyGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyGraphic_hotfix != null)
			{
				this.m_DestroyGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.Destroy();
				this.m_spineGraphic = null;
			}
			this.m_image.gameObject.SetActive(false);
			this.m_animationName = string.Empty;
		}

		// Token: 0x0600BC21 RID: 48161 RVA: 0x0034BE00 File Offset: 0x0034A000
		public void SetDirection(int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDirectionInt32_hotfix != null)
			{
				this.m_SetDirectionInt32_hotfix.call(new object[]
				{
					this,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.SetDirection(dir);
			}
			else
			{
				Vector3 localScale = this.m_image.transform.localScale;
				if (dir > 0)
				{
					localScale.x = -Mathf.Abs(localScale.x);
				}
				else
				{
					localScale.x = Mathf.Abs(localScale.x);
				}
				this.m_image.transform.localScale = localScale;
			}
		}

		// Token: 0x0600BC22 RID: 48162 RVA: 0x0034BEE4 File Offset: 0x0034A0E4
		public void PlayAnimation(string animation, bool loop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationStringBoolean_hotfix != null)
			{
				this.m_PlayAnimationStringBoolean_hotfix.call(new object[]
				{
					this,
					animation,
					loop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_animationName = animation;
			if (loop)
			{
				this.m_loopAnimationName = animation;
			}
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.PlayAnimation(animation, loop, 0);
			}
		}

		// Token: 0x0600BC23 RID: 48163 RVA: 0x0034BF94 File Offset: 0x0034A194
		public bool HasAnimation(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasAnimationString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasAnimationString_hotfix.call(new object[]
				{
					this,
					name
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_spineGraphic != null && this.m_spineGraphic.HasAnimation(name);
		}

		// Token: 0x0600BC24 RID: 48164 RVA: 0x0034C02C File Offset: 0x0034A22C
		public string GetAnimationName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAnimationName_hotfix != null)
			{
				return (string)this.m_GetAnimationName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_animationName;
		}

		// Token: 0x0600BC25 RID: 48165 RVA: 0x0034C0A0 File Offset: 0x0034A2A0
		public void ForceUpdate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ForceUpdate_hotfix != null)
			{
				this.m_ForceUpdate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.ForceUpdate();
			}
		}

		// Token: 0x0600BC26 RID: 48166 RVA: 0x0034C118 File Offset: 0x0034A318
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
			if (this.m_spineGraphic != null && !this.m_spineGraphic.IsPlayAnimation(0))
			{
				this.PlayAnimation(this.m_loopAnimationName, true);
			}
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x0600BC27 RID: 48167 RVA: 0x0034C1A4 File Offset: 0x0034A3A4
		// (set) Token: 0x0600BC28 RID: 48168 RVA: 0x0034C1C4 File Offset: 0x0034A3C4
		[DoNotToLua]
		public new CombatCharUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CombatCharUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BC29 RID: 48169 RVA: 0x0034C1D0 File Offset: 0x0034A3D0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600BC2A RID: 48170 RVA: 0x0034C1DC File Offset: 0x0034A3DC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600BC2B RID: 48171 RVA: 0x0034C1E4 File Offset: 0x0034A3E4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600BC2C RID: 48172 RVA: 0x0034C1EC File Offset: 0x0034A3EC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600BC2D RID: 48173 RVA: 0x0034C200 File Offset: 0x0034A400
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600BC2E RID: 48174 RVA: 0x0034C208 File Offset: 0x0034A408
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600BC2F RID: 48175 RVA: 0x0034C214 File Offset: 0x0034A414
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600BC30 RID: 48176 RVA: 0x0034C220 File Offset: 0x0034A420
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600BC31 RID: 48177 RVA: 0x0034C22C File Offset: 0x0034A42C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600BC32 RID: 48178 RVA: 0x0034C238 File Offset: 0x0034A438
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600BC33 RID: 48179 RVA: 0x0034C244 File Offset: 0x0034A444
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600BC34 RID: 48180 RVA: 0x0034C250 File Offset: 0x0034A450
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x0034C25C File Offset: 0x0034A45C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600BC36 RID: 48182 RVA: 0x0034C268 File Offset: 0x0034A468
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600BC37 RID: 48183 RVA: 0x0034C274 File Offset: 0x0034A474
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x0034C27C File Offset: 0x0034A47C
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
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_CreateGraphicConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix = (luaObj.RawGet("CreateGraphic") as LuaFunction);
					this.m_DestroyGraphic_hotfix = (luaObj.RawGet("DestroyGraphic") as LuaFunction);
					this.m_SetDirectionInt32_hotfix = (luaObj.RawGet("SetDirection") as LuaFunction);
					this.m_PlayAnimationStringBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_HasAnimationString_hotfix = (luaObj.RawGet("HasAnimation") as LuaFunction);
					this.m_GetAnimationName_hotfix = (luaObj.RawGet("GetAnimationName") as LuaFunction);
					this.m_ForceUpdate_hotfix = (luaObj.RawGet("ForceUpdate") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BC39 RID: 48185 RVA: 0x0034C428 File Offset: 0x0034A628
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CombatCharUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040078C7 RID: 30919
		[AutoBind("./Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x040078C8 RID: 30920
		private UISpineGraphic m_spineGraphic;

		// Token: 0x040078C9 RID: 30921
		private string m_animationName;

		// Token: 0x040078CA RID: 30922
		private string m_loopAnimationName;

		// Token: 0x040078CB RID: 30923
		[DoNotToLua]
		private CombatCharUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040078CC RID: 30924
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040078CD RID: 30925
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040078CE RID: 30926
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040078CF RID: 30927
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x040078D0 RID: 30928
		private LuaFunction m_CreateGraphicConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix;

		// Token: 0x040078D1 RID: 30929
		private LuaFunction m_DestroyGraphic_hotfix;

		// Token: 0x040078D2 RID: 30930
		private LuaFunction m_SetDirectionInt32_hotfix;

		// Token: 0x040078D3 RID: 30931
		private LuaFunction m_PlayAnimationStringBoolean_hotfix;

		// Token: 0x040078D4 RID: 30932
		private LuaFunction m_HasAnimationString_hotfix;

		// Token: 0x040078D5 RID: 30933
		private LuaFunction m_GetAnimationName_hotfix;

		// Token: 0x040078D6 RID: 30934
		private LuaFunction m_ForceUpdate_hotfix;

		// Token: 0x040078D7 RID: 30935
		private LuaFunction m_Update_hotfix;

		// Token: 0x02000AFD RID: 2813
		public new class LuaExportHelper
		{
			// Token: 0x0600BC3A RID: 48186 RVA: 0x0034C490 File Offset: 0x0034A690
			public LuaExportHelper(CombatCharUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BC3B RID: 48187 RVA: 0x0034C4A0 File Offset: 0x0034A6A0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600BC3C RID: 48188 RVA: 0x0034C4B0 File Offset: 0x0034A6B0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600BC3D RID: 48189 RVA: 0x0034C4C0 File Offset: 0x0034A6C0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600BC3E RID: 48190 RVA: 0x0034C4D0 File Offset: 0x0034A6D0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600BC3F RID: 48191 RVA: 0x0034C4E8 File Offset: 0x0034A6E8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600BC40 RID: 48192 RVA: 0x0034C4F8 File Offset: 0x0034A6F8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600BC41 RID: 48193 RVA: 0x0034C508 File Offset: 0x0034A708
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600BC42 RID: 48194 RVA: 0x0034C518 File Offset: 0x0034A718
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600BC43 RID: 48195 RVA: 0x0034C528 File Offset: 0x0034A728
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600BC44 RID: 48196 RVA: 0x0034C538 File Offset: 0x0034A738
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600BC45 RID: 48197 RVA: 0x0034C548 File Offset: 0x0034A748
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600BC46 RID: 48198 RVA: 0x0034C558 File Offset: 0x0034A758
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600BC47 RID: 48199 RVA: 0x0034C568 File Offset: 0x0034A768
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600BC48 RID: 48200 RVA: 0x0034C578 File Offset: 0x0034A778
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600BC49 RID: 48201 RVA: 0x0034C588 File Offset: 0x0034A788
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170025AE RID: 9646
			// (get) Token: 0x0600BC4A RID: 48202 RVA: 0x0034C598 File Offset: 0x0034A798
			// (set) Token: 0x0600BC4B RID: 48203 RVA: 0x0034C5A8 File Offset: 0x0034A7A8
			public Image m_image
			{
				get
				{
					return this.m_owner.m_image;
				}
				set
				{
					this.m_owner.m_image = value;
				}
			}

			// Token: 0x170025AF RID: 9647
			// (get) Token: 0x0600BC4C RID: 48204 RVA: 0x0034C5B8 File Offset: 0x0034A7B8
			// (set) Token: 0x0600BC4D RID: 48205 RVA: 0x0034C5C8 File Offset: 0x0034A7C8
			public UISpineGraphic m_spineGraphic
			{
				get
				{
					return this.m_owner.m_spineGraphic;
				}
				set
				{
					this.m_owner.m_spineGraphic = value;
				}
			}

			// Token: 0x170025B0 RID: 9648
			// (get) Token: 0x0600BC4E RID: 48206 RVA: 0x0034C5D8 File Offset: 0x0034A7D8
			// (set) Token: 0x0600BC4F RID: 48207 RVA: 0x0034C5E8 File Offset: 0x0034A7E8
			public string m_animationName
			{
				get
				{
					return this.m_owner.m_animationName;
				}
				set
				{
					this.m_owner.m_animationName = value;
				}
			}

			// Token: 0x170025B1 RID: 9649
			// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x0034C5F8 File Offset: 0x0034A7F8
			// (set) Token: 0x0600BC51 RID: 48209 RVA: 0x0034C608 File Offset: 0x0034A808
			public string m_loopAnimationName
			{
				get
				{
					return this.m_owner.m_loopAnimationName;
				}
				set
				{
					this.m_owner.m_loopAnimationName = value;
				}
			}

			// Token: 0x0600BC52 RID: 48210 RVA: 0x0034C618 File Offset: 0x0034A818
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600BC53 RID: 48211 RVA: 0x0034C628 File Offset: 0x0034A828
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600BC54 RID: 48212 RVA: 0x0034C638 File Offset: 0x0034A838
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x040078D8 RID: 30936
			private CombatCharUIController m_owner;
		}
	}
}
