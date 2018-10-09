using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007AF RID: 1967
	[ProtoContract(Name = "HeroComposeReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroComposeReq : IExtensible
	{
		// Token: 0x060064ED RID: 25837 RVA: 0x001C41B8 File Offset: 0x001C23B8
		public HeroComposeReq()
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

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x060064EE RID: 25838 RVA: 0x001C4220 File Offset: 0x001C2420
		// (set) Token: 0x060064EF RID: 25839 RVA: 0x001C4228 File Offset: 0x001C2428
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x001C4234 File Offset: 0x001C2434
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x001C4244 File Offset: 0x001C2444
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

		// Token: 0x060064F2 RID: 25842 RVA: 0x001C4310 File Offset: 0x001C2510
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroComposeReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BA6 RID: 19366
		private int _HeroId;

		// Token: 0x04004BA7 RID: 19367
		private IExtension extensionObject;

		// Token: 0x04004BA8 RID: 19368
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BA9 RID: 19369
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BAA RID: 19370
		private LuaFunction m_ctor_hotfix;
	}
}
