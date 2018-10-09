using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200030C RID: 780
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "Int32Pair")]
	[Serializable]
	public class Int32Pair : IExtensible
	{
		// Token: 0x06002E9B RID: 11931 RVA: 0x000BA270 File Offset: 0x000B8470
		public Int32Pair()
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

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002E9C RID: 11932 RVA: 0x000BA2D8 File Offset: 0x000B84D8
		// (set) Token: 0x06002E9D RID: 11933 RVA: 0x000BA2E0 File Offset: 0x000B84E0
		[ProtoMember(1, IsRequired = true, Name = "Key", DataFormat = DataFormat.TwosComplement)]
		public int Key
		{
			get
			{
				return this._Key;
			}
			set
			{
				this._Key = value;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x000BA2EC File Offset: 0x000B84EC
		// (set) Token: 0x06002E9F RID: 11935 RVA: 0x000BA2F4 File Offset: 0x000B84F4
		[ProtoMember(2, IsRequired = true, Name = "Value", DataFormat = DataFormat.TwosComplement)]
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				this._Value = value;
			}
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x000BA300 File Offset: 0x000B8500
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000BA310 File Offset: 0x000B8510
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

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000BA3DC File Offset: 0x000B85DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(Int32Pair));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023BE RID: 9150
		private int _Key;

		// Token: 0x040023BF RID: 9151
		private int _Value;

		// Token: 0x040023C0 RID: 9152
		private IExtension extensionObject;

		// Token: 0x040023C1 RID: 9153
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023C2 RID: 9154
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023C3 RID: 9155
		private LuaFunction m_ctor_hotfix;
	}
}
