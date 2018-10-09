using System;
using System.Diagnostics;
using System.IO;
using BlackJack.ProjectLBasic;
using UnityEngine;

// Token: 0x02001080 RID: 4224
public class DebugConsoleView
{
	// Token: 0x060155F2 RID: 87538 RVA: 0x0056BDC0 File Offset: 0x00569FC0
	private DebugConsoleView()
	{
		DebugConsoleView._instance = this;
	}

	// Token: 0x140004CE RID: 1230
	// (add) Token: 0x060155F3 RID: 87539 RVA: 0x0056BE1C File Offset: 0x0056A01C
	// (remove) Token: 0x060155F4 RID: 87540 RVA: 0x0056BE54 File Offset: 0x0056A054
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event EventHandler<KeyDownEventArgs> OnKeyDown;

	// Token: 0x140004CF RID: 1231
	// (add) Token: 0x060155F5 RID: 87541 RVA: 0x0056BE8C File Offset: 0x0056A08C
	// (remove) Token: 0x060155F6 RID: 87542 RVA: 0x0056BEC4 File Offset: 0x0056A0C4
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event EventHandler<KeyUpEventArgs> OnKeyUp;

	// Token: 0x17003E59 RID: 15961
	// (get) Token: 0x060155F7 RID: 87543 RVA: 0x0056BEFC File Offset: 0x0056A0FC
	// (set) Token: 0x060155F8 RID: 87544 RVA: 0x0056BF04 File Offset: 0x0056A104
	public bool IsForceHide
	{
		get
		{
			return this.m_isForceHide;
		}
		set
		{
			if (this.m_isForceHide == value)
			{
				return;
			}
			this.m_isForceHide = value;
			if (this.m_isForceHide)
			{
				this.IsSwitchOn = false;
			}
		}
	}

	// Token: 0x17003E5A RID: 15962
	// (get) Token: 0x060155FA RID: 87546 RVA: 0x0056BF5C File Offset: 0x0056A15C
	// (set) Token: 0x060155F9 RID: 87545 RVA: 0x0056BF2C File Offset: 0x0056A12C
	public bool IsSwitchOn
	{
		get
		{
			return this._isSwitchOn;
		}
		set
		{
			if (this.IsForceHide && value)
			{
				return;
			}
			if (this._isSwitchOn == value)
			{
				return;
			}
			this._isSwitchOn = value;
			this.SaveData();
		}
	}

	// Token: 0x17003E5B RID: 15963
	// (get) Token: 0x060155FC RID: 87548 RVA: 0x0056BF90 File Offset: 0x0056A190
	// (set) Token: 0x060155FB RID: 87547 RVA: 0x0056BF64 File Offset: 0x0056A164
	private bool IsAutoScrollView
	{
		get
		{
			return this._isAutoScrollView;
		}
		set
		{
			if (this._isAutoScrollView == value)
			{
				return;
			}
			this._isAutoScrollView = value;
			global::Debug.Log(string.Format("Debug console AutoScroll: {0}", value));
		}
	}

	// Token: 0x060155FD RID: 87549 RVA: 0x0056BF98 File Offset: 0x0056A198
	public static DebugConsoleView Create()
	{
		DebugConsoleView debugConsoleView = new DebugConsoleView();
		debugConsoleView._Init();
		return debugConsoleView;
	}

	// Token: 0x060155FE RID: 87550 RVA: 0x0056BFB4 File Offset: 0x0056A1B4
	private void _Init()
	{
		this.LoadData();
	}

