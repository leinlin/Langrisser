using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000272 RID: 626
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRandomNameTail")]
	[Serializable]
	public class ConfigDataRandomNameTail : IExtensible
	{
		// Token: 0x0600281A RID: 10266 RVA: 0x000AD5DC File Offset: 0x000AB7DC
		public ConfigDataRandomNameTail()
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

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x000AD644 File Offset: 0x000AB844
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x000AD64C File Offset: 0x000AB84C
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000AD658 File Offset: 0x000AB858
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x000AD660 File Offset: 0x000AB860
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000AD66C File Offset: 0x000AB86C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000AD67C File Offset: 0x000AB87C
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

		// Token: 0x06002821 RID: 10273 RVA: 0x000AD748 File Offset: 0x000AB948
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRandomNameTail));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400189E RID: 6302
		private int _ID;

		// Token: 0x0400189F RID: 6303
		private string _Name;

		// Token: 0x040018A0 RID: 6304
		private IExtension extensionObject;

		// Token: 0x040018A1 RID: 6305
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040018A2 RID: 6306
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040018A3 RID: 6307
		private LuaFunction m_ctor_hotfix;
	}
}
