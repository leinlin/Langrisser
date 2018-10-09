using System;
using BlackJack.ProjectL.Misc;
using UnityEngine;

// Token: 0x020005A4 RID: 1444
public class ShowObjectsCmd : IDebugCmd
{
	// Token: 0x06005250 RID: 21072 RVA: 0x00186978 File Offset: 0x00184B78
	public void Execute(string strParams)
	{
		GameObject sceneRoot = GameObjectUtility.SceneRoot;
		if (sceneRoot != null)
		{
			GameObjectUtility.FindChildObject(sceneRoot, strParams.Split(new char[]
			{
				'/'
			}), delegate(GameObject obj)
			{
				obj.SetActive(true);
			});
		}
	}

	// Token: 0x06005251 RID: 21073 RVA: 0x001869CC File Offset: 0x00184BCC
	public string GetHelpDesc()
	{
		return "so  Root/Login/Button: 显示所有路径包含[Root/Login/Button]的GameObject";
	}

	// Token: 0x06005252 RID: 21074 RVA: 0x001869D4 File Offset: 0x00184BD4
	public string GetName()
	{
		return "so";
	}
}
