using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007FC RID: 2044
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RemoveAnnouncementNtf")]
	[Serializable]
	public class RemoveAnnouncementNtf : IExtensible
	{
		// Token: 0x0600679E RID: 26526 RVA: 0x001CD1D8 File Offset: 0x001CB3D8
		public RemoveAnnouncementNtf()
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

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x0600679F RID: 26527 RVA: 0x001CD240 File Offset: 0x001CB440
		// (set) Token: 0x060067A0 RID: 26528 RVA: 0x001CD248 File Offset: 0x001CB448
		[ProtoMember(1, IsRequired = true, Name = "RemoveInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong RemoveInstanceId
		{
			get
			{
				return this._RemoveInstanceId;
			}
			set
			{
				this._RemoveInstanceId = value;
			}
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x001CD254 File Offset: 0x001CB454
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x001CD264 File Offset: 0x001CB464
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

		// Token: 0x060067A3 RID: 26531 RVA: 0x001CD330 File Offset: 0x001CB530
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RemoveAnnouncementNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D9F RID: 19871
		private ulong _RemoveInstanceId;

		// Token: 0x04004DA0 RID: 19872
		private IExtension extensionObject;

		// Token: 0x04004DA1 RID: 19873
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004DA2 RID: 19874
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004DA3 RID: 19875
		private LuaFunction m_ctor_hotfix;
	}
}
