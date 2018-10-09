using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006FE RID: 1790
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ExchangeGiftCDKeyAck")]
	[Serializable]
	public class ExchangeGiftCDKeyAck : IExtensible
	{
		// Token: 0x06005F3B RID: 24379 RVA: 0x001AF9FC File Offset: 0x001ADBFC
		public ExchangeGiftCDKeyAck()
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

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06005F3C RID: 24380 RVA: 0x001AFA64 File Offset: 0x001ADC64
		// (set) Token: 0x06005F3D RID: 24381 RVA: 0x001AFA6C File Offset: 0x001ADC6C
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06005F3E RID: 24382 RVA: 0x001AFA78 File Offset: 0x001ADC78
		// (set) Token: 0x06005F3F RID: 24383 RVA: 0x001AFA80 File Offset: 0x001ADC80
		[ProtoMember(2, IsRequired = true, Name = "ResultDetail", DataFormat = DataFormat.TwosComplement)]
		public int ResultDetail
		{
			get
			{
				return this._ResultDetail;
			}
			set
			{
				this._ResultDetail = value;
			}
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x001AFA8C File Offset: 0x001ADC8C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x001AFA9C File Offset: 0x001ADC9C
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

		// Token: 0x06005F42 RID: 24386 RVA: 0x001AFB68 File Offset: 0x001ADD68
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ExchangeGiftCDKeyAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400474A RID: 18250
		private int _Result;

		// Token: 0x0400474B RID: 18251
		private int _ResultDetail;

		// Token: 0x0400474C RID: 18252
		private IExtension extensionObject;

		// Token: 0x0400474D RID: 18253
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400474E RID: 18254
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400474F RID: 18255
		private LuaFunction m_ctor_hotfix;
	}
}
