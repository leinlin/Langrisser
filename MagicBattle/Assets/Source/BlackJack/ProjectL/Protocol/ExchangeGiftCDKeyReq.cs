using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006FD RID: 1789
	[ProtoContract(Name = "ExchangeGiftCDKeyReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ExchangeGiftCDKeyReq : IExtensible
	{
		// Token: 0x06005F35 RID: 24373 RVA: 0x001AF83C File Offset: 0x001ADA3C
		public ExchangeGiftCDKeyReq()
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

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06005F36 RID: 24374 RVA: 0x001AF8A4 File Offset: 0x001ADAA4
		// (set) Token: 0x06005F37 RID: 24375 RVA: 0x001AF8AC File Offset: 0x001ADAAC
		[ProtoMember(1, IsRequired = true, Name = "GiftCDkey", DataFormat = DataFormat.Default)]
		public string GiftCDkey
		{
			get
			{
				return this._GiftCDkey;
			}
			set
			{
				this._GiftCDkey = value;
			}
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x001AF8B8 File Offset: 0x001ADAB8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x001AF8C8 File Offset: 0x001ADAC8
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

		// Token: 0x06005F3A RID: 24378 RVA: 0x001AF994 File Offset: 0x001ADB94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ExchangeGiftCDKeyReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004745 RID: 18245
		private string _GiftCDkey;

		// Token: 0x04004746 RID: 18246
		private IExtension extensionObject;

		// Token: 0x04004747 RID: 18247
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004748 RID: 18248
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004749 RID: 18249
		private LuaFunction m_ctor_hotfix;
	}
}
