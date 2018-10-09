using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C5D RID: 3165
	[HotFix]
	public class CourseItemUIController : UIControllerBase
	{
		// Token: 0x0600E111 RID: 57617 RVA: 0x003CA0B4 File Offset: 0x003C82B4
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnCourseItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600E112 RID: 57618 RVA: 0x003CA144 File Offset: 0x003C8344
		public void InitCourseInfo(TrainingCourse course)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitCourseInfoTrainingCourse_hotfix != null)
			{
				this.m_InitCourseInfoTrainingCourse_hotfix.call(new object[]
				{
					this,
					course
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_trainingCourse = course;
			if (course.Locked)
			{
				this.m_stateCtrl.SetToUIState("Lock", false, true);
				this.m_lockNameText.text = course.Config.Name;
			}
			else
			{
				this.m_stateCtrl.SetToUIState("UnSelect", false, true);
				this.m_point.SetActive(false);
				this.m_nameText.text = course.Config.Name;
				int num = 0;
				int num2 = 0;
				foreach (TrainingTech trainingTech in course.Techs)
				{
					num += trainingTech.Level;
					num2 += projectLPlayerContext.GetTechMaxLevel(trainingTech.ConfigId);
				}
				if (num2 == 0)
				{
					this.m_valueText.text = "0%";
					this.m_progressBar.fillAmount = 0f;
				}
				else
				{
					this.m_valueText.text = num * 100 / num2 + "%";
					this.m_progressBar.fillAmount = (float)num / (float)num2;
				}
				this.m_maxText.SetActive(false);
			}
			bool active = projectLPlayerContext.CanTrainingCourseLevelup(course);
			this.m_redMark.SetActive(active);
		}

		// Token: 0x0600E113 RID: 57619 RVA: 0x003CA31C File Offset: 0x003C851C
		public void ShowSelectFrame(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectFrameBoolean_hotfix != null)
			{
				this.m_ShowSelectFrameBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isShow)
			{
				this.m_stateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_stateCtrl.SetToUIState("UnSelect", false, true);
			}
		}

		// Token: 0x0600E114 RID: 57620 RVA: 0x003CA3BC File Offset: 0x003C85BC
		private void OnCourseItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCourseItemClick_hotfix != null)
			{
				this.m_OnCourseItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_trainingCourse.Locked)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				string txt = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_TrainingNeedLevel), this.m_trainingCourse.WhichRoom.Config.Name, this.m_trainingCourse.Config.RoomLevel);
				CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
			}
			else if (this.EventOnCourseItemClick != null)
			{
				this.EventOnCourseItemClick(this);
			}
		}

		// Token: 0x140002D1 RID: 721
		// (add) Token: 0x0600E115 RID: 57621 RVA: 0x003CA4A8 File Offset: 0x003C86A8
		// (remove) Token: 0x0600E116 RID: 57622 RVA: 0x003CA544 File Offset: 0x003C8744
		public event Action<CourseItemUIController> EventOnCourseItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCourseItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnCourseItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<CourseItemUIController> action = this.EventOnCourseItemClick;
				Action<CourseItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<CourseItemUIController>>(ref this.EventOnCourseItemClick, (Action<CourseItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCourseItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnCourseItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<CourseItemUIController> action = this.EventOnCourseItemClick;
				Action<CourseItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<CourseItemUIController>>(ref this.EventOnCourseItemClick, (Action<CourseItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x0600E117 RID: 57623 RVA: 0x003CA5E0 File Offset: 0x003C87E0
		// (set) Token: 0x0600E118 RID: 57624 RVA: 0x003CA600 File Offset: 0x003C8800
		[DoNotToLua]
		public new CourseItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CourseItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E119 RID: 57625 RVA: 0x003CA60C File Offset: 0x003C880C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E11A RID: 57626 RVA: 0x003CA618 File Offset: 0x003C8818
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E11B RID: 57627 RVA: 0x003CA620 File Offset: 0x003C8820
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E11C RID: 57628 RVA: 0x003CA628 File Offset: 0x003C8828
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E11D RID: 57629 RVA: 0x003CA63C File Offset: 0x003C883C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E11E RID: 57630 RVA: 0x003CA644 File Offset: 0x003C8844
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E11F RID: 57631 RVA: 0x003CA650 File Offset: 0x003C8850
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E120 RID: 57632 RVA: 0x003CA65C File Offset: 0x003C885C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E121 RID: 57633 RVA: 0x003CA668 File Offset: 0x003C8868
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E122 RID: 57634 RVA: 0x003CA674 File Offset: 0x003C8874
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E123 RID: 57635 RVA: 0x003CA680 File Offset: 0x003C8880
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E124 RID: 57636 RVA: 0x003CA68C File Offset: 0x003C888C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E125 RID: 57637 RVA: 0x003CA698 File Offset: 0x003C8898
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E126 RID: 57638 RVA: 0x003CA6A4 File Offset: 0x003C88A4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E127 RID: 57639 RVA: 0x003CA6B0 File Offset: 0x003C88B0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E128 RID: 57640 RVA: 0x003CA6B8 File Offset: 0x003C88B8
		private void __callDele_EventOnCourseItemClick(CourseItemUIController obj)
		{
			Action<CourseItemUIController> eventOnCourseItemClick = this.EventOnCourseItemClick;
			if (eventOnCourseItemClick != null)
			{
				eventOnCourseItemClick(obj);
			}
		}

		// Token: 0x0600E129 RID: 57641 RVA: 0x003CA6DC File Offset: 0x003C88DC
		private void __clearDele_EventOnCourseItemClick(CourseItemUIController obj)
		{
			this.EventOnCourseItemClick = null;
		}

		// Token: 0x0600E12A RID: 57642 RVA: 0x003CA6E8 File Offset: 0x003C88E8
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
					this.m_InitCourseInfoTrainingCourse_hotfix = (luaObj.RawGet("InitCourseInfo") as LuaFunction);
					this.m_ShowSelectFrameBoolean_hotfix = (luaObj.RawGet("ShowSelectFrame") as LuaFunction);
					this.m_OnCourseItemClick_hotfix = (luaObj.RawGet("OnCourseItemClick") as LuaFunction);
					this.m_add_EventOnCourseItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnCourseItemClick") as LuaFunction);
					this.m_remove_EventOnCourseItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnCourseItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E12B RID: 57643 RVA: 0x003CA830 File Offset: 0x003C8A30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CourseItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040088A9 RID: 34985
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x040088AA RID: 34986
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x040088AB RID: 34987
		[AutoBind("./Normal/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_progressBar;

		// Token: 0x040088AC RID: 34988
		[AutoBind("./Normal/Point", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_point;

		// Token: 0x040088AD RID: 34989
		[AutoBind("./Normal/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x040088AE RID: 34990
		[AutoBind("./Normal/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_valueText;

		// Token: 0x040088AF RID: 34991
		[AutoBind("./Normal/MaxText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_maxText;

		// Token: 0x040088B0 RID: 34992
		[AutoBind("./Lock/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockNameText;

		// Token: 0x040088B1 RID: 34993
		[AutoBind("./Normal/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_redMark;

		// Token: 0x040088B2 RID: 34994
		public TrainingCourse m_trainingCourse;

		// Token: 0x040088B3 RID: 34995
		[DoNotToLua]
		private CourseItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040088B4 RID: 34996
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040088B5 RID: 34997
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040088B6 RID: 34998
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040088B7 RID: 34999
		private LuaFunction m_InitCourseInfoTrainingCourse_hotfix;

		// Token: 0x040088B8 RID: 35000
		private LuaFunction m_ShowSelectFrameBoolean_hotfix;

		// Token: 0x040088B9 RID: 35001
		private LuaFunction m_OnCourseItemClick_hotfix;

		// Token: 0x040088BA RID: 35002
		private LuaFunction m_add_EventOnCourseItemClickAction;

		// Token: 0x040088BB RID: 35003
		private LuaFunction m_remove_EventOnCourseItemClickAction;

		// Token: 0x02000C5E RID: 3166
		public new class LuaExportHelper
		{
			// Token: 0x0600E12C RID: 57644 RVA: 0x003CA898 File Offset: 0x003C8A98
			public LuaExportHelper(CourseItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E12D RID: 57645 RVA: 0x003CA8A8 File Offset: 0x003C8AA8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E12E RID: 57646 RVA: 0x003CA8B8 File Offset: 0x003C8AB8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E12F RID: 57647 RVA: 0x003CA8C8 File Offset: 0x003C8AC8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E130 RID: 57648 RVA: 0x003CA8D8 File Offset: 0x003C8AD8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E131 RID: 57649 RVA: 0x003CA8F0 File Offset: 0x003C8AF0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E132 RID: 57650 RVA: 0x003CA900 File Offset: 0x003C8B00
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E133 RID: 57651 RVA: 0x003CA910 File Offset: 0x003C8B10
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E134 RID: 57652 RVA: 0x003CA920 File Offset: 0x003C8B20
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E135 RID: 57653 RVA: 0x003CA930 File Offset: 0x003C8B30
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E136 RID: 57654 RVA: 0x003CA940 File Offset: 0x003C8B40
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E137 RID: 57655 RVA: 0x003CA950 File Offset: 0x003C8B50
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E138 RID: 57656 RVA: 0x003CA960 File Offset: 0x003C8B60
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E139 RID: 57657 RVA: 0x003CA970 File Offset: 0x003C8B70
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E13A RID: 57658 RVA: 0x003CA980 File Offset: 0x003C8B80
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E13B RID: 57659 RVA: 0x003CA990 File Offset: 0x003C8B90
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E13C RID: 57660 RVA: 0x003CA9A0 File Offset: 0x003C8BA0
			public void __callDele_EventOnCourseItemClick(CourseItemUIController obj)
			{
				this.m_owner.__callDele_EventOnCourseItemClick(obj);
			}

			// Token: 0x0600E13D RID: 57661 RVA: 0x003CA9B0 File Offset: 0x003C8BB0
			public void __clearDele_EventOnCourseItemClick(CourseItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnCourseItemClick(obj);
			}

			// Token: 0x17002BBA RID: 11194
			// (get) Token: 0x0600E13E RID: 57662 RVA: 0x003CA9C0 File Offset: 0x003C8BC0
			// (set) Token: 0x0600E13F RID: 57663 RVA: 0x003CA9D0 File Offset: 0x003C8BD0
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x17002BBB RID: 11195
			// (get) Token: 0x0600E140 RID: 57664 RVA: 0x003CA9E0 File Offset: 0x003C8BE0
			// (set) Token: 0x0600E141 RID: 57665 RVA: 0x003CA9F0 File Offset: 0x003C8BF0
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x17002BBC RID: 11196
			// (get) Token: 0x0600E142 RID: 57666 RVA: 0x003CAA00 File Offset: 0x003C8C00
			// (set) Token: 0x0600E143 RID: 57667 RVA: 0x003CAA10 File Offset: 0x003C8C10
			public Image m_progressBar
			{
				get
				{
					return this.m_owner.m_progressBar;
				}
				set
				{
					this.m_owner.m_progressBar = value;
				}
			}

			// Token: 0x17002BBD RID: 11197
			// (get) Token: 0x0600E144 RID: 57668 RVA: 0x003CAA20 File Offset: 0x003C8C20
			// (set) Token: 0x0600E145 RID: 57669 RVA: 0x003CAA30 File Offset: 0x003C8C30
			public GameObject m_point
			{
				get
				{
					return this.m_owner.m_point;
				}
				set
				{
					this.m_owner.m_point = value;
				}
			}

			// Token: 0x17002BBE RID: 11198
			// (get) Token: 0x0600E146 RID: 57670 RVA: 0x003CAA40 File Offset: 0x003C8C40
			// (set) Token: 0x0600E147 RID: 57671 RVA: 0x003CAA50 File Offset: 0x003C8C50
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

			// Token: 0x17002BBF RID: 11199
			// (get) Token: 0x0600E148 RID: 57672 RVA: 0x003CAA60 File Offset: 0x003C8C60
			// (set) Token: 0x0600E149 RID: 57673 RVA: 0x003CAA70 File Offset: 0x003C8C70
			public Text m_valueText
			{
				get
				{
					return this.m_owner.m_valueText;
				}
				set
				{
					this.m_owner.m_valueText = value;
				}
			}

			// Token: 0x17002BC0 RID: 11200
			// (get) Token: 0x0600E14A RID: 57674 RVA: 0x003CAA80 File Offset: 0x003C8C80
			// (set) Token: 0x0600E14B RID: 57675 RVA: 0x003CAA90 File Offset: 0x003C8C90
			public GameObject m_maxText
			{
				get
				{
					return this.m_owner.m_maxText;
				}
				set
				{
					this.m_owner.m_maxText = value;
				}
			}

			// Token: 0x17002BC1 RID: 11201
			// (get) Token: 0x0600E14C RID: 57676 RVA: 0x003CAAA0 File Offset: 0x003C8CA0
			// (set) Token: 0x0600E14D RID: 57677 RVA: 0x003CAAB0 File Offset: 0x003C8CB0
			public Text m_lockNameText
			{
				get
				{
					return this.m_owner.m_lockNameText;
				}
				set
				{
					this.m_owner.m_lockNameText = value;
				}
			}

			// Token: 0x17002BC2 RID: 11202
			// (get) Token: 0x0600E14E RID: 57678 RVA: 0x003CAAC0 File Offset: 0x003C8CC0
			// (set) Token: 0x0600E14F RID: 57679 RVA: 0x003CAAD0 File Offset: 0x003C8CD0
			public GameObject m_redMark
			{
				get
				{
					return this.m_owner.m_redMark;
				}
				set
				{
					this.m_owner.m_redMark = value;
				}
			}

			// Token: 0x0600E150 RID: 57680 RVA: 0x003CAAE0 File Offset: 0x003C8CE0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E151 RID: 57681 RVA: 0x003CAAF0 File Offset: 0x003C8CF0
			public void OnCourseItemClick()
			{
				this.m_owner.OnCourseItemClick();
			}

			// Token: 0x040088BC RID: 35004
			private CourseItemUIController m_owner;
		}
	}
}
