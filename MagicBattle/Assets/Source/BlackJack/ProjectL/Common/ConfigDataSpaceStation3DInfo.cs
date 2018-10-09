using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200033C RID: 828
	[ProtoContract(Name = "ConfigDataSpaceStation3DInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataSpaceStation3DInfo : IExtensible
	{
		// Token: 0x06003105 RID: 12549 RVA: 0x000C0474 File Offset: 0x000BE674
		public ConfigDataSpaceStation3DInfo()
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

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x000C04DC File Offset: 0x000BE6DC
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x000C04E4 File Offset: 0x000BE6E4
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

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x000C04F0 File Offset: 0x000BE6F0
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x000C04F8 File Offset: 0x000BE6F8
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

		// Token: 0x0600310A RID: 12554 RVA: 0x000C0504 File Offset: 0x000BE704
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x000C0514 File Offset: 0x000BE714
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

		// Token: 0x0600310C RID: 12556 RVA: 0x000C05E0 File Offset: 0x000BE7E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSpaceStation3DInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400255B RID: 9563
		private int _ID;

		// Token: 0x0400255C RID: 9564
		private CollisionInfo _collision;

		// Token: 0x0400255D RID: 9565
		private IExtension extensionObject;

		// Token: 0x0400255E RID: 9566
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400255F RID: 9567
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002560 RID: 9568
		private LuaFunction m_ctor_hotfix;
	}
}
