using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C5 RID: 1989
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroInteractReq")]
	[Serializable]
	public class HeroInteractReq : IExtensible
	{
		// Token: 0x060065BE RID: 26046 RVA: 0x001C6B44 File Offset: 0x001C4D44
		public HeroInteractReq()
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

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x060065BF RID: 26047 RVA: 0x001C6BAC File Offset: 0x001C4DAC
		// (set) Token: 0x060065C0 RID: 26048 RVA: 0x001C6BB4 File Offset: 0x001C4DB4
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

		// Token: 0x060065C1 RID: 26049 RVA: 0x001C6BC0 File Offset: 0x001C4DC0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x001C6BD0 File Offset: 0x001C4DD0
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

		// Token: 0x060065C3 RID: 26051 RVA: 0x001C6C9C File Offset: 0x001C4E9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroInteractReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C3B RID: 19515
		private int _HeroId;

		// Token: 0x04004C3C RID: 19516
		private IExtension extensionObject;

		// Token: 0x04004C3D RID: 19517
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C3E RID: 19518
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C3F RID: 19519
		private LuaFunction m_ctor_hotfix;
	}
}
