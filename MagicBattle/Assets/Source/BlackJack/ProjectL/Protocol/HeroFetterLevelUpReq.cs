using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007BF RID: 1983
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroFetterLevelUpReq")]
	[Serializable]
	public class HeroFetterLevelUpReq : IExtensible
	{
		// Token: 0x0600657E RID: 25982 RVA: 0x001C5FAC File Offset: 0x001C41AC
		public HeroFetterLevelUpReq()
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

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x001C6014 File Offset: 0x001C4214
		// (set) Token: 0x06006580 RID: 25984 RVA: 0x001C601C File Offset: 0x001C421C
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

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06006581 RID: 25985 RVA: 0x001C6028 File Offset: 0x001C4228
		// (set) Token: 0x06006582 RID: 25986 RVA: 0x001C6030 File Offset: 0x001C4230
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

		// Token: 0x06006583 RID: 25987 RVA: 0x001C603C File Offset: 0x001C423C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x001C604C File Offset: 0x001C424C
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

		// Token: 0x06006585 RID: 25989 RVA: 0x001C6118 File Offset: 0x001C4318
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroFetterLevelUpReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C0F RID: 19471
		private int _HeroId;

		// Token: 0x04004C10 RID: 19472
		private int _FetterId;

		// Token: 0x04004C11 RID: 19473
		private IExtension extensionObject;

		// Token: 0x04004C12 RID: 19474
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C13 RID: 19475
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C14 RID: 19476
		private LuaFunction m_ctor_hotfix;
	}
}
