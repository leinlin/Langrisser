using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C1 RID: 1985
	[ProtoContract(Name = "HeroConfessReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroConfessReq : IExtensible
	{
		// Token: 0x06006590 RID: 26000 RVA: 0x001C6368 File Offset: 0x001C4568
		public HeroConfessReq()
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

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06006591 RID: 26001 RVA: 0x001C63D0 File Offset: 0x001C45D0
		// (set) Token: 0x06006592 RID: 26002 RVA: 0x001C63D8 File Offset: 0x001C45D8
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

		// Token: 0x06006593 RID: 26003 RVA: 0x001C63E4 File Offset: 0x001C45E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x001C63F4 File Offset: 0x001C45F4
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

		// Token: 0x06006595 RID: 26005 RVA: 0x001C64C0 File Offset: 0x001C46C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroConfessReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C1C RID: 19484
		private int _HeroId;

		// Token: 0x04004C1D RID: 19485
		private IExtension extensionObject;

		// Token: 0x04004C1E RID: 19486
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C1F RID: 19487
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C20 RID: 19488
		private LuaFunction m_ctor_hotfix;
	}
}
