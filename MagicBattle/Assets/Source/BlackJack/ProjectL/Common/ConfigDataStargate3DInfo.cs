using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200033B RID: 827
	[ProtoContract(Name = "ConfigDataStargate3DInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataStargate3DInfo : IExtensible
	{
		// Token: 0x060030FD RID: 12541 RVA: 0x000C02A0 File Offset: 0x000BE4A0
		public ConfigDataStargate3DInfo()
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

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x060030FE RID: 12542 RVA: 0x000C0308 File Offset: 0x000BE508
		// (set) Token: 0x060030FF RID: 12543 RVA: 0x000C0310 File Offset: 0x000BE510
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

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x000C031C File Offset: 0x000BE51C
		// (set) Token: 0x06003101 RID: 12545 RVA: 0x000C0324 File Offset: 0x000BE524
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "collision", DataFormat = DataFormat.Default)]
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

		// Token: 0x06003102 RID: 12546 RVA: 0x000C0330 File Offset: 0x000BE530
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x000C0340 File Offset: 0x000BE540
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

		// Token: 0x06003104 RID: 12548 RVA: 0x000C040C File Offset: 0x000BE60C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataStargate3DInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002555 RID: 9557
		private int _ID;

		// Token: 0x04002556 RID: 9558
		private CollisionInfo _collision;

		// Token: 0x04002557 RID: 9559
		private IExtension extensionObject;

		// Token: 0x04002558 RID: 9560
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002559 RID: 9561
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400255A RID: 9562
		private LuaFunction m_ctor_hotfix;
	}
}
