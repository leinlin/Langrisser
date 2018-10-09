using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000336 RID: 822
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SphereCollisionInfo")]
	[Serializable]
	public class SphereCollisionInfo : IExtensible
	{
		// Token: 0x060030D3 RID: 12499 RVA: 0x000BF958 File Offset: 0x000BDB58
		public SphereCollisionInfo()
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

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x000BF9C0 File Offset: 0x000BDBC0
		// (set) Token: 0x060030D5 RID: 12501 RVA: 0x000BF9C8 File Offset: 0x000BDBC8
		[ProtoMember(1, IsRequired = true, Name = "center", DataFormat = DataFormat.Default)]
		public PVector3D Center
		{
			get
			{
				return this._center;
			}
			set
			{
				this._center = value;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x000BF9D4 File Offset: 0x000BDBD4
		// (set) Token: 0x060030D7 RID: 12503 RVA: 0x000BF9DC File Offset: 0x000BDBDC
		[ProtoMember(2, IsRequired = true, Name = "radius", DataFormat = DataFormat.FixedSize)]
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

		// Token: 0x060030D8 RID: 12504 RVA: 0x000BF9E8 File Offset: 0x000BDBE8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x000BF9F8 File Offset: 0x000BDBF8
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

		// Token: 0x060030DA RID: 12506 RVA: 0x000BFAC4 File Offset: 0x000BDCC4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SphereCollisionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002535 RID: 9525
		private PVector3D _center;

		// Token: 0x04002536 RID: 9526
		private float _radius;

		// Token: 0x04002537 RID: 9527
		private IExtension extensionObject;

		// Token: 0x04002538 RID: 9528
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002539 RID: 9529
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400253A RID: 9530
		private LuaFunction m_ctor_hotfix;
	}
}
