using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002F7 RID: 759
	[ProtoContract(Name = "ParamPosition")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ParamPosition : IExtensible
	{
		// Token: 0x06002DD3 RID: 11731 RVA: 0x000B7ACC File Offset: 0x000B5CCC
		public ParamPosition()
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

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002DD4 RID: 11732 RVA: 0x000B7B34 File Offset: 0x000B5D34
		// (set) Token: 0x06002DD5 RID: 11733 RVA: 0x000B7B3C File Offset: 0x000B5D3C
		[ProtoMember(1, IsRequired = true, Name = "X", DataFormat = DataFormat.TwosComplement)]
		public int X
		{
			get
			{
				return this._X;
			}
			set
			{
				this._X = value;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x000B7B48 File Offset: 0x000B5D48
		// (set) Token: 0x06002DD7 RID: 11735 RVA: 0x000B7B50 File Offset: 0x000B5D50
		[ProtoMember(2, IsRequired = true, Name = "Y", DataFormat = DataFormat.TwosComplement)]
		public int Y
		{
			get
			{
				return this._Y;
			}
			set
			{
				this._Y = value;
			}
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x000B7B5C File Offset: 0x000B5D5C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x000B7B6C File Offset: 0x000B5D6C
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

		// Token: 0x06002DDA RID: 11738 RVA: 0x000B7C38 File Offset: 0x000B5E38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ParamPosition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002330 RID: 9008
		private int _X;

		// Token: 0x04002331 RID: 9009
		private int _Y;

		// Token: 0x04002332 RID: 9010
		private IExtension extensionObject;

		// Token: 0x04002333 RID: 9011
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002334 RID: 9012
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002335 RID: 9013
		private LuaFunction m_ctor_hotfix;
	}
}
