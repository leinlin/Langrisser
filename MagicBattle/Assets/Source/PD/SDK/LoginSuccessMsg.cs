using System;
using SLua;

namespace PD.SDK
{
	// Token: 0x020010A7 RID: 4263
	[CustomLuaClass]
	public struct LoginSuccessMsg
	{
		// Token: 0x0601581D RID: 88093 RVA: 0x00577D08 File Offset: 0x00575F08
		public LoginSuccessMsg(string d, string o, string ch, string cu)
		{
			this.data = d;
			this.opcode = o;
			this.channel_id = ch;
			this.customparams = cu;
		}

		// Token: 0x0601581E RID: 88094 RVA: 0x00577D28 File Offset: 0x00575F28
		public static LoginSuccessMsg Parse(string msg)
		{
			JsonData jsonData = JsonMapper.ToObject(msg);
			return new LoginSuccessMsg((string)jsonData["data"], (string)jsonData["opcode"], (string)jsonData["channel_id"], (string)jsonData["customparams"]);
		}

		// Token: 0x0400BBE3 RID: 48099
		public string data;

		// Token: 0x0400BBE4 RID: 48100
		public string opcode;

		// Token: 0x0400BBE5 RID: 48101
		public string channel_id;

		// Token: 0x0400BBE6 RID: 48102
		public string customparams;
	}
}