	// Token: 0x060155FF RID: 87551 RVA: 0x0056BFBC File Offset: 0x0056A1BC
	public void Show()
	{
		if (this.m_labelStyle == null)
		{
			this.m_labelStyle = new GUIStyle(GUI.skin.label);
			this.m_labelStyle.fontSize = (int)(Screen.dpi * 0.14f);
		}
		if (this.m_textfieldStyle == null)
		{
			this.m_textfieldStyle = new GUIStyle(GUI.skin.textField);
			this.m_textfieldStyle.fontSize = (int)(Screen.dpi * 0.14f);
		}
		int width = Screen.width;
		int height = Screen.height;
		this._consoleWidth = width / 2 - 20;
		this._consoleHeight = height / 2;
		if (this._preViewWidth == -1 || this._preViewWidth != width || this._preViewHeight == -1 || this._preViewHeight != height)
		{
			this._windowRect = new Rect(5f, 5f, (float)this._consoleWidth, (float)this._consoleHeight);
			this._preViewWidth = width;
			this._preViewHeight = height;
		}
		this._ShowConsole(5, 5, this._consoleWidth, this._consoleHeight);
		this._ShowSwitchInput();
	}

	// Token: 0x06015600 RID: 87552 RVA: 0x0056C0D4 File Offset: 0x0056A2D4
	private void _ShowSwitchInput()
	{
		bool flag = Input.GetMouseButton(0) && Input.GetMouseButton(1);
		if (flag)
		{
			this._leftAndRightButtonDownTime += Time.deltaTime;
		}
		else
		{
			this._leftAndRightButtonDownTime = 0f;
		}
		if (this._leftAndRightButtonDownTime > 2f && this._leftAndRightButtonDownTime - Time.deltaTime < 2f)
		{
			this.IsSwitchOn = !this.IsSwitchOn;
		}
		LeftMouseButtonTapCount.Update();
		if (this.IsSwitchOn && LeftMouseButtonTapCount.Count == 3)
		{
			this.IsAutoScrollView = !this.IsAutoScrollView;
		}
	}

	// Token: 0x06015601 RID: 87553 RVA: 0x0056C180 File Offset: 0x0056A380
	private void _ShowSwitchTouch()
	{
		if (Input.touchCount == 5)
		{
			this._fiveFingersDownTime += Time.deltaTime;
		}
		else
		{
			this._fiveFingersDownTime = 0f;
		}
		if (this.IsSwitchOn && Input.touchCount > 0 && Input.touches[0].tapCount > this._lastFrameTouchTapCount && Input.touches[0].tapCount == 3)
		{
			this.IsAutoScrollView = !this.IsAutoScrollView;
		}
		if (this._fiveFingersDownTime > 2f && this._fiveFingersDownTime - Time.deltaTime < 2f)
		{
			this.IsSwitchOn = !this.IsSwitchOn;
			if (!this.IsSwitchOn)
			{
				DebugConsoleMode.instance.ProcessCmd("Save");
			}
		}
		if (Input.touchCount > 0)
		{
			this._lastFrameTouchTapCount = Input.touches[0].tapCount;
		}
		if (this.IsSwitchOn)
		{
			TwoFingersMoveEvent.Update();
			if (TwoFingersMoveEvent.Up)
			{
				this.ShowPreviousCommand();
			}
			else if (TwoFingersMoveEvent.Down)
			{
				this.ShowNextCommand();
			}
		}
	}

	// Token: 0x06015602 RID: 87554 RVA: 0x0056C2B8 File Offset: 0x0056A4B8
	private void _ShowConsole(int x, int y, int width, int height)
	{
		if (this.IsSwitchOn)
		{
			this._windowRect = GUILayout.Window(0, this._windowRect, new GUI.WindowFunction(this._WindowFunction), "Console Window", new GUILayoutOption[0]);
		}
		else
		{
			this._ConsoleInputFieldFocusIsSet = false;
		}
	}

	// Token: 0x06015603 RID: 87555 RVA: 0x0056C308 File Offset: 0x0056A508
	private Rect _ComputeSwitchBtnRect(int viewWidth, int viewHeight)
	{
		int num = 5;
		int num2 = viewHeight / 2 + 5;
		return new Rect((float)num, (float)num2, 30f, 30f);
	}

