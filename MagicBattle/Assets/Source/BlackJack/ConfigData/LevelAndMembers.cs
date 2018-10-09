using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000306 RID: 774
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LevelAndMembers")]
	[Serializable]
	public class LevelAndMembers : IExtensible
	{
		// Token: 0x06002E61 RID: 11873 RVA: 0x000B9714 File Offset: 0x000B7914
		public LevelAndMembers()
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

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x000B977C File Offset: 0x000B797C
		// (set) Token: 0x06002E63 RID: 11875 RVA: 0x000B9784 File Offset: 0x000B7984
		[ProtoMember(1, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x000B9790 File Offset: 0x000B7990
		// (set) Token: 0x06002E65 RID: 11877 RVA: 0x000B9798 File Offset: 0x000B7998
		[ProtoMember(2, IsRequired = true, Name = "Members", DataFormat = DataFormat.TwosComplement)]
		public int Members
		{
			get
			{
				return this._Members;
			}
			set
			{
				this._Members = value;
			}
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000B97A4 File Offset: 0x000B79A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x000B97B4 File Offset: 0x000B79B4
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

		// Token: 0x06002E68 RID: 11880 RVA: 0x000B9880 File Offset: 0x000B7A80
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelAndMembers));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002395 RID: 9109
		private int _Level;

		// Token: 0x04002396 RID: 9110
		private int _Members;

		// Token: 0x04002397 RID: 9111
		private IExtension extensionObject;

		// Token: 0x04002398 RID: 9112
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002399 RID: 9113
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400239A RID: 9114
		private LuaFunction m_ctor_hotfix;
	}
}
