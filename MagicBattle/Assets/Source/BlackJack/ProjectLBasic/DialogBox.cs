using System;
using System.Collections;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectLBasic
{
	// Token: 0x020010B2 RID: 4274
	[CustomLuaClass]
	public class DialogBox : MonoBehaviour
	{
		// Token: 0x06015896 RID: 88214 RVA: 0x0057C378 File Offset: 0x0057A578
		public static IEnumerator Show(GameObject parentObj, string prefabPath, string msgText, string okText, string cancelText, Action<DialogBoxResult> onClose)
		{
			GameObject dlgObj = null;
			yield return ResourceManager.Instance.LoadAsset<GameObject>(prefabPath, delegate(string path, GameObject obj)
			{
				dlgObj = UnityEngine.Object.Instantiate<GameObject>(obj);
			}, false, false);
			dlgObj.transform.SetParent(parentObj.transform, false);
			DialogBox dlg = dlgObj.AddComponent<DialogBox>();
			dlg.Initialize();
			bool isClose = false;
			DialogBoxResult result = DialogBoxResult.None;
			dlg.Show(msgText, okText, cancelText, delegate(DialogBoxResult ret)
			{
				isClose = true;
				result = ret;
			});
			yield return new WaitUntil(() => isClose);
			dlgObj.transform.SetParent(null);
			UnityEngine.Object.Destroy(dlgObj);
			if (onClose != null)
			{
				onClose(result);
			}
			yield break;
		}

		// Token: 0x06015897 RID: 88215 RVA: 0x0057C3B8 File Offset: 0x0057A5B8
		public void Show(string msgText, string okText, string cancelText, Action<DialogBoxResult> callback)
		{
			if (this.m_uiStateController == null)
			{
				this.Initialize();
			}
			this.m_msgText.text = msgText;
			this.m_okButtonText.text = okText;
			if (cancelText.Length == 0)
			{
				this.m_panelUIStateController.SetToUIState("OneButton", false, true);
			}
			else
			{
				this.m_panelUIStateController.SetToUIState("TwoButton", false, true);
				this.m_cancelButtonText.text = cancelText;
			}
			this.m_callback = callback;
			Utility.SetUIStateOpen(this.m_uiStateController, "Open", null, null, true);
		}

		// Token: 0x06015898 RID: 88216 RVA: 0x0057C450 File Offset: 0x0057A650
		public void Initialize()
		{
			base.gameObject.SetActive(false);
			this.m_uiStateController = base.gameObject.GetComponent<CommonUIStateController>();
			this.m_panelUIStateController = Utility.FindChildComponent<CommonUIStateController>(base.gameObject, "Panel", true);
			this.m_msgText = Utility.FindChildComponent<Text>(base.gameObject, "Panel/FrameImage/Text", true);
			this.m_okButton = Utility.FindChildComponent<Button>(base.gameObject, "Panel/FrameImage/ButtonGroup/OkButton", true);
			this.m_okButtonText = Utility.FindChildComponent<Text>(base.gameObject, "Panel/FrameImage/ButtonGroup/OkButton/Text", true);
			this.m_cancelButton = Utility.FindChildComponent<Button>(base.gameObject, "Panel/FrameImage/ButtonGroup/CancelButton", true);
			this.m_cancelButtonText = Utility.FindChildComponent<Text>(base.gameObject, "Panel/FrameImage/ButtonGroup/CancelButton/Text", true);
			this.m_backgroundGameObject = Utility.FindChildGameObject(base.gameObject, "Background", true);
			this.m_okButton.onClick.AddListener(new UnityAction(this.OnOK));
			this.m_cancelButton.onClick.AddListener(new UnityAction(this.OnCancel));
			this.m_backgroundGameObject.SetActive(true);
		}

		// Token: 0x06015899 RID: 88217 RVA: 0x0057C560 File Offset: 0x0057A760
		public bool Cancel()
		{
			if (this.m_uiStateController == null)
			{
				return false;
			}
			UIStateDesc currentUIState = this.m_uiStateController.GetCurrentUIState();
			if (currentUIState == null || currentUIState.StateName != "Open")
			{
				return false;
			}
			this.OnCancel();
			return true;
		}

		// Token: 0x0601589A RID: 88218 RVA: 0x0057C5B0 File Offset: 0x0057A7B0
		private void OnCancel()
		{
			this.OnClose(DialogBoxResult.Cancel);
		}

		// Token: 0x0601589B RID: 88219 RVA: 0x0057C5BC File Offset: 0x0057A7BC
		private void OnOK()
		{
			this.OnClose(DialogBoxResult.Ok);
		}

		// Token: 0x0601589C RID: 88220 RVA: 0x0057C5C8 File Offset: 0x0057A7C8
		private void OnClose(DialogBoxResult ret)
		{
			this.m_msgText.text = string.Empty;
			this.m_okButtonText.text = string.Empty;
			this.m_cancelButtonText.text = string.Empty;
			this.m_ret = ret;
			Utility.SetUIStateClose(this.m_uiStateController, "Close", new Action(this.OnCloseAnimationFinished), null, true);
		}

		// Token: 0x0601589D RID: 88221 RVA: 0x0057C62C File Offset: 0x0057A82C
		private void OnCloseAnimationFinished()
		{
			base.gameObject.SetActive(false);
			this.m_callback(this.m_ret);
			this.m_callback = null;
		}

		// Token: 0x0400BC49 RID: 48201
		private Action<DialogBoxResult> m_callback;

		// Token: 0x0400BC4A RID: 48202
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400BC4B RID: 48203
		private CommonUIStateController m_panelUIStateController;

		// Token: 0x0400BC4C RID: 48204
		private Text m_msgText;

		// Token: 0x0400BC4D RID: 48205
		private Button m_okButton;

		// Token: 0x0400BC4E RID: 48206
		private Text m_okButtonText;

		// Token: 0x0400BC4F RID: 48207
		private Button m_cancelButton;

		// Token: 0x0400BC50 RID: 48208
		private Text m_cancelButtonText;

		// Token: 0x0400BC51 RID: 48209
		private GameObject m_backgroundGameObject;

		// Token: 0x0400BC52 RID: 48210
		private DialogBoxResult m_ret;
	}
}
