using System;
using UnityEngine;

// Token: 0x02001082 RID: 4226
public class KeyUpEventArgs : EventArgs
{
	// Token: 0x06015618 RID: 87576 RVA: 0x0056C8DC File Offset: 0x0056AADC
	public KeyUpEventArgs(KeyCode keyCode)
	{
		this._keyCode = keyCode;
	}

	// Token: 0x17003E60 RID: 15968
	// (get) Token: 0x06015619 RID: 87577 RVA: 0x0056C8EC File Offset: 0x0056AAEC
	public KeyCode KeyCode
	{
		get
		{
			return this._keyCode;
		}
	}

	// Token: 0x0400BA77 RID: 47735
	private readonly KeyCode _keyCode;
}
