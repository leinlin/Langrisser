using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A60 RID: 2656
	[HotFix]
	public class BuffDesc : MonoBehaviour
	{
		// Token: 0x0600A67D RID: 42621 RVA: 0x002EB13C File Offset: 0x002E933C
		private void Awake()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Awake_hotfix != null)
			{
				this.m_Awake_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_image = Utility.FindChildComponent<Image>(base.gameObject, "InfoGroup/BuffImage/Image", true);
			this.m_text = Utility.FindChildComponent<Text>(base.gameObject, "InfoGroup/Text/Text", true);
			this.m_timeText = Utility.FindChildComponent<Text>(base.gameObject, "InfoGroup/TimeGroup/TimeText", true);
		}

		// Token: 0x0600A67E RID: 42622 RVA: 0x002EB1E4 File Offset: 0x002E93E4
		public void SetBuff(ConfigDataBuffInfo buffInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBuffConfigDataBuffInfo_hotfix != null)
			{
				this.m_SetBuffConfigDataBuffInfo_hotfix.call(new object[]
				{
					this,
					buffInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (buffInfo == null)
			{
				return;
			}
			this.m_buffInfo = buffInfo;
			this.m_image.sprite = AssetUtility.Instance.GetSprite(buffInfo.Icon);
			this.m_text.text = buffInfo.Desc;
		}

		// Token: 0x0600A67F RID: 42623 RVA: 0x002EB290 File Offset: 0x002E9490
		public void AppendDebugText(string txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppendDebugTextString_hotfix != null)
			{
				this.m_AppendDebugTextString_hotfix.call(new object[]
				{
					this,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text text = this.m_text;
			text.text += txt;
		}

		// Token: 0x0600A680 RID: 42624 RVA: 0x002EB318 File Offset: 0x002E9518
		public void SetTime(int buffTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTimeInt32_hotfix != null)
			{
				this.m_SetTimeInt32_hotfix.call(new object[]
				{
					this,
					buffTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buffInfo.IsInfiniteTime())
			{
				this.m_timeText.text = "-";
			}
			else
			{
				this.m_timeText.text = buffTime.ToString();
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x0600A681 RID: 42625 RVA: 0x002EB3C8 File Offset: 0x002E95C8
		// (set) Token: 0x0600A682 RID: 42626 RVA: 0x002EB3E8 File Offset: 0x002E95E8
		[DoNotToLua]
		public BuffDesc.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BuffDesc.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A683 RID: 42627 RVA: 0x002EB3F4 File Offset: 0x002E95F4
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
					this.m_Awake_hotfix = (luaObj.RawGet("Awake") as LuaFunction);
					this.m_SetBuffConfigDataBuffInfo_hotfix = (luaObj.RawGet("SetBuff") as LuaFunction);
					this.m_AppendDebugTextString_hotfix = (luaObj.RawGet("AppendDebugText") as LuaFunction);
					this.m_SetTimeInt32_hotfix = (luaObj.RawGet("SetTime") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x002EB50C File Offset: 0x002E970C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BuffDesc));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006E7A RID: 28282
		private Image m_image;

		// Token: 0x04006E7B RID: 28283
		private Text m_text;

		// Token: 0x04006E7C RID: 28284
		private Text m_timeText;

		// Token: 0x04006E7D RID: 28285
		private ConfigDataBuffInfo m_buffInfo;

		// Token: 0x04006E7E RID: 28286
		[DoNotToLua]
		private BuffDesc.LuaExportHelper luaExportHelper;

		// Token: 0x04006E7F RID: 28287
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006E80 RID: 28288
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006E81 RID: 28289
		private LuaFunction m_Awake_hotfix;

		// Token: 0x04006E82 RID: 28290
		private LuaFunction m_SetBuffConfigDataBuffInfo_hotfix;

		// Token: 0x04006E83 RID: 28291
		private LuaFunction m_AppendDebugTextString_hotfix;

		// Token: 0x04006E84 RID: 28292
		private LuaFunction m_SetTimeInt32_hotfix;

		// Token: 0x02000A61 RID: 2657
		public class LuaExportHelper
		{
			// Token: 0x0600A685 RID: 42629 RVA: 0x002EB574 File Offset: 0x002E9774
			public LuaExportHelper(BuffDesc owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170021DA RID: 8666
			// (get) Token: 0x0600A686 RID: 42630 RVA: 0x002EB584 File Offset: 0x002E9784
			// (set) Token: 0x0600A687 RID: 42631 RVA: 0x002EB594 File Offset: 0x002E9794
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

			// Token: 0x170021DB RID: 8667
			// (get) Token: 0x0600A688 RID: 42632 RVA: 0x002EB5A4 File Offset: 0x002E97A4
			// (set) Token: 0x0600A689 RID: 42633 RVA: 0x002EB5B4 File Offset: 0x002E97B4
			public Text m_text
			{
				get
				{
					return this.m_owner.m_text;
				}
				set
				{
					this.m_owner.m_text = value;
				}
			}

			// Token: 0x170021DC RID: 8668
			// (get) Token: 0x0600A68A RID: 42634 RVA: 0x002EB5C4 File Offset: 0x002E97C4
			// (set) Token: 0x0600A68B RID: 42635 RVA: 0x002EB5D4 File Offset: 0x002E97D4
			public Text m_timeText
			{
				get
				{
					return this.m_owner.m_timeText;
				}
				set
				{
					this.m_owner.m_timeText = value;
				}
			}

			// Token: 0x170021DD RID: 8669
			// (get) Token: 0x0600A68C RID: 42636 RVA: 0x002EB5E4 File Offset: 0x002E97E4
			// (set) Token: 0x0600A68D RID: 42637 RVA: 0x002EB5F4 File Offset: 0x002E97F4
			public ConfigDataBuffInfo m_buffInfo
			{
				get
				{
					return this.m_owner.m_buffInfo;
				}
				set
				{
					this.m_owner.m_buffInfo = value;
				}
			}

			// Token: 0x0600A68E RID: 42638 RVA: 0x002EB604 File Offset: 0x002E9804
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x04006E85 RID: 28293
			private BuffDesc m_owner;
		}
	}
}
