using System;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectLBasic
{
	// Token: 0x020010B6 RID: 4278
	[CustomLuaClass]
	public class ShowHideEvent : MonoBehaviour
	{
		// Token: 0x060158AC RID: 88236 RVA: 0x0057C84C File Offset: 0x0057AA4C
		private void OnEnable()
		{
			if (!this.m_isStarted)
			{
				return;
			}
			this.m_bNeedCallShow = true;
		}

		// Token: 0x060158AD RID: 88237 RVA: 0x0057C864 File Offset: 0x0057AA64
		private void Start()
		{
			this.m_isStarted = true;
			this.CallOnShowEvent();
		}

		// Token: 0x060158AE RID: 88238 RVA: 0x0057C874 File Offset: 0x0057AA74
		private void Update()
		{
			if (this.m_bNeedCallShow)
			{
				this.CallOnShowEvent();
				this.m_bNeedCallShow = false;
			}
		}

		// Token: 0x060158AF RID: 88239 RVA: 0x0057C890 File Offset: 0x0057AA90
		private void OnDisable()
		{
			this.CallOnHideEvent();
		}

		// Token: 0x060158B0 RID: 88240 RVA: 0x0057C898 File Offset: 0x0057AA98
		private void CallOnShowEvent()
		{
			if (base.gameObject != null && ShowHideEvent.m_onShowEvent != null)
			{
				ShowHideEvent.m_onShowEvent(this.Param);
			}
		}

		// Token: 0x060158B1 RID: 88241 RVA: 0x0057C8C8 File Offset: 0x0057AAC8
		private void CallOnHideEvent()
		{
			if (base.gameObject != null && ShowHideEvent.m_onHideEvent != null)
			{
				ShowHideEvent.m_onHideEvent(this.Param);
			}
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x060158B2 RID: 88242 RVA: 0x0057C8F8 File Offset: 0x0057AAF8
		private string Param
		{
			get
			{
				return (!string.IsNullOrEmpty(this.m_eventParam)) ? this.m_eventParam : SceneManager.GetObjectPath(base.gameObject);
			}
		}

		// Token: 0x140004D1 RID: 1233
		// (add) Token: 0x060158B3 RID: 88243 RVA: 0x0057C920 File Offset: 0x0057AB20
		// (remove) Token: 0x060158B4 RID: 88244 RVA: 0x0057C954 File Offset: 0x0057AB54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<string> m_onShowEvent;

		// Token: 0x140004D2 RID: 1234
		// (add) Token: 0x060158B5 RID: 88245 RVA: 0x0057C988 File Offset: 0x0057AB88
		// (remove) Token: 0x060158B6 RID: 88246 RVA: 0x0057C9BC File Offset: 0x0057ABBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<string> m_onHideEvent;

		// Token: 0x0400BC61 RID: 48225
		private bool m_isStarted;

		// Token: 0x0400BC62 RID: 48226
		private bool m_bNeedCallShow;

		// Token: 0x0400BC63 RID: 48227
		public string m_eventParam;
	}
}
