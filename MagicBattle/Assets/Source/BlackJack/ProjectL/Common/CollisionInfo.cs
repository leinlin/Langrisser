using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000338 RID: 824
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "CollisionInfo")]
	[Serializable]
	public class CollisionInfo : IExtensible
	{
		// Token: 0x060030E5 RID: 12517 RVA: 0x000BFD14 File Offset: 0x000BDF14
		public CollisionInfo()
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

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x000BFD90 File Offset: 0x000BDF90
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x000BFD98 File Offset: 0x000BDF98
		[ProtoMember(1, IsRequired = true, Name = "RadiusMax", DataFormat = DataFormat.FixedSize)]
		public float RadiusMax
		{
			get
			{
				return this._RadiusMax;
			}
			set
			{
				this._RadiusMax = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x000BFDA4 File Offset: 0x000BDFA4
		[ProtoMember(3, Name = "sphereCollisions", DataFormat = DataFormat.Default)]
		public List<SphereCollisionInfo> SphereCollisions
		{
			get
			{
				return this._sphereCollisions;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060030E9 RID: 12521 RVA: 0x000BFDAC File Offset: 0x000BDFAC
		[ProtoMember(4, Name = "capsuleCollisions", DataFormat = DataFormat.Default)]
		public List<CapsuleCollisionInfo> CapsuleCollisions
		{
			get
			{
				return this._capsuleCollisions;
			}
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000BFDB4 File Offset: 0x000BDFB4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000BFDC4 File Offset: 0x000BDFC4
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

		// Token: 0x060030EC RID: 12524 RVA: 0x000BFE90 File Offset: 0x000BE090
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CollisionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002542 RID: 9538
		private float _RadiusMax;

		// Token: 0x04002543 RID: 9539
		private readonly List<SphereCollisionInfo> _sphereCollisions = new List<SphereCollisionInfo>();

		// Token: 0x04002544 RID: 9540
		private readonly List<CapsuleCollisionInfo> _capsuleCollisions = new List<CapsuleCollisionInfo>();

		// Token: 0x04002545 RID: 9541
		private IExtension extensionObject;

		// Token: 0x04002546 RID: 9542
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002547 RID: 9543
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002548 RID: 9544
		private LuaFunction m_ctor_hotfix;
	}
}
