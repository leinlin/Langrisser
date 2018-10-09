using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D02 RID: 3330
	[HotFix]
	public class GuildJournalItemUIController : UIControllerBase
	{
		// Token: 0x0600F577 RID: 62839 RVA: 0x0040F5A4 File Offset: 0x0040D7A4
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

		// Token: 0x0600F578 RID: 62840 RVA: 0x0040F60C File Offset: 0x0040D80C
		public void InitItemInfo(GuildLog log)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitItemInfoGuildLog_hotfix != null)
			{
				this.m_InitItemInfoGuildLog_hotfix.call(new object[]
				{
					this,
					log
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_dateText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ServerOpenTimeFormatString), new object[]
			{
				log.SendTime.Year,
				log.SendTime.Month,
				log.SendTime.Day,
				log.SendTime.Hour,
				log.SendTime.Minute.ToString().PadLeft(2, '0')
			});
			this.m_infoText.text = projectLPlayerContext.GetGuildLogContent(log);
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0600F579 RID: 62841 RVA: 0x0040F760 File Offset: 0x0040D960
		// (set) Token: 0x0600F57A RID: 62842 RVA: 0x0040F780 File Offset: 0x0040D980
		[DoNotToLua]
		public new GuildJournalItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildJournalItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F57B RID: 62843 RVA: 0x0040F78C File Offset: 0x0040D98C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F57C RID: 62844 RVA: 0x0040F798 File Offset: 0x0040D998
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F57D RID: 62845 RVA: 0x0040F7A0 File Offset: 0x0040D9A0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F57E RID: 62846 RVA: 0x0040F7A8 File Offset: 0x0040D9A8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F57F RID: 62847 RVA: 0x0040F7BC File Offset: 0x0040D9BC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F580 RID: 62848 RVA: 0x0040F7C4 File Offset: 0x0040D9C4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F581 RID: 62849 RVA: 0x0040F7D0 File Offset: 0x0040D9D0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F582 RID: 62850 RVA: 0x0040F7DC File Offset: 0x0040D9DC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F583 RID: 62851 RVA: 0x0040F7E8 File Offset: 0x0040D9E8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F584 RID: 62852 RVA: 0x0040F7F4 File Offset: 0x0040D9F4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F585 RID: 62853 RVA: 0x0040F800 File Offset: 0x0040DA00
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F586 RID: 62854 RVA: 0x0040F80C File Offset: 0x0040DA0C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F587 RID: 62855 RVA: 0x0040F818 File Offset: 0x0040DA18
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F588 RID: 62856 RVA: 0x0040F824 File Offset: 0x0040DA24
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F589 RID: 62857 RVA: 0x0040F830 File Offset: 0x0040DA30
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F58A RID: 62858 RVA: 0x0040F838 File Offset: 0x0040DA38
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
					this.m_InitItemInfoGuildLog_hotfix = (luaObj.RawGet("InitItemInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F58B RID: 62859 RVA: 0x0040F91C File Offset: 0x0040DB1C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJournalItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009123 RID: 37155
		[AutoBind("./DateText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dateText;

		// Token: 0x04009124 RID: 37156
		[AutoBind("./InfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoText;

		// Token: 0x04009125 RID: 37157
		[DoNotToLua]
		private GuildJournalItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009126 RID: 37158
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009127 RID: 37159
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009128 RID: 37160
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009129 RID: 37161
		private LuaFunction m_InitItemInfoGuildLog_hotfix;

		// Token: 0x02000D03 RID: 3331
		public new class LuaExportHelper
		{
			// Token: 0x0600F58C RID: 62860 RVA: 0x0040F984 File Offset: 0x0040DB84
			public LuaExportHelper(GuildJournalItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F58D RID: 62861 RVA: 0x0040F994 File Offset: 0x0040DB94
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F58E RID: 62862 RVA: 0x0040F9A4 File Offset: 0x0040DBA4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F58F RID: 62863 RVA: 0x0040F9B4 File Offset: 0x0040DBB4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F590 RID: 62864 RVA: 0x0040F9C4 File Offset: 0x0040DBC4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F591 RID: 62865 RVA: 0x0040F9DC File Offset: 0x0040DBDC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F592 RID: 62866 RVA: 0x0040F9EC File Offset: 0x0040DBEC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F593 RID: 62867 RVA: 0x0040F9FC File Offset: 0x0040DBFC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F594 RID: 62868 RVA: 0x0040FA0C File Offset: 0x0040DC0C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F595 RID: 62869 RVA: 0x0040FA1C File Offset: 0x0040DC1C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F596 RID: 62870 RVA: 0x0040FA2C File Offset: 0x0040DC2C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F597 RID: 62871 RVA: 0x0040FA3C File Offset: 0x0040DC3C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F598 RID: 62872 RVA: 0x0040FA4C File Offset: 0x0040DC4C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F599 RID: 62873 RVA: 0x0040FA5C File Offset: 0x0040DC5C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F59A RID: 62874 RVA: 0x0040FA6C File Offset: 0x0040DC6C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F59B RID: 62875 RVA: 0x0040FA7C File Offset: 0x0040DC7C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002F29 RID: 12073
			// (get) Token: 0x0600F59C RID: 62876 RVA: 0x0040FA8C File Offset: 0x0040DC8C
			// (set) Token: 0x0600F59D RID: 62877 RVA: 0x0040FA9C File Offset: 0x0040DC9C
			public Text m_dateText
			{
				get
				{
					return this.m_owner.m_dateText;
				}
				set
				{
					this.m_owner.m_dateText = value;
				}
			}

			// Token: 0x17002F2A RID: 12074
			// (get) Token: 0x0600F59E RID: 62878 RVA: 0x0040FAAC File Offset: 0x0040DCAC
			// (set) Token: 0x0600F59F RID: 62879 RVA: 0x0040FABC File Offset: 0x0040DCBC
			public Text m_infoText
			{
				get
				{
					return this.m_owner.m_infoText;
				}
				set
				{
					this.m_owner.m_infoText = value;
				}
			}

			// Token: 0x0600F5A0 RID: 62880 RVA: 0x0040FACC File Offset: 0x0040DCCC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400912A RID: 37162
			private GuildJournalItemUIController m_owner;
		}
	}
}
