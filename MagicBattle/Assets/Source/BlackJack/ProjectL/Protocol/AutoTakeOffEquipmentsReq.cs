using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D5 RID: 2005
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "AutoTakeOffEquipmentsReq")]
	[Serializable]
	public class AutoTakeOffEquipmentsReq : IExtensible
	{
		// Token: 0x06006656 RID: 26198 RVA: 0x001C8974 File Offset: 0x001C6B74
		public AutoTakeOffEquipmentsReq()
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

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06006657 RID: 26199 RVA: 0x001C89DC File Offset: 0x001C6BDC
		// (set) Token: 0x06006658 RID: 26200 RVA: 0x001C89E4 File Offset: 0x001C6BE4
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

		// Token: 0x06006659 RID: 26201 RVA: 0x001C89F0 File Offset: 0x001C6BF0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x001C8A00 File Offset: 0x001C6C00
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

		// Token: 0x0600665B RID: 26203 RVA: 0x001C8ACC File Offset: 0x001C6CCC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AutoTakeOffEquipmentsReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CA7 RID: 19623
		private int _HeroId;

		// Token: 0x04004CA8 RID: 19624
		private IExtension extensionObject;

		// Token: 0x04004CA9 RID: 19625
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CAA RID: 19626
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CAB RID: 19627
		private LuaFunction m_ctor_hotfix;
	}
}