	// Token: 0x06015604 RID: 87556 RVA: 0x0056C330 File Offset: 0x0056A530
	private string _GetSwitchButtonText()
	{
		string result = string.Empty;
		if (!this.IsSwitchOn)
		{
			result = "O";
		}
		else if (this.IsSwitchOn)
		{
			result = "|";
		}
		return result;
	}

	// Token: 0x06015605 RID: 87557 RVA: 0x0056C36C File Offset: 0x0056A56C
	private void _ProcessKeyboard()
	{
		if (Event.current != null && Event.current.isKey)
		{
			if (Event.current.rawType == EventType.KeyDown)
			{
				KeyDownEventArgs e = new KeyDownEventArgs(Event.current.keyCode);
				if (this.OnKeyDown != null)
				{
					this.OnKeyDown(this, e);
				}
			}
			else if (Event.current.rawType == EventType.KeyUp)
			{
				KeyUpEventArgs e2 = new KeyUpEventArgs(Event.current.keyCode);
				if (this.OnKeyUp != null)
				{
					this.OnKeyUp(this, e2);
				}
			}
		}
	}

	// Token: 0x06015606 RID: 87558 RVA: 0x0056C408 File Offset: 0x0056A608
	private void _WindowFunction(int id)
	{
		this._DrawMainConsoleCtrl();
		GUI.DragWindow(new Rect(0f, 0f, this._windowRect.width, 20f));
	}

	// Token: 0x06015607 RID: 87559 RVA: 0x0056C434 File Offset: 0x0056A634
	private void _DrawMainConsoleCtrl()
	{
		this._ProcessKeyboard();
		GUILayout.BeginVertical(new GUILayoutOption[0]);
		this._DrawInputBox_And_OKButton();
		this._DrawOutputArea();
		GUILayout.EndVertical();
	}

	// Token: 0x06015608 RID: 87560 RVA: 0x0056C458 File Offset: 0x0056A658
	private void _DrawInputBox_And_OKButton()
	{
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this._DrawCloseButton();
		this._DrawInputBox();
		this._DrawOKButton();
		GUILayout.EndHorizontal();
		if (!this._ConsoleInputFieldFocusIsSet)
		{
			GUI.FocusControl("ConsoleInputField");
			this._ConsoleInputFieldFocusIsSet = true;
		}
	}

	// Token: 0x06015609 RID: 87561 RVA: 0x0056C498 File Offset: 0x0056A698
	private void _DrawInputBox()
	{
		int num = this._consoleWidth - 50;
		GUI.SetNextControlName("ConsoleInputField");
		this._instructionText = GUILayout.TextField(this._instructionText, this.m_textfieldStyle, new GUILayoutOption[]
		{
			GUILayout.Width((float)num),
			GUILayout.Height(Math.Max(22f, Screen.dpi * 0.15f))
		});
	}

	// Token: 0x0601560A RID: 87562 RVA: 0x0056C500 File Offset: 0x0056A700
	private void _DrawOKButton()
	{
		if (GUILayout.Button("OK", new GUILayoutOption[]
		{
			GUILayout.Width(Math.Max(32f, Screen.dpi * 0.2f)),
			GUILayout.Height(Math.Max(22f, Screen.dpi * 0.15f))
		}) && this.OnOKButtonClick != null)
		{
			this.OnOKButtonClick();
		}
	}

	// Token: 0x0601560B RID: 87563 RVA: 0x0056C574 File Offset: 0x0056A774
	private void _DrawCloseButton()
	{
		if (GUILayout.Button("X", new GUILayoutOption[]
		{
			GUILayout.Width(Math.Max(22f, Screen.dpi * 0.15f)),
			GUILayout.Height(Math.Max(22f, Screen.dpi * 0.15f))
		}) && this.OnCloseButtonClick != null)
		{
			this.OnCloseButtonClick();
		}
	}

