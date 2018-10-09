using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E2C RID: 3628
	[HotFix]
	[RequireComponent(typeof(ContentSizeFitter))]
	[RequireComponent(typeof(GridLayoutGroup))]
	public class InfinityGridLayoutGroup : MonoBehaviour
	{
		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x060118AD RID: 71853 RVA: 0x00489A60 File Offset: 0x00487C60
		// (set) Token: 0x060118AE RID: 71854 RVA: 0x00489AD4 File Offset: 0x00487CD4
		public int MinAmount
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_MinAmount_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_MinAmount_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_minAmount;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_MinAmountInt32_hotfix != null)
				{
					this.m_set_MinAmountInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_minAmount = value;
			}
		}

		// Token: 0x060118AF RID: 71855 RVA: 0x00489B4C File Offset: 0x00487D4C
		private void Start()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Start_hotfix != null)
			{
				this.m_Start_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.InitChildren());
		}

		// Token: 0x060118B0 RID: 71856 RVA: 0x00489BBC File Offset: 0x00487DBC
		[DebuggerHidden]
		private IEnumerator InitChildren()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitChildren_hotfix != null)
			{
				return (IEnumerator)this.m_InitChildren_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			InfinityGridLayoutGroup.<InitChildren>c__Iterator0 <InitChildren>c__Iterator = new InfinityGridLayoutGroup.<InitChildren>c__Iterator0();
			<InitChildren>c__Iterator.$this = this;
			return <InitChildren>c__Iterator;
		}

		// Token: 0x060118B1 RID: 71857 RVA: 0x00489C38 File Offset: 0x00487E38
		private void ScrollCallback(Vector2 data)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ScrollCallbackVector2_hotfix != null)
			{
				this.m_ScrollCallbackVector2_hotfix.call(new object[]
				{
					this,
					data
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateChildren();
		}

		// Token: 0x060118B2 RID: 71858 RVA: 0x00489CB0 File Offset: 0x00487EB0
		private void UpdateChildren()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChildren_hotfix != null)
			{
				this.m_UpdateChildren_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.transform.childCount < this.m_minAmount)
			{
				return;
			}
			Vector2 anchoredPosition = this.rectTransform.anchoredPosition;
			if (this.gridLayoutGroup.constraint == GridLayoutGroup.Constraint.FixedColumnCount)
			{
				float num = anchoredPosition.y - this.startPosition.y;
				if (num > 0f)
				{
					if (this.realIndex >= this.amount - 1)
					{
						this.startPosition = anchoredPosition;
						return;
					}
					float y = this.scrollRect.transform.TransformPoint(Vector3.zero).y;
					Vector3 position = new Vector3(this.children[0].anchoredPosition.x, this.children[0].anchoredPosition.y - this.gridLayoutGroup.cellSize.y, 0f);
					float y2 = base.transform.TransformPoint(position).y;
					if (y2 >= y)
					{
						for (int i = 0; i < this.gridLayoutGroup.constraintCount; i++)
						{
							this.children[i].SetAsLastSibling();
							this.children[i].anchoredPosition = new Vector2(this.children[i].anchoredPosition.x, this.children[this.children.Count - 1].anchoredPosition.y - this.gridLayoutGroup.cellSize.y - this.gridLayoutGroup.spacing.y);
							this.realIndex++;
							if (this.realIndex > this.amount - 1)
							{
								this.children[i].gameObject.SetActive(false);
							}
							else
							{
								this.UpdateChildrenCallback(this.realIndex, this.children[i]);
							}
						}
						this.rectTransform.sizeDelta += new Vector2(0f, this.gridLayoutGroup.cellSize.y + this.gridLayoutGroup.spacing.y);
						for (int j = 0; j < this.children.Count; j++)
						{
							this.children[j] = base.transform.GetChild(j).GetComponent<RectTransform>();
						}
					}
				}
				else
				{
					if (this.realIndex + 1 <= this.children.Count)
					{
						this.startPosition = anchoredPosition;
						return;
					}
					RectTransform component = this.scrollRect.GetComponent<RectTransform>();
					Vector3 position2 = new Vector3(0f, -component.rect.height - this.gridLayoutGroup.spacing.y, 0f);
					float y3 = this.scrollRect.transform.TransformPoint(position2).y;
					Vector3 position3 = new Vector3(this.children[this.children.Count - 1].anchoredPosition.x, this.children[this.children.Count - 1].anchoredPosition.y + this.gridLayoutGroup.cellSize.y, 0f);
					float y4 = base.transform.TransformPoint(position3).y;
					if (y4 < y3)
					{
						for (int k = 0; k < this.gridLayoutGroup.constraintCount; k++)
						{
							this.children[this.children.Count - 1 - k].SetAsFirstSibling();
							this.children[this.children.Count - 1 - k].anchoredPosition = new Vector2(this.children[this.children.Count - 1 - k].anchoredPosition.x, this.children[0].anchoredPosition.y + this.gridLayoutGroup.cellSize.y + this.gridLayoutGroup.spacing.y);
							this.children[this.children.Count - 1 - k].gameObject.SetActive(true);
							this.UpdateChildrenCallback(this.realIndex - this.children.Count - k, this.children[this.children.Count - 1 - k]);
						}
						this.realIndex -= this.gridLayoutGroup.constraintCount;
						this.rectTransform.sizeDelta -= new Vector2(0f, this.gridLayoutGroup.cellSize.y + this.gridLayoutGroup.spacing.y);
						for (int l = 0; l < this.children.Count; l++)
						{
							this.children[l] = base.transform.GetChild(l).GetComponent<RectTransform>();
						}
					}
				}
			}
			else
			{
				float num2 = anchoredPosition.x - this.startPosition.x;
				if (num2 < 0f)
				{
					if (this.realIndex >= this.amount - 1)
					{
						this.startPosition = anchoredPosition;
						return;
					}
					float x = this.scrollRect.transform.TransformPoint(Vector3.zero).x;
					Vector3 position4 = new Vector3(this.children[0].anchoredPosition.x + this.gridLayoutGroup.cellSize.x, this.children[0].anchoredPosition.y, 0f);
					float x2 = base.transform.TransformPoint(position4).x;
					if (x2 <= x)
					{
						for (int m = 0; m < this.gridLayoutGroup.constraintCount; m++)
						{
							this.children[m].SetAsLastSibling();
							this.children[m].anchoredPosition = new Vector2(this.children[this.children.Count - 1].anchoredPosition.x + this.gridLayoutGroup.cellSize.x + this.gridLayoutGroup.spacing.x, this.children[m].anchoredPosition.y);
							this.realIndex++;
							if (this.realIndex > this.amount - 1)
							{
								this.children[m].gameObject.SetActive(false);
							}
							else
							{
								this.UpdateChildrenCallback(this.realIndex, this.children[m]);
							}
						}
						this.rectTransform.sizeDelta += new Vector2(this.gridLayoutGroup.cellSize.x + this.gridLayoutGroup.spacing.x, 0f);
						for (int n = 0; n < this.children.Count; n++)
						{
							this.children[n] = base.transform.GetChild(n).GetComponent<RectTransform>();
						}
					}
				}
				else
				{
					if (this.realIndex + 1 <= this.children.Count)
					{
						this.startPosition = anchoredPosition;
						return;
					}
					RectTransform component2 = this.scrollRect.GetComponent<RectTransform>();
					Vector3 position5 = new Vector3(component2.rect.width + this.gridLayoutGroup.spacing.x, 0f, 0f);
					float x3 = this.scrollRect.transform.TransformPoint(position5).x;
					Vector3 position6 = new Vector3(this.children[this.children.Count - 1].anchoredPosition.x - this.gridLayoutGroup.cellSize.x, this.children[this.children.Count - 1].anchoredPosition.y, 0f);
					float x4 = base.transform.TransformPoint(position6).x;
					if (x4 >= x3)
					{
						for (int num3 = 0; num3 < this.gridLayoutGroup.constraintCount; num3++)
						{
							this.children[this.children.Count - 1 - num3].SetAsFirstSibling();
							this.children[this.children.Count - 1 - num3].anchoredPosition = new Vector2(this.children[0].anchoredPosition.x - this.gridLayoutGroup.cellSize.x - this.gridLayoutGroup.spacing.x, this.children[this.children.Count - 1 - num3].anchoredPosition.y);
							this.children[this.children.Count - 1 - num3].gameObject.SetActive(true);
							this.UpdateChildrenCallback(this.realIndex - this.children.Count - num3, this.children[this.children.Count - 1 - num3]);
						}
						this.rectTransform.sizeDelta -= new Vector2(this.gridLayoutGroup.cellSize.x + this.gridLayoutGroup.spacing.x, 0f);
						for (int num4 = 0; num4 < this.children.Count; num4++)
						{
							this.children[num4] = base.transform.GetChild(num4).GetComponent<RectTransform>();
						}
						this.realIndex -= this.gridLayoutGroup.constraintCount;
					}
				}
			}
			this.startPosition = anchoredPosition;
		}

		// Token: 0x060118B3 RID: 71859 RVA: 0x0048A7D8 File Offset: 0x004889D8
		private void UpdateChildrenCallback(int index, Transform trans)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChildrenCallbackInt32Transform_hotfix != null)
			{
				this.m_UpdateChildrenCallbackInt32Transform_hotfix.call(new object[]
				{
					this,
					index,
					trans
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.updateChildrenCallback != null)
			{
				this.updateChildrenCallback(index, trans);
			}
		}

		// Token: 0x060118B4 RID: 71860 RVA: 0x0048A870 File Offset: 0x00488A70
		public void SetAmount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAmountInt32_hotfix != null)
			{
				this.m_SetAmountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.amount = count;
			base.StartCoroutine(this.InitChildren());
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x060118B5 RID: 71861 RVA: 0x0048A8F4 File Offset: 0x00488AF4
		// (set) Token: 0x060118B6 RID: 71862 RVA: 0x0048A914 File Offset: 0x00488B14
		[DoNotToLua]
		public InfinityGridLayoutGroup.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new InfinityGridLayoutGroup.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060118B7 RID: 71863 RVA: 0x0048A920 File Offset: 0x00488B20
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
					this.m_get_MinAmount_hotfix = (luaObj.RawGet("get_MinAmount") as LuaFunction);
					this.m_set_MinAmountInt32_hotfix = (luaObj.RawGet("set_MinAmount") as LuaFunction);
					this.m_Start_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_InitChildren_hotfix = (luaObj.RawGet("InitChildren") as LuaFunction);
					this.m_ScrollCallbackVector2_hotfix = (luaObj.RawGet("ScrollCallback") as LuaFunction);
					this.m_UpdateChildren_hotfix = (luaObj.RawGet("UpdateChildren") as LuaFunction);
					this.m_UpdateChildrenCallbackInt32Transform_hotfix = (luaObj.RawGet("UpdateChildrenCallback") as LuaFunction);
					this.m_SetAmountInt32_hotfix = (luaObj.RawGet("SetAmount") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060118B8 RID: 71864 RVA: 0x0048AA9C File Offset: 0x00488C9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(InfinityGridLayoutGroup));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009FEB RID: 40939
		[SerializeField]
		private int m_minAmount;

		// Token: 0x04009FEC RID: 40940
		[SerializeField]
		private int amount;

		// Token: 0x04009FED RID: 40941
		private RectTransform rectTransform;

		// Token: 0x04009FEE RID: 40942
		private GridLayoutGroup gridLayoutGroup;

		// Token: 0x04009FEF RID: 40943
		private ContentSizeFitter contentSizeFitter;

		// Token: 0x04009FF0 RID: 40944
		private ScrollRect scrollRect;

		// Token: 0x04009FF1 RID: 40945
		private List<RectTransform> children = new List<RectTransform>();

		// Token: 0x04009FF2 RID: 40946
		private Vector2 startPosition;

		// Token: 0x04009FF3 RID: 40947
		public InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate updateChildrenCallback;

		// Token: 0x04009FF4 RID: 40948
		private int realIndex = -1;

		// Token: 0x04009FF5 RID: 40949
		private int realIndexUp = -1;

		// Token: 0x04009FF6 RID: 40950
		private bool hasInit;

		// Token: 0x04009FF7 RID: 40951
		private Vector2 gridLayoutSize;

		// Token: 0x04009FF8 RID: 40952
		private Vector2 gridLayoutPos;

		// Token: 0x04009FF9 RID: 40953
		private Dictionary<Transform, Vector2> childsAnchoredPosition = new Dictionary<Transform, Vector2>();

		// Token: 0x04009FFA RID: 40954
		private Dictionary<Transform, int> childsSiblingIndex = new Dictionary<Transform, int>();

		// Token: 0x04009FFB RID: 40955
		[DoNotToLua]
		private InfinityGridLayoutGroup.LuaExportHelper luaExportHelper;

		// Token: 0x04009FFC RID: 40956
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009FFD RID: 40957
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009FFE RID: 40958
		private LuaFunction m_get_MinAmount_hotfix;

		// Token: 0x04009FFF RID: 40959
		private LuaFunction m_set_MinAmountInt32_hotfix;

		// Token: 0x0400A000 RID: 40960
		private LuaFunction m_Start_hotfix;

		// Token: 0x0400A001 RID: 40961
		private LuaFunction m_InitChildren_hotfix;

		// Token: 0x0400A002 RID: 40962
		private LuaFunction m_ScrollCallbackVector2_hotfix;

		// Token: 0x0400A003 RID: 40963
		private LuaFunction m_UpdateChildren_hotfix;

		// Token: 0x0400A004 RID: 40964
		private LuaFunction m_UpdateChildrenCallbackInt32Transform_hotfix;

		// Token: 0x0400A005 RID: 40965
		private LuaFunction m_SetAmountInt32_hotfix;

		// Token: 0x02000E2D RID: 3629
		// (Invoke) Token: 0x060118BA RID: 71866
		public delegate void UpdateChildrenCallbackDelegate(int index, Transform trans);

		// Token: 0x02000E2E RID: 3630
		public class LuaExportHelper
		{
			// Token: 0x060118BD RID: 71869 RVA: 0x0048AB04 File Offset: 0x00488D04
			public LuaExportHelper(InfinityGridLayoutGroup owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170035E1 RID: 13793
			// (get) Token: 0x060118BE RID: 71870 RVA: 0x0048AB14 File Offset: 0x00488D14
			// (set) Token: 0x060118BF RID: 71871 RVA: 0x0048AB24 File Offset: 0x00488D24
			public int m_minAmount
			{
				get
				{
					return this.m_owner.m_minAmount;
				}
				set
				{
					this.m_owner.m_minAmount = value;
				}
			}

			// Token: 0x170035E2 RID: 13794
			// (get) Token: 0x060118C0 RID: 71872 RVA: 0x0048AB34 File Offset: 0x00488D34
			// (set) Token: 0x060118C1 RID: 71873 RVA: 0x0048AB44 File Offset: 0x00488D44
			public int amount
			{
				get
				{
					return this.m_owner.amount;
				}
				set
				{
					this.m_owner.amount = value;
				}
			}

			// Token: 0x170035E3 RID: 13795
			// (get) Token: 0x060118C2 RID: 71874 RVA: 0x0048AB54 File Offset: 0x00488D54
			// (set) Token: 0x060118C3 RID: 71875 RVA: 0x0048AB64 File Offset: 0x00488D64
			public RectTransform rectTransform
			{
				get
				{
					return this.m_owner.rectTransform;
				}
				set
				{
					this.m_owner.rectTransform = value;
				}
			}

			// Token: 0x170035E4 RID: 13796
			// (get) Token: 0x060118C4 RID: 71876 RVA: 0x0048AB74 File Offset: 0x00488D74
			// (set) Token: 0x060118C5 RID: 71877 RVA: 0x0048AB84 File Offset: 0x00488D84
			public GridLayoutGroup gridLayoutGroup
			{
				get
				{
					return this.m_owner.gridLayoutGroup;
				}
				set
				{
					this.m_owner.gridLayoutGroup = value;
				}
			}

			// Token: 0x170035E5 RID: 13797
			// (get) Token: 0x060118C6 RID: 71878 RVA: 0x0048AB94 File Offset: 0x00488D94
			// (set) Token: 0x060118C7 RID: 71879 RVA: 0x0048ABA4 File Offset: 0x00488DA4
			public ContentSizeFitter contentSizeFitter
			{
				get
				{
					return this.m_owner.contentSizeFitter;
				}
				set
				{
					this.m_owner.contentSizeFitter = value;
				}
			}

			// Token: 0x170035E6 RID: 13798
			// (get) Token: 0x060118C8 RID: 71880 RVA: 0x0048ABB4 File Offset: 0x00488DB4
			// (set) Token: 0x060118C9 RID: 71881 RVA: 0x0048ABC4 File Offset: 0x00488DC4
			public ScrollRect scrollRect
			{
				get
				{
					return this.m_owner.scrollRect;
				}
				set
				{
					this.m_owner.scrollRect = value;
				}
			}

			// Token: 0x170035E7 RID: 13799
			// (get) Token: 0x060118CA RID: 71882 RVA: 0x0048ABD4 File Offset: 0x00488DD4
			// (set) Token: 0x060118CB RID: 71883 RVA: 0x0048ABE4 File Offset: 0x00488DE4
			public List<RectTransform> children
			{
				get
				{
					return this.m_owner.children;
				}
				set
				{
					this.m_owner.children = value;
				}
			}

			// Token: 0x170035E8 RID: 13800
			// (get) Token: 0x060118CC RID: 71884 RVA: 0x0048ABF4 File Offset: 0x00488DF4
			// (set) Token: 0x060118CD RID: 71885 RVA: 0x0048AC04 File Offset: 0x00488E04
			public Vector2 startPosition
			{
				get
				{
					return this.m_owner.startPosition;
				}
				set
				{
					this.m_owner.startPosition = value;
				}
			}

			// Token: 0x170035E9 RID: 13801
			// (get) Token: 0x060118CE RID: 71886 RVA: 0x0048AC14 File Offset: 0x00488E14
			// (set) Token: 0x060118CF RID: 71887 RVA: 0x0048AC24 File Offset: 0x00488E24
			public int realIndex
			{
				get
				{
					return this.m_owner.realIndex;
				}
				set
				{
					this.m_owner.realIndex = value;
				}
			}

			// Token: 0x170035EA RID: 13802
			// (get) Token: 0x060118D0 RID: 71888 RVA: 0x0048AC34 File Offset: 0x00488E34
			// (set) Token: 0x060118D1 RID: 71889 RVA: 0x0048AC44 File Offset: 0x00488E44
			public int realIndexUp
			{
				get
				{
					return this.m_owner.realIndexUp;
				}
				set
				{
					this.m_owner.realIndexUp = value;
				}
			}

			// Token: 0x170035EB RID: 13803
			// (get) Token: 0x060118D2 RID: 71890 RVA: 0x0048AC54 File Offset: 0x00488E54
			// (set) Token: 0x060118D3 RID: 71891 RVA: 0x0048AC64 File Offset: 0x00488E64
			public bool hasInit
			{
				get
				{
					return this.m_owner.hasInit;
				}
				set
				{
					this.m_owner.hasInit = value;
				}
			}

			// Token: 0x170035EC RID: 13804
			// (get) Token: 0x060118D4 RID: 71892 RVA: 0x0048AC74 File Offset: 0x00488E74
			// (set) Token: 0x060118D5 RID: 71893 RVA: 0x0048AC84 File Offset: 0x00488E84
			public Vector2 gridLayoutSize
			{
				get
				{
					return this.m_owner.gridLayoutSize;
				}
				set
				{
					this.m_owner.gridLayoutSize = value;
				}
			}

			// Token: 0x170035ED RID: 13805
			// (get) Token: 0x060118D6 RID: 71894 RVA: 0x0048AC94 File Offset: 0x00488E94
			// (set) Token: 0x060118D7 RID: 71895 RVA: 0x0048ACA4 File Offset: 0x00488EA4
			public Vector2 gridLayoutPos
			{
				get
				{
					return this.m_owner.gridLayoutPos;
				}
				set
				{
					this.m_owner.gridLayoutPos = value;
				}
			}

			// Token: 0x170035EE RID: 13806
			// (get) Token: 0x060118D8 RID: 71896 RVA: 0x0048ACB4 File Offset: 0x00488EB4
			// (set) Token: 0x060118D9 RID: 71897 RVA: 0x0048ACC4 File Offset: 0x00488EC4
			public Dictionary<Transform, Vector2> childsAnchoredPosition
			{
				get
				{
					return this.m_owner.childsAnchoredPosition;
				}
				set
				{
					this.m_owner.childsAnchoredPosition = value;
				}
			}

			// Token: 0x170035EF RID: 13807
			// (get) Token: 0x060118DA RID: 71898 RVA: 0x0048ACD4 File Offset: 0x00488ED4
			// (set) Token: 0x060118DB RID: 71899 RVA: 0x0048ACE4 File Offset: 0x00488EE4
			public Dictionary<Transform, int> childsSiblingIndex
			{
				get
				{
					return this.m_owner.childsSiblingIndex;
				}
				set
				{
					this.m_owner.childsSiblingIndex = value;
				}
			}

			// Token: 0x060118DC RID: 71900 RVA: 0x0048ACF4 File Offset: 0x00488EF4
			public void Start()
			{
				this.m_owner.Start();
			}

			// Token: 0x060118DD RID: 71901 RVA: 0x0048AD04 File Offset: 0x00488F04
			public IEnumerator InitChildren()
			{
				return this.m_owner.InitChildren();
			}

			// Token: 0x060118DE RID: 71902 RVA: 0x0048AD14 File Offset: 0x00488F14
			public void ScrollCallback(Vector2 data)
			{
				this.m_owner.ScrollCallback(data);
			}

			// Token: 0x060118DF RID: 71903 RVA: 0x0048AD24 File Offset: 0x00488F24
			public void UpdateChildren()
			{
				this.m_owner.UpdateChildren();
			}

			// Token: 0x060118E0 RID: 71904 RVA: 0x0048AD34 File Offset: 0x00488F34
			public void UpdateChildrenCallback(int index, Transform trans)
			{
				this.m_owner.UpdateChildrenCallback(index, trans);
			}

			// Token: 0x0400A006 RID: 40966
			private InfinityGridLayoutGroup m_owner;
		}
	}
}
