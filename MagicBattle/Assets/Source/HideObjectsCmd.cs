using System;
using BlackJack.ProjectL.Misc;
using UnityEngine;

// Token: 0x020005A3 RID: 1443
public class HideObjectsCmd : IDebugCmd
{
	// Token: 0x0600524B RID: 21067 RVA: 0x00186900 File Offset: 0x00184B00
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
				obj.SetActive(false);
			});
		}
	}

	// Token: 0x0600524C RID: 21068 RVA: 0x00186954 File Offset: 0x00184B54
	public string GetHelpDesc()
	{
		return "ho  Battle/Hourse/Plane : 显示所有路径包含[Battle/Hourse/Plane]的GameObject";
	}

	// Token: 0x0600524D RID: 21069 RVA: 0x0018695C File Offset: 0x00184B5C
	public string GetName()
	{
		return "ho";
	}
}
