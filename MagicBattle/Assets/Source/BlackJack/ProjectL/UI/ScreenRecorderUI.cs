using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BFD RID: 3069
	[HotFix]
	public class ScreenRecorderUI : PrefabControllerBase, IBeginDragHandler, IDragHandler, IEndDragHandler, IEventSystemHandler
	{
		// Token: 0x0600D6C5 RID: 54981 RVA: 0x003A7BE4 File Offset: 0x003A5DE4
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
			this.ToggleScreenRecord(false);
		}

		// Token: 0x0600D6C6 RID: 54982 RVA: 0x003A7C4C File Offset: 0x003A5E4C
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
			this.m_recordIndicator = Utility.FindChildGameObject(base.gameObject, "RecordingIndicator", true);
			this.m_recordTimerText = Utility.FindChildComponent<Text>(base.gameObject, "TimerText", true);
			this.m_screenRecordToggle = Utility.FindChildComponent<Toggle>(base.gameObject, "RecorderToggle", true);
			this.m_screenRecordToggle.isOn = false;
			this.ToggleScreenRecord(false);
			this.m_screenRecordToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnScreenRecordToggleValueChanged));
		}

		// Token: 0x0600D6C7 RID: 54983 RVA: 0x003A7D20 File Offset: 0x003A5F20
		public void OnScreenRecordToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScreenRecordToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnScreenRecordToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ToggleScreenRecord(isOn);
		}

		// Token: 0x0600D6C8 RID: 54984 RVA: 0x003A7D98 File Offset: 0x003A5F98
		private void ToggleScreenRecord(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ToggleScreenRecordBoolean_hotfix != null)
			{
				this.m_ToggleScreenRecordBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_recordIndicator == null)
			{
				return;
			}
			if (this.m_screenRecordToggle.isOn != isOn)
			{
				this.m_screenRecordToggle.isOn = isOn;
			}
			this.m_recordIndicator.SetActive(isOn);
			this.m_recordTimerText.gameObject.SetActive(isOn);
			if (isOn)
			{
				this.m_recordTime = 0f;
				this.m_recordTimerText.text = this.FormatRecordTimeString(this.m_recordTime);
				this.StartRecord();
			}
			else
			{
				this.StopRecord();
			}
		}

		// Token: 0x0600D6C9 RID: 54985 RVA: 0x003A7E90 File Offset: 0x003A6090
		private string FormatRecordTimeString(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FormatRecordTimeStringSingle_hotfix != null)
			{
				return (string)this.m_FormatRecordTimeStringSingle_hotfix.call(new object[]
				{
					this,
					time
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return string.Format("{0}:{1}", (int)this.m_recordTime / 60, (int)this.m_recordTime % 60);
		}

		// Token: 0x0600D6CA RID: 54986 RVA: 0x003A7F34 File Offset: 0x003A6134
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
			if (this.m_screenRecordToggle.isOn)
			{
				this.m_recordTime += Time.deltaTime;
				if ((int)this.m_recordTime != (int)(this.m_recordTime - Time.deltaTime))
				{
					this.m_recordTimerText.text = this.FormatRecordTimeString(this.m_recordTime);
				}
			}
			this.UpdateScreenRecord();
		}

		// Token: 0x0600D6CB RID: 54987 RVA: 0x003A7FEC File Offset: 0x003A61EC
		public void OnBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBeginDragPointerEventData_hotfix != null)
			{
				this.m_OnBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetDraggedPosition(eventData);
		}

		// Token: 0x0600D6CC RID: 54988 RVA: 0x003A8064 File Offset: 0x003A6264
		public void OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDragPointerEventData_hotfix != null)
			{
				this.m_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetDraggedPosition(eventData);
		}

		// Token: 0x0600D6CD RID: 54989 RVA: 0x003A80DC File Offset: 0x003A62DC
		public void OnEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndDragPointerEventData_hotfix != null)
			{
				this.m_OnEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetDraggedPosition(eventData);
		}

		// Token: 0x0600D6CE RID: 54990 RVA: 0x003A8154 File Offset: 0x003A6354
		private void SetDraggedPosition(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDraggedPositionPointerEventData_hotfix != null)
			{
				this.m_SetDraggedPositionPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RectTransform component = base.gameObject.GetComponent<RectTransform>();
			Vector3 position;
			if (RectTransformUtility.ScreenPointToWorldPointInRectangle(component, eventData.position, eventData.pressEventCamera, out position))
			{
				component.position = position;
			}
		}

		// Token: 0x0600D6CF RID: 54991 RVA: 0x003A81F0 File Offset: 0x003A63F0
		private void StartRecord()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRecord_hotfix != null)
			{
				this.m_StartRecord_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600D6D0 RID: 54992 RVA: 0x003A8250 File Offset: 0x003A6450
		private void StopRecord()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopRecord_hotfix != null)
			{
				this.m_StopRecord_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600D6D1 RID: 54993 RVA: 0x003A82B0 File Offset: 0x003A64B0
		private void UpdateScreenRecord()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateScreenRecord_hotfix != null)
			{
				this.m_UpdateScreenRecord_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0600D6D2 RID: 54994 RVA: 0x003A8310 File Offset: 0x003A6510
		// (set) Token: 0x0600D6D3 RID: 54995 RVA: 0x003A8330 File Offset: 0x003A6530
		[DoNotToLua]
		public ScreenRecorderUI.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ScreenRecorderUI.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D6D4 RID: 54996 RVA: 0x003A833C File Offset: 0x003A653C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D6D5 RID: 54997 RVA: 0x003A8348 File Offset: 0x003A6548
		private UnityEngine.Object __callBase_GetAssetInContainer(string resName)
		{
			return base.GetAssetInContainer(resName);
		}

		// Token: 0x0600D6D6 RID: 54998 RVA: 0x003A8354 File Offset: 0x003A6554
		private void __callBase_BindResContainer()
		{
			base.BindResContainer();
		}

		// Token: 0x0600D6D7 RID: 54999 RVA: 0x003A835C File Offset: 0x003A655C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D6D8 RID: 55000 RVA: 0x003A8364 File Offset: 0x003A6564
		private PrefabControllerNextUpdateExecutor __callBase_GetNextUpdateExecutor()
		{
			return base.GetNextUpdateExecutor();
		}

		// Token: 0x0600D6D9 RID: 55001 RVA: 0x003A836C File Offset: 0x003A656C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D6DA RID: 55002 RVA: 0x003A8374 File Offset: 0x003A6574
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D6DB RID: 55003 RVA: 0x003A8388 File Offset: 0x003A6588
		private GameObject __callBase_GetChildByPath(string path)
		{
			return base.GetChildByPath(path);
		}

		// Token: 0x0600D6DC RID: 55004 RVA: 0x003A8394 File Offset: 0x003A6594
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
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_Awake_hotfix = (luaObj.RawGet("Awake") as LuaFunction);
					this.m_OnScreenRecordToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnScreenRecordToggleValueChanged") as LuaFunction);
					this.m_ToggleScreenRecordBoolean_hotfix = (luaObj.RawGet("ToggleScreenRecord") as LuaFunction);
					this.m_FormatRecordTimeStringSingle_hotfix = (luaObj.RawGet("FormatRecordTimeString") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_SetDraggedPositionPointerEventData_hotfix = (luaObj.RawGet("SetDraggedPosition") as LuaFunction);
					this.m_StartRecord_hotfix = (luaObj.RawGet("StartRecord") as LuaFunction);
					this.m_StopRecord_hotfix = (luaObj.RawGet("StopRecord") as LuaFunction);
					this.m_UpdateScreenRecord_hotfix = (luaObj.RawGet("UpdateScreenRecord") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D6DD RID: 55005 RVA: 0x003A858C File Offset: 0x003A678C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ScreenRecorderUI));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008440 RID: 33856
		private Toggle m_screenRecordToggle;

		// Token: 0x04008441 RID: 33857
		private GameObject m_recordIndicator;

		// Token: 0x04008442 RID: 33858
		private Text m_recordTimerText;

		// Token: 0x04008443 RID: 33859
		private float m_recordTime;

		// Token: 0x04008444 RID: 33860
		private bool m_isPreviewing;

		// Token: 0x04008445 RID: 33861
		[DoNotToLua]
		private ScreenRecorderUI.LuaExportHelper luaExportHelper;

		// Token: 0x04008446 RID: 33862
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008447 RID: 33863
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008448 RID: 33864
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04008449 RID: 33865
		private LuaFunction m_Awake_hotfix;

		// Token: 0x0400844A RID: 33866
		private LuaFunction m_OnScreenRecordToggleValueChangedBoolean_hotfix;

		// Token: 0x0400844B RID: 33867
		private LuaFunction m_ToggleScreenRecordBoolean_hotfix;

		// Token: 0x0400844C RID: 33868
		private LuaFunction m_FormatRecordTimeStringSingle_hotfix;

		// Token: 0x0400844D RID: 33869
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400844E RID: 33870
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x0400844F RID: 33871
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x04008450 RID: 33872
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x04008451 RID: 33873
		private LuaFunction m_SetDraggedPositionPointerEventData_hotfix;

		// Token: 0x04008452 RID: 33874
		private LuaFunction m_StartRecord_hotfix;

		// Token: 0x04008453 RID: 33875
		private LuaFunction m_StopRecord_hotfix;

		// Token: 0x04008454 RID: 33876
		private LuaFunction m_UpdateScreenRecord_hotfix;

		// Token: 0x02000BFE RID: 3070
		public class LuaExportHelper
		{
			// Token: 0x0600D6DE RID: 55006 RVA: 0x003A85F4 File Offset: 0x003A67F4
			public LuaExportHelper(ScreenRecorderUI owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D6DF RID: 55007 RVA: 0x003A8604 File Offset: 0x003A6804
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D6E0 RID: 55008 RVA: 0x003A8614 File Offset: 0x003A6814
			public UnityEngine.Object __callBase_GetAssetInContainer(string resName)
			{
				return this.m_owner.__callBase_GetAssetInContainer(resName);
			}

			// Token: 0x0600D6E1 RID: 55009 RVA: 0x003A8624 File Offset: 0x003A6824
			public void __callBase_BindResContainer()
			{
				this.m_owner.__callBase_BindResContainer();
			}

			// Token: 0x0600D6E2 RID: 55010 RVA: 0x003A8634 File Offset: 0x003A6834
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D6E3 RID: 55011 RVA: 0x003A8644 File Offset: 0x003A6844
			public PrefabControllerNextUpdateExecutor __callBase_GetNextUpdateExecutor()
			{
				return this.m_owner.__callBase_GetNextUpdateExecutor();
			}

			// Token: 0x0600D6E4 RID: 55012 RVA: 0x003A8654 File Offset: 0x003A6854
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D6E5 RID: 55013 RVA: 0x003A8664 File Offset: 0x003A6864
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D6E6 RID: 55014 RVA: 0x003A867C File Offset: 0x003A687C
			public GameObject __callBase_GetChildByPath(string path)
			{
				return this.m_owner.__callBase_GetChildByPath(path);
			}

			// Token: 0x170029E7 RID: 10727
			// (get) Token: 0x0600D6E7 RID: 55015 RVA: 0x003A868C File Offset: 0x003A688C
			// (set) Token: 0x0600D6E8 RID: 55016 RVA: 0x003A869C File Offset: 0x003A689C
			public Toggle m_screenRecordToggle
			{
				get
				{
					return this.m_owner.m_screenRecordToggle;
				}
				set
				{
					this.m_owner.m_screenRecordToggle = value;
				}
			}

			// Token: 0x170029E8 RID: 10728
			// (get) Token: 0x0600D6E9 RID: 55017 RVA: 0x003A86AC File Offset: 0x003A68AC
			// (set) Token: 0x0600D6EA RID: 55018 RVA: 0x003A86BC File Offset: 0x003A68BC
			public GameObject m_recordIndicator
			{
				get
				{
					return this.m_owner.m_recordIndicator;
				}
				set
				{
					this.m_owner.m_recordIndicator = value;
				}
			}

			// Token: 0x170029E9 RID: 10729
			// (get) Token: 0x0600D6EB RID: 55019 RVA: 0x003A86CC File Offset: 0x003A68CC
			// (set) Token: 0x0600D6EC RID: 55020 RVA: 0x003A86DC File Offset: 0x003A68DC
			public Text m_recordTimerText
			{
				get
				{
					return this.m_owner.m_recordTimerText;
				}
				set
				{
					this.m_owner.m_recordTimerText = value;
				}
			}

			// Token: 0x170029EA RID: 10730
			// (get) Token: 0x0600D6ED RID: 55021 RVA: 0x003A86EC File Offset: 0x003A68EC
			// (set) Token: 0x0600D6EE RID: 55022 RVA: 0x003A86FC File Offset: 0x003A68FC
			public float m_recordTime
			{
				get
				{
					return this.m_owner.m_recordTime;
				}
				set
				{
					this.m_owner.m_recordTime = value;
				}
			}

			// Token: 0x170029EB RID: 10731
			// (get) Token: 0x0600D6EF RID: 55023 RVA: 0x003A870C File Offset: 0x003A690C
			// (set) Token: 0x0600D6F0 RID: 55024 RVA: 0x003A871C File Offset: 0x003A691C
			public bool m_isPreviewing
			{
				get
				{
					return this.m_owner.m_isPreviewing;
				}
				set
				{
					this.m_owner.m_isPreviewing = value;
				}
			}

			// Token: 0x0600D6F1 RID: 55025 RVA: 0x003A872C File Offset: 0x003A692C
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600D6F2 RID: 55026 RVA: 0x003A873C File Offset: 0x003A693C
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x0600D6F3 RID: 55027 RVA: 0x003A874C File Offset: 0x003A694C
			public void ToggleScreenRecord(bool isOn)
			{
				this.m_owner.ToggleScreenRecord(isOn);
			}

			// Token: 0x0600D6F4 RID: 55028 RVA: 0x003A875C File Offset: 0x003A695C
			public string FormatRecordTimeString(float time)
			{
				return this.m_owner.FormatRecordTimeString(time);
			}

			// Token: 0x0600D6F5 RID: 55029 RVA: 0x003A876C File Offset: 0x003A696C
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600D6F6 RID: 55030 RVA: 0x003A877C File Offset: 0x003A697C
			public void SetDraggedPosition(PointerEventData eventData)
			{
				this.m_owner.SetDraggedPosition(eventData);
			}

			// Token: 0x0600D6F7 RID: 55031 RVA: 0x003A878C File Offset: 0x003A698C
			public void StartRecord()
			{
				this.m_owner.StartRecord();
			}

			// Token: 0x0600D6F8 RID: 55032 RVA: 0x003A879C File Offset: 0x003A699C
			public void StopRecord()
			{
				this.m_owner.StopRecord();
			}

			// Token: 0x0600D6F9 RID: 55033 RVA: 0x003A87AC File Offset: 0x003A69AC
			public void UpdateScreenRecord()
			{
				this.m_owner.UpdateScreenRecord();
			}

			// Token: 0x04008455 RID: 33877
			private ScreenRecorderUI m_owner;
		}
	}
}
