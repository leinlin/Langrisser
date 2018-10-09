using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000339 RID: 825
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSpaceSimpleObject3DInfo")]
	[Serializable]
	public class ConfigDataSpaceSimpleObject3DInfo : IExtensible
	{
		// Token: 0x060030ED RID: 12525 RVA: 0x000BFEF8 File Offset: 0x000BE0F8
		public ConfigDataSpaceSimpleObject3DInfo()
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

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x000BFF60 File Offset: 0x000BE160
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x000BFF68 File Offset: 0x000BE168
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

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x000BFF74 File Offset: 0x000BE174
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x000BFF7C File Offset: 0x000BE17C
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

		// Token: 0x060030F2 RID: 12530 RVA: 0x000BFF88 File Offset: 0x000BE188
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x000BFF98 File Offset: 0x000BE198
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

		// Token: 0x060030F4 RID: 12532 RVA: 0x000C0064 File Offset: 0x000BE264
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSpaceSimpleObject3DInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002549 RID: 9545
		private int _ID;

		// Token: 0x0400254A RID: 9546
		private CollisionInfo _collision;

		// Token: 0x0400254B RID: 9547
		private IExtension extensionObject;

		// Token: 0x0400254C RID: 9548
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400254D RID: 9549
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400254E RID: 9550
		private LuaFunction m_ctor_hotfix;
	}
}