	// Token: 0x0601560C RID: 87564 RVA: 0x0056C5E8 File Offset: 0x0056A7E8
	private void _DrawOutputArea()
	{
		if (this.IsAutoScrollView)
		{
			this._outputScrollViewVector.y = float.MaxValue;
		}
		GUI.skin.verticalScrollbar.fixedWidth = Screen.dpi * 0.1f;
		GUI.skin.verticalScrollbarThumb.fixedWidth = GUI.skin.verticalScrollbar.fixedWidth;
		this._outputScrollViewVector = GUILayout.BeginScrollView(this._outputScrollViewVector, false, true, new GUILayoutOption[0]);
		GUILayout.Label(this._logText, this.m_labelStyle, new GUILayoutOption[0]);
		GUILayout.EndScrollView();
		GUILayout.Label(string.Format("FPS: {0:D3}    MEM: {1:D4} MB    MAX_MEM: {2:D4} MB", (int)this._fps, (int)this._allocatedMemorySize, (int)this._maxAllocatedMemorySize), this.m_labelStyle, new GUILayoutOption[0]);
		if (Time.time > this._nextUpdateFPSTime)
		{
			this._fps = 1f / Time.deltaTime;
			this._allocatedMemorySize = (float)((double)Utility.GetRuntimeMemorySize() * 9.536743164E-07);
			this._maxAllocatedMemorySize = Math.Max(this._maxAllocatedMemorySize, this._allocatedMemorySize);
			this._nextUpdateFPSTime = Time.time + 1f;
		}
	}

	// Token: 0x17003E5C RID: 15964
	// (set) Token: 0x0601560D RID: 87565 RVA: 0x0056C71C File Offset: 0x0056A91C
	public string LogText
	{
		set
		{
			this._logText = value;
		}
	}

	// Token: 0x17003E5D RID: 15965
	// (get) Token: 0x0601560E RID: 87566 RVA: 0x0056C728 File Offset: 0x0056A928
	// (set) Token: 0x0601560F RID: 87567 RVA: 0x0056C730 File Offset: 0x0056A930
	public string InstructionText
	{
		get
		{
			return this._instructionText;
		}
		set
		{
			this._instructionText = value;
		}
	}

	// Token: 0x06015610 RID: 87568 RVA: 0x0056C73C File Offset: 0x0056A93C
	public void SetFontSize(int size)
	{
		if (this.m_labelStyle == null)
		{
			return;
		}
		this.m_labelStyle.fontSize = size;
	}

	// Token: 0x17003E5E RID: 15966
	// (get) Token: 0x06015611 RID: 87569 RVA: 0x0056C758 File Offset: 0x0056A958
	public static DebugConsoleView instance
	{
		get
		{
			return DebugConsoleView._instance;
		}
	}

	// Token: 0x06015612 RID: 87570 RVA: 0x0056C760 File Offset: 0x0056A960
	public void ShowNextCommand()
	{
		this._instructionText = DebugCmdManager.instance.GetNextOldCommand();
	}

	// Token: 0x06015613 RID: 87571 RVA: 0x0056C774 File Offset: 0x0056A974
	public void ShowPreviousCommand()
	{
		this._instructionText = DebugCmdManager.instance.GetPreviousOldCommand();
	}

	// Token: 0x06015614 RID: 87572 RVA: 0x0056C788 File Offset: 0x0056A988
	private void SaveData()
	{
		try
		{
			string path = string.Format("{0}{1}DebugConsoleView.txt", Application.persistentDataPath, Path.AltDirectorySeparatorChar);
			StreamWriter streamWriter = new StreamWriter(path);
			streamWriter.WriteLine(this.IsSwitchOn);
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			global::Debug.LogError(string.Format("DebugConsoleView.SaveData exception={0}", ex.Message));
		}
	}

