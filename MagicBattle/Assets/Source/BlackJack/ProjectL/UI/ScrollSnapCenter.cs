using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C03 RID: 3075
	[HotFix]
	public class ScrollSnapCenter : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IEventSystemHandler
	{
		// Token: 0x0600D728 RID: 55080 RVA: 0x003A9068 File Offset: 0x003A7268
		private void Awake()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Awake_hotfix != null)
			{
				this.m_Awake_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_scrollRect = base.GetComponent<ScrollRect>();
		}

		// Token: 0x0600D729 RID: 55081 RVA: 0x003A90D4 File Offset: 0x003A72D4
		private void LateUpdate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LateUpdate_hotfix != null)
			{
				this.m_LateUpdate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_scrollRect == null)
			{
				return;
			}
			if (this.m_isSnaping)
			{
				this.m_scrollRect.content.anchoredPosition = Vector3.Lerp(this.m_scrollRect.content.anchoredPosition, this.m_snapPosition, 10f * Time.deltaTime);
				if (Vector2.Distance(this.m_scrollRect.content.anchoredPosition, this.m_snapPosition) < 1f)
				{
					this.m_scrollRect.content.anchoredPosition = this.m_snapPosition;
					this.m_scrollRect.velocity = Vector2.zero;
					this.m_isSnaping = false;
				}
			}
			if (this.m_itemCount > 0)
			{
				int centerItemIndex = this.GetCenterItemIndex();
				if (centerItemIndex != this.m_currentCenterIndex)
				{
					this.m_currentCenterIndex = centerItemIndex;
					if (this.EventOnCenterItemChanged != null)
					{
						this.EventOnCenterItemChanged(centerItemIndex);
					}
				}
			}
		}

		// Token: 0x0600D72A RID: 55082 RVA: 0x003A9228 File Offset: 0x003A7428
		public void SetItemCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetItemCountInt32_hotfix != null)
			{
				this.m_SetItemCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_itemCount = count;
			if (this.m_scrollRect != null)
			{
				if (this.m_scrollSnapDir == ScrollSnapDirection.Horizontal)
				{
					this.m_scrollRect.content.sizeDelta = new Vector2((float)(count - 1) * this.m_itemSize + this.m_scrollRect.viewport.rect.width, this.m_scrollRect.content.sizeDelta.y);
				}
				else
				{
					this.m_scrollRect.content.sizeDelta = new Vector2(this.m_scrollRect.content.sizeDelta.x, (float)(count - 1) * this.m_itemSize + this.m_scrollRect.viewport.rect.height);
				}
			}
		}

		// Token: 0x0600D72B RID: 55083 RVA: 0x003A9364 File Offset: 0x003A7564
		public int GetItemCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetItemCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetItemCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_itemCount;
		}

		// Token: 0x0600D72C RID: 55084 RVA: 0x003A93D8 File Offset: 0x003A75D8
		public Vector2 ComputeItemPosition(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeItemPositionInt32_hotfix != null)
			{
				return (Vector2)this.m_ComputeItemPositionInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_scrollSnapDir == ScrollSnapDirection.Horizontal)
			{
				return new Vector2((float)idx * this.m_itemSize + this.m_scrollRect.viewport.rect.width * 0.5f, 0f);
			}
			return new Vector2(0f, -((float)idx * this.m_itemSize + this.m_scrollRect.viewport.rect.height * 0.5f));
		}

		// Token: 0x0600D72D RID: 55085 RVA: 0x003A94C8 File Offset: 0x003A76C8
		public int GetCenterItemIndexUnclamped()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCenterItemIndexUnclamped_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCenterItemIndexUnclamped_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_itemCount <= 0)
			{
				return 0;
			}
			if (this.m_scrollRect == null)
			{
				return 0;
			}
			int result;
			if (this.m_scrollSnapDir == ScrollSnapDirection.Horizontal)
			{
				result = Mathf.RoundToInt(-this.m_scrollRect.content.anchoredPosition.x / this.m_itemSize);
			}
			else
			{
				result = Mathf.RoundToInt(this.m_scrollRect.content.anchoredPosition.y / this.m_itemSize);
			}
			return result;
		}

		// Token: 0x0600D72E RID: 55086 RVA: 0x003A95B4 File Offset: 0x003A77B4
		public int GetCenterItemIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCenterItemIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCenterItemIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.GetCenterItemIndexUnclamped();
			if (num < 0)
			{
				num = 0;
			}
			if (num >= this.m_itemCount)
			{
				num = this.m_itemCount - 1;
			}
			return num;
		}

		// Token: 0x0600D72F RID: 55087 RVA: 0x003A9648 File Offset: 0x003A7848
		public void Snap(int idx, bool smooth = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SnapInt32Boolean_hotfix != null)
			{
				this.m_SnapInt32Boolean_hotfix.call(new object[]
				{
					this,
					idx,
					smooth
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_scrollRect == null)
			{
				return;
			}
			this.Snap(this.ComputeSnapCenterPosition(idx));
			if (!smooth)
			{
				this.m_scrollRect.content.anchoredPosition = this.m_snapPosition;
				this.m_isSnaping = false;
				this.LateUpdate();
			}
		}

		// Token: 0x0600D730 RID: 55088 RVA: 0x003A9710 File Offset: 0x003A7910
		private int GetItemIndexByDragDistance()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetItemIndexByDragDistance_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetItemIndexByDragDistance_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_currentCenterIndex;
			Vector2 vector = this.m_endFragPosition - this.m_beginDragPosition;
			if (this.m_scrollSnapDir == ScrollSnapDirection.Horizontal)
			{
				if (this.m_itemSize != 0f && Math.Abs(vector.x) / this.m_itemSize > this.m_dragPercentage)
				{
					if (vector.x > 0f)
					{
						num = this.m_currentCenterIndex - 1;
					}
					else if (vector.x < 0f)
					{
						num = this.m_currentCenterIndex + 1;
					}
				}
			}
			else if (this.m_scrollSnapDir == ScrollSnapDirection.Vertical && this.m_itemSize != 0f && Math.Abs(vector.y) / this.m_itemSize > this.m_dragPercentage)
			{
				if (vector.y > 0f)
				{
					num = this.m_currentCenterIndex + 1;
				}
				else if (vector.y < 0f)
				{
					num = this.m_currentCenterIndex - 1;
				}
			}
			if (num < 0)
			{
				num = 0;
			}
			if (num >= this.m_itemCount)
			{
				num = this.m_itemCount - 1;
			}
			return num;
		}

		// Token: 0x0600D731 RID: 55089 RVA: 0x003A98A0 File Offset: 0x003A7AA0
		private Vector2 ComputeSnapCenterPosition(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeSnapCenterPositionInt32_hotfix != null)
			{
				return (Vector2)this.m_ComputeSnapCenterPositionInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_scrollSnapDir == ScrollSnapDirection.Horizontal)
			{
				return new Vector2((float)idx * -this.m_itemSize, this.m_scrollRect.content.anchoredPosition.y);
			}
			return new Vector2(this.m_scrollRect.content.anchoredPosition.x, (float)idx * this.m_itemSize);
		}

		// Token: 0x0600D732 RID: 55090 RVA: 0x003A9978 File Offset: 0x003A7B78
		private void Snap(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SnapVector2_hotfix != null)
			{
				this.m_SnapVector2_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_snapPosition = p;
			this.m_scrollRect.velocity = Vector2.zero;
			this.m_isSnaping = true;
		}

		// Token: 0x0600D733 RID: 55091 RVA: 0x003A9A08 File Offset: 0x003A7C08
		public void OnBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBeginDragPointerEventData_hotfix != null)
			{
				this.m_OnBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isSnaping = false;
			this.m_beginDragPosition = this.m_scrollRect.content.anchoredPosition;
		}

		// Token: 0x0600D734 RID: 55092 RVA: 0x003A9A98 File Offset: 0x003A7C98
		public void OnEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndDragPointerEventData_hotfix != null)
			{
				this.m_OnEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_endFragPosition = this.m_scrollRect.content.anchoredPosition;
			if (this.m_scrollSnapPageType == ScrollSnapPageType.HalfOfItem)
			{
				this.Snap(this.GetCenterItemIndex(), true);
			}
			else
			{
				this.Snap(this.GetItemIndexByDragDistance(), true);
			}
			if (this.EventOnEndDrag != null)
			{
				this.EventOnEndDrag();
			}
		}

		// Token: 0x140002AA RID: 682
		// (add) Token: 0x0600D735 RID: 55093 RVA: 0x003A9B60 File Offset: 0x003A7D60
		// (remove) Token: 0x0600D736 RID: 55094 RVA: 0x003A9BFC File Offset: 0x003A7DFC
		public event Action<int> EventOnCenterItemChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCenterItemChangedAction`1_hotfix != null)
				{
					this.m_add_EventOnCenterItemChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnCenterItemChanged;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnCenterItemChanged, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCenterItemChangedAction`1_hotfix != null)
				{
					this.m_remove_EventOnCenterItemChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnCenterItemChanged;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnCenterItemChanged, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002AB RID: 683
		// (add) Token: 0x0600D737 RID: 55095 RVA: 0x003A9C98 File Offset: 0x003A7E98
		// (remove) Token: 0x0600D738 RID: 55096 RVA: 0x003A9D34 File Offset: 0x003A7F34
		public event Action EventOnEndDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndDragAction_hotfix != null)
				{
					this.m_add_EventOnEndDragAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndDrag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndDrag, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndDragAction_hotfix != null)
				{
					this.m_remove_EventOnEndDragAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndDrag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndDrag, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x0600D739 RID: 55097 RVA: 0x003A9DD0 File Offset: 0x003A7FD0
		// (set) Token: 0x0600D73A RID: 55098 RVA: 0x003A9DF0 File Offset: 0x003A7FF0
		[DoNotToLua]
		public ScrollSnapCenter.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ScrollSnapCenter.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D73B RID: 55099 RVA: 0x003A9DFC File Offset: 0x003A7FFC
		private void __callDele_EventOnCenterItemChanged(int obj)
		{
			Action<int> eventOnCenterItemChanged = this.EventOnCenterItemChanged;
			if (eventOnCenterItemChanged != null)
			{
				eventOnCenterItemChanged(obj);
			}
		}

		// Token: 0x0600D73C RID: 55100 RVA: 0x003A9E20 File Offset: 0x003A8020
		private void __clearDele_EventOnCenterItemChanged(int obj)
		{
			this.EventOnCenterItemChanged = null;
		}

		// Token: 0x0600D73D RID: 55101 RVA: 0x003A9E2C File Offset: 0x003A802C
		private void __callDele_EventOnEndDrag()
		{
			Action eventOnEndDrag = this.EventOnEndDrag;
			if (eventOnEndDrag != null)
			{
				eventOnEndDrag();
			}
		}

		// Token: 0x0600D73E RID: 55102 RVA: 0x003A9E4C File Offset: 0x003A804C
		private void __clearDele_EventOnEndDrag()
		{
			this.EventOnEndDrag = null;
		}

		// Token: 0x0600D73F RID: 55103 RVA: 0x003A9E58 File Offset: 0x003A8058
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_Awake_hotfix = (luaObj.RawGet("Awake") as LuaFunction);
					this.m_LateUpdate_hotfix = (luaObj.RawGet("LateUpdate") as LuaFunction);
					this.m_SetItemCountInt32_hotfix = (luaObj.RawGet("SetItemCount") as LuaFunction);
					this.m_GetItemCount_hotfix = (luaObj.RawGet("GetItemCount") as LuaFunction);
					this.m_ComputeItemPositionInt32_hotfix = (luaObj.RawGet("ComputeItemPosition") as LuaFunction);
					this.m_GetCenterItemIndexUnclamped_hotfix = (luaObj.RawGet("GetCenterItemIndexUnclamped") as LuaFunction);
					this.m_GetCenterItemIndex_hotfix = (luaObj.RawGet("GetCenterItemIndex") as LuaFunction);
					this.m_SnapInt32Boolean_hotfix = (luaObj.RawGet("Snap") as LuaFunction);
					this.m_GetItemIndexByDragDistance_hotfix = (luaObj.RawGet("GetItemIndexByDragDistance") as LuaFunction);
					this.m_ComputeSnapCenterPositionInt32_hotfix = (luaObj.RawGet("ComputeSnapCenterPosition") as LuaFunction);
					this.m_SnapVector2_hotfix = (luaObj.RawGet("Snap") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_add_EventOnCenterItemChangedAction`1_hotfix = (luaObj.RawGet("add_EventOnCenterItemChanged") as LuaFunction);
					this.m_remove_EventOnCenterItemChangedAction`1_hotfix = (luaObj.RawGet("remove_EventOnCenterItemChanged") as LuaFunction);
					this.m_add_EventOnEndDragAction_hotfix = (luaObj.RawGet("add_EventOnEndDrag") as LuaFunction);
					this.m_remove_EventOnEndDragAction_hotfix = (luaObj.RawGet("remove_EventOnEndDrag") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D740 RID: 55104 RVA: 0x003AA0B4 File Offset: 0x003A82B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ScrollSnapCenter));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400846E RID: 33902
		public float m_itemSize = 100f;

		// Token: 0x0400846F RID: 33903
		public ScrollSnapDirection m_scrollSnapDir;

		// Token: 0x04008470 RID: 33904
		public ScrollSnapPageType m_scrollSnapPageType;

		// Token: 0x04008471 RID: 33905
		public float m_dragPercentage = 0.1f;

		// Token: 0x04008474 RID: 33908
		private bool m_isSnaping;

		// Token: 0x04008475 RID: 33909
		private Vector2 m_snapPosition;

		// Token: 0x04008476 RID: 33910
		private int m_itemCount;

		// Token: 0x04008477 RID: 33911
		private ScrollRect m_scrollRect;

		// Token: 0x04008478 RID: 33912
		private int m_currentCenterIndex = -1;

		// Token: 0x04008479 RID: 33913
		private Vector2 m_beginDragPosition;

		// Token: 0x0400847A RID: 33914
		private Vector2 m_endFragPosition;

		// Token: 0x0400847B RID: 33915
		[DoNotToLua]
		private ScrollSnapCenter.LuaExportHelper luaExportHelper;

		// Token: 0x0400847C RID: 33916
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400847D RID: 33917
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400847E RID: 33918
		private LuaFunction m_Awake_hotfix;

		// Token: 0x0400847F RID: 33919
		private LuaFunction m_LateUpdate_hotfix;

		// Token: 0x04008480 RID: 33920
		private LuaFunction m_SetItemCountInt32_hotfix;

		// Token: 0x04008481 RID: 33921
		private LuaFunction m_GetItemCount_hotfix;

		// Token: 0x04008482 RID: 33922
		private LuaFunction m_ComputeItemPositionInt32_hotfix;

		// Token: 0x04008483 RID: 33923
		private LuaFunction m_GetCenterItemIndexUnclamped_hotfix;

		// Token: 0x04008484 RID: 33924
		private LuaFunction m_GetCenterItemIndex_hotfix;

		// Token: 0x04008485 RID: 33925
		private LuaFunction m_SnapInt32Boolean_hotfix;

		// Token: 0x04008486 RID: 33926
		private LuaFunction m_GetItemIndexByDragDistance_hotfix;

		// Token: 0x04008487 RID: 33927
		private LuaFunction m_ComputeSnapCenterPositionInt32_hotfix;

		// Token: 0x04008488 RID: 33928
		private LuaFunction m_SnapVector2_hotfix;

		// Token: 0x04008489 RID: 33929
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x0400848A RID: 33930
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x0400848B RID: 33931
		private LuaFunction m_add_EventOnCenterItemChangedAction;

		// Token: 0x0400848C RID: 33932
		private LuaFunction m_remove_EventOnCenterItemChangedAction;

		// Token: 0x0400848D RID: 33933
		private LuaFunction m_add_EventOnEndDragAction_hotfix;

		// Token: 0x0400848E RID: 33934
		private LuaFunction m_remove_EventOnEndDragAction_hotfix;

		// Token: 0x02000C04 RID: 3076
		public class LuaExportHelper
		{
			// Token: 0x0600D741 RID: 55105 RVA: 0x003AA11C File Offset: 0x003A831C
			public LuaExportHelper(ScrollSnapCenter owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D742 RID: 55106 RVA: 0x003AA12C File Offset: 0x003A832C
			public void __callDele_EventOnCenterItemChanged(int obj)
			{
				this.m_owner.__callDele_EventOnCenterItemChanged(obj);
			}

			// Token: 0x0600D743 RID: 55107 RVA: 0x003AA13C File Offset: 0x003A833C
			public void __clearDele_EventOnCenterItemChanged(int obj)
			{
				this.m_owner.__clearDele_EventOnCenterItemChanged(obj);
			}

			// Token: 0x0600D744 RID: 55108 RVA: 0x003AA14C File Offset: 0x003A834C
			public void __callDele_EventOnEndDrag()
			{
				this.m_owner.__callDele_EventOnEndDrag();
			}

			// Token: 0x0600D745 RID: 55109 RVA: 0x003AA15C File Offset: 0x003A835C
			public void __clearDele_EventOnEndDrag()
			{
				this.m_owner.__clearDele_EventOnEndDrag();
			}

			// Token: 0x170029F0 RID: 10736
			// (get) Token: 0x0600D746 RID: 55110 RVA: 0x003AA16C File Offset: 0x003A836C
			// (set) Token: 0x0600D747 RID: 55111 RVA: 0x003AA17C File Offset: 0x003A837C
			public bool m_isSnaping
			{
				get
				{
					return this.m_owner.m_isSnaping;
				}
				set
				{
					this.m_owner.m_isSnaping = value;
				}
			}

			// Token: 0x170029F1 RID: 10737
			// (get) Token: 0x0600D748 RID: 55112 RVA: 0x003AA18C File Offset: 0x003A838C
			// (set) Token: 0x0600D749 RID: 55113 RVA: 0x003AA19C File Offset: 0x003A839C
			public Vector2 m_snapPosition
			{
				get
				{
					return this.m_owner.m_snapPosition;
				}
				set
				{
					this.m_owner.m_snapPosition = value;
				}
			}

			// Token: 0x170029F2 RID: 10738
			// (get) Token: 0x0600D74A RID: 55114 RVA: 0x003AA1AC File Offset: 0x003A83AC
			// (set) Token: 0x0600D74B RID: 55115 RVA: 0x003AA1BC File Offset: 0x003A83BC
			public int m_itemCount
			{
				get
				{
					return this.m_owner.m_itemCount;
				}
				set
				{
					this.m_owner.m_itemCount = value;
				}
			}

			// Token: 0x170029F3 RID: 10739
			// (get) Token: 0x0600D74C RID: 55116 RVA: 0x003AA1CC File Offset: 0x003A83CC
			// (set) Token: 0x0600D74D RID: 55117 RVA: 0x003AA1DC File Offset: 0x003A83DC
			public ScrollRect m_scrollRect
			{
				get
				{
					return this.m_owner.m_scrollRect;
				}
				set
				{
					this.m_owner.m_scrollRect = value;
				}
			}

			// Token: 0x170029F4 RID: 10740
			// (get) Token: 0x0600D74E RID: 55118 RVA: 0x003AA1EC File Offset: 0x003A83EC
			// (set) Token: 0x0600D74F RID: 55119 RVA: 0x003AA1FC File Offset: 0x003A83FC
			public int m_currentCenterIndex
			{
				get
				{
					return this.m_owner.m_currentCenterIndex;
				}
				set
				{
					this.m_owner.m_currentCenterIndex = value;
				}
			}

			// Token: 0x170029F5 RID: 10741
			// (get) Token: 0x0600D750 RID: 55120 RVA: 0x003AA20C File Offset: 0x003A840C
			// (set) Token: 0x0600D751 RID: 55121 RVA: 0x003AA21C File Offset: 0x003A841C
			public Vector2 m_beginDragPosition
			{
				get
				{
					return this.m_owner.m_beginDragPosition;
				}
				set
				{
					this.m_owner.m_beginDragPosition = value;
				}
			}

			// Token: 0x170029F6 RID: 10742
			// (get) Token: 0x0600D752 RID: 55122 RVA: 0x003AA22C File Offset: 0x003A842C
			// (set) Token: 0x0600D753 RID: 55123 RVA: 0x003AA23C File Offset: 0x003A843C
			public Vector2 m_endFragPosition
			{
				get
				{
					return this.m_owner.m_endFragPosition;
				}
				set
				{
					this.m_owner.m_endFragPosition = value;
				}
			}

			// Token: 0x0600D754 RID: 55124 RVA: 0x003AA24C File Offset: 0x003A844C
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x0600D755 RID: 55125 RVA: 0x003AA25C File Offset: 0x003A845C
			public void LateUpdate()
			{
				this.m_owner.LateUpdate();
			}

			// Token: 0x0600D756 RID: 55126 RVA: 0x003AA26C File Offset: 0x003A846C
			public int GetItemIndexByDragDistance()
			{
				return this.m_owner.GetItemIndexByDragDistance();
			}

			// Token: 0x0600D757 RID: 55127 RVA: 0x003AA27C File Offset: 0x003A847C
			public Vector2 ComputeSnapCenterPosition(int idx)
			{
				return this.m_owner.ComputeSnapCenterPosition(idx);
			}

			// Token: 0x0600D758 RID: 55128 RVA: 0x003AA28C File Offset: 0x003A848C
			public void Snap(Vector2 p)
			{
				this.m_owner.Snap(p);
			}

			// Token: 0x0400848F RID: 33935
			private ScrollSnapCenter m_owner;
		}
	}
}
