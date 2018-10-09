using System;
using UnityEngine;

// Token: 0x0200107C RID: 4220
public class DebugConsoleCtrl
{
	// Token: 0x060155D4 RID: 87508 RVA: 0x0056B6AC File Offset: 0x005698AC
	private DebugConsoleCtrl()
	{
	}

	// Token: 0x060155D5 RID: 87509 RVA: 0x0056B6B4 File Offset: 0x005698B4
	public static DebugConsoleCtrl Create(DebugConsoleView consoleView, DebugConsoleMode consoleMode)
	{
		DebugConsoleCtrl debugConsoleCtrl = new DebugConsoleCtrl();
		debugConsoleCtrl._Init(consoleView, consoleMode);
		return debugConsoleCtrl;
	}

	// Token: 0x060155D6 RID: 87510 RVA: 0x0056B6D0 File Offset: 0x005698D0
	private void _Init(DebugConsoleView consoleView, DebugConsoleMode consoleMode)
	{
		this._consoleView = consoleView;
		this._consoleMode = consoleMode;
		this._consoleView.OnKeyDown += this._ConsoleView_OnKeyDown;
		this._consoleView.OnKeyUp += this._ConsoleView_OnKeyUp;
		this._consoleView.OnOKButtonClick = new Action(this._ConsoleView_OnBtnOKClick);
		this._consoleView.OnCloseButtonClick = new Action(this._ConsoleView_OnBtnCloseClick);
		this._consoleMode.refreshEvent += this._ConsoleModeLogRefresh;
	}

	// Token: 0x060155D7 RID: 87511 RVA: 0x0056B760 File Offset: 0x00569960
	private void _ConsoleView_OnKeyUp(object sender, KeyUpEventArgs e)
	{
	}

	// Token: 0x060155D8 RID: 87512 RVA: 0x0056B764 File Offset: 0x00569964
	private void _ConsoleView_OnKeyDown(object sender, KeyDownEventArgs e)
	{
		if (e.KeyCode == KeyCode.Return)
		{
			this._ProcessCmd();
		}
		else if (e.KeyCode == KeyCode.UpArrow)
		{
			this._consoleView.ShowPreviousCommand();
		}
		else if (e.KeyCode == KeyCode.DownArrow)
		{
			this._consoleView.ShowNextCommand();
		}
	}

	// Token: 0x060155D9 RID: 87513 RVA: 0x0056B7C4 File Offset: 0x005699C4
	private void _ConsoleView_OnBtnCloseClick()
	{
		if (this._consoleView != null)
		{
			this._consoleView.IsSwitchOn = false;
		}
	}

	// Token: 0x060155DA RID: 87514 RVA: 0x0056B7E0 File Offset: 0x005699E0
	private void _ConsoleView_OnBtnOKClick()
	{
		this._ProcessCmd();
	}

	// Token: 0x060155DB RID: 87515 RVA: 0x0056B7E8 File Offset: 0x005699E8
	private void _ProcessCmd()
	{
		global::Debug.Log(this._consoleView.InstructionText);
		this._consoleMode.ProcessCmd(this._consoleView.InstructionText);
		this._consoleView.InstructionText = string.Empty;
	}

	// Token: 0x060155DC RID: 87516 RVA: 0x0056B820 File Offset: 0x00569A20
	private void _ConsoleModeLogRefresh()
	{
		this._consoleView.LogText = this._consoleMode.GetLogText();
	}

	// Token: 0x0400BA47 RID: 47687
	private DebugConsoleView _consoleView;

	// Token: 0x0400BA48 RID: 47688
	private DebugConsoleMode _consoleMode;
}
