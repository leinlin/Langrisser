using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007BD RID: 1981
	[ProtoContract(Name = "HeroFetterUnlockReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroFetterUnlockReq : IExtensible
	{
		// Token: 0x0600656A RID: 25962 RVA: 0x001C5BDC File Offset: 0x001C3DDC
		public HeroFetterUnlockReq()
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

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x0600656B RID: 25963 RVA: 0x001C5C44 File Offset: 0x001C3E44
		// (set) Token: 0x0600656C RID: 25964 RVA: 0x001C5C4C File Offset: 0x001C3E4C
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

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x0600656D RID: 25965 RVA: 0x001C5C58 File Offset: 0x001C3E58
		// (set) Token: 0x0600656E RID: 25966 RVA: 0x001C5C60 File Offset: 0x001C3E60
		[ProtoMember(2, IsRequired = true, Name = "FetterId", DataFormat = DataFormat.TwosComplement)]
		public int FetterId
		{
			get
			{
				return this._FetterId;
			}
			set
			{
				this._FetterId = value;
			}
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x001C5C6C File Offset: 0x001C3E6C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x001C5C7C File Offset: 0x001C3E7C
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

		// Token: 0x06006571 RID: 25969 RVA: 0x001C5D48 File Offset: 0x001C3F48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroFetterUnlockReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C01 RID: 19457
		private int _HeroId;

		// Token: 0x04004C02 RID: 19458
		private int _FetterId;

		// Token: 0x04004C03 RID: 19459
		private IExtension extensionObject;

		// Token: 0x04004C04 RID: 19460
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C05 RID: 19461
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C06 RID: 19462
		private LuaFunction m_ctor_hotfix;
	}
}
