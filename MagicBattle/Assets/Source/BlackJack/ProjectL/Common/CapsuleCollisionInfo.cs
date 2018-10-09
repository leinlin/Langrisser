using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000337 RID: 823
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "CapsuleCollisionInfo")]
	[Serializable]
	public class CapsuleCollisionInfo : IExtensible
	{
		// Token: 0x060030DB RID: 12507 RVA: 0x000BFB2C File Offset: 0x000BDD2C
		public CapsuleCollisionInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060030DC RID: 12508 RVA: 0x000BFB94 File Offset: 0x000BDD94
		// (set) Token: 0x060030DD RID: 12509 RVA: 0x000BFB9C File Offset: 0x000BDD9C
		[ProtoMember(1, IsRequired = true, Name = "pointA", DataFormat = DataFormat.Default)]
		public PVector3D PointA
		{
			get
			{
				return this._pointA;
			}
			set
			{
				this._pointA = value;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x000BFBA8 File Offset: 0x000BDDA8
		// (set) Token: 0x060030DF RID: 12511 RVA: 0x000BFBB0 File Offset: 0x000BDDB0
		[ProtoMember(2, IsRequired = true, Name = "pointB", DataFormat = DataFormat.Default)]
		public PVector3D PointB
		{
			get
			{
				return this._pointB;
			}
			set
			{
				this._pointB = value;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060030E0 RID: 12512 RVA: 0x000BFBBC File Offset: 0x000BDDBC
		// (set) Token: 0x060030E1 RID: 12513 RVA: 0x000BFBC4 File Offset: 0x000BDDC4
		[ProtoMember(3, IsRequired = true, Name = "radius", DataFormat = DataFormat.FixedSize)]
		public float Radius
		{
			get
			{
				return this._radius;
			}
			set
			{
				this._radius = value;
			}
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x000BFBD0 File Offset: 0x000BDDD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x000BFBE0 File Offset: 0x000BDDE0
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000BFCAC File Offset: 0x000BDEAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CapsuleCollisionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400253B RID: 9531
		private PVector3D _pointA;

		// Token: 0x0400253C RID: 9532
		private PVector3D _pointB;

		// Token: 0x0400253D RID: 9533
		private float _radius;

		// Token: 0x0400253E RID: 9534
		private IExtension extensionObject;

		// Token: 0x0400253F RID: 9535
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002540 RID: 9536
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002541 RID: 9537
		private LuaFunction m_ctor_hotfix;
	}
}
