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
	// Token: 0x02000A62 RID: 2658
	[HotFix]
	public class SkillDesc : MonoBehaviour
	{
		// Token: 0x0600A690 RID: 42640 RVA: 0x002EB61C File Offset: 0x002E981C
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
			this.m_icon = Utility.FindChildComponent<Image>(base.gameObject, "Icon", true);
			this.m_title = Utility.FindChildComponent<Text>(base.gameObject, "Text", true);
			this.m_desc = Utility.FindChildComponent<Text>(base.gameObject, "DescScrollView/Viewport/Content/Desc", true);
			this.m_cd = Utility.FindChildComponent<Text>(base.gameObject, "CD/ValueText", true);
			this.m_range = Utility.FindChildComponent<Text>(base.gameObject, "Range/ValueText", true);
			this.m_distance = Utility.FindChildComponent<Text>(base.gameObject, "Distance/ValueText", true);
		}

		// Token: 0x0600A691 RID: 42641 RVA: 0x002EB708 File Offset: 0x002E9908
		public void SetSkill(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillConfigDataSkillInfo_hotfix != null)
			{
				this.m_SetSkillConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			this.m_icon.sprite = AssetUtility.Instance.GetSprite(skillInfo.Icon);
			this.m_title.text = skillInfo.Name;
			this.m_desc.text = skillInfo.Desc;
			this.m_cd.text = skillInfo.CDText;
			this.m_range.text = skillInfo.RangeText;
			this.m_distance.text = skillInfo.DistanceText;
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x0600A692 RID: 42642 RVA: 0x002EB7F0 File Offset: 0x002E99F0
		// (set) Token: 0x0600A693 RID: 42643 RVA: 0x002EB810 File Offset: 0x002E9A10
		[DoNotToLua]
		public SkillDesc.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SkillDesc.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A694 RID: 42644 RVA: 0x002EB81C File Offset: 0x002E9A1C
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
					this.m_SetSkillConfigDataSkillInfo_hotfix = (luaObj.RawGet("SetSkill") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A695 RID: 42645 RVA: 0x002EB900 File Offset: 0x002E9B00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SkillDesc));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006E86 RID: 28294
		private Image m_icon;

		// Token: 0x04006E87 RID: 28295
		private Text m_title;

		// Token: 0x04006E88 RID: 28296
		private Text m_desc;

		// Token: 0x04006E89 RID: 28297
		private Text m_cd;

		// Token: 0x04006E8A RID: 28298
		private Text m_range;

		// Token: 0x04006E8B RID: 28299
		private Text m_distance;

		// Token: 0x04006E8C RID: 28300
		[DoNotToLua]
		private SkillDesc.LuaExportHelper luaExportHelper;

		// Token: 0x04006E8D RID: 28301
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006E8E RID: 28302
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006E8F RID: 28303
		private LuaFunction m_Awake_hotfix;

		// Token: 0x04006E90 RID: 28304
		private LuaFunction m_SetSkillConfigDataSkillInfo_hotfix;

		// Token: 0x02000A63 RID: 2659
		public class LuaExportHelper
		{
			// Token: 0x0600A696 RID: 42646 RVA: 0x002EB968 File Offset: 0x002E9B68
			public LuaExportHelper(SkillDesc owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170021DF RID: 8671
			// (get) Token: 0x0600A697 RID: 42647 RVA: 0x002EB978 File Offset: 0x002E9B78
			// (set) Token: 0x0600A698 RID: 42648 RVA: 0x002EB988 File Offset: 0x002E9B88
			public Image m_icon
			{
				get
				{
					return this.m_owner.m_icon;
				}
				set
				{
					this.m_owner.m_icon = value;
				}
			}

			// Token: 0x170021E0 RID: 8672
			// (get) Token: 0x0600A699 RID: 42649 RVA: 0x002EB998 File Offset: 0x002E9B98
			// (set) Token: 0x0600A69A RID: 42650 RVA: 0x002EB9A8 File Offset: 0x002E9BA8
			public Text m_title
			{
				get
				{
					return this.m_owner.m_title;
				}
				set
				{
					this.m_owner.m_title = value;
				}
			}

			// Token: 0x170021E1 RID: 8673
			// (get) Token: 0x0600A69B RID: 42651 RVA: 0x002EB9B8 File Offset: 0x002E9BB8
			// (set) Token: 0x0600A69C RID: 42652 RVA: 0x002EB9C8 File Offset: 0x002E9BC8
			public Text m_desc
			{
				get
				{
					return this.m_owner.m_desc;
				}
				set
				{
					this.m_owner.m_desc = value;
				}
			}

			// Token: 0x170021E2 RID: 8674
			// (get) Token: 0x0600A69D RID: 42653 RVA: 0x002EB9D8 File Offset: 0x002E9BD8
			// (set) Token: 0x0600A69E RID: 42654 RVA: 0x002EB9E8 File Offset: 0x002E9BE8
			public Text m_cd
			{
				get
				{
					return this.m_owner.m_cd;
				}
				set
				{
					this.m_owner.m_cd = value;
				}
			}

			// Token: 0x170021E3 RID: 8675
			// (get) Token: 0x0600A69F RID: 42655 RVA: 0x002EB9F8 File Offset: 0x002E9BF8
			// (set) Token: 0x0600A6A0 RID: 42656 RVA: 0x002EBA08 File Offset: 0x002E9C08
			public Text m_range
			{
				get
				{
					return this.m_owner.m_range;
				}
				set
				{
					this.m_owner.m_range = value;
				}
			}

			// Token: 0x170021E4 RID: 8676
			// (get) Token: 0x0600A6A1 RID: 42657 RVA: 0x002EBA18 File Offset: 0x002E9C18
			// (set) Token: 0x0600A6A2 RID: 42658 RVA: 0x002EBA28 File Offset: 0x002E9C28
			public Text m_distance
			{
				get
				{
					return this.m_owner.m_distance;
				}
				set
				{
					this.m_owner.m_distance = value;
				}
			}

			// Token: 0x0600A6A3 RID: 42659 RVA: 0x002EBA38 File Offset: 0x002E9C38
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x04006E91 RID: 28305
			private SkillDesc m_owner;
		}
	}
}
