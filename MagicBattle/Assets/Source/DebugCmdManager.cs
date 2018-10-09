using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

// Token: 0x02001075 RID: 4213
public class DebugCmdManager
{
	// Token: 0x060155A8 RID: 87464 RVA: 0x0056AF88 File Offset: 0x00569188
	private DebugCmdManager()
	{
		DebugCmdManager._instance = this;
	}

	// Token: 0x060155A9 RID: 87465 RVA: 0x0056AFA4 File Offset: 0x005691A4
	public static DebugCmdManager Create(IConsoleMode debugConsoleMode)
	{
		DebugCmdManager debugCmdManager = new DebugCmdManager();
		debugCmdManager._Init(debugConsoleMode);
		return debugCmdManager;
	}

	// Token: 0x060155AA RID: 87466 RVA: 0x0056AFC0 File Offset: 0x005691C0
	private void AddCmd(Type cmdType)
	{
		object obj = Activator.CreateInstance(cmdType);
		IDebugCmd debugCmd = (IDebugCmd)obj;
		this._cmdMap.Add(debugCmd.GetName().ToLower(), debugCmd);
	}

	// Token: 0x060155AB RID: 87467 RVA: 0x0056AFF4 File Offset: 0x005691F4
	public void LoadIDebugCmds(Assembly a)
	{
		if (a == null)
		{
			return;
		}
		if (this._cmdMap == null)
		{
			this._cmdMap = new Dictionary<string, IDebugCmd>();
		}
		Type[] types = a.GetTypes();
		foreach (Type type in types)
		{
			if (type.GetInterface("IDebugCmd") != null)
			{
				this.AddCmd(type);
			}
		}
	}

	// Token: 0x060155AC RID: 87468 RVA: 0x0056B058 File Offset: 0x00569258
	private void _Init(IConsoleMode consoleMode)
	{
		this.LoadIDebugCmds(Assembly.GetExecutingAssembly());
		this.LoadOldCommands();
	}

	// Token: 0x060155AD RID: 87469 RVA: 0x0056B06C File Offset: 0x0056926C
	public void RunInstruct(string instruct)
	{
		string instruct2 = instruct.Trim();
		string cmdName = this._GetCommandName(instruct2);
		string strParams = this._GetCommandParams(instruct2);
		IDebugCmd debugCmd = this._GetCommand(cmdName);
		if (debugCmd != null)
		{
			debugCmd.Execute(strParams);
			this._showOldCommandIdx = 0;
			if (this._oldCommands.Count == 0 || this._oldCommands[this._oldCommands.Count - 1].ToLower() != instruct.ToLower())
			{
				this._oldCommands.Add(instruct);
			}
			this.SaveOldCommands();
		}
		else
		{
			this._PrintWrongCommandHint();
		}
	}

	// Token: 0x060155AE RID: 87470 RVA: 0x0056B108 File Offset: 0x00569308
	private void _PrintWrongCommandHint()
	{
		global::Debug.LogError("Wrong command!use \"help\" to show all command.");
	}

	// Token: 0x060155AF RID: 87471 RVA: 0x0056B114 File Offset: 0x00569314
	private string _GetCommandName(string instruct)
	{
		string text = instruct;
		int num = instruct.IndexOf(' ');
		if (num != -1)
		{
			text = instruct.Substring(0, num).Trim();
		}
		return text.ToLower();
	}

	// Token: 0x060155B0 RID: 87472 RVA: 0x0056B148 File Offset: 0x00569348
	private string _GetCommandParams(string instruct)
	{
		string result = string.Empty;
		int num = instruct.IndexOf(' ');
		if (num != -1)
		{
			result = instruct.Substring(num + 1).Trim();
		}
		return result;
	}

