using System;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000880 RID: 2176
	[CustomLuaClass]
	public class MonoBehaviourEvent : MonoBehaviour
	{
		// Token: 0x06006BD6 RID: 27606 RVA: 0x001E36D8 File Offset: 0x001E18D8
		public void SetListener(IMonoBehaviourEventListener listener)
		{
			this.m_listener = listener;
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x001E36E4 File Offset: 0x001E18E4
		private void Start()
		{
			if (this.m_listener != null)
			{
				this.m_listener.OnStart(this);
			}
			else if (GlobalMonoBehaviourEventListener.Instance != null)
			{
				GlobalMonoBehaviourEventListener.Instance.OnStart(this);
			}
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x001E3718 File Offset: 0x001E1918
		private void OnDestroy()
		{
			if (this.m_listener != null)
			{
				this.m_listener.OnDestroy(this);
			}
			else if (GlobalMonoBehaviourEventListener.Instance != null)
			{
				GlobalMonoBehaviourEventListener.Instance.OnDestroy(this);
			}
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x001E374C File Offset: 0x001E194C
		private void Update()
		{
			if (this.m_listener != null)
			{
				this.m_listener.OnUpdate(this);
			}
			else if (GlobalMonoBehaviourEventListener.Instance != null)
			{
				GlobalMonoBehaviourEventListener.Instance.OnUpdate(this);
			}
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x001E3780 File Offset: 0x001E1980
		private void LateUpdate()
		{
			if (this.m_listener != null)
			{
				this.m_listener.OnLateUpdate(this);
			}
			else if (GlobalMonoBehaviourEventListener.Instance != null)
			{
				GlobalMonoBehaviourEventListener.Instance.OnLateUpdate(this);
			}
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x001E37B4 File Offset: 0x001E19B4
		private void OnRenderObject()
		{
			if (this.m_listener != null)
			{
				this.m_listener.OnRenderObject(this);
			}
			else if (GlobalMonoBehaviourEventListener.Instance != null)
			{
				GlobalMonoBehaviourEventListener.Instance.OnRenderObject(this);
			}
		}

		// Token: 0x040052F8 RID: 21240
		private IMonoBehaviourEventListener m_listener;
	}
}
