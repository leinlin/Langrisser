using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000314 RID: 788
	[ProtoContract(Name = "CompleteValueDropID")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class CompleteValueDropID : IExtensible
	{
		// Token: 0x06002EEB RID: 12011 RVA: 0x000BB1B0 File Offset: 0x000B93B0
		public CompleteValueDropID()
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

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x000BB218 File Offset: 0x000B9418
		// (set) Token: 0x06002EED RID: 12013 RVA: 0x000BB220 File Offset: 0x000B9420
		[ProtoMember(1, IsRequired = true, Name = "CompleteValue", DataFormat = DataFormat.TwosComplement)]
		public int CompleteValue
		{
			get
			{
				return this._CompleteValue;
			}
			set
			{
				this._CompleteValue = value;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x000BB22C File Offset: 0x000B942C
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x000BB234 File Offset: 0x000B9434
		[ProtoMember(2, IsRequired = true, Name = "DropID", DataFormat = DataFormat.TwosComplement)]
		public int DropID
		{
			get
			{
				return this._DropID;
			}
			set
			{
				this._DropID = value;
			}
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x000BB240 File Offset: 0x000B9440
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000BB250 File Offset: 0x000B9450
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

		// Token: 0x06002EF2 RID: 12018 RVA: 0x000BB31C File Offset: 0x000B951C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CompleteValueDropID));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023F6 RID: 9206
		private int _CompleteValue;

		// Token: 0x040023F7 RID: 9207
		private int _DropID;

		// Token: 0x040023F8 RID: 9208
		private IExtension extensionObject;

		// Token: 0x040023F9 RID: 9209
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023FA RID: 9210
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023FB RID: 9211
		private LuaFunction m_ctor_hotfix;
	}
}
