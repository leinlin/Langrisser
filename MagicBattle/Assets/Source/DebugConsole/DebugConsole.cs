using System;
using UnityEngine;

namespace DebugConsole
{
	// Token: 0x0200107B RID: 4219
	public class DebugConsole : MonoBehaviour
	{
		// Token: 0x060155CD RID: 87501 RVA: 0x0056B630 File Offset: 0x00569830
		private static void LogPlatformDefine()
		{
			global::Debug.Log(string.Format("Application.platform = {0}", Application.platform));
			global::Debug.Log("UNITY_STANDALONE define.");
		}

		// Token: 0x060155CE RID: 87502 RVA: 0x0056B658 File Offset: 0x00569858
		private void Awake()
		{
			DebugConsole.instance = this;
			this.Init();
		}

		// Token: 0x060155CF RID: 87503 RVA: 0x0056B668 File Offset: 0x00569868
		private void Start()
		{
			DebugConsole.LogPlatformDefine();
		}

		// Token: 0x060155D0 RID: 87504 RVA: 0x0056B670 File Offset: 0x00569870
		public void Init()
		{
			this._consoleView = DebugConsoleView.Create();
			DebugConsoleCtrl.Create(this._consoleView, DebugConsoleMode.Create());
		}

		// Token: 0x060155D1 RID: 87505 RVA: 0x0056B690 File Offset: 0x00569890
		protected void OnGUI()
		{
			this._consoleView.Show();
		}

		// Token: 0x060155D2 RID: 87506 RVA: 0x0056B6A0 File Offset: 0x005698A0
		private void OnDestroy()
		{
			DebugConsole.instance = null;
		}

		// Token: 0x0400BA45 RID: 47685
		private DebugConsoleView _consoleView;

		// Token: 0x0400BA46 RID: 47686
		public static DebugConsole instance;
	}
}
