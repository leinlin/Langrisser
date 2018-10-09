using System;
using System.Collections.Generic;
using BlackJack.ProjectL.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020009C7 RID: 2503
	[AddComponentMenu("UI/BlackJack/AndroidBackEventListener")]
	public class AndroidBackEventListener : MonoBehaviour
	{
		// Token: 0x060091D6 RID: 37334 RVA: 0x002A3028 File Offset: 0x002A1228
		private void Start()
		{
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x002A302C File Offset: 0x002A122C
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				if (this.IsClickable(base.gameObject))
				{
					if (this.Click(base.gameObject))
					{
						CommonUIController.m_hasFinishAndroidBackEvent = true;
					}
				}
				else
				{
					global::Debug.Log("[AndroidBackEventListener] IsClickable = false, GameObject:" + base.gameObject.name);
				}
			}
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x002A308C File Offset: 0x002A128C
		private bool Click(GameObject o)
		{
			if (o == null)
			{
				return false;
			}
			global::Debug.Log("[AndroidBackEventListener] Click GameObject:" + o.name);
			List<Component> list = new List<Component>();
			o.GetComponents(typeof(MonoBehaviour), list);
			bool result = false;
			foreach (Component component in list)
			{
				IPointerDownHandler pointerDownHandler = component as IPointerDownHandler;
				if (pointerDownHandler != null)
				{
					pointerDownHandler.OnPointerDown(new PointerEventData(EventSystem.current));
					result = true;
				}
				IPointerUpHandler pointerUpHandler = component as IPointerUpHandler;
				if (pointerUpHandler != null)
				{
					pointerUpHandler.OnPointerUp(new PointerEventData(EventSystem.current));
					result = true;
				}
				IPointerClickHandler pointerClickHandler = component as IPointerClickHandler;
				if (pointerClickHandler != null)
				{
					pointerClickHandler.OnPointerClick(new PointerEventData(EventSystem.current));
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x002A3180 File Offset: 0x002A1380
		private bool IsClickable(GameObject obj)
		{
			if (obj == null)
			{
				return false;
			}
			PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
			Vector2 zero = Vector2.zero;
			if (this.SuitableClickPosition != zero)
			{
				if (!this.WorldPosToScreenPos(obj.transform as RectTransform, this.SuitableClickPosition, ref zero))
				{
					return false;
				}
			}
			else if (!this.GetCenterScreenPosition(obj.transform as RectTransform, ref zero))
			{
				return false;
			}
			if (!this.IsInsideScreen(zero))
			{
				return false;
			}
			pointerEventData.position = zero;
			List<RaycastResult> list = new List<RaycastResult>();
			EventSystem.current.RaycastAll(pointerEventData, list);
			return list.Count != 0 && (list[0].gameObject == obj || this.IsChildTransform(obj.transform, list[0].gameObject.transform));
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x002A3274 File Offset: 0x002A1474
		private bool WorldPosToScreenPos(RectTransform rt, Vector2 worldPos, ref Vector2 screenPos)
		{
			if (rt == null || rt.gameObject == null)
			{
				return false;
			}
			Canvas componentInParent = rt.gameObject.GetComponentInParent<Canvas>();
			if (componentInParent == null)
			{
				return false;
			}
			Camera worldCamera = componentInParent.worldCamera;
			if (worldCamera == null)
			{
				return false;
			}
			worldPos = rt.TransformPoint(worldPos);
			screenPos = worldCamera.WorldToScreenPoint(worldPos);
			return true;
		}

		// Token: 0x060091DB RID: 37339 RVA: 0x002A32FC File Offset: 0x002A14FC
		private bool GetCenterScreenPosition(RectTransform rt, ref Vector2 pos)
		{
			if (rt == null || rt.gameObject == null)
			{
				return false;
			}
			Canvas componentInParent = rt.gameObject.GetComponentInParent<Canvas>();
			if (componentInParent == null)
			{
				return false;
			}
			Vector3[] array = new Vector3[4];
			rt.GetWorldCorners(array);
			Camera worldCamera = componentInParent.worldCamera;
			if (worldCamera == null)
			{
				return false;
			}
			Vector2 a = worldCamera.WorldToScreenPoint(array[0]);
			Vector2 b = worldCamera.WorldToScreenPoint(array[2]);
			pos = (a + b) * 0.5f;
			return true;
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x002A33B0 File Offset: 0x002A15B0
		private bool IsInsideScreen(Vector2 pos)
		{
			return pos.x >= 0f && pos.x <= (float)Screen.width && pos.y >= 0f && pos.y <= (float)Screen.height;
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x002A3408 File Offset: 0x002A1608
		private bool IsChildTransform(Transform parent, Transform child)
		{
			if (parent == null || child == null)
			{
				return false;
			}
			if (parent == child)
			{
				return true;
			}
			for (int i = 0; i < parent.childCount; i++)
			{
				if (this.IsChildTransform(parent.GetChild(i), child))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04006613 RID: 26131
		public Vector2 SuitableClickPosition;
	}
}
