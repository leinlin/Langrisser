using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C7 RID: 1991
	[ProtoContract(Name = "CharSkinWearReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class CharSkinWearReq : IExtensible
	{
		// Token: 0x060065D2 RID: 26066 RVA: 0x001C6F14 File Offset: 0x001C5114
		public CharSkinWearReq()
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

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x060065D3 RID: 26067 RVA: 0x001C6F7C File Offset: 0x001C517C
		// (set) Token: 0x060065D4 RID: 26068 RVA: 0x001C6F84 File Offset: 0x001C5184
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

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060065D5 RID: 26069 RVA: 0x001C6F90 File Offset: 0x001C5190
		// (set) Token: 0x060065D6 RID: 26070 RVA: 0x001C6F98 File Offset: 0x001C5198
		[ProtoMember(2, IsRequired = true, Name = "CharSkinId", DataFormat = DataFormat.TwosComplement)]
		public int CharSkinId
		{
			get
			{
				return this._CharSkinId;
			}
			set
			{
				this._CharSkinId = value;
			}
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x001C6FA4 File Offset: 0x001C51A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x001C6FB4 File Offset: 0x001C51B4
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

		// Token: 0x060065D9 RID: 26073 RVA: 0x001C7080 File Offset: 0x001C5280
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CharSkinWearReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C49 RID: 19529
		private int _HeroId;

		// Token: 0x04004C4A RID: 19530
		private int _CharSkinId;

		// Token: 0x04004C4B RID: 19531
		private IExtension extensionObject;

		// Token: 0x04004C4C RID: 19532
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C4D RID: 19533
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C4E RID: 19534
		private LuaFunction m_ctor_hotfix;
	}
}
