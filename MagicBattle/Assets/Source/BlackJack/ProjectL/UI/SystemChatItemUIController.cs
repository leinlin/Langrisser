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
	// Token: 0x02000B4A RID: 2890
	[HotFix]
	public class SystemChatItemUIController : UIControllerBase
	{
		// Token: 0x0600C49B RID: 50331 RVA: 0x00366CE0 File Offset: 0x00364EE0
		public void UpdateChatInfo(ChatComponent.ChatMessageClient chatInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChatInfoChatMessageClient_hotfix != null)
			{
				this.m_UpdateChatInfoChatMessageClient_hotfix.call(new object[]
				{
					this,
					chatInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			if (chatInfo.ChatMessageInfo.ChatContentType == ChatContentType.Text)
			{
				ChatTextMessage chatTextMessage = chatInfo.ChatMessageInfo as ChatTextMessage;
				this.ContentText.text = chatTextMessage.Text;
			}
			else if (chatInfo.ChatMessageInfo.ChatContentType == ChatContentType.EnterRoomInfo)
			{
				ChatEnterRoomMessage chatEnterRoomMessage = chatInfo.ChatMessageInfo as ChatEnterRoomMessage;
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				this.ContentText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_EnterWorldRoom), chatEnterRoomMessage.RoomId + 1, this.FakePlayerCount(chatEnterRoomMessage.PlayerCount));
			}
		}

		// Token: 0x0600C49C RID: 50332 RVA: 0x00366DF4 File Offset: 0x00364FF4
		private int FakePlayerCount(int trueCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FakePlayerCountInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_FakePlayerCountInt32_hotfix.call(new object[]
				{
					this,
					trueCount
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return trueCount;
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x0600C49D RID: 50333 RVA: 0x00366E74 File Offset: 0x00365074
		// (set) Token: 0x0600C49E RID: 50334 RVA: 0x00366E94 File Offset: 0x00365094
		[DoNotToLua]
		public new SystemChatItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SystemChatItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C49F RID: 50335 RVA: 0x00366EA0 File Offset: 0x003650A0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x00366EAC File Offset: 0x003650AC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x00366EB4 File Offset: 0x003650B4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C4A2 RID: 50338 RVA: 0x00366EBC File Offset: 0x003650BC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C4A3 RID: 50339 RVA: 0x00366ED0 File Offset: 0x003650D0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C4A4 RID: 50340 RVA: 0x00366ED8 File Offset: 0x003650D8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C4A5 RID: 50341 RVA: 0x00366EE4 File Offset: 0x003650E4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C4A6 RID: 50342 RVA: 0x00366EF0 File Offset: 0x003650F0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x00366EFC File Offset: 0x003650FC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C4A8 RID: 50344 RVA: 0x00366F08 File Offset: 0x00365108
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C4A9 RID: 50345 RVA: 0x00366F14 File Offset: 0x00365114
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C4AA RID: 50346 RVA: 0x00366F20 File Offset: 0x00365120
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C4AB RID: 50347 RVA: 0x00366F2C File Offset: 0x0036512C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x00366F38 File Offset: 0x00365138
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x00366F44 File Offset: 0x00365144
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x00366F4C File Offset: 0x0036514C
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
					this.m_UpdateChatInfoChatMessageClient_hotfix = (luaObj.RawGet("UpdateChatInfo") as LuaFunction);
					this.m_FakePlayerCountInt32_hotfix = (luaObj.RawGet("FakePlayerCount") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x00367030 File Offset: 0x00365230
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SystemChatItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007C88 RID: 31880
		[AutoBind("./BgImage/Text", AutoBindAttribute.InitState.NotInit, false)]
		public Text ContentText;

		// Token: 0x04007C89 RID: 31881
		[DoNotToLua]
		private SystemChatItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007C8A RID: 31882
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007C8B RID: 31883
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007C8C RID: 31884
		private LuaFunction m_UpdateChatInfoChatMessageClient_hotfix;

		// Token: 0x04007C8D RID: 31885
		private LuaFunction m_FakePlayerCountInt32_hotfix;

		// Token: 0x02000B4B RID: 2891
		public new class LuaExportHelper
		{
			// Token: 0x0600C4B0 RID: 50352 RVA: 0x00367098 File Offset: 0x00365298
			public LuaExportHelper(SystemChatItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C4B1 RID: 50353 RVA: 0x003670A8 File Offset: 0x003652A8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C4B2 RID: 50354 RVA: 0x003670B8 File Offset: 0x003652B8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C4B3 RID: 50355 RVA: 0x003670C8 File Offset: 0x003652C8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C4B4 RID: 50356 RVA: 0x003670D8 File Offset: 0x003652D8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C4B5 RID: 50357 RVA: 0x003670F0 File Offset: 0x003652F0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C4B6 RID: 50358 RVA: 0x00367100 File Offset: 0x00365300
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C4B7 RID: 50359 RVA: 0x00367110 File Offset: 0x00365310
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C4B8 RID: 50360 RVA: 0x00367120 File Offset: 0x00365320
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C4B9 RID: 50361 RVA: 0x00367130 File Offset: 0x00365330
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C4BA RID: 50362 RVA: 0x00367140 File Offset: 0x00365340
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C4BB RID: 50363 RVA: 0x00367150 File Offset: 0x00365350
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C4BC RID: 50364 RVA: 0x00367160 File Offset: 0x00365360
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C4BD RID: 50365 RVA: 0x00367170 File Offset: 0x00365370
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C4BE RID: 50366 RVA: 0x00367180 File Offset: 0x00365380
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C4BF RID: 50367 RVA: 0x00367190 File Offset: 0x00365390
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C4C0 RID: 50368 RVA: 0x003671A0 File Offset: 0x003653A0
			public int FakePlayerCount(int trueCount)
			{
				return this.m_owner.FakePlayerCount(trueCount);
			}

			// Token: 0x04007C8E RID: 31886
			private SystemChatItemUIController m_owner;
		}
	}
}
