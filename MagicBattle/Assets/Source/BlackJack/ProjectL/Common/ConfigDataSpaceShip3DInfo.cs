using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200033A RID: 826
	[ProtoContract(Name = "ConfigDataSpaceShip3DInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataSpaceShip3DInfo : IExtensible
	{
		// Token: 0x060030F5 RID: 12533 RVA: 0x000C00CC File Offset: 0x000BE2CC
		public ConfigDataSpaceShip3DInfo()
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

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x000C0134 File Offset: 0x000BE334
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x000C013C File Offset: 0x000BE33C
		[ProtoMember(1, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x000C0148 File Offset: 0x000BE348
		// (set) Token: 0x060030F9 RID: 12537 RVA: 0x000C0150 File Offset: 0x000BE350
		[ProtoMember(2, IsRequired = false, Name = "collision", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public CollisionInfo Collision
		{
			get
			{
				return this._collision;
			}
			set
			{
				this._collision = value;
			}
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x000C015C File Offset: 0x000BE35C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x000C016C File Offset: 0x000BE36C
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

		// Token: 0x060030FC RID: 12540 RVA: 0x000C0238 File Offset: 0x000BE438
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSpaceShip3DInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400254F RID: 9551
		private int _ID;

		// Token: 0x04002550 RID: 9552
		private CollisionInfo _collision;

		// Token: 0x04002551 RID: 9553
		private IExtension extensionObject;

		// Token: 0x04002552 RID: 9554
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002553 RID: 9555
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002554 RID: 9556
		private LuaFunction m_ctor_hotfix;
	}
}