	// Token: 0x06015615 RID: 87573 RVA: 0x0056C7F8 File Offset: 0x0056A9F8
	private void LoadData()
	{
		string text = string.Format("{0}{1}DebugConsoleView.txt", Application.persistentDataPath, Path.AltDirectorySeparatorChar);
		try
		{
			if (File.Exists(text))
			{
				StreamReader streamReader = new StreamReader(text);
				this.IsSwitchOn = bool.Parse(streamReader.ReadLine());
				streamReader.Close();
			}
		}
		catch (FileNotFoundException)
		{
			global::Debug.LogError(string.Format("DebugConsoleView.LoadData [{0}] not found.", text));
		}
		catch (FileLoadException)
		{
			global::Debug.LogError(string.Format("DebugConsoleView.LoadDataFailed to load [{0}].", text));
		}
		catch (Exception ex)
		{
			global::Debug.LogError(string.Format("DebugConsoleView.LoadData exception={0}", ex.Message));
		}
	}

	// Token: 0x0400BA55 RID: 47701
	public Action OnOKButtonClick;

	// Token: 0x0400BA56 RID: 47702
	public Action OnCloseButtonClick;

	// Token: 0x0400BA57 RID: 47703
	private const int CONSOLE_MARGIN_X = 5;

	// Token: 0x0400BA58 RID: 47704
	private const int CONSOLE_MARGIN_Y = 5;

	// Token: 0x0400BA59 RID: 47705
	private const int SWITCHBTN_MARGIN_X = 5;

	// Token: 0x0400BA5A RID: 47706
	private const int SWITCHBTN_MARGIN_Y = 5;

	// Token: 0x0400BA5B RID: 47707
	private const int SWITCHBTN_WIDTH = 30;

	// Token: 0x0400BA5C RID: 47708
	private const int SWITCHBTN_HEIGHT = 30;

	// Token: 0x0400BA5D RID: 47709
	private int _lastFrameTouchTapCount;

	// Token: 0x0400BA5E RID: 47710
	private const string CONSOLE_INPUTFIELD_NAME = "ConsoleInputField";

	// Token: 0x0400BA5F RID: 47711
	private bool _ConsoleInputFieldFocusIsSet;

	// Token: 0x0400BA60 RID: 47712
	private const int OKBUTTON_SIZE = 50;

	// Token: 0x0400BA61 RID: 47713
	private int _consoleWidth;

	// Token: 0x0400BA62 RID: 47714
	private int _consoleHeight;

	// Token: 0x0400BA63 RID: 47715
	private int _preViewWidth = -1;

	// Token: 0x0400BA64 RID: 47716
	private int _preViewHeight = -1;

	// Token: 0x0400BA65 RID: 47717
	private Rect _windowRect;

	// Token: 0x0400BA66 RID: 47718
	private string _instructionText = string.Empty;

	// Token: 0x0400BA67 RID: 47719
	private Vector2 _outputScrollViewVector = Vector2.zero;

	// Token: 0x0400BA68 RID: 47720
	private string _logText = string.Empty;

	// Token: 0x0400BA69 RID: 47721
	private bool _isSwitchOn;

	// Token: 0x0400BA6A RID: 47722
	private bool _isAutoScrollView = true;

	// Token: 0x0400BA6B RID: 47723
	private bool m_isForceHide;

	// Token: 0x0400BA6C RID: 47724
	private static DebugConsoleView _instance;

	// Token: 0x0400BA6D RID: 47725
	private float _leftAndRightButtonDownTime;

	// Token: 0x0400BA6E RID: 47726
	private float _fiveFingersDownTime;

	// Token: 0x0400BA6F RID: 47727
	private float _nextUpdateFPSTime;

	// Token: 0x0400BA70 RID: 47728
	private float _fps = 60f;

	// Token: 0x0400BA71 RID: 47729
	private float _allocatedMemorySize;

	// Token: 0x0400BA72 RID: 47730
	private float _maxAllocatedMemorySize;

	// Token: 0x0400BA73 RID: 47731
	private GUIStyle m_labelStyle;

	// Token: 0x0400BA74 RID: 47732
	private GUIStyle m_textfieldStyle;

	// Token: 0x0400BA75 RID: 47733
	private const float ScreenDpi2FontSize = 0.14f;
}
