using System;
using UnityEngine;

// Token: 0x02001081 RID: 4225
public class KeyDownEventArgs : EventArgs
{
	// Token: 0x06015616 RID: 87574 RVA: 0x0056C8C4 File Offset: 0x0056AAC4
	public KeyDownEventArgs(KeyCode keyCode)
	{
		this._keyCode = keyCode;
	}

	// Token: 0x17003E5F RID: 15967
	// (get) Token: 0x06015617 RID: 87575 RVA: 0x0056C8D4 File Offset: 0x0056AAD4
	public KeyCode KeyCode
	{
		get
		{
			return this._keyCode;
		}
	}

	// Token: 0x0400BA76 RID: 47734
	private readonly KeyCode _keyCode;
}
