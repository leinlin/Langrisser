using System;
using System.Collections.Generic;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Prefab
{
	// Token: 0x02000077 RID: 119
	public class PrefabControllerCreater : MonoBehaviour
	{
		// Token: 0x0600056D RID: 1389 RVA: 0x00018080 File Offset: 0x00016280
		public static bool CreateAllControllers(GameObject root)
		{
			bool result = true;
			PrefabControllerCreater[] componentsInChildren = root.GetComponentsInChildren<PrefabControllerCreater>(true);
			if (componentsInChildren == null)
			{
				return true;
			}
			foreach (PrefabControllerCreater prefabControllerCreater in componentsInChildren)
			{
				if (!prefabControllerCreater.CreateAllControllers(false))
				{
					result = false;
				}
			}
			foreach (PrefabControllerCreater prefabControllerCreater2 in componentsInChildren)
			{
				foreach (PrefabControllerBase prefabControllerBase in prefabControllerCreater2.CtrlList)
				{
					prefabControllerBase.BindFields();
				}
			}
			return result;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00018144 File Offset: 0x00016344
		public bool CreateAllControllers(bool autoBind = true)
		{
			bool result = true;
			this.CtrlList.Clear();
			foreach (ControllerDesc controllerDesc in this.CtrlDescList)
			{
				PrefabControllerBase prefabControllerBase = PrefabControllerBase.AddControllerToGameObject(base.gameObject, controllerDesc.m_attachPath, controllerDesc.m_ctrlTypeDNName, controllerDesc.m_ctrlName, controllerDesc.m_luaModuleName, false);
				if (prefabControllerBase == null)
				{
					global::Debug.LogError(string.Format("PrefabControllerCreater.CreateAllControllers AddControllerToGameObject fail {0} {1} {2}", controllerDesc.m_ctrlName, controllerDesc.m_attachPath, controllerDesc.m_ctrlTypeDNName));
				}
				this.CtrlList.Add(prefabControllerBase);
			}
			if (autoBind)
			{
				foreach (PrefabControllerBase prefabControllerBase2 in this.CtrlList)
				{
					if (prefabControllerBase2 != null)
					{
						prefabControllerBase2.BindFields();
					}
					else
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00018274 File Offset: 0x00016474
		public PrefabControllerBase GetControllerByName(string name)
		{
			foreach (PrefabControllerBase prefabControllerBase in this.CtrlList)
			{
				if (prefabControllerBase.CtrlName == name)
				{
					return prefabControllerBase;
				}
			}
			return null;
		}

		// Token: 0x040002AE RID: 686
		public List<ControllerDesc> CtrlDescList = new List<ControllerDesc>();

		// Token: 0x040002AF RID: 687
		public List<PrefabControllerBase> CtrlList = new List<PrefabControllerBase>();
	}
}
