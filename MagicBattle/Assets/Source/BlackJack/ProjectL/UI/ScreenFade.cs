using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BFB RID: 3067
	[HotFix]
	public class ScreenFade
	{
		// Token: 0x0600D6A4 RID: 54948 RVA: 0x003A72F4 File Offset: 0x003A54F4
		public ScreenFade()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x003A7368 File Offset: 0x003A5568
		public void Setup(Image image)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupImage_hotfix != null)
			{
				this.m_SetupImage_hotfix.call(new object[]
				{
					this,
					image
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_image = image;
		}

		// Token: 0x0600D6A6 RID: 54950 RVA: 0x003A73E0 File Offset: 0x003A55E0
		public void FadeIn(float time, Color color, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FadeInSingleColorAction_hotfix != null)
			{
				this.m_FadeInSingleColorAction_hotfix.call(new object[]
				{
					this,
					time,
					color,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curTime = 0f;
			this.m_duration = time;
			this.m_color = color;
			this.m_isFadeIn = true;
			this.m_delayFrame = 1;
			this.m_isEnd = false;
			this.m_onEnd = onEnd;
			if (time > 0f)
			{
				this.m_image.gameObject.SetActive(true);
				this.m_image.color = new Color(this.m_color.r, this.m_color.g, this.m_color.b, 1f);
			}
			else
			{
				this.m_image.gameObject.SetActive(false);
				if (onEnd != null)
				{
					this.m_onEnd = null;
					onEnd();
				}
			}
		}

		// Token: 0x0600D6A7 RID: 54951 RVA: 0x003A7520 File Offset: 0x003A5720
		public void FadeOut(float time, Color color, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FadeOutSingleColorAction_hotfix != null)
			{
				this.m_FadeOutSingleColorAction_hotfix.call(new object[]
				{
					this,
					time,
					color,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curTime = 0f;
			this.m_duration = time;
			this.m_delayFrame = 0;
			this.m_color = color;
			this.m_isFadeIn = false;
			this.m_isEnd = false;
			this.m_onEnd = onEnd;
			this.m_image.gameObject.SetActive(true);
			if (time > 0f)
			{
				this.m_image.color = new Color(this.m_color.r, this.m_color.g, this.m_color.b, 0f);
			}
			else
			{
				this.m_image.color = new Color(this.m_color.r, this.m_color.g, this.m_color.b, 1f);
				if (onEnd != null)
				{
					this.m_onEnd = null;
					onEnd();
				}
			}
		}

		// Token: 0x0600D6A8 RID: 54952 RVA: 0x003A7688 File Offset: 0x003A5888
		private bool IsFading()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFading_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFading_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_image.gameObject.activeSelf;
		}

		// Token: 0x0600D6A9 RID: 54953 RVA: 0x003A7704 File Offset: 0x003A5904
		public void Update(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSingle_hotfix != null)
			{
				this.m_UpdateSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isEnd && this.m_onEnd != null)
			{
				Action onEnd = this.m_onEnd;
				this.m_onEnd = null;
				this.m_isEnd = false;
				onEnd();
			}
			if (this.m_curTime < this.m_duration)
			{
				float num = 0f;
				if (this.m_delayFrame > 0)
				{
					this.m_delayFrame--;
				}
				else
				{
					this.m_curTime += dt;
					num = Mathf.Clamp01(this.m_curTime / this.m_duration);
				}
				if (this.m_isFadeIn)
				{
					num = 1f - num;
				}
				this.m_image.color = new Color(this.m_color.r, this.m_color.g, this.m_color.b, num);
				if (this.m_curTime >= this.m_duration)
				{
					this.m_curTime = (this.m_duration = 0f);
					if (this.m_isFadeIn)
					{
						this.m_image.gameObject.SetActive(false);
					}
					if (this.m_onEnd != null)
					{
						this.m_isEnd = true;
					}
				}
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x0600D6AA RID: 54954 RVA: 0x003A7894 File Offset: 0x003A5A94
		// (set) Token: 0x0600D6AB RID: 54955 RVA: 0x003A78B4 File Offset: 0x003A5AB4
		[DoNotToLua]
		public ScreenFade.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ScreenFade.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D6AC RID: 54956 RVA: 0x003A78C0 File Offset: 0x003A5AC0
		private void __callDele_m_onEnd()
		{
			Action onEnd = this.m_onEnd;
			if (onEnd != null)
			{
				onEnd();
			}
		}

		// Token: 0x0600D6AD RID: 54957 RVA: 0x003A78E0 File Offset: 0x003A5AE0
		private void __clearDele_m_onEnd()
		{
			this.m_onEnd = null;
		}

		// Token: 0x0600D6AE RID: 54958 RVA: 0x003A78EC File Offset: 0x003A5AEC
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_SetupImage_hotfix = (luaObj.RawGet("Setup") as LuaFunction);
					this.m_FadeInSingleColorAction_hotfix = (luaObj.RawGet("FadeIn") as LuaFunction);
					this.m_FadeOutSingleColorAction_hotfix = (luaObj.RawGet("FadeOut") as LuaFunction);
					this.m_IsFading_hotfix = (luaObj.RawGet("IsFading") as LuaFunction);
					this.m_UpdateSingle_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D6AF RID: 54959 RVA: 0x003A7A34 File Offset: 0x003A5C34
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ScreenFade));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400842E RID: 33838
		private float m_curTime;

		// Token: 0x0400842F RID: 33839
		private float m_duration;

		// Token: 0x04008430 RID: 33840
		private int m_delayFrame;

		// Token: 0x04008431 RID: 33841
		private bool m_isFadeIn;

		// Token: 0x04008432 RID: 33842
		private bool m_isEnd;

		// Token: 0x04008433 RID: 33843
		private Color m_color = Color.black;

		// Token: 0x04008434 RID: 33844
		private Action m_onEnd;

		// Token: 0x04008435 RID: 33845
		private Image m_image;

		// Token: 0x04008436 RID: 33846
		[DoNotToLua]
		private ScreenFade.LuaExportHelper luaExportHelper;

		// Token: 0x04008437 RID: 33847
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008438 RID: 33848
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008439 RID: 33849
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400843A RID: 33850
		private LuaFunction m_SetupImage_hotfix;

		// Token: 0x0400843B RID: 33851
		private LuaFunction m_FadeInSingleColorAction_hotfix;

		// Token: 0x0400843C RID: 33852
		private LuaFunction m_FadeOutSingleColorAction_hotfix;

		// Token: 0x0400843D RID: 33853
		private LuaFunction m_IsFading_hotfix;

		// Token: 0x0400843E RID: 33854
		private LuaFunction m_UpdateSingle_hotfix;

		// Token: 0x02000BFC RID: 3068
		public class LuaExportHelper
		{
			// Token: 0x0600D6B0 RID: 54960 RVA: 0x003A7A9C File Offset: 0x003A5C9C
			public LuaExportHelper(ScreenFade owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D6B1 RID: 54961 RVA: 0x003A7AAC File Offset: 0x003A5CAC
			public void __callDele_m_onEnd()
			{
				this.m_owner.__callDele_m_onEnd();
			}

			// Token: 0x0600D6B2 RID: 54962 RVA: 0x003A7ABC File Offset: 0x003A5CBC
			public void __clearDele_m_onEnd()
			{
				this.m_owner.__clearDele_m_onEnd();
			}

			// Token: 0x170029DE RID: 10718
			// (get) Token: 0x0600D6B3 RID: 54963 RVA: 0x003A7ACC File Offset: 0x003A5CCC
			// (set) Token: 0x0600D6B4 RID: 54964 RVA: 0x003A7ADC File Offset: 0x003A5CDC
			public float m_curTime
			{
				get
				{
					return this.m_owner.m_curTime;
				}
				set
				{
					this.m_owner.m_curTime = value;
				}
			}

			// Token: 0x170029DF RID: 10719
			// (get) Token: 0x0600D6B5 RID: 54965 RVA: 0x003A7AEC File Offset: 0x003A5CEC
			// (set) Token: 0x0600D6B6 RID: 54966 RVA: 0x003A7AFC File Offset: 0x003A5CFC
			public float m_duration
			{
				get
				{
					return this.m_owner.m_duration;
				}
				set
				{
					this.m_owner.m_duration = value;
				}
			}

			// Token: 0x170029E0 RID: 10720
			// (get) Token: 0x0600D6B7 RID: 54967 RVA: 0x003A7B0C File Offset: 0x003A5D0C
			// (set) Token: 0x0600D6B8 RID: 54968 RVA: 0x003A7B1C File Offset: 0x003A5D1C
			public int m_delayFrame
			{
				get
				{
					return this.m_owner.m_delayFrame;
				}
				set
				{
					this.m_owner.m_delayFrame = value;
				}
			}

			// Token: 0x170029E1 RID: 10721
			// (get) Token: 0x0600D6B9 RID: 54969 RVA: 0x003A7B2C File Offset: 0x003A5D2C
			// (set) Token: 0x0600D6BA RID: 54970 RVA: 0x003A7B3C File Offset: 0x003A5D3C
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

			// Token: 0x170029E2 RID: 10722
			// (get) Token: 0x0600D6BB RID: 54971 RVA: 0x003A7B4C File Offset: 0x003A5D4C
			// (set) Token: 0x0600D6BC RID: 54972 RVA: 0x003A7B5C File Offset: 0x003A5D5C
			public bool m_isEnd
			{
				get
				{
					return this.m_owner.m_isEnd;
				}
				set
				{
					this.m_owner.m_isEnd = value;
				}
			}

			// Token: 0x170029E3 RID: 10723
			// (get) Token: 0x0600D6BD RID: 54973 RVA: 0x003A7B6C File Offset: 0x003A5D6C
			// (set) Token: 0x0600D6BE RID: 54974 RVA: 0x003A7B7C File Offset: 0x003A5D7C
			public Color m_color
			{
				get
				{
					return this.m_owner.m_color;
				}
				set
				{
					this.m_owner.m_color = value;
				}
			}

			// Token: 0x170029E4 RID: 10724
			// (get) Token: 0x0600D6BF RID: 54975 RVA: 0x003A7B8C File Offset: 0x003A5D8C
			// (set) Token: 0x0600D6C0 RID: 54976 RVA: 0x003A7B9C File Offset: 0x003A5D9C
			public Action m_onEnd
			{
				get
				{
					return this.m_owner.m_onEnd;
				}
				set
				{
					this.m_owner.m_onEnd = value;
				}
			}

			// Token: 0x170029E5 RID: 10725
			// (get) Token: 0x0600D6C1 RID: 54977 RVA: 0x003A7BAC File Offset: 0x003A5DAC
			// (set) Token: 0x0600D6C2 RID: 54978 RVA: 0x003A7BBC File Offset: 0x003A5DBC
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

			// Token: 0x0600D6C3 RID: 54979 RVA: 0x003A7BCC File Offset: 0x003A5DCC
			public bool IsFading()
			{
				return this.m_owner.IsFading();
			}

			// Token: 0x0400843F RID: 33855
			private ScreenFade m_owner;
		}
	}
}
