using System;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Scene
{
	// Token: 0x020000BA RID: 186
	[CustomLuaClass]
	public class SceneLayerBase : MonoBehaviour
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x0001F0C0 File Offset: 0x0001D2C0
		public void SetName(string name)
		{
			if (string.IsNullOrEmpty(this.LayerName))
			{
				this.LayerName = name;
				return;
			}
			throw new Exception(string.Format("SceneLayerBase.SetName={0} to layer already have name={1}", name, this.LayerName));
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		public bool IsOpaque()
		{
			LayerLayoutDesc desc = this.GetDesc();
			return desc == null || desc.Opaque;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001F120 File Offset: 0x0001D320
		public bool IsFullScreen()
		{
			LayerLayoutDesc desc = this.GetDesc();
			return desc == null || desc.FullScreen;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001F148 File Offset: 0x0001D348
		public bool IsStayOnTop()
		{
			LayerLayoutDesc desc = this.GetDesc();
			return !(desc == null) && desc.StayOnTop;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001F170 File Offset: 0x0001D370
		private LayerLayoutDesc GetDesc()
		{
			if (this.m_layerLayoutDesc == null)
			{
				LayerLayoutDesc[] componentsInChildren = base.transform.GetComponentsInChildren<LayerLayoutDesc>(true);
				if (componentsInChildren.Length != 0)
				{
					this.m_layerLayoutDesc = componentsInChildren[0];
				}
			}
			return this.m_layerLayoutDesc;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001F1B4 File Offset: 0x0001D3B4
		public void AttachGameObject(GameObject go)
		{
			if (go == null)
			{
				return;
			}
			Vector3 localPosition = go.transform.localPosition;
			Vector3 localScale = go.transform.localScale;
			Quaternion localRotation = go.transform.localRotation;
			go.transform.SetParent(base.transform);
			go.transform.localPosition = localPosition;
			go.transform.localScale = localScale;
			go.transform.localRotation = localRotation;
			this.LayerPrefabRoot = go;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001F230 File Offset: 0x0001D430
		public LayerRenderSettingDesc GetRenderSetting()
		{
			if (this.m_renderSettingSearched)
			{
				return this.m_renderSetting;
			}
			this.m_renderSettingSearched = true;
			LayerRenderSettingDesc[] componentsInChildren = base.GetComponentsInChildren<LayerRenderSettingDesc>(true);
			if (componentsInChildren.Length != 0)
			{
				this.m_renderSetting = componentsInChildren[0];
			}
			return this.m_renderSetting;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001F278 File Offset: 0x0001D478
		public bool IsReserve()
		{
			return this.m_isReserve;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001F280 File Offset: 0x0001D480
		public void SetReserve(bool value)
		{
			this.m_isReserve = value;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0001F28C File Offset: 0x0001D48C
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x0001F294 File Offset: 0x0001D494
		public string LayerName { get; private set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0001F2A0 File Offset: 0x0001D4A0
		public virtual Camera LayerCamera
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x0001F2AC File Offset: 0x0001D4AC
		public GameObject LayerPrefabRoot { get; private set; }

		// Token: 0x0400047B RID: 1147
		public SceneLayerBase.LayerState State;

		// Token: 0x0400047C RID: 1148
		private LayerLayoutDesc m_layerLayoutDesc;

		// Token: 0x0400047D RID: 1149
		private LayerRenderSettingDesc m_renderSetting;

		// Token: 0x0400047E RID: 1150
		private bool m_renderSettingSearched;

		// Token: 0x0400047F RID: 1151
		private bool m_isReserve;

		// Token: 0x020000BB RID: 187
		public enum LayerState
		{
			// Token: 0x04000482 RID: 1154
			None,
			// Token: 0x04000483 RID: 1155
			Loading,
			// Token: 0x04000484 RID: 1156
			Unused,
			// Token: 0x04000485 RID: 1157
			InStack,
			// Token: 0x04000486 RID: 1158
			WaitForFree
		}
	}
}