	// Token: 0x060155B1 RID: 87473 RVA: 0x0056B17C File Offset: 0x0056937C
	private IDebugCmd _GetCommand(string cmdName)
	{
		cmdName = cmdName.ToLower();
		IDebugCmd result;
		if (this._cmdMap.TryGetValue(cmdName, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060155B2 RID: 87474 RVA: 0x0056B1A8 File Offset: 0x005693A8
	public void PringAllCmdDescription()
	{
		global::Debug.Log("*******Command List End******");
		foreach (KeyValuePair<string, IDebugCmd> keyValuePair in this._cmdMap)
		{
			global::Debug.Log(keyValuePair.Value.GetHelpDesc());
		}
		global::Debug.Log("Triple click (continuous click 3 times ) the window to toggle [Auto Scrolling View].");
		global::Debug.Log("*******Command List Start*******");
	}

	// Token: 0x060155B3 RID: 87475 RVA: 0x0056B22C File Offset: 0x0056942C
	public int GetCommandNumber()
	{
		if (this._cmdMap != null)
		{
			return this._cmdMap.Count;
		}
		return 0;
	}

	// Token: 0x17003E57 RID: 15959
	// (get) Token: 0x060155B4 RID: 87476 RVA: 0x0056B248 File Offset: 0x00569448
	public static DebugCmdManager instance
	{
		get
		{
			return DebugCmdManager._instance;
		}
	}

	// Token: 0x060155B5 RID: 87477 RVA: 0x0056B250 File Offset: 0x00569450
	private void SaveOldCommands()
	{
		string path = string.Format("{0}{1}DebugConsoleCommands.txt", Application.persistentDataPath, Path.AltDirectorySeparatorChar);
		StreamWriter streamWriter = new StreamWriter(path);
		foreach (string value in this._oldCommands)
		{
			streamWriter.WriteLine(value);
		}
		streamWriter.Close();
	}

	// Token: 0x060155B6 RID: 87478 RVA: 0x0056B2D4 File Offset: 0x005694D4
	private void LoadOldCommands()
	{
		string text = string.Format("{0}{1}DebugConsoleCommands.txt", Application.persistentDataPath, Path.AltDirectorySeparatorChar);
		try
		{
			if (File.Exists(text))
			{
				StreamReader streamReader = new StreamReader(text);
				this._oldCommands.Clear();
				while (!streamReader.EndOfStream)
				{
					string text2 = streamReader.ReadLine();
					if (!string.IsNullOrEmpty(text2))
					{
						this._oldCommands.Add(text2);
					}
				}
				streamReader.Close();
			}
		}
		catch (FileNotFoundException)
		{
			global::Debug.Log(string.Format("[{0}] not found.", text));
		}
		catch (FileLoadException)
		{
			global::Debug.LogError(string.Format("Failed to load [{0}].", text));
		}
		catch (Exception ex)
		{
			global::Debug.LogError(ex.Message);
		}
	}

	// Token: 0x060155B7 RID: 87479 RVA: 0x0056B3C0 File Offset: 0x005695C0
	public string GetNextOldCommand()
	{
		string result = string.Empty;
		if (this._oldCommands.Count > 1)
		{
			this._showOldCommandIdx--;
			this._showOldCommandIdx = Math.Max(Math.Min(this._showOldCommandIdx, this._oldCommands.Count), 0);
			if (this._showOldCommandIdx > 0)
			{
				result = this._oldCommands[this._oldCommands.Count - this._showOldCommandIdx];
			}
		}
		return result;
	}

	// Token: 0x060155B8 RID: 87480 RVA: 0x0056B440 File Offset: 0x00569640
	public string GetPreviousOldCommand()
	{
		string result = string.Empty;
		if (this._oldCommands.Count > 1)
		{
			this._showOldCommandIdx++;
			this._showOldCommandIdx = Math.Max(Math.Min(this._showOldCommandIdx, this._oldCommands.Count), 1);
			result = this._oldCommands[this._oldCommands.Count - this._showOldCommandIdx];
		}
		return result;
	}

	// Token: 0x0400BA39 RID: 47673
	private Dictionary<string, IDebugCmd> _cmdMap;

	// Token: 0x0400BA3A RID: 47674
	private static DebugCmdManager _instance;

	// Token: 0x0400BA3B RID: 47675
	private List<string> _oldCommands = new List<string>(50);

	// Token: 0x0400BA3C RID: 47676
	private int _showOldCommandIdx;
}
