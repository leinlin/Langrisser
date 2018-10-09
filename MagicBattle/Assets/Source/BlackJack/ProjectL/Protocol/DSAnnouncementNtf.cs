using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000725 RID: 1829
	[ProtoContract(Name = "DSAnnouncementNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSAnnouncementNtf : IExtensible
	{
		// Token: 0x060060A0 RID: 24736 RVA: 0x001B43EC File Offset: 0x001B25EC
		public DSAnnouncementNtf()
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

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x060060A1 RID: 24737 RVA: 0x001B4460 File Offset: 0x001B2660
		// (set) Token: 0x060060A2 RID: 24738 RVA: 0x001B4468 File Offset: 0x001B2668
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x060060A3 RID: 24739 RVA: 0x001B4474 File Offset: 0x001B2674
		[ProtoMember(2, Name = "Announcements", DataFormat = DataFormat.Default)]
		public List<ProAnnouncement> Announcements
		{
			get
			{
				return this._Announcements;
			}
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x001B447C File Offset: 0x001B267C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x001B448C File Offset: 0x001B268C
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

		// Token: 0x060060A6 RID: 24742 RVA: 0x001B4558 File Offset: 0x001B2758
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSAnnouncementNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004857 RID: 18519
		private uint _Version;

		// Token: 0x04004858 RID: 18520
		private readonly List<ProAnnouncement> _Announcements = new List<ProAnnouncement>();

		// Token: 0x04004859 RID: 18521
		private IExtension extensionObject;

		// Token: 0x0400485A RID: 18522
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400485B RID: 18523
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400485C RID: 18524
		private LuaFunction m_ctor_hotfix;
	}
}
