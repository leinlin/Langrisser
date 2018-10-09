using System;

// Token: 0x02001078 RID: 4216
public interface IDebugCmd
{
	// Token: 0x060155C1 RID: 87489
	void Execute(string strParams);

	// Token: 0x060155C2 RID: 87490
	string GetHelpDesc();

	// Token: 0x060155C3 RID: 87491
	string GetName();
}
